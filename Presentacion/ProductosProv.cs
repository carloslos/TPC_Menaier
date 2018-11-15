using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using Negocio;
using Dominio;
/// <summary>
/// TODO: AGREGAR BOTON GUARDAR/CANCELAR
/// </summary>
namespace Presentacion
{
    public partial class ProductosProv : MetroFramework.Forms.MetroForm
    {
        int IdProveedor;
        List<Producto> lstProductos;
        List<Producto> lstProductosProv;

        public ProductosProv(string s, int id)
        {
            InitializeComponent();
            this.Text = s;
            IdProveedor = id;
        }

        private void ProductosProv_Load(object sender, EventArgs e)
        {
            try
            {
                ProductoNegocio neg = new ProductoNegocio();
                lstProductos = neg.Listar(0);
                lstProductosProv = neg.Listar(IdProveedor);
                if (lstProductos.Count > 0 && lstProductosProv.Count > 0)
                {
                    for (int i = lstProductos.Count - 1; i >= 0; i--)
                    {
                        for (int j = lstProductosProv.Count - 1; i >= 0; i--)
                        {
                            if (lstProductos[i].IdProducto == lstProductosProv[j].IdProducto)
                            {
                                lstProductos.Remove(lstProductos[i]);
                                break;
                            }
                        }
                    }
                }
                LlenarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LlenarTabla()
        {
            try
            {
                dgvProductosProv.DataSource = lstProductosProv;
                dgvProductosProv.Columns["IdProducto"].HeaderText = "ID";
                dgvProductosProv.Columns["Descripcion"].HeaderText = "Descripción";
                dgvProductosProv.Columns["TipoProducto"].Visible = false;
                dgvProductosProv.Columns["Ganancia"].Visible = false;
                dgvProductosProv.Columns["StockMin"].Visible = false;
                dgvProductosProv.Columns["Activo"].Visible = false;
                dgvProductosProv.Update();
                dgvProductosProv.Refresh();

                dgvProductos.DataSource = lstProductos;
                dgvProductos.Columns["IdProducto"].HeaderText = "ID";
                dgvProductos.Columns["Descripcion"].HeaderText = "Descripción";
                dgvProductos.Columns["Ganancia"].Visible = false;
                dgvProductos.Columns["TipoProducto"].Visible = false;
                dgvProductos.Columns["StockMin"].Visible = false;
                dgvProductos.Columns["Activo"].Visible = false;
                dgvProductos.Update();
                dgvProductos.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.RowCount > 0)
            {
                Producto p = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                dgvProductos.DataSource = null;
                dgvProductosProv.DataSource = null;
                lstProductosProv.Add(p);
                lstProductos.Remove(p);
                LlenarTabla();
            }
        }
    
        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvProductosProv.RowCount > 0)
            {
                Producto p = (Producto)dgvProductosProv.CurrentRow.DataBoundItem;
                dgvProductos.DataSource = null;
                dgvProductosProv.DataSource = null;
                lstProductos.Add(p);
                lstProductosProv.Remove(p);
                LlenarTabla();
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            ProductoNegocio negP = new ProductoNegocio();
            negP.EliminarProductoDeProveedor(IdProveedor);
            foreach (Producto p in lstProductosProv)
            {
                negP.AgregarProductoDeProveedor(p.IdProducto, IdProveedor);
            }
            this.Close();
        }
    }
}

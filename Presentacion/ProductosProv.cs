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

namespace Presentacion
{
    public partial class ProductosProv : Presentacion.Metro_Template
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
            Producto p = (Producto)dgvProductos.CurrentRow.DataBoundItem;
            lstProductosProv.Add(p);
            lstProductos.Remove(p);
            LlenarTabla();

        }

        /// <summary>
        /// TODO: MOVER PRODUCTOS ENTRE TABLAS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            lstProductos.Add((Producto)dgvProductosProv.CurrentRow.DataBoundItem);
            lstProductosProv.Remove((Producto)dgvProductosProv.CurrentRow.DataBoundItem);
            LlenarTabla();
        }
    }
}

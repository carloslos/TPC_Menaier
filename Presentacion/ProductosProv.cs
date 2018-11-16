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
    public partial class ProductosProv : MetroFramework.Forms.MetroForm
    {
        int IdProveedor, permisos;
        List<Producto> lstProductos;
        BindingList<Producto> bindProductos;
        List<Producto> lstProductosProv;
        BindingList<Producto> bindProductosProv;

        public ProductosProv(string s, int id, int p)
        {
            InitializeComponent();
            this.Text = s;
            permisos = p;
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
                    for (int j = lstProductosProv.Count - 1; j >= 0; j--)
                    {
                        for (int i = lstProductos.Count - 1; i >= 0; i--)
                        {
                            if (lstProductos[i].IdProducto == lstProductosProv[j].IdProducto)
                            {
                                lstProductos.Remove(lstProductos[i]);
                                break;
                            }
                        }
                    }
                }
                bindProductos = new BindingList<Producto>(lstProductos);
                dgvProductos.DataSource = bindProductos;
                bindProductosProv = new BindingList<Producto>(lstProductosProv);
                dgvProductosProv.DataSource = bindProductosProv;
                LlenarTabla();
                if (permisos == 3)
                {
                    BtnQuitar.Enabled = false;
                    BtnAgregar.Enabled = false;
                    BtnAceptar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Mensaje m = new Mensaje(ex.ToString()); m.ShowDialog();
            }
        }

        private void LlenarTabla()
        {
            try
            {
                dgvProductosProv.DataSource = bindProductosProv;
                dgvProductosProv.Columns["IdProducto"].HeaderText = "ID";
                dgvProductosProv.Columns["Descripcion"].HeaderText = "Descripción";
                dgvProductosProv.Columns["TipoProducto"].Visible = false;
                dgvProductosProv.Columns["Ganancia"].Visible = false;
                dgvProductosProv.Columns["StockMin"].Visible = false;
                dgvProductosProv.Columns["Activo"].Visible = false;
                dgvProductosProv.Update();
                dgvProductosProv.Refresh();

                dgvProductos.DataSource = bindProductos;
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
                Mensaje m = new Mensaje(ex.ToString()); m.ShowDialog();
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.RowCount > 0)
                {
                    Producto p = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                    lstProductosProv.Add(p);
                    lstProductos.Remove(p);
                    bindProductosProv.ResetBindings();
                    bindProductos.ResetBindings();
                }
            }
            catch (Exception ex)
            {
                Mensaje m = new Mensaje(ex.ToString()); m.ShowDialog();
            }
        }
    
        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductosProv.RowCount > 0)
                {
                    Producto p = (Producto)dgvProductosProv.CurrentRow.DataBoundItem;
                    lstProductos.Add(p);
                    lstProductosProv.Remove(p);
                    bindProductosProv.ResetBindings();
                    bindProductos.ResetBindings();
                }
            }
            catch(Exception ex)
            {
                Mensaje m = new Mensaje(ex.ToString()); m.ShowDialog();
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var popup = new Confirmacion(@"salir sin guardar los cambios?" + @""""))
                {
                    var R = popup.ShowDialog();
                    if (R == DialogResult.OK)
                    {
                        bool conf = popup.R;
                        if (conf == true)
                        {
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Mensaje m = new Mensaje(ex.ToString()); m.ShowDialog();
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoNegocio negP = new ProductoNegocio();
                negP.EliminarProductoDeProveedor(IdProveedor);
                foreach (Producto p in lstProductosProv)
                {
                    negP.AgregarProductoDeProveedor(p.IdProducto, IdProveedor);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                Mensaje m = new Mensaje(ex.ToString()); m.ShowDialog();
            }
        }
    }
}

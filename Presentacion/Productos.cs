using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class Productos : Presentacion.Metro_Template
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            try
            {
                llenarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void llenarTabla()
        {
            ProductosNegocio neg = new ProductosNegocio();
            try
            {
                dgvProductos.DataSource = neg.listar();
                dgvProductos.Columns["idTipo"].HeaderText = "Tipo de producto";
                dgvProductos.Columns["descripcion"].HeaderText = "Descripcion";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            {
                foreach (Form item in Application.OpenForms)
                {
                    if (item.GetType() == typeof(ModTipoProducto))
                    {
                        item.Focus();
                        return;
                    }
                }
                try
                {
                    ModTipoProducto wndAgregarTipoProducto = new ModTipoProducto();
                    wndAgregarTipoProducto.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            try
            {
                llenarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

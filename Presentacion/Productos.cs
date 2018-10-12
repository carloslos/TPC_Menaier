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
                LlenarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LlenarTabla()
        {
            ProductosNegocio neg = new ProductosNegocio();
            try
            {
                dgvProductos.DataSource = neg.Listar();
                dgvProductos.Columns["IdProducto"].HeaderText = "ID";
                dgvProductos.Columns["Descripcion"].HeaderText = "Descripción";
                dgvProductos.Columns["TipoProducto"].HeaderText = "Tipo de producto";
                dgvProductos.Columns["Stockmin"].HeaderText = "Stock Minimo";
                dgvProductos.Columns["Activo"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            try
            {
                LlenarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ModProducto))
                {
                    item.Focus();
                    return;
                }
            }
            try
            {
                ModProducto mod = new ModProducto("Agregar");
                mod.Show();
                LlenarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

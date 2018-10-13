using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Presentacion
{
    public partial class TiposProducto : MetroFramework.Forms.MetroForm
    {
        public TiposProducto()
        {
            InitializeComponent();
        }

        private void TiposProducto_Load(object sender, EventArgs e)
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
            TiposProductoNegocio neg = new TiposProductoNegocio();
            try
            {
                dgvTiposProducto.DataSource = neg.Listar();
                dgvTiposProducto.Columns["IdTipoProducto"].HeaderText = "ID";
                dgvTiposProducto.Columns["Descripcion"].HeaderText = "Descripción";
                dgvTiposProducto.Columns["Activo"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
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
                    ModTipoProducto mod = new ModTipoProducto();
                    mod.Show();
                    LlenarTabla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
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

        private void BtnEditar_Click(object sender, EventArgs e)
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
                    TipoProducto obj = (TipoProducto)dgvTiposProducto.CurrentRow.DataBoundItem;
                    ModTipoProducto mod = new ModTipoProducto(obj);
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
}

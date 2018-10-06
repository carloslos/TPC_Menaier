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
                llenarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void llenarTabla()
        {
            TipoProductoNegocio neg = new TipoProductoNegocio();
            try
            {
                dgvTiposProducto.DataSource = neg.listar();
                dgvTiposProducto.Columns["idTipo"].HeaderText = "ID";
                dgvTiposProducto.Columns["descripcion"].HeaderText = "Descripcion";
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
                    ModTipoProducto wndAgregarTipoProducto = new ModTipoProducto("Agregar");
                    wndAgregarTipoProducto.ShowDialog();
                    llenarTabla();
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

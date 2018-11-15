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
            TipoProductoNegocio neg = new TipoProductoNegocio();
            try
            {
                dgvTiposProducto.DataSource = neg.Listar();
                dgvTiposProducto.Columns["IdTipoProducto"].HeaderText = "ID";
                dgvTiposProducto.Columns["Descripcion"].HeaderText = "Descripción";
                dgvTiposProducto.Columns["Activo"].Visible = false;
                dgvTiposProducto.Update();
                dgvTiposProducto.Refresh();
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
                    mod.ShowDialog();
                    LlenarTabla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvTiposProducto.SelectedCells.Count > 0)
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
                    mod.ShowDialog();
                    LlenarTabla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                Mensaje m = new Mensaje("Ningun item seleccion.");
                m.ShowDialog();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTiposProducto.SelectedCells.Count > 0)
            {
                TipoProductoNegocio neg = new TipoProductoNegocio();
                TipoProducto tp = (TipoProducto)dgvTiposProducto.CurrentRow.DataBoundItem;
                try
                {
                    using (var popup = new Confirmacion(@"eliminar """ + tp.ToString() + @""""))
                    {
                        var R = popup.ShowDialog();
                        if (R == DialogResult.OK)
                        {
                            bool conf = popup.R;
                            if (tp != null && conf == true)
                            {
                                neg.EliminarLogico(tp.IdTipoProducto);
                                LlenarTabla();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                Mensaje m = new Mensaje("Ningun item seleccion.");
                m.ShowDialog();
            }
        }
    }
}

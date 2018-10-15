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
    public partial class Marcas : MetroFramework.Forms.MetroForm
    {
        public Marcas()
        {
            InitializeComponent();
        }

        private void Marcas_Load(object sender, EventArgs e)
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
                dgvMarcas.DataSource = neg.Listar();
                dgvMarcas.Columns["IdMarca"].HeaderText = "ID";
                dgvMarcas.Columns["Descripcion"].HeaderText = "Descripción";
                dgvMarcas.Columns["Activo"].Visible = false;
                dgvMarcas.Update();
                dgvMarcas.Refresh();
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
                    if (item.GetType() == typeof(ModMarca))
                    {
                        item.Focus();
                        return;
                    }
                }
                try
                {
                    ModMarca mod = new ModMarca();
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
            {
                foreach (Form item in Application.OpenForms)
                {
                    if (item.GetType() == typeof(ModMarca))
                    {
                        item.Focus();
                        return;
                    }
                }
                try
                {
                    Marca obj = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                    ModMarca mod = new ModMarca(obj);
                    mod.ShowDialog();
                    LlenarTabla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            {
                MarcaNegocio neg = new MarcaNegocio();
                Marca m = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                try
                {
                    using (var popup = new Confirmacion(@"eliminar """ + m.ToString() + @""""))
                    {
                        var R = popup.ShowDialog();
                        if (R == DialogResult.OK)
                        {
                            bool conf = popup.R;
                            if (m != null && conf == true)
                            {
                                neg.EliminarLogico(m.IdMarca);
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
        }
    }
}

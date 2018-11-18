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
        int permisos;
        MenuPrincipal menu;
        public Marcas(int p, MenuPrincipal mp)
        {
            InitializeComponent();
            permisos = p;
            menu = mp;
        }

        private void Marcas_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarTabla();
            }
            catch (Exception ex)
            {
                Mensaje m = new Mensaje(ex.ToString()); m.ShowDialog(); 
            }
            if (permisos == 2)
            {
                BtnEditar.Enabled = false;
                BtnEliminar.Enabled = false;
            }
            if (permisos == 3)
            {
                BtnEditar.Enabled = false;
                BtnEliminar.Enabled = false;
                BtnAgregar.Enabled = false;
            }
        }

        private void LlenarTabla()
        {
            MarcaNegocio neg = new MarcaNegocio();
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
                Mensaje m = new Mensaje(ex.ToString()); m.ShowDialog(); 
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
                    Mensaje m = new Mensaje(ex.ToString()); m.ShowDialog(); 
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.SelectedCells.Count > 0)
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
                    Mensaje m = new Mensaje(ex.ToString()); m.ShowDialog(); 
                }
            }
            else
            {
                Mensaje m = new Mensaje("Ningun item seleccionado.");
                m.ShowDialog(); 
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.SelectedCells.Count > 0)
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
                    Mensaje me = new Mensaje(ex.ToString()); me.ShowDialog(); 
                }
            }
            else
            {
                Mensaje m = new Mensaje("Ningun item seleccionado.");
                m.ShowDialog(); 
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Focus();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class Contactos : MetroFramework.Forms.MetroForm
    {
        int IdRelacion;

        public Contactos(int Id)
        {
            InitializeComponent();
            IdRelacion = Id;
        }
    
        private void Contactos_Load(object sender, EventArgs e)
        {
            LlenarTabla();
        }
        
        private void LlenarTabla()
        {
            ContactoNegocio neg = new ContactoNegocio();
            try
            {
                dgvContactos.DataSource = neg.Listar(IdRelacion);
                dgvContactos.Columns["IdContacto"].HeaderText = "ID";
                dgvContactos.Columns["Dni"].HeaderText = "DNI";
                dgvContactos.Columns["Activo"].Visible = false;
                dgvContactos.Update();
                dgvContactos.Refresh();
            }
            catch (Exception ex)
            {
                Mensaje m = new Mensaje(ex.ToString()); m.ShowDialog(); 
            }
        }
        
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ModContacto))
                {
                    item.Focus();
                    return;
                }
            }
            try
            {
                ModContacto mod = new ModContacto(IdRelacion);
                mod.ShowDialog(); 
                LlenarTabla();
            }
            catch (Exception ex)
            {
                Mensaje m = new Mensaje(ex.ToString()); m.ShowDialog(); 
            }
        }
        
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvContactos.SelectedCells.Count > 0)
            {
                foreach (Form item in Application.OpenForms)
                {
                    if (item.GetType() == typeof(Contacto))
                    {
                        item.Focus();
                        return;
                    }
                }
                try
                {
                    Contacto obj = (Contacto)dgvContactos.CurrentRow.DataBoundItem;
                    ModContacto mod = new ModContacto(obj);
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
            if (dgvContactos.SelectedCells.Count > 0)
            {
                ContactoNegocio neg = new ContactoNegocio();
                Contacto C = (Contacto)dgvContactos.CurrentRow.DataBoundItem;
                try
                {
                    using (var popup = new Confirmacion(@"eliminar """ + C.ToString() + @""""))
                    {
                        var R = popup.ShowDialog(); 
                        if (R == DialogResult.OK)
                        {
                            bool conf = popup.R;
                            if (C != null && conf == true)
                            {
                                neg.EliminarLogico(C.IdContacto);
                                LlenarTabla();
                            }
                        }
                    }
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
        
        private void BtnDetalles_Click(object sender, EventArgs e)
        {
            if (dgvContactos.SelectedCells.Count > 0)
            {
                foreach (Form item in Application.OpenForms)
                {
                    if (item.GetType() == typeof(DetallesContacto))
                    {
                        item.Focus();
                        return;
                    }
                }
                try
                {
                    DetallesContacto detalles = new DetallesContacto((Contacto)dgvContactos.CurrentRow.DataBoundItem);
                    detalles.ShowDialog();
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
        
        private void DgvContactos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(DetallesContacto))
                {
                    item.Focus();
                    return;
                }
            }
            try
            {
                DetallesContacto detalles = new DetallesContacto((Contacto)dgvContactos.CurrentRow.DataBoundItem);
                detalles.Show();
                LlenarTabla();
            }
            catch (Exception ex)
            {
                Mensaje m = new Mensaje(ex.ToString()); m.ShowDialog(); 
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

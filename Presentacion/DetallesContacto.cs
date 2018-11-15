using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Presentacion
{
    public partial class DetallesContacto : MetroFramework.Forms.MetroForm
    {
        private Contacto c;

        public DetallesContacto(Contacto C)
        {
            c = C;
            InitializeComponent();
        }

        public DetallesContacto(Empleado C)
        {
            c = C;
            c.IdContacto = C.IdEmpleado;
            InitializeComponent();
        }

        public DetallesContacto(ClienteP C)
        {
            c = new Contacto
            {
                IdContacto = C.IdCliente,
                Nombre = C.Nombre,
                Apellido = C.Apellido,
                Dni = C.Dni,
                Email = C.Email,
                LstTelefonos = C.LstTelefonos,
                LstDomicilios = C.LstDomicilios, 
                Activo = C.Activo
            };
            InitializeComponent();
        }

        private void DetallesContacto_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = c.ToString();
                LlenarTablaT();
                LlenarTablaD();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LlenarTablaT()
        {
            TelefonoNegocio negT = new TelefonoNegocio();
            try
            {
                c.LstTelefonos = negT.Listar(c.IdContacto);
                dgvTelefonos.DataSource = c.LstTelefonos;
                dgvTelefonos.Columns["IdTelefono"].HeaderText = "ID";
                dgvTelefonos.Columns["Descripcion"].HeaderText = "Descripción";
                dgvTelefonos.Columns["Numero"].HeaderText = "Número";
                dgvTelefonos.Columns["Activo"].Visible = false;
                dgvTelefonos.Columns["IdRelacion"].Visible = false;
                dgvTelefonos.Update();
                dgvTelefonos.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LlenarTablaD()
        {
            DomicilioNegocio negD = new DomicilioNegocio();
            try
            {
                c.LstDomicilios = negD.Listar(c.IdContacto);
                dgvDomicilios.DataSource = c.LstDomicilios;
                dgvDomicilios.Columns["IdDomicilio"].HeaderText = "ID";
                dgvDomicilios.Columns["Activo"].Visible = false;
                dgvDomicilios.Columns["IdRelacion"].Visible = false;
                dgvDomicilios.Update();
                dgvDomicilios.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnAgregarT_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ModTelefono))
                {
                    item.Focus();
                    return;
                }
            }
            try
            {
                ModTelefono mod = new ModTelefono(c.IdContacto);
                mod.ShowDialog();
                LlenarTablaT();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnEditarT_Click(object sender, EventArgs e)
        {
            if (dgvTelefonos.SelectedCells.Count > 0)
            {
                foreach (Form item in Application.OpenForms)
                {
                    if (item.GetType() == typeof(ModTelefono))
                    {
                        item.Focus();
                        return;
                    }
                }
                try
                {
                    Telefono obj = (Telefono)dgvTelefonos.CurrentRow.DataBoundItem;
                    ModTelefono mod = new ModTelefono(obj);
                    mod.ShowDialog();
                    LlenarTablaT();
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

        private void BtnEliminarT_Click(object sender, EventArgs e)
        {
            if (dgvTelefonos.SelectedCells.Count > 0)
            {
                TelefonoNegocio neg = new TelefonoNegocio();
                Telefono em = (Telefono)dgvTelefonos.CurrentRow.DataBoundItem;
                try
                {
                    using (var popup = new Confirmacion(@"eliminar """ + em.ToString() + @""""))
                    {
                        var R = popup.ShowDialog();
                        if (R == DialogResult.OK)
                        {
                            bool conf = popup.R;
                            if (em != null && conf == true)
                            {
                                neg.EliminarLogico(em.IdTelefono);
                                LlenarTablaT();
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

        private void BtnAgregarD_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ModDomicilio))
                {
                    item.Focus();
                    return;
                }
            }
            try
            {
                ModDomicilio mod = new ModDomicilio(c.IdContacto);
                mod.ShowDialog();
                LlenarTablaD();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnEditarD_Click(object sender, EventArgs e)
        {
            if (dgvDomicilios.SelectedCells.Count > 0)
            {
                foreach (Form item in Application.OpenForms)
                {
                    if (item.GetType() == typeof(ModDomicilio))
                    {
                        item.Focus();
                        return;
                    }
                }
                try
                {
                    Domicilio obj = (Domicilio)dgvDomicilios.CurrentRow.DataBoundItem;
                    ModDomicilio mod = new ModDomicilio(obj);
                    mod.ShowDialog();
                    LlenarTablaD();
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

        private void BtnEliminarD_Click(object sender, EventArgs e)
        {
            if (dgvDomicilios.SelectedCells.Count > 0)
            {
                DomicilioNegocio neg = new DomicilioNegocio();
                Domicilio d = (Domicilio)dgvDomicilios.CurrentRow.DataBoundItem;
                try
                {
                    using (var popup = new Confirmacion(@"eliminar """ + d.ToString() + @""""))
                    {
                        var R = popup.ShowDialog();
                        if (R == DialogResult.OK)
                        {
                            bool conf = popup.R;
                            if (d != null && conf == true)
                            {
                                neg.EliminarLogico(d.IdDomicilio);
                                LlenarTablaD();
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

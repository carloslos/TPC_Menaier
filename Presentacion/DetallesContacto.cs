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
    public partial class DetallesContacto : Presentacion.Metro_Template
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
        }

        private void BtnEditarT_Click(object sender, EventArgs e)
        {
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
                    ModTelefono mod = new ModTelefono(c.IdContacto,obj);
                    mod.Show();
                    LlenarTablaT();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void BtnEliminarT_Click(object sender, EventArgs e)
        {
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
        }

        private void BtnAgregarD_Click(object sender, EventArgs e)
        {
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
                    LlenarTablaT();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void BtnEditarD_Click(object sender, EventArgs e)
        {
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
                    Domicilio obj = (Domicilio)dgvTelefonos.CurrentRow.DataBoundItem;
                    ModDomicilio mod = new ModDomicilio(c.IdContacto, obj);
                    mod.Show();
                    LlenarTablaT();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void BtnEliminarD_Click(object sender, EventArgs e)
        {
            {
                DomicilioNegocio neg = new DomicilioNegocio();
                Domicilio d = (Domicilio)dgvTelefonos.CurrentRow.DataBoundItem;
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
        }
    }
}

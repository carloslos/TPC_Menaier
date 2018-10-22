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
            this.Text = C.ToString();
            c = C;
            InitializeComponent();
        }

        public DetallesContacto(Empleado C)
        {
            this.Text = C.ToString();
            c = C;
            c.IdContacto = C.IdEmpleado;
            InitializeComponent();
        }

        private void DetallesContacto_Load(object sender, EventArgs e)
        {
            try
            {
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
                dgvTelefonos.DataSource = negT.Listar(c.IdContacto);
                dgvTelefonos.Columns["IdTelefono"].HeaderText = "ID";
                dgvTelefonos.Columns["Descripcion"].HeaderText = "Descripción";
                dgvTelefonos.Columns["Numero"].HeaderText = "Número";
                dgvTelefonos.Columns["Activo"].Visible = false;
                dgvTelefonos.Columns["IdContacto"].Visible = false;
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
                dgvDomicilios.DataSource = negD.Listar(c.IdContacto);
                dgvDomicilios.Columns["IdDomicilio"].HeaderText = "ID";
                dgvDomicilios.Columns["Descripcion"].HeaderText = "Descripción";
                dgvDomicilios.Columns["Activo"].Visible = false;
                dgvDomicilios.Columns["IdContacto"].Visible = false;
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

        }

        private void BtnEditarT_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminarT_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregarD_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditarD_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminarD_Click(object sender, EventArgs e)
        {

        }
    }
}

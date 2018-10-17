using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using Negocio;
using Dominio;

namespace Presentacion
{
    public partial class ModEmpleado : Presentacion.Metro_Template
    {
        public ModEmpleado()
        {
            InitializeComponent();
            this.Text = "Agregar " + this.Text;
            BtnMod.Text = "Agregar";
        }

        public ModEmpleado(Empleado e)
        {
            InitializeComponent();
            this.Text = "Editar " + this.Text;
            BtnMod.Text = "Editar";
            TxtNombre.Text = e.Nombre;
            TxtApellido.Text = e.Apellido;
            TxtDni.Text = e.Dni.ToString();
            TxtEmail.Text = e.Email;
            DateFechaNac.Value = e.FechaNac;
            switch (e.TipoPerfil)
            {
                case 'A':
                    BoxTipoPerfil.Text = "Administrador";
                    break;
                case 'S':
                    BoxTipoPerfil.Text = "Supervisor";
                    break;
                case 'V':
                    BoxTipoPerfil.Text = "Vendedor";
                    break;
                default:
                    break;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            EmpleadoNegocio neg = new EmpleadoNegocio();
            Empleado empleado = new Empleado
            {
                Nombre = TxtNombre.Text.Trim(), // VALIDAR
                Apellido = TxtApellido.Text.Trim()
            };
            try
            {
                neg.Agregar(empleado);
                TxtNombre.Text = "";
                TxtApellido.Text = "";
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void TxtDni_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

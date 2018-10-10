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
        private Empleado empleado = null;

        public ModEmpleado(string title)
        {
            InitializeComponent();
            this.Text = title + " " + this.Text;
        }

        public ModEmpleado(string title, Empleado e)
        {
            InitializeComponent();
            this.Text = title + " " + this.Text;
            empleado = e;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            EmpleadosNegocio neg = new EmpleadosNegocio();
            Empleado empleado = new Empleado
            {
                Nombre = txtNombre.Text.Trim(), // VALIDAR
                Apellido = txtApellido.Text.Trim()
            };
            try
            {
                neg.Agregar(empleado);
                txtNombre.Text = "";
                txtApellido.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            bool isEmail;
            try
            {
                MailAddress addr = new MailAddress(txtEmail.Text);
                isEmail = true;
            }
            catch
            {
                isEmail = false;
            }
            if(isEmail)
            {
                // EMAIL OK
            }
            else
            {
                // EMAIL NOT OK
            }
        }

        private void ModEmpleado_Load(object sender, EventArgs e)
        {
            try
            {
                if (empleado != null)
                {
                    txtNombre.Text = empleado.Nombre;
                    txtApellido.Text = empleado.Apellido;
                    txtDNI.Text = empleado.Dni.ToString();
                    txtEmail.Text = empleado.Email;
                    dateFechaNac.Value = empleado.FechaNac;
                    switch(empleado.TipoPerfil)
                    {
                        case 'A':
                            boxTipoPerfil.Text = "Administrador";
                            break;
                        case 'S':
                            boxTipoPerfil.Text = "Supervisor";
                            break;
                        case 'V':
                            boxTipoPerfil.Text = "Vendedor";
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    empleado = new Empleado();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

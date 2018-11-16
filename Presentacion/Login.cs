using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {

        private Empleado empleado;

        public Login()
        {
            InitializeComponent();
        }

        public Login(Empleado em)
        {
            InitializeComponent();
            empleado = em;
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (empleado.IdEmpleado == 0)
            {
                Application.Exit();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            EmpleadoNegocio usuarioNegocio = new EmpleadoNegocio();
            try
            {
                empleado.Usuario = txtUsuario.Text.Trim();
                empleado.Pass = txtContrasenia.Text.Trim();
                if (usuarioNegocio.ValidarUsuario(empleado))
                {
                    Close();
                }
                else
                {
                    Mensaje m = new Mensaje("Usuario o contraseña incorrectos.");
                    m.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Mensaje m = new Mensaje(ex.ToString());
                m.ShowDialog();
            }
        }
    }
}

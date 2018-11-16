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
    public partial class ModEmpleado : MetroFramework.Forms.MetroForm
    {
        private bool[] EntradasVal = new bool[7];
        Empleado em;
        Validaciones val = new Validaciones();

        public ModEmpleado()
        {
            InitializeComponent();
            this.Text = "Agregar " + this.Text;
            BtnMod.Text = "Agregar";
            BtnMod.Enabled = false;
            DateFechaNac.CustomFormat = " ";
            DateFechaNac.Format = DateTimePickerFormat.Custom;
            em = new Empleado();
        }

        public ModEmpleado(Empleado E)
        {
            InitializeComponent();
            this.Text = "Editar " + this.Text;
            BtnMod.Text = "Editar";
            BtnMod.Enabled = false;
            TxtNombre.Text = E.Nombre;
            TxtApellido.Text = E.Apellido;
            TxtDni.Text = E.Dni.ToString();
            TxtEmail.Text = E.Email;
            BoxTipoPerfil.SelectedItem = E.TipoPerfilS;
            DateFechaNac.CustomFormat = "dd/MM/yyyy";
            DateFechaNac.Value = E.FechaNac;
            em = E;
        }

        private void ModEmpleado_Load(object sender, EventArgs e)
        {
            bool b;
            if (em.IdEmpleado != 0) { b = true; }
            else { b = false; }
            for (int i = 0; i < EntradasVal.Length; i++)
            {
                EntradasVal[i] = b;
            }
            ValidarEntradas();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMod_Click(object sender, EventArgs e)
        {
            try
            {
                EmpleadoNegocio neg = new EmpleadoNegocio();
                em.Nombre = TxtNombre.Text.Trim();
                em.Apellido = TxtApellido.Text.Trim();
                em.Dni = Convert.ToInt32(TxtDni.Text.Trim());
                em.Email = TxtEmail.Text.Trim();
                em.TipoPerfil.IdTipoPerfil = (int)BoxTipoPerfil.SelectedValue;
                em.Usuario = TxtUsuario.Text;
                em.FechaNac = DateFechaNac.Value;             
                if (em.IdEmpleado == 0)
                {
                    neg.Agregar(em);
                }
                else
                {
                    neg.Modificar(em);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            TxtNombre.Text = TxtNombre.Text.TrimStart();
            ValidarTxt(0, val.EsAlfa, TxtNombre, tileNombre, lblNombre);
            if(EntradasVal[0] == true && EntradasVal[1] == true)
            {
                TxtUsuario.Text = TxtNombre.Text[0] + TxtApellido.Text.Substring(0, TxtApellido.Text.IndexOf(" "));
            }
            else
            {
                TxtUsuario.Text = "";
            }
        }

        private void TxtApellido_TextChanged(object sender, EventArgs e)
        {
            TxtApellido.Text = TxtApellido.Text.TrimStart();
            ValidarTxt(1, val.EsAlfa, TxtApellido, tileApellido, lblApellido);
            if (EntradasVal[0] == true && EntradasVal[1] == true)
            {
                TxtUsuario.Text = TxtNombre.Text[0] + TxtApellido.Text.Substring(0, TxtApellido.Text.IndexOf(" "));
            }
            else
            {
                TxtUsuario.Text = "";
            }
        }

        private void TxtDni_TextChanged(object sender, EventArgs e)
        {
            TxtDni.Text = TxtDni.Text.TrimStart();
            ValidarTxt(2, val.EsDni, TxtDni, tileDni, lblDni);
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            TxtEmail.Text = TxtEmail.Text.TrimStart();
            ValidarTxt(3, val.EsEmail, TxtEmail, tileEmail, lblEmail);
        }

        private void BoxTipoPerfil_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidarBox(4, BoxTipoPerfil, tileTipoPerfil, lblTipoPerfil);
        }

        private void DateFechaNac_ValueChanged(object sender, EventArgs e)
        {
            DateFechaNac.CustomFormat = "dd/MM/yyyy";
            ValidarDate(5, DateFechaNac.Value, tileFechaNac, lblFechaNac);
        }

        private void ValidarTxt(int c, Func<string, bool> metodo, MetroFramework.Controls.MetroTextBox txt, MetroFramework.Controls.MetroTile t, MetroFramework.Controls.MetroLabel l)
        {
            if (metodo(txt.Text))
            {
                EntradasVal[c] = true;
                val.CambiarColor(t, l, 'g');
            }
            else
            {
                EntradasVal[c] = false;
                if (txt.Text == "")
                {
                    val.CambiarColor(t, l, 'b');
                }
                else
                {
                    val.CambiarColor(t, l, 'r');
                }
            }
            ValidarEntradas();
        }

        private void LimpiarEntradas()
        {
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtDni.Text = "";
            TxtEmail.Text = "";
            BoxTipoPerfil.SelectedIndex = -1;
            DateFechaNac.CustomFormat = " ";
            DateFechaNac.Format = DateTimePickerFormat.Custom;
            val.CambiarColor(tileNombre, lblNombre, 'b');
            val.CambiarColor(tileApellido, lblApellido, 'b');
            val.CambiarColor(tileDni, lblDni, 'b');
            val.CambiarColor(tileEmail, lblEmail, 'b');
            val.CambiarColor(tileTipoPerfil, lblTipoPerfil, 'b');
            val.CambiarColor(tileFechaNac, lblFechaNac, 'b');
        }

        private void ValidarDate (int c, DateTime d, MetroFramework.Controls.MetroTile t, MetroFramework.Controls.MetroLabel l)
        {
            DateTime v = new DateTime(1900, 1, 1), a = DateTime.Today.AddYears(-18);
            if (DateFechaNac.CustomFormat == " ")
            {
                val.CambiarColor(t, l, 'b');
            }
            else
            {
                if (d > v && d < a)
                {
                    EntradasVal[c] = true;
                    val.CambiarColor(t, l, 'g');
                }
                else
                {
                    EntradasVal[c] = false;
                    val.CambiarColor(t, l, 'r');
                }
            }
            ValidarEntradas();
        }

        private void ValidarBox(int c, MetroFramework.Controls.MetroComboBox b, MetroFramework.Controls.MetroTile t, MetroFramework.Controls.MetroLabel l)
        {
            if (b.SelectedIndex != -1)
            {
                EntradasVal[c] = true;
                val.CambiarColor(t, l, 'g');
            }
            else
            {
                EntradasVal[c] = false;
                val.CambiarColor(t, l, 'b');
            }
            ValidarEntradas();
        }

        private void ValidarEntradas()
        {
            int i;
            bool v = true;
            for (i = 0; i < EntradasVal.Length - 1; i++)
            {
                if (EntradasVal[i] == false)
                {
                    v = false;
                    break;
                }
            }
            if (v == true) { BtnMod.Enabled = true; }
            else { BtnMod.Enabled = false; }
        }

        private void TxtPass_TextChanged(object sender, EventArgs e)
        {
            TxtPass.Text = TxtPass.Text.TrimStart();
            ValidarTxt(7, val.EsPass, TxtPass, tilePass, lblPass);
        }

        private void ModEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool v = true;
            for (int i = 0; i < EntradasVal.Length - 1; i++)
            {
                if (EntradasVal[i] == false)
                {
                    v = false;
                    break;
                }
            }
            if (e.KeyChar == 13 && v == true)
            {
                BtnMod_Click(sender, e);
            }
        }
    }
}

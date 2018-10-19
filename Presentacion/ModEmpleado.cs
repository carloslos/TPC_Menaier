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
        private bool[] EntradasVal = new bool[6];
        Empleado em;
        Validaciones val = new Validaciones();

        public ModEmpleado()
        {
            InitializeComponent();
            this.Text = "Agregar " + this.Text;
            BtnMod.Text = "Agregar";
            BtnMod.Enabled = false;
            em = new Empleado();
        }

        public ModEmpleado(Empleado E)
        {
            InitializeComponent();
            string tp;
            this.Text = "Editar " + this.Text;
            BtnMod.Text = "Editar";
            BtnMod.Enabled = false;
            TxtNombre.Text = E.Nombre;
            TxtApellido.Text = E.Apellido;
            TxtDni.Text = E.Dni.ToString();
            switch (E.TipoPerfil)
            {
                case 'A':
                    tp = "Administrador";
                    break;
                case 'S':
                    tp = "Supervisor";
                    break;
                case 'V':
                default:
                    tp = "Vendedor";
                    break;
            }
            BoxTipoPerfil.SelectedValue = tp;
            DateFechaNac.Value = E.FechaNac;
            em = E;
        }

        private void ModEmpleado_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < EntradasVal.Length; i++)
            {
                EntradasVal[i] = false;
            }
            RealizarValidaciones();
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
                //string s = BoxTipoPerfil.SelectedText;                // ESTA COSA
                //em.TipoPerfil = s[0];
                em.FechaNac = DateFechaNac.Value;             
                if (em.IdEmpleado == 0)
                {
                    neg.Agregar(em);
                    LimpiarEntradas();
                }
                else
                {
                    neg.Modificar(em);
                    this.Close();
                }
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
        }

        private void TxtApellido_TextChanged(object sender, EventArgs e)
        {
            TxtApellido.Text = TxtApellido.Text.TrimStart();
            ValidarTxt(1, val.EsAlfa, TxtApellido, tileApellido, lblApellido);
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

        private void RealizarValidaciones()
        {
            TxtNombre.Text = TxtNombre.Text.TrimStart();
            ValidarTxt(0, val.EsAlfa, TxtNombre, tileNombre, lblNombre);
            TxtApellido.Text = TxtApellido.Text.TrimStart();
            ValidarTxt(1, val.EsAlfa, TxtApellido, tileApellido, lblApellido);
            TxtDni.Text = TxtDni.Text.TrimStart();
            ValidarTxt(2, val.EsDni, TxtDni, tileDni, lblDni);
            ValidarBox(3, BoxTipoPerfil, tileTipoPerfil, lblTipoPerfil);
            ValidarBox(4, BoxTipoPerfil, tileTipoPerfil, lblTipoPerfil);
            ValidarDate(5, DateFechaNac.Value, tileFechaNac, lblFechaNac);
            ValidarEntradas();
        }

        private void LimpiarEntradas()
        {
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtDni.Text = "";
            BoxTipoPerfil.SelectedIndex = -1;
            val.CambiarColor(tileNombre, lblNombre, 'b');
            val.CambiarColor(tileApellido, lblApellido, 'b');
            val.CambiarColor(tileDni, lblDni, 'b');
            val.CambiarColor(tileTipoPerfil, lblTipoPerfil, 'b');
        }

        private void ValidarDate (int c, DateTime d, MetroFramework.Controls.MetroTile t, MetroFramework.Controls.MetroLabel l)
        {
            DateTime v = new DateTime(1900, 1, 1), a = DateTime.Today.AddYears(-18);
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
    }
}

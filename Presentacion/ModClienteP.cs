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
    public partial class ModClienteP : Presentacion.Metro_Template
    {
        private bool[] EntradasVal = new bool[4];
        Validaciones val = new Validaciones();
        ClienteP c = null;

        public ModClienteP()
        {
            InitializeComponent();
            this.Text = "Agregar " + this.Text;
            BtnMod.Text = "Agregar";
            BtnMod.Enabled = false;
            c = new ClienteP();
        }

        public ModClienteP(ClienteP C)
        {
            InitializeComponent();
            this.Text = "Editar " + this.Text;
            BtnMod.Text = "Editar";
            BtnMod.Enabled = false;
            TxtNombre.Text = C.Datos.Nombre;
            TxtApellido.Text = C.Datos.Apellido;
            TxtDni.Text = C.Datos.Dni.ToString();
            TxtEmail.Text = C.Datos.Email;
            c = C;
        }

        private void ModClienteP_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < EntradasVal.Length; i++)
            {
                EntradasVal[i] = false;
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

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnMod_Click(object sender, EventArgs e)
        {
            ClientePNegocio neg = new ClientePNegocio();
            try
            {
                c.Datos.Nombre = TxtNombre.Text.Trim();
                c.Datos.Apellido = TxtApellido.Text.Trim();
                c.Datos.Dni = Convert.ToInt32(TxtDni.Text.Trim());
                c.Datos.Email = TxtEmail.Text.Trim();
                if (c.Datos.IdContacto != 0)
                {
                    neg.Modificar(c);
                    this.Dispose();
                }
                else
                {
                    neg.Agregar(c);
                    LimpiarEntradas();
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
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
            val.CambiarColor(tileNombre, lblNombre, 'b');
            val.CambiarColor(tileApellido, lblApellido, 'b');
            val.CambiarColor(tileDni, lblDni, 'b');
            val.CambiarColor(tileEmail, lblEmail, 'b');
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtDni.Text = "";
            TxtEmail.Text = "";
        }

        private void ValidarEntradas()
        {
            int i;
            bool v = true;
            for (i = 0; i < EntradasVal.Length; i++)
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

        private void BtnMod_Click_1(object sender, EventArgs e)
        {

        }
    }
}

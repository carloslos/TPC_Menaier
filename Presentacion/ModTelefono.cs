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
    public partial class ModTelefono : MetroFramework.Forms.MetroForm
    {
        private bool[] EntradasVal = new bool[2];
        Telefono t = null;
        Validaciones val = new Validaciones();

        public ModTelefono(int IdRelacion)
        {
            InitializeComponent();
            this.Text = "Agregar " + this.Text;
            BtnMod.Text = "Agregar";
            BtnMod.Enabled = false;
            t = new Telefono
            {
                IdRelacion = IdRelacion
            };
        }

        public ModTelefono(Telefono T)
        {
            InitializeComponent();
            this.Text = "Editar " + this.Text;
            BtnMod.Text = "Editar";
            BtnMod.Enabled = false;
            TxtDescripcion.Text = T.Descripcion;
            TxtNumero.Text = T.Numero.ToString();
            t = T;
        }

        private void ModTelefono_Load(object sender, EventArgs e)
        {
            bool b;
            if(t.IdTelefono != 0) { b = true; }
            else { b = false; }
            for (int i = 0; i < EntradasVal.Length; i++)
            {
                EntradasVal[i] = b;
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMod_Click(object sender, EventArgs e)
        {
            TelefonoNegocio neg = new TelefonoNegocio();
            try
            {
                t.Descripcion = TxtDescripcion.Text.Trim();
                t.Numero = Convert.ToInt32(TxtNumero.Text.Trim());
                if (t.IdTelefono != 0)
                {
                    neg.Modificar(t);
                }
                else
                {
                    neg.Agregar(t);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void TxtDescripcion_TextChanged(object sender, EventArgs e)
        {
            TxtDescripcion.Text = TxtDescripcion.Text.TrimStart();
            ValidarTxt(0, val.EsAlfa, TxtDescripcion, tileDescripcion, lblDescripcion);
        }

        private void TxtNumero_TextChanged(object sender, EventArgs e)
        {
            TxtNumero.Text = TxtNumero.Text.TrimStart();
            ValidarTxt(1, val.EsNumeroEntero, TxtNumero, tileNumero, lblNumero);
        }

        private void ValidarTxt(int p, Func<string, bool> metodo, MetroFramework.Controls.MetroTextBox txt, MetroFramework.Controls.MetroTile t, MetroFramework.Controls.MetroLabel l)
        {
            if (metodo(txt.Text))
            {
                EntradasVal[p] = true;
                val.CambiarColor(t, l, 'g');
            }
            else
            {
                EntradasVal[p] = false;
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

        private void ValidarEntradas()
        {
            if (EntradasVal[0] == true && EntradasVal[1] == true) { BtnMod.Enabled = true; }
            else { BtnMod.Enabled = false; }
        }
    }
}

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
    public partial class ModMarca : Presentacion.Metro_Template
    {
        private bool EntradasVal = false;
        Validaciones val = new Validaciones();

        public ModMarca()
        {
            InitializeComponent();
            this.Text = "Agregar " + this.Text;
            BtnMod.Text = "Agregar";
            BtnMod.Enabled = false;
        }

        public ModMarca(Marca m)
        {
            InitializeComponent();
            this.Text = "Editar " + this.Text;
            BtnMod.Text = "Editar";
            BtnMod.Enabled = false;
            TxtDescripcion.Text = m.Descripcion;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            MarcaNegocio neg = new MarcaNegocio ();
            Marca m = new Marca
            {
                Descripcion = TxtDescripcion.Text.Trim()
            };
            try
            {
                neg.Agregar(m);
                TxtDescripcion.Text = "";
                LimpiarEntradas();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        private void TxtDescripcion_TextChanged(object sender, EventArgs e)
        {
            TxtDescripcion.Text = TxtDescripcion.Text.TrimStart();
            ValidarTxt(val.EsAlfanumerico, TxtDescripcion, tileDescripcion, lblDescripcion);
        }

        private void ValidarTxt(Func<string, bool> metodo, MetroFramework.Controls.MetroTextBox txt, MetroFramework.Controls.MetroTile t, MetroFramework.Controls.MetroLabel l)
        {
            if (metodo(txt.Text))
            {
                EntradasVal = true;
                val.CambiarColor(t, l, 'g');
            }
            else
            {
                EntradasVal = false;
                if (txt.Text == "")
                {
                    val.CambiarColor(t, l, 'b');
                }
                else
                {
                    val.CambiarColor(t, l, 'r');
                }
            }
            ValidarBox();
        }

        private void ValidarBox()
        {
            if (EntradasVal == true) { BtnMod.Enabled = true; }
            else { BtnMod.Enabled = false; }
        }

        private void LimpiarEntradas()
        {
            val.CambiarColor(tileDescripcion, lblDescripcion, 'b');
        }
    }
}

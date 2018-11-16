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
    public partial class ModMarca : MetroFramework.Forms.MetroForm
    {
        private bool EntradasVal = false;
        Validaciones val = new Validaciones();
        Marca m;

        public ModMarca()
        {
            InitializeComponent();
            this.Text = "Agregar " + this.Text;
            BtnMod.Text = "Agregar";
            BtnMod.Enabled = false;
            m = new Marca();
        }

        public ModMarca(Marca M)
        {
            InitializeComponent();
            this.Text = "Editar " + this.Text;
            BtnMod.Text = "Editar";
            BtnMod.Enabled = true;
            TxtDescripcion.Text = M.Descripcion;
            m = M;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            MarcaNegocio neg = new MarcaNegocio ();
            m.Descripcion = TxtDescripcion.Text;
            try
            {
                if(m.IdMarca == 0)
                {
                    neg.Agregar(m);
                }
                else
                {
                    neg.Modificar(m);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        private void TxtDescripcion_TextChanged(object sender, EventArgs e)
        {
            TxtDescripcion.Text = TxtDescripcion.Text.TrimStart();
            ValidarTxt(val.EsAlfa, TxtDescripcion, tileDescripcion, lblDescripcion);
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
            ValidarEntradas();
        }

        private void ValidarEntradas()
        {
            if (EntradasVal == true) { BtnMod.Enabled = true; }
            else { BtnMod.Enabled = false; }
        }

        private void ModMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && EntradasVal == true)
            {
                BtnAgregar_Click(sender, e);
            }
        }
    }
}

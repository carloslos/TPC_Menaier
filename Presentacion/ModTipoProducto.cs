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
    public partial class ModTipoProducto : Presentacion.Metro_Template
    {
        private bool EntradasVal = false;
        TipoProducto tp = null;
        Validaciones val = new Validaciones();

        public ModTipoProducto()
        {
            InitializeComponent();
            this.Text = "Agregar " + this.Text;
            BtnMod.Text = "Agregar";
            BtnMod.Enabled = false;
            tp = new TipoProducto();
        }

        public ModTipoProducto(TipoProducto Tp)
        {
            InitializeComponent();
            this.Text = "Editar " + this.Text;
            BtnMod.Text = "Editar";
            BtnMod.Enabled = false;
            TxtDescripcion.Text = Tp.Descripcion;
            tp = Tp;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMod_Click(object sender, EventArgs e)
        {
            TipoProductoNegocio neg = new TipoProductoNegocio();
            try
            {
                tp.Descripcion = TxtDescripcion.Text.Trim();
                if (tp.IdTipoProducto != 0)
                {
                    neg.Modificar(tp);
                    this.Close();
                }
                else
                {
                    neg.Agregar(tp);
                    LimpiarEntradas();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void TxtDescripcion_TextChanged(object sender, EventArgs e)
        {
            TxtDescripcion.Text = TxtDescripcion.Text.TrimStart();
            ValidarTxt(val.EsAlfa,TxtDescripcion, tileDescripcion, lblDescripcion);
        }

        private void ValidarTxt(Func<string, bool> metodo,MetroFramework.Controls.MetroTextBox txt, MetroFramework.Controls.MetroTile t, MetroFramework.Controls.MetroLabel l)
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

        private void LimpiarEntradas()
        {
            val.CambiarColor(tileDescripcion, lblDescripcion, 'b');
            TxtDescripcion.Text = "";
        }
    }
}

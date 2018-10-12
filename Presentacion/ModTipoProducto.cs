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
        Validaciones val = new Validaciones();

        public ModTipoProducto(string title)
        {
            InitializeComponent();
            this.Text = title + " " + this.Text;
            BtnAgregar.Enabled = false;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            TiposProductoNegocio neg = new TiposProductoNegocio();
            TipoProducto tp = new TipoProducto
            {
                Descripcion = TxtDescripcion.Text.Trim()
            };
            try
            {
                neg.Agregar(tp);
                TxtDescripcion.Text = "";
                LimpiarEntradas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void TxtDescripcion_TextChanged(object sender, EventArgs e)
        {
            TxtDescripcion.Text = TxtDescripcion.Text.TrimStart();
            ValidarEntrada(val.EsAlfanumerico,TxtDescripcion, tileDescripcion, lblDescripcion);
        }

        private void ValidarEntrada(Func<string, bool> metodo,MetroFramework.Controls.MetroTextBox txt, MetroFramework.Controls.MetroTile t, MetroFramework.Controls.MetroLabel l)
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
            if (EntradasVal == true) { BtnAgregar.Enabled = true; }
            else { BtnAgregar.Enabled = false; }
        }

        private void LimpiarEntradas()
        {
            val.CambiarColor(tileDescripcion, lblDescripcion, 'b');
        }
    }
}

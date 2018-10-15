using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Presentacion
{
    public partial class ModProducto : Presentacion.Metro_Template
    {
        private bool[] EntradasVal = new bool[6];
        Validaciones val = new Validaciones();

        public ModProducto()
        {
            InitializeComponent();
            this.Text = "Agregar " + this.Text;
            BtnMod.Text = "Agregar";
            BtnMod.Enabled = false;
        }

        public ModProducto(Producto p)
        {
            InitializeComponent();
            this.Text = "Editar " + this.Text;
            BtnMod.Text = "Editar";
            BtnMod.Enabled = false;
            TxtDescripcion.Text = p.Descripcion;
            TxtGanancia.Text = p.Ganancia.ToString();
            TxtStockMin.Text = p.StockMin.ToString();
        }

        private void ModProducto_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < EntradasVal.Length; i++)
            {
                EntradasVal[i] = false;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ProductoNegocio neg = new ProductoNegocio();
            Producto p = new Producto
            {
                Descripcion = TxtDescripcion.Text.Trim(),
                Ganancia = Convert.ToDouble(TxtGanancia.Text.Trim())
            };
            try
            {
                neg.Agregar(p);
                TxtDescripcion.Text = "";
                TxtGanancia.Text = "";
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
            ValidarEntrada(0, val.EsAlfanumerico, TxtDescripcion, tileDescripcion, lblDescripcion);
        }

        private void TxtPrecio_TextChanged(object sender, EventArgs e)
        {
            TxtGanancia.Text = TxtGanancia.Text.TrimStart();
            ValidarEntrada(1, val.EsNumero, TxtGanancia, tileGanancia, lblGanancia);
        }

        private void ValidarEntrada(int c, Func<string, bool> metodo, MetroFramework.Controls.MetroTextBox txt, MetroFramework.Controls.MetroTile t, MetroFramework.Controls.MetroLabel l)
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
            val.CambiarColor(tileDescripcion, lblDescripcion, 'b');
            val.CambiarColor(tileGanancia, lblGanancia, 'b');
        }

        private void ValidarEntradas()
        {
            if (EntradasVal[0] == true && EntradasVal[1] == true) { BtnMod.Enabled = true; }
            else { BtnMod.Enabled = false; }
        }
    }
}

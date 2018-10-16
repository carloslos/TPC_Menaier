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
        private bool[] EntradasVal = new bool[5];
        Producto p = null;
        Validaciones val = new Validaciones();

        public ModProducto()
        {
            InitializeComponent();
            this.Text = "Agregar " + this.Text;
            BtnMod.Text = "Agregar";
            BtnMod.Enabled = false;
            p = new Producto();
        }

        public ModProducto(Producto P)
        {
            InitializeComponent();
            this.Text = "Editar " + this.Text;
            BtnMod.Text = "Editar";
            BtnMod.Enabled = false;
            TxtDescripcion.Text = P.Descripcion;
            TxtGanancia.Text = P.Ganancia.ToString();
            TxtStockMin.Text = P.StockMin.ToString();
            p = P;
        }

        private void ModProducto_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < EntradasVal.Length; i++)
            {
                EntradasVal[i] = false;
            }

            TipoProductoNegocio negTP = new TipoProductoNegocio();
            MarcaNegocio negM = new MarcaNegocio();
            try
            {
                BoxMarca.DisplayMember = "Descripcion";
                BoxMarca.ValueMember = "IdMarca";
                BoxMarca.DataSource = negM.Listar();

                BoxTipoProducto.DisplayMember = "Descripcion";
                BoxTipoProducto.ValueMember = "IdTipoProducto";
                BoxTipoProducto.DataSource = negTP.Listar();

                BoxMarca.SelectedIndex = -1;
                BoxTipoProducto.SelectedIndex = -1;

                if (p.Marca != null)
                {
                    BoxMarca.SelectedValue = p.Marca.IdMarca;
                }

                if (p.TipoProducto != null)
                {
                    BoxTipoProducto.SelectedValue = p.TipoProducto.IdTipoProducto;
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMod_Click(object sender, EventArgs e)
        {
            ProductoNegocio neg = new ProductoNegocio();
            Producto p = new Producto
            {
                Descripcion = TxtDescripcion.Text.Trim(),
                Ganancia = Convert.ToDouble(TxtGanancia.Text.Trim()),
                StockMin = Convert.ToInt32(TxtStockMin.Text.Trim())
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
                throw (ex);
            }
        }

        private void TxtDescripcion_TextChanged(object sender, EventArgs e)
        {
            TxtDescripcion.Text = TxtDescripcion.Text.TrimStart();
            ValidarTxt(0, val.EsAlfanumerico, TxtDescripcion, tileDescripcion, lblDescripcion);
        }

        private void TxtGanancia_TextChanged(object sender, EventArgs e)
        {
            TxtGanancia.Text = TxtGanancia.Text.TrimStart();
            ValidarTxt(1, val.EsNumero, TxtGanancia, tileGanancia, lblGanancia);
        }

        private void TxtStockMin_TextChanged(object sender, EventArgs e)
        {
            TxtStockMin.Text = TxtStockMin.Text.TrimStart();
            ValidarTxt(2, val.EsNumeroEntero, TxtStockMin, tileStockMin, lblStockMin);
        }

        private void BoxMarca_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidarBox(3, BoxMarca, tileMarca, lblMarca);
        }

        private void BoxTipoProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidarBox(4, BoxTipoProducto, tileTipoProducto, lblTipoProducto);
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

        private void ValidarBox(int c, MetroFramework.Controls.MetroComboBox b, MetroFramework.Controls.MetroTile t, MetroFramework.Controls.MetroLabel l)
        {
            if(b.SelectedIndex != -1)
            {
                EntradasVal[c] = true;
                val.CambiarColor(t, l, 'g');
            }
            else
            {
                val.CambiarColor(t, l, 'b');
            }
            ValidarEntradas();
        }

        private void LimpiarEntradas()
        {
            val.CambiarColor(tileDescripcion, lblDescripcion, 'b');
            val.CambiarColor(tileGanancia, lblGanancia, 'b');
            val.CambiarColor(tileStockMin, lblStockMin, 'b');
            val.CambiarColor(tileMarca, lblMarca, 'b');
            val.CambiarColor(tileTipoProducto, lblTipoProducto, 'b');
        }

        private void ValidarEntradas()
        {
            int i;
            bool v = true;
            for (i=0; i<5; i++)
            {
                if (EntradasVal[i] == false && v == true)
                    v = false;
            }
            if (v == true) { BtnMod.Enabled = true; }
            else { BtnMod.Enabled = false; }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

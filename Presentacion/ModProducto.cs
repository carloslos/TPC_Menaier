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
    public partial class ModProducto : MetroFramework.Forms.MetroForm
    {
        private bool[] EntradasVal = new bool[5];
        Producto p;
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
            bool b;
            if (p.IdProducto != 0) { b = true; }
            else { b = false; }
            for (int i = 0; i < EntradasVal.Length; i++)
            {
                EntradasVal[i] = b;
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

                if (p.TipoProducto != null)
                {
                    BoxTipoProducto.SelectedValue = p.TipoProducto.IdTipoProducto;
                    BoxTipoProducto.SelectedText = p.TipoProducto.Descripcion;
                }
                else
                {
                    BoxTipoProducto.SelectedIndex = -1;
                }
                if (p.Marca != null)
                {
                    BoxMarca.SelectedValue = p.Marca.IdMarca;
                    BoxMarca.SelectedText = p.Marca.Descripcion;
                    RealizarValidaciones();
                }
                else
                {
                    BoxMarca.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        private void BtnMod_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoNegocio neg = new ProductoNegocio();
                p.Descripcion = TxtDescripcion.Text.Trim();
                p.Ganancia = (float)Convert.ToDouble(TxtGanancia.Text.Trim());
                p.StockMin = Convert.ToInt32(TxtStockMin.Text.Trim());
                if(p.IdProducto == 0)
                {
                    p.TipoProducto = new TipoProducto();
                    p.Marca = new Marca();
                }
                p.TipoProducto.IdTipoProducto = Convert.ToInt32(BoxTipoProducto.SelectedValue);
                p.TipoProducto.Descripcion = BoxTipoProducto.SelectedText;
                p.Marca.IdMarca = Convert.ToInt32(BoxMarca.SelectedValue);
                p.Marca.Descripcion = BoxMarca.SelectedText;
                if (p.IdProducto == 0)
                {
                    neg.Agregar(p);
                    LimpiarEntradas();
                }
                else
                {
                    neg.Modificar(p);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        private void TxtDescripcion_TextChanged(object sender, EventArgs e)
        {
            TxtDescripcion.Text = TxtDescripcion.Text.TrimStart();
            ValidarTxt(0, val.EsAlfanum, TxtDescripcion, tileDescripcion, lblDescripcion);
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

        private void RealizarValidaciones()
        {
            TxtDescripcion.Text = TxtDescripcion.Text.Trim();
            ValidarTxt(0, val.EsAlfa, TxtDescripcion, tileDescripcion, lblDescripcion);
            TxtGanancia.Text = TxtGanancia.Text.Trim();
            ValidarTxt(1, val.EsNumero, TxtGanancia, tileGanancia, lblGanancia);
            TxtStockMin.Text = TxtStockMin.Text.Trim();
            ValidarTxt(2, val.EsNumeroEntero, TxtStockMin, tileStockMin, lblStockMin);
            ValidarBox(3, BoxMarca, tileMarca, lblMarca);
            ValidarBox(4, BoxTipoProducto, tileTipoProducto, lblTipoProducto);
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
                EntradasVal[c] = false;
                val.CambiarColor(t, l, 'b');
            }
            ValidarEntradas();
        }

        private void LimpiarEntradas()
        {
            TxtDescripcion.Text = "";
            TxtGanancia.Text = "";
            TxtStockMin.Text = "";
            BoxMarca.SelectedIndex = -1;
            BoxTipoProducto.SelectedIndex = -1;
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
            for (i = 0; i < EntradasVal.Length-1; i++)
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

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

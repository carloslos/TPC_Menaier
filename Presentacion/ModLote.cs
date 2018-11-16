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
    public partial class ModLote : MetroFramework.Forms.MetroForm
    {
        private bool[] EntradasVal = new bool[4];
        public Lote l;
        Validaciones val = new Validaciones();

        public Lote Return
        {
            get { return l; }
        }

        public ModLote(int IdCompra)
        {
            InitializeComponent();
            this.Text = "Agregar " + this.Text;
            BtnMod.Text = "Agregar";
            BtnMod.Enabled = false;
            TxtUnidadesE.Enabled = false;
            l = new Lote
            {
                IdCompra = IdCompra
            };
        }

        public ModLote(Lote L)
        {
            InitializeComponent();
            this.Text = "Editar " + this.Text;
            BtnMod.Text = "Editar";
            TxtCostoUnitario.Text = L.CostoPU.ToString();
            l = L;
            TxtUnidadesE.Text = L.UnidadesE.ToString();
            TxtUnidadesP.Text = L.UnidadesP.ToString();
        }

        private void ModLote_Load(object sender, EventArgs e)
        {
            bool b;
            if (l.IdLote != 0) { b = true; }
            else { b = false; }
            for (int i = 0; i < EntradasVal.Length; i++)
            {
                EntradasVal[i] = b;
            }

            if(l.IdLote == 0)
            {
                val.CambiarColor(tileUnidadesE, lblUnidadesE, 's');
                EntradasVal[2] = true;
            }

            ProductoNegocio negP = new ProductoNegocio();
            try
            {
                BoxProducto.DisplayMember = "Descripcion";
                BoxProducto.ValueMember = "IdProducto";
                BoxProducto.DataSource = negP.Listar(0);

                if (l.Producto != null)
                {
                    BoxProducto.SelectedValue = l.Producto.IdProducto;
                    BoxProducto.SelectedText = l.Producto.Descripcion;
                }
                else
                {
                    BoxProducto.SelectedIndex = -1;
                }
                ActualizarTotal();
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
                LoteNegocio neg = new LoteNegocio();
                l.UnidadesE = Convert.ToInt32(TxtUnidadesE.Text.Trim());
                l.UnidadesP = Convert.ToInt32(TxtUnidadesP.Text.Trim());
                l.CostoPU = (float)Convert.ToDouble(TxtCostoUnitario.Text.Trim());
                l.CostoT = (float)Convert.ToDouble(TxtCostoTotal.Text.Trim());
                if (l.IdLote == 0)
                {
                    l.Producto = new Producto();
                }
                l.Producto = (Producto)BoxProducto.SelectedItem;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        private void BoxProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidarBox(0, BoxProducto, tileProducto, lblProducto);
        }

        private void TxtUnidadesP_TextChanged(object sender, EventArgs e)
        {
            TxtUnidadesP.Text = TxtUnidadesP.Text.TrimStart();
            ValidarTxt(1, val.EsNumeroEntero, TxtUnidadesP, tileUnidadesP, lblUnidadesP);
            if(l.IdLote == 0)
            {
                TxtUnidadesE.Text = TxtUnidadesP.Text;
            }
        }
        
        private void TxtUnidadesE_TextChanged(object sender, EventArgs e)
        {
            if(l.IdLote != 0)
            {
                TxtUnidadesE.Text = TxtUnidadesE.Text.TrimStart();
                ValidarTxt(2, val.EsNumeroEntero, TxtUnidadesE, tileUnidadesE, lblUnidadesE);
                if (EntradasVal[1] == true && EntradasVal[3] == true)
                {
                    if ((Convert.ToInt32(TxtUnidadesE.Text)) > (Convert.ToInt32(TxtUnidadesP.Text)))
                    {
                        EntradasVal[2] = false;
                        val.CambiarColor(tileUnidadesE, lblUnidadesE, 'r');
                        ValidarEntradas();
                    }
                }
            }
        }

        private void TxtCostoUnitario_TextChanged(object sender, EventArgs e)
        {
            TxtCostoUnitario.Text = TxtCostoUnitario.Text.TrimStart();
            ValidarTxt(3, val.EsNumero, TxtCostoUnitario, tileCostoUnitario, lblCostoUnitario);
            ActualizarTotal();
        }

        private void ActualizarTotal()
        {
            if(EntradasVal[1] == true && EntradasVal[3] == true)
            {
                TxtCostoTotal.Text = ((Convert.ToInt32(TxtUnidadesP.Text)) * ((float)Convert.ToDouble(TxtCostoUnitario.Text))).ToString();
            }
            else
            {
                TxtCostoTotal.Text = "";
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

        private void RealizarValidaciones()
        {
            ValidarBox(0, BoxProducto, tileProducto, lblProducto);
            ValidarTxt(1, val.EsNumeroEntero, TxtUnidadesP, tileUnidadesP, lblUnidadesP);
            if (l.IdLote != 0) { ValidarTxt(2, val.EsNumeroEntero, TxtUnidadesE, tileUnidadesE, lblUnidadesE); }
            ValidarTxt(3, val.EsNumero, TxtCostoUnitario, tileCostoUnitario, lblCostoUnitario);
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

        private void LimpiarEntradas()
        {
            TxtUnidadesP.Text = "";
            TxtUnidadesE.Text = "";
            TxtCostoUnitario.Text = "";
            BoxProducto.SelectedIndex = -1;
            val.CambiarColor(tileUnidadesP, lblUnidadesP, 'b');
            val.CambiarColor(tileUnidadesE, lblUnidadesE, 'b');
            val.CambiarColor(tileCostoUnitario, lblCostoUnitario, 'b');
            val.CambiarColor(tileProducto, lblProducto, 'b');
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

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModLote_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool v = true;
            for (int i = 0; i < EntradasVal.Length - 1; i++)
            {
                if (EntradasVal[i] == false)
                {
                    v = false;
                    break;
                }
            }
            if (e.KeyChar == 13 && v == true)
            {
                BtnMod_Click(sender, e);
            }
        }
    }
}

/*
CREATE TABLE LOTES
(
	IDLOTE BIGINT IDENTITY(140000000,1) NOT NULL PRIMARY KEY,
	IDPRODUCTO INT NOT NULL FOREIGN KEY REFERENCES PRODUCTOS(IDPRODUCTO),
	UNIDADES INT NOT NULL,
	COSTOPU FLOAT NOT NULL,
	ACTIVO BIT NOT NULL
)
*/

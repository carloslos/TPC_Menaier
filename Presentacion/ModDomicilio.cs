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
    public partial class ModDomicilio : Presentacion.Metro_Template
    {
        private bool[] EntradasVal = new bool[2];
        Domicilio d = null;
        Validaciones val = new Validaciones();

        public ModDomicilio(int IdRelacion)
        {
            InitializeComponent();
            this.Text = "Agregar " + this.Text;
            BtnMod.Text = "Agregar";
            BtnMod.Enabled = false;
            d = new Domicilio
            {
                IdRelacion = IdRelacion
            };
        }

        public ModDomicilio(int IdRelacion, Domicilio D)
        {
            InitializeComponent();
            this.Text = "Editar " + this.Text;
            BtnMod.Text = "Editar";
            BtnMod.Enabled = false;
            TxtCalle.Text = D.Calle;
            TxtAltura.Text = D.Altura.ToString();
            d = D;
            d.IdRelacion = IdRelacion;
        }

        private void ModDomicilio_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < EntradasVal.Length; i++)
            {
                EntradasVal[i] = false;
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMod_Click(object sender, EventArgs e)
        {
            DomicilioNegocio neg = new DomicilioNegocio();
            try
            {
                d.Calle = TxtCalle.Text.Trim();
                d.Altura = Convert.ToInt32(TxtAltura.Text.Trim());
                if (d.IdDomicilio != 0)
                {
                    neg.Modificar(d);
                    this.Close();
                }
                else
                {
                    neg.Agregar(d);
                    LimpiarEntradas();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void TxtCalle_TextChanged(object sender, EventArgs e)
        {
            TxtCalle.Text = TxtCalle.Text.TrimStart();
            ValidarTxt(0, val.EsAlfa, TxtCalle, tileCalle, lblCalle);
        }

        private void TxtAltura_TextChanged(object sender, EventArgs e)
        {
            TxtAltura.Text = TxtAltura.Text.TrimStart();
            ValidarTxt(1, val.EsNumeroEntero, TxtAltura, tileAltura, lblAltura);
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

        private void LimpiarEntradas()
        {
            val.CambiarColor(tileCalle, lblCalle, 'b');
            val.CambiarColor(tileAltura, lblAltura, 'b');
            TxtCalle.Text = "";
            TxtAltura.Text = "";
        }
    }
}

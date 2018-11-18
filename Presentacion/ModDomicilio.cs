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
    public partial class ModDomicilio : MetroFramework.Forms.MetroForm
    {
        private bool[] EntradasVal = new bool[7];
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

        public ModDomicilio(Domicilio D)
        {
            InitializeComponent();
            this.Text = "Editar " + this.Text;
            BtnMod.Text = "Editar";
            BtnMod.Enabled = false;
            TxtCalle.Text = D.Calle;
            TxtAltura.Text = D.Altura.ToString();
            TxtDepartamento.Text = D.Departamento;
            TxtBarrio.Text = D.Barrio;
            TxtCiudad.Text = D.Ciudad;
            TxtPais.Text = D.Pais;
            TxtCP.Text = D.Cp.ToString();
            d = D;
        }

        private void ModDomicilio_Load(object sender, EventArgs e)
        {
            bool b;
            if (d.IdDomicilio != 0) { b = true; }
            else { b = false; }
            for (int i = 0; i < EntradasVal.Length; i++)
            {
                EntradasVal[i] = b;
            }
            EntradasVal[2] = true;
            ValidarEntradas();
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
                d.Departamento = TxtDepartamento.Text.Trim();
                d.Barrio = TxtBarrio.Text.Trim();
                d.Ciudad = TxtCiudad.Text.Trim();
                d.Pais = TxtPais.Text.Trim();
                d.Cp = Convert.ToInt32(TxtCP.Text.Trim());
                if (d.IdDomicilio != 0)
                {
                    neg.Modificar(d);
                }
                else
                {
                    neg.Agregar(d);
                }
                this.Close();
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

        private void TxtDepartamento_TextChanged(object sender, EventArgs e)
        {
            TxtDepartamento.Text = TxtDepartamento.Text.TrimStart();
            if(TxtDepartamento.Text == "")
            {
                EntradasVal[2] = true;
                val.CambiarColor(tileDepartamento, lblDepartamento, 'g');
                ValidarEntradas();
            }
            else
            {
                ValidarTxt(2, val.EsAlfanum, TxtDepartamento, tileDepartamento, lblDepartamento);
            }
        }

        private void TxtBarrio_TextChanged(object sender, EventArgs e)
        {
            TxtBarrio.Text = TxtBarrio.Text.TrimStart();
            ValidarTxt(3, val.EsAlfa, TxtBarrio, tileBarrio, lblBarrio);
        }

        private void TxtCiudad_TextChanged(object sender, EventArgs e)
        {
            TxtCiudad.Text = TxtCiudad.Text.TrimStart();
            ValidarTxt(4, val.EsAlfa, TxtCiudad, tileCiudad, lblCiudad);
        }

        private void TxtPais_TextChanged(object sender, EventArgs e)
        {
            TxtPais.Text = TxtPais.Text.TrimStart();
            ValidarTxt(5, val.EsAlfa, TxtPais, tilePais, lblPais);
        }

        private void TxtCP_TextChanged(object sender, EventArgs e)
        {
            TxtCP.Text = TxtCP.Text.TrimStart();
            ValidarTxt(6, val.EsNumeroEntero, TxtCP, tileCP, lblCP);
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
            for (i = 0; i < EntradasVal.Length; i++)
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

        private void ModDomicilio_KeyPress(object sender, KeyPressEventArgs e)
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

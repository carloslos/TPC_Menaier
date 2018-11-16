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
    public partial class ModProveedor : MetroFramework.Forms.MetroForm
    {
        private bool[] EntradasVal = new bool[2];
        Validaciones val = new Validaciones();
        Proveedor p;

        public ModProveedor()
        {
            InitializeComponent();
            this.Text = "Agregar " + this.Text;
            BtnMod.Text = "Agregar";
            BtnMod.Enabled = false;
            p = new Proveedor();
        }

        public ModProveedor(Proveedor P)
        {
            InitializeComponent();
            this.Text = "Editar " + this.Text;
            BtnMod.Text = "Editar";
            BtnMod.Enabled = true;
            TxtEmpresa.Text = P.Empresa;
            TxtCuit.Text = P.Cuit.ToString();
            p = P;
        }

        private void ModProveedor_Load(object sender, EventArgs e)
        {
            bool b;
            if (p.IdProveedor != 0) { b = true; }
            else { b = false; }
            for (int i = 0; i < EntradasVal.Length; i++)
            {
                EntradasVal[i] = b;
            }
        }
    
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMod_Click(object sender, EventArgs e)
        {
            ProveedorNegocio neg = new ProveedorNegocio();
            try
            {
                p.Empresa = TxtEmpresa.Text.Trim();
                p.Cuit = Convert.ToInt64(TxtCuit.Text.Trim());
                if (p.IdProveedor != 0)
                {
                    neg.Modificar(p);
                }
                else
                {
                    neg.Agregar(p);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        private void TxtEmpresa_TextChanged(object sender, EventArgs e)
        {
            TxtEmpresa.Text = TxtEmpresa.Text.TrimStart();
            ValidarTxt(0, val.EsAlfa, TxtEmpresa, tileEmpresa, lblEmpresa);
        }

        private void TxtCuit_TextChanged(object sender, EventArgs e)
        {
            TxtCuit.Text = TxtCuit.Text.TrimStart();
            ValidarTxt(1, val.EsCuit, TxtCuit, tileCuit, lblCuit);
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

        private void LimpiarEntradas()
        {
            val.CambiarColor(tileEmpresa, lblEmpresa, 'b');
            val.CambiarColor(tileCuit, lblCuit, 'b');
            TxtEmpresa.Text = "";
            TxtCuit.Text = "";
        }

        private void ValidarEntradas()
        {
            if (EntradasVal[0] == true && EntradasVal[1] == true) { BtnMod.Enabled = true; }
            else { BtnMod.Enabled = false; }
        }

        private void ModProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && EntradasVal[0] == true && EntradasVal[1] == true)
            {
                BtnMod_Click(sender, e);
            }
        }
    }
}


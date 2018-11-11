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
    public partial class ModClienteE : MetroFramework.Forms.MetroForm
    {
        private bool[] EntradasVal = new bool[2];
        Validaciones val = new Validaciones();
        ClienteE c = null;

        public ModClienteE()
        {
            InitializeComponent();
            this.Text = "Agregar " + this.Text;
            BtnMod.Text = "Agregar";
            BtnMod.Enabled = false;
            c = new ClienteE();
        }

        public ModClienteE(ClienteE C)
        {
            InitializeComponent();
            this.Text = "Editar " + this.Text;
            BtnMod.Text = "Editar";
            BtnMod.Enabled = false;
            TxtEmpresa.Text = c.Nombre;
            TxtCuit.Text = c.Cuit.ToString();
            c = C;
        }

        private void ModClienteE_Load(object sender, EventArgs e)
        {
            bool b;
            if (c.IdCliente != 0) { b = true; }
            else { b = false; }
            for (int i = 0; i < EntradasVal.Length; i++)
            {
                EntradasVal[i] = b;
            }
            ValidarEntradas();
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

        private void BtnMod_Click(object sender, EventArgs e)
        {
            ClienteENegocio neg = new ClienteENegocio();
            try
            {
                c.Nombre = TxtEmpresa.Text.Trim();
                c.Cuit = Convert.ToInt32(TxtCuit.Text.Trim());
                if (c.IdCliente != 0)
                {
                    neg.Modificar(c);
                }
                else
                {
                    neg.Agregar(c);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                throw (ex);
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

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

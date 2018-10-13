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
    public partial class ModCliente : Presentacion.Metro_Template
    {
        private bool[] EntradasVal = new bool[2];
        Validaciones val = new Validaciones();

        public ModCliente()
        {
            InitializeComponent();
            this.Text = "Agregar " + this.Text;
            BtnMod.Text = "Agregar";
            BtnMod.Enabled = false;
        }

        public ModCliente(Cliente c)
        {
            InitializeComponent();
            this.Text = "Editar " + this.Text;
            BtnMod.Text = "Editar";
            BtnMod.Enabled = false;
            //TxtEmpresa.Text = p.Empresa;
            //TxtCuit.Text = p.Cuit.ToString();
        }

        private void ModCliente_Load(object sender, EventArgs e)
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
        /*    ClienteNegocio neg = new ClienteNegocio();
            Cliente tp = new Cliente
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
            }*/
        }

        /*private void TxtEmpresa_TextChanged(object sender, EventArgs e)
        {
            TxtEmpresa.Text = TxtEmpresa.Text.TrimStart();
            ValidarEntrada(0, val.EsAlfanumerico, TxtEmpresa, tileEmpresa, lblEmpresa);
        }

        private void TxtCuit_TextChanged(object sender, EventArgs e)
        {
            TxtCuit.Text = TxtCuit.Text.TrimStart();
            ValidarEntrada(1, val.EsNumeroEntero, TxtCuit, tileCuit, lblCuit);
        }*/

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
            //val.CambiarColor(tileEmpresa, lblEmpresa, 'b');
            //val.CambiarColor(tileCuit, lblCuit, 'b');
        }

        private void ValidarEntradas()
        {
            if (EntradasVal[0] == true && EntradasVal[1] == true) { BtnMod.Enabled = true; }
            else { BtnMod.Enabled = false; }
        }
    }
}

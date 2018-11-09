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
    public partial class ModClienteE : Presentacion.Metro_Template
    {
        private bool[] EntradasVal = new bool[2];
        Validaciones val = new Validaciones();

        public ModClienteE()
        {
            InitializeComponent();
            this.Text = "Agregar " + this.Text;
            BtnMod.Text = "Agregar";
            BtnMod.Enabled = false;
        }

        public ModClienteE(ClienteE c)
        {
            InitializeComponent();
            this.Text = "Editar " + this.Text;
            BtnMod.Text = "Editar";
            BtnMod.Enabled = false;
            TxtEmpresa.Text = c.Empresa;
            TxtCuit.Text = c.Cuit.ToString();
        }
    }
}

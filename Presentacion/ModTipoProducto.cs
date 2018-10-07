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
    public partial class ModTipoProducto : Presentacion.Metro_Template
    {
        public ModTipoProducto(string title)
        {
            InitializeComponent();
            this.Text = title + " " + this.Text;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            TiposProductoNegocio neg = new TiposProductoNegocio();
            TipoProducto tp = new TipoProducto
            {
                Descripcion = txtDescripcion.Text.Trim() // VALIDAR
            };
            try
            {
                neg.Agregar(tp);
                txtDescripcion.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

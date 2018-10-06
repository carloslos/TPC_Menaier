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
            this.Text = title + this.Text;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            TipoProductoNegocio neg = new TipoProductoNegocio();
            TipoProducto tp = new TipoProducto();
            tp.descripcion = txtDescripcion.Text.Trim(); // VALIDAR
            try
            {
                neg.agregar(tp);
                txtDescripcion.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

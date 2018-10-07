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
    public partial class ModMarca : Presentacion.Metro_Template
    {
        public ModMarca(string title)
        {  
            InitializeComponent();
            this.Text = title + " " + this.Text;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            MarcasNegocio neg = new MarcasNegocio();
            Marca m = new Marca
            {
                Descripcion = txtDescripcion.Text.Trim() // VALIDAR
            };
            try
            {
                neg.Agregar(m);
                txtDescripcion.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

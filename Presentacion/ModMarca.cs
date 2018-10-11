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
        private bool val = false;

        public ModMarca(string title)
        {  
            InitializeComponent();
            this.Text = title + " " + this.Text;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ValidarEntradas();
            if (val == true)
            {
                MarcasNegocio neg = new MarcasNegocio();
                Marca m = new Marca
                {
                    Descripcion = TxtDescripcion.Text.Trim()
                };
                try
                {
                    neg.Agregar(m);
                    TxtDescripcion.Text = "";
                    tileDescripcion.Style = MetroFramework.MetroColorStyle.Blue;
                    lblDescripcion.Style = MetroFramework.MetroColorStyle.Blue;
                    tileDescripcion.Refresh();
                    lblDescripcion.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (TxtDescripcion.Text.Trim() != "") { val = true; }
            else { val = false; }
            tileDescripcion.Style = MetroFramework.MetroColorStyle.Blue;
            lblDescripcion.Style = MetroFramework.MetroColorStyle.Blue;
            tileDescripcion.Refresh();
            lblDescripcion.Refresh();
        }

        private void ValidarEntradas()
        {
            if (val == true)
            {
                tileDescripcion.Style = MetroFramework.MetroColorStyle.Green;
                lblDescripcion.Style = MetroFramework.MetroColorStyle.Green;
                tileDescripcion.Refresh();
                lblDescripcion.Refresh();
            }
            else
            {
                tileDescripcion.Style = MetroFramework.MetroColorStyle.Red;
                lblDescripcion.Style = MetroFramework.MetroColorStyle.Red;
                tileDescripcion.Refresh();
                lblDescripcion.Refresh();
            }
        }
    }
}

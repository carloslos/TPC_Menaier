using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Contactos : Presentacion.Metro_Template
    {
        public Contactos()
        {
            InitializeComponent();
        }

        private void BtnDetalles_Click(object sender, EventArgs e)
        {

        }

        private void Contactos_Load(object sender, EventArgs e)
        {

        }

        private void LlenarTabla()
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            {
                foreach (Form item in Application.OpenForms)
                {
                    if (item.GetType() == typeof(ModContacto))
                    {
                        item.Focus();
                        return;
                    }
                }
                try
                {
                    ModContacto mod = new ModContacto("Agregar");
                    mod.Show();
                    LlenarTabla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}

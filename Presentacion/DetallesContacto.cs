using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class DetallesContacto : Presentacion.Metro_Template
    {
        public DetallesContacto(string text)
        {
            this.Text = text;
            InitializeComponent();
        }

        private void DgvDirecciones_Click(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvTelefonos_Click(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

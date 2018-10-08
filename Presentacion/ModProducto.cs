using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class ModProducto : Presentacion.Metro_Template
    {
        public ModProducto(string title)
        {
            InitializeComponent();
            this.Text = title + " " + this.Text;
        }

        private void ModProducto_Load(object sender, EventArgs e)
        {

        }

        private void ModProducto_MouseEnter(object sender, EventArgs e)
        {
            this.Activate();
        }
    }
}

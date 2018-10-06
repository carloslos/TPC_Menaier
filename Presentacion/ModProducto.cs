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
            this.Text = title;
            InitializeComponent();
        }
    }
}

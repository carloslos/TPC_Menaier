using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class ModProveedor : Presentacion.Metro_Template
    {
        public ModProveedor(string title)
        {
            InitializeComponent();
            this.Text = title + " " + this.Text;
        }
    }
}

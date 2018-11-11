using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Confirmacion : MetroFramework.Forms.MetroForm
    {
        public bool R { get; set; }

        public Confirmacion(string s)
        {
            InitializeComponent();
            R = false;
            tileTxt.Text += s;
        }

        private void BtnSi_Click(object sender, EventArgs e)
        {
            R = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            R = false;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

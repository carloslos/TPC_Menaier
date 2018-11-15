using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Mensaje : MetroFramework.Forms.MetroForm
    {
        public Mensaje(string s)
        {
            InitializeComponent();
            tileTxt.Text = s;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

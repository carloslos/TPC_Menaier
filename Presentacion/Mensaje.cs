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
        private string s;

        public Mensaje(string S)
        {
            InitializeComponent();
            s = S;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mensaje_Load(object sender, EventArgs e)
        {
            
            tileTxt.Text = s;
        }
    }
}

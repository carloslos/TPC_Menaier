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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            MenuPrincipal wndVentanaPrincipal = new MenuPrincipal(); // VALIDAR
            wndVentanaPrincipal.Show(); // HACER LOG OUT
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Presentacion
{
    public partial class Clientes : MetroFramework.Forms.MetroForm
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            try
            {
                LlenarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LlenarTabla()
        {
            ClientePNegocio neg = new ClientePNegocio();
            try
            {
                //dgvClientes.DataSource = neg.Listar();
                //dgvClientes.Columns[""].HeaderText = "";                 // DESARROLLAR NEGOCIO
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DgvClientesP_Click(object sender, DataGridViewCellEventArgs e)
        {
            BtnVer.Text = "Ver Detalles";
        }

        private void DgvClientesE_Click(object sender, DataGridViewCellEventArgs e)
        {
            BtnVer.Text = "Ver Contactos";
        }

        private void BtnMod_Click(object sender, EventArgs e)
        {

        }
    }
}

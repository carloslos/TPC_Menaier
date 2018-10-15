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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            {
                foreach (Form item in Application.OpenForms)
                {
                    if (item.GetType() == typeof(ModClienteP))
                    {
                        item.Focus();
                        return;
                    }
                }
                try
                {
                    ModClienteP mod = new ModClienteP();
                    mod.Show();
                    LlenarTabla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
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

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            {
                foreach (Form item in Application.OpenForms)
                {
                    if (item.GetType() == typeof(ModClienteP))
                    {
                        item.Focus();
                        return;
                    }
                }
                try
                {
                    ClienteP obj = (ClienteP)dgvClientesP.CurrentRow.DataBoundItem;
                    ModClienteP mod = new ModClienteP(obj);
                    mod.Show();
                    LlenarTabla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
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
    }
}

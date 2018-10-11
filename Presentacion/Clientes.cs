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
            ClienteNegocio neg = new ClienteNegocio();
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
                    if (item.GetType() == typeof(ModCliente))
                    {
                        item.Focus();
                        return;
                    }
                }
                try
                {
                    ModCliente mod = new ModCliente("Agregar");
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
                    if (item.GetType() == typeof(ModCliente))
                    {
                        item.Focus();
                        return;
                    }
                }
                try
                {
                    ModCliente mod = new ModCliente("Editar");
                    mod.Show();
                    LlenarTabla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void Clientes_MouseEnter(object sender, EventArgs e)
        {
            this.Activate();
        }
    }
}

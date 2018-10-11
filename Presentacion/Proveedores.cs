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
    public partial class Proveedores : MetroFramework.Forms.MetroForm
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
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
            ProveedorNegocio neg = new ProveedorNegocio();
            try
            {
                dgvProveedores.DataSource = neg.Listar();
                dgvProveedores.Columns["IdProveedor"].HeaderText = "ID";
                dgvProveedores.Columns["Cuit"].HeaderText = "CUIT";
                dgvProveedores.Columns["Activo"].Visible = false;
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
                    if (item.GetType() == typeof(Proveedores))
                    {
                        item.Focus();
                        return;
                    }
                }
                try
                {
                    ModProveedor mod = new ModProveedor("Agregar");
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
                    if (item.GetType() == typeof(Proveedores))
                    {
                        item.Focus();
                        return;
                    }
                }
                try
                {
                    ModProveedor mod = new ModProveedor("Editar");
                    mod.Show();
                    LlenarTabla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void Proveedores_MouseEnter(object sender, EventArgs e)
        {
            this.Activate();
        }
    }
}

/*
CREATE TABLE PROVEEDORES
(
	IDPROVEEDOR INT NOT NULL IDENTITY(20000000,1) PRIMARY KEY,
	EMPRESA VARCHAR(60) NOT NULL,
	CUIT BIGINT NOT NULL,
	ACTIVO BIT NOT NULL
)
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// TODO: MENU PRINCIPAL (EMBELLECER)
/// </summary>
namespace Presentacion
{
    public partial class MenuPrincipal : MetroFramework.Forms.MetroForm
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            {
                foreach (Form item in Application.OpenForms)
                {
                    if (item.GetType() == typeof(Empleados))
                    {
                        item.Focus();
                        return;
                    }
                }
                Empleados wndEmpleados = new Empleados();
                wndEmpleados.Show();
            }
        }

        private void BtnMarcas_Click(object sender, EventArgs e)
        {
            {
                foreach (Form item in Application.OpenForms)
                {
                    if (item.GetType() == typeof(Marcas))
                    {
                        item.Focus();
                        return;
                    }
                }
                Marcas wndMarcas = new Marcas();
                wndMarcas.Show();
            }
        }

        private void BtnTiposProducto_Click(object sender, EventArgs e)
        {
            {
                foreach (Form item in Application.OpenForms)
                {
                    if (item.GetType() == typeof(TiposProducto))
                    {
                        item.Focus();
                        return;
                    }
                }
                TiposProducto wndTiposProducto = new TiposProducto();
                wndTiposProducto.Show();
            }
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            {
                foreach (Form item in Application.OpenForms)
                {
                    if (item.GetType() == typeof(Clientes))
                    {
                        item.Focus();
                        return;
                    }
                }
                Clientes wndClientes = new Clientes();
                wndClientes.Show();
            }
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
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
                Proveedores wndProveedores = new Proveedores();
                wndProveedores.Show();
            }
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            {
                foreach (Form item in Application.OpenForms)
                {
                    if (item.GetType() == typeof(Ventas))
                    {
                        item.Focus();
                        return;
                    }
                }
                Ventas wndVentas = new Ventas();
                wndVentas.Show();
            }
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            {
                foreach (Form item in Application.OpenForms)
                {
                    if (item.GetType() == typeof(Compras))
                    {
                        item.Focus();
                        return;
                    }
                }
                Compras wndCompras = new Compras();
                wndCompras.Show();
            }
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            {
                foreach (Form item in Application.OpenForms)
                {
                    if (item.GetType() == typeof(Productos))
                    {
                        item.Focus();
                        return;
                    }
                }
                Productos wndProductos = new Productos();
                wndProductos.Show();
            }
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

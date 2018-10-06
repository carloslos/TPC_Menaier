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
    public partial class MenuPrincipal : MetroFramework.Forms.MetroForm
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
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

        private void btnMarcas_Click(object sender, EventArgs e)
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

        private void btnTiposProducto_Click(object sender, EventArgs e)
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

        private void btnClientes_Click(object sender, EventArgs e)
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

        private void btnProveedores_Click(object sender, EventArgs e)
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

        private void btnVentas_Click(object sender, EventArgs e)
        {

        }

        private void btnCompras_Click(object sender, EventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
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

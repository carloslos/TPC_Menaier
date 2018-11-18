using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Presentacion
{
    public partial class MenuPrincipal : MetroFramework.Forms.MetroForm
    {
        private Empleado empleadoLoggeado = new Empleado();

        public Empleado EmpleadoLoggeado
        {
            get { return empleadoLoggeado; }
        }

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.Hide();
            empleadoLoggeado = new Empleado();
            Login login = new Login(empleadoLoggeado);
            login.ShowDialog();
            this.Show();
            this.FocusMe();
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Empleados))
                {
                    item.Focus();
                    return;
                }
            }
            Empleados wndEmpleados = new Empleados(empleadoLoggeado.TipoPerfil.IdTipoPerfil, this);
            wndEmpleados.Show();
        }

        private void BtnMarcas_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Marcas))
                {
                    item.Focus();
                    return;
                }
            }
            Marcas wndMarcas = new Marcas(empleadoLoggeado.TipoPerfil.IdTipoPerfil, this);
            wndMarcas.Show();
        }

        private void BtnTiposProducto_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(TiposProducto))
                {
                    item.Focus();
                    return;
                }
            }
            TiposProducto wndTiposProducto = new TiposProducto(empleadoLoggeado.TipoPerfil.IdTipoPerfil, this);
            wndTiposProducto.Show();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Clientes))
                {
                    item.Focus();
                    return;
                }
            }
            Clientes wndClientes = new Clientes(empleadoLoggeado.TipoPerfil.IdTipoPerfil, this);
            wndClientes.Show();
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Proveedores))
                {
                    item.Focus();
                    return;
                }
            }
            Proveedores wndProveedores = new Proveedores(empleadoLoggeado.TipoPerfil.IdTipoPerfil, this);
            wndProveedores.Show();
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Ventas))
                {
                    item.Focus();
                    return;
                }
            }
            Ventas wndVentas = new Ventas(empleadoLoggeado.TipoPerfil.IdTipoPerfil, this);
            wndVentas.Show();
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Compras))
                {
                    item.Focus();
                    return;
                }
            }
            Compras wndCompras = new Compras(empleadoLoggeado.TipoPerfil.IdTipoPerfil, this);
            wndCompras.Show();
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Productos))
                {
                    item.Focus();
                    return;
                }
            }
            Productos wndProductos = new Productos(empleadoLoggeado.TipoPerfil.IdTipoPerfil, this);
            wndProductos.Show();
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            MenuPrincipal_Load(sender, e);
        }
    }
}

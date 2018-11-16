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
                Mensaje m = new Mensaje(ex.ToString()); m.ShowDialog();
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
                dgvProveedores.Update();
                dgvProveedores.Refresh();
            }
            catch (Exception ex)
            {
                Mensaje m = new Mensaje(ex.ToString()); m.ShowDialog();
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ModProveedor))
                {
                    item.Focus();
                    return;
                }
            }
            try
            {
                ModProveedor mod = new ModProveedor();
                mod.ShowDialog();
                LlenarTabla();
            }
            catch (Exception ex)
            {
                Mensaje m = new Mensaje(ex.ToString()); m.ShowDialog();
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

            if (dgvProveedores.SelectedCells.Count > 0)
            {
                foreach (Form item in Application.OpenForms)
                {
                    if (item.GetType() == typeof(ModProveedor))
                    {
                        item.Focus();
                        return;
                    }
                }
                try
                {
                    Proveedor obj = (Proveedor)dgvProveedores.CurrentRow.DataBoundItem;
                    ModProveedor mod = new ModProveedor(obj);
                    mod.ShowDialog();
                    LlenarTabla();
                }
                catch (Exception ex)
                {
                    Mensaje m = new Mensaje(ex.ToString()); m.ShowDialog();
                }
            }
            else
            {
                Mensaje m = new Mensaje("Ningun item seleccion.");
                m.ShowDialog();
            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedCells.Count > 0)
            {
                ProveedorNegocio neg = new ProveedorNegocio();
                Proveedor p = (Proveedor)dgvProveedores.CurrentRow.DataBoundItem;
                try
                {
                    using (var popup = new Confirmacion(@"eliminar """ + p.ToString() + @""""))
                    {
                        var R = popup.ShowDialog();
                        if (R == DialogResult.OK)
                        {
                            bool conf = popup.R;
                            if (p != null && conf == true)
                            {
                                neg.EliminarLogico(p.IdProveedor);
                                LlenarTabla();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Mensaje m = new Mensaje(ex.ToString()); m.ShowDialog();
                }
            }
            else
            {
                Mensaje m = new Mensaje("Ningun item seleccion.");
                m.ShowDialog();
            }

        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedCells.Count > 0)
            {
                foreach (Form item in Application.OpenForms)
                {
                    if (item.GetType() == typeof(ProductosProv))
                    {
                        item.Focus();
                        return;
                    }
                }
                try
                {
                    Proveedor p = new Proveedor();
                    p = (Proveedor)dgvProveedores.CurrentRow.DataBoundItem;
                    ProductosProv pp = new ProductosProv(p.ToString(), p.GetId());
                    pp.Show();
                    LlenarTabla();
                }
                catch (Exception ex)
                {
                    Mensaje m = new Mensaje(ex.ToString()); m.ShowDialog();
                }
            }
            else
            {
                Mensaje m = new Mensaje("Ningun item seleccion.");
                m.ShowDialog();
            }

        }

        private void BtnContactos_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedCells.Count > 0)
            {
                foreach (Form item in Application.OpenForms)
                {
                    if (item.GetType() == typeof(Contactos))
                    {
                        item.Focus();
                        return;
                    }
                }
                try
                {
                    Proveedor p = new Proveedor();
                    p = (Proveedor)dgvProveedores.CurrentRow.DataBoundItem;
                    Contactos c = new Contactos(p.GetId());
                    c.Show();
                    LlenarTabla();
                }
                catch (Exception ex)
                {
                    Mensaje m = new Mensaje(ex.ToString()); m.ShowDialog();
                }
            }
            else
            {
                Mensaje m = new Mensaje("Ningun item seleccion.");
                m.ShowDialog();
            }

        }

        private void DgvProveedores_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Contactos))
                {
                    item.Focus();
                    return;
                }
            }
            try
            {
                Proveedor p = new Proveedor();
                p = (Proveedor)dgvProveedores.CurrentRow.DataBoundItem;
                Contactos c = new Contactos(p.GetId());
                c.Show();
                LlenarTabla();
            }
            catch (Exception ex)
            {
                Mensaje m = new Mensaje(ex.ToString()); m.ShowDialog();
            }
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
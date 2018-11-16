using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Presentacion
{
    public partial class Productos : MetroFramework.Forms.MetroForm
    {
        int permisos;
        public Productos(int p)
        {
            InitializeComponent();
            permisos = p;
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            LlenarTabla();
            if(permisos == 2)
            {
                BtnEditar.Enabled = false;
                BtnEliminar.Enabled = false;
            }
            if(permisos == 3)
            {
                BtnEditar.Enabled = false;
                BtnEliminar.Enabled = false;
                BtnAgregar.Enabled = false;
            }
        }

        private void LlenarTabla()
        {
            ProductoNegocio neg = new ProductoNegocio();
            try
            {
                dgvProductos.DataSource = neg.Listar(0);
                dgvProductos.Columns["IdProducto"].HeaderText = "ID";
                dgvProductos.Columns["Descripcion"].HeaderText = "Descripción";
                dgvProductos.Columns["TipoProducto"].HeaderText = "Tipo de producto";
                dgvProductos.Columns["StockMin"].HeaderText = "Stock Minimo";
                dgvProductos.Columns["Ganancia"].HeaderText = "Ganancia (%)";
                dgvProductos.Columns["Activo"].Visible = false;
                dgvProductos.Update();
                dgvProductos.Refresh();
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
                if (item.GetType() == typeof(ModProducto))
                {
                    item.Focus();
                    return;
                }
            }
            try
            {
                ModProducto mod = new ModProducto();
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
            if (dgvProductos.SelectedCells.Count > 0)
            {
                foreach (Form item in Application.OpenForms)
                {
                    if (item.GetType() == typeof(ModProducto))
                    {
                        item.Focus();
                        return;
                    }
                }
                try
                {
                    Producto obj = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                    ModProducto mod = new ModProducto(obj);
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
                Mensaje m = new Mensaje("Ningun item seleccionado.");
                m.ShowDialog();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedCells.Count > 0)
            {
                ProductoNegocio neg = new ProductoNegocio();
                Producto p = (Producto)dgvProductos.CurrentRow.DataBoundItem;
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
                                neg.EliminarLogico(p.IdProducto);
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
                Mensaje m = new Mensaje("Ningun item seleccionado.");
                m.ShowDialog();
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

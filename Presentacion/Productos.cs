﻿using System;
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
    public partial class Productos : Presentacion.Metro_Template
    {
        private int Id = 0;

        public Productos()
        {
            InitializeComponent();
        }

        public Productos(int IdP)
        {
            Id = IdP;
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(Id.ToString());
                LlenarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LlenarTabla()
        {
            ProductoNegocio neg = new ProductoNegocio();
            try
            {
                dgvProductos.DataSource = neg.Listar(Id);
                dgvProductos.Columns["IdProducto"].HeaderText = "ID";
                dgvProductos.Columns["Descripcion"].HeaderText = "Descripción";
                dgvProductos.Columns["TipoProducto"].HeaderText = "Tipo de producto";
                dgvProductos.Columns["StockMin"].HeaderText = "Stock Minimo";
                dgvProductos.Columns["Activo"].Visible = false;
                dgvProductos.Update();
                dgvProductos.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
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
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
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
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}

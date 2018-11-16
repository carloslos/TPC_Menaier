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
    public partial class Ventas : MetroFramework.Forms.MetroForm
    {
        int permisos;
        public Ventas(int p)
        {
            InitializeComponent();
            permisos = p;
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            LlenarTabla();
            if (permisos == 2)
            {
                //BtnEliminar.Enabled = false;
            }
            if (permisos == 3)
            {
                BtnEditar.Enabled = false;
                //BtnEliminar.Enabled = false;
            }
        }

        private void LlenarTabla()
        {
            VentaNegocio neg = new VentaNegocio();
            try
            {
                dgvVentas.DataSource = neg.Listar();
                dgvVentas.Columns["IdVenta"].HeaderText = "ID";
                dgvVentas.Columns["FechaVenta"].HeaderText = "Fecha de Venta";
                dgvVentas.Columns["FechaRegistro"].Visible = false;
                dgvVentas.Columns["Activo"].Visible = false;
                dgvVentas.Update();
                dgvVentas.Refresh();
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
                if (item.GetType() == typeof(ModVenta))
                {
                    item.Focus();
                    return;
                }
            }
            try
            {
                ModVenta mod = new ModVenta();
                mod.Show();
                LlenarTabla();
            }
            catch (Exception ex)
            {
                Mensaje m = new Mensaje(ex.ToString()); m.ShowDialog();
            }
        }

        private void BtnDetalles_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedCells.Count > 0)
            {
                foreach (Form item in Application.OpenForms)
                {
                    if (item.GetType() == typeof(ModVenta))
                    {
                        item.Focus();
                        return;
                    }
                }
                try
                {
                    ProductoVendidoNegocio negPV = new ProductoVendidoNegocio();
                    Venta v = (Venta)dgvVentas.CurrentRow.DataBoundItem;
                    v.LstProductosVendidos = negPV.Listar(v.IdVenta);
                    ModVenta detalles = new ModVenta(v, false);
                    detalles.Show();
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

        private void DgvCompras_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ModVenta))
                {
                    item.Focus();
                    return;
                }
            }
            try
            {
                ModVenta detalles = new ModVenta((Venta)dgvVentas.CurrentRow.DataBoundItem, false);
                detalles.Show();
                LlenarTabla();
            }
            catch (Exception ex)
            {
                Mensaje m = new Mensaje(ex.ToString()); m.ShowDialog();
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedCells.Count>0)
            {
                foreach (Form item in Application.OpenForms)
                {
                    if (item.GetType() == typeof(ModVenta))
                    {
                        item.Focus();
                        return;
                    }
                }
                try
                {
                    ProductoVendidoNegocio negPV = new ProductoVendidoNegocio();
                    Venta v = (Venta)dgvVentas.CurrentRow.DataBoundItem;
                    v.LstProductosVendidos = negPV.Listar(v.IdVenta);
                    ModVenta detalles = new ModVenta(v, true);
                    detalles.Show();
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

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedCells.Count > 0)
            {
                VentaNegocio negV = new VentaNegocio();
                ProductoVendidoNegocio negPV = new ProductoVendidoNegocio();
                Venta v = (Venta)dgvVentas.CurrentRow.DataBoundItem;
                try
                {
                    using (var popup = new Confirmacion(@"eliminar """ + v.ToString() + @""""))
                    {
                        var R = popup.ShowDialog();
                        if (R == DialogResult.OK)
                        {
                            bool conf = popup.R;
                            if (v != null && conf == true)
                            {
                                negPV.EliminarPxV(v.IdVenta);
                                negV.EliminarLogico(v.IdVenta);
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
    }
}
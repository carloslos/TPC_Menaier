﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class Compras : MetroFramework.Forms.MetroForm
    {
        int permisos;
        public Compras(int p)
        {
            InitializeComponent();
            permisos = p;
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            LlenarTabla();
            if (permisos == 2)
            {
                BtnEliminar.Enabled = false;
            }
            if (permisos == 3)
            {
                BtnEditar.Enabled = false;
                BtnEliminar.Enabled = false;
                BtnAgregar.Enabled = false;
            }
        }

        private void LlenarTabla()
        {
            CompraNegocio neg = new CompraNegocio();
            try
            {
                dgvCompras.DataSource = neg.Listar();
                dgvCompras.Columns["IdCompra"].HeaderText = "ID";
                dgvCompras.Columns["FechaCompra"].HeaderText = "Fecha de Compra";
                dgvCompras.Columns["FechaRegistro"].Visible = false;
                dgvCompras.Columns["Activo"].Visible = false;
                dgvCompras.Update();
                dgvCompras.Refresh();
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
                if (item.GetType() == typeof(ModCompra))
                {
                    item.Focus();
                    return;
                }
            }
            try
            {
                ModCompra mod = new ModCompra();
                mod.ShowDialog();
                LlenarTabla();
            }
            catch (Exception ex)
            {
                Mensaje m = new Mensaje(ex.ToString()); m.ShowDialog();
            }
        }

        private void BtnDetalles_Click(object sender, EventArgs e)
        {
            if (dgvCompras.SelectedCells.Count > 0)
            {
                foreach (Form item in Application.OpenForms)
                {
                    if (item.GetType() == typeof(ModCompra))
                    {
                        item.Focus();
                        return;
                    }
                }
                try
                {
                    LoteNegocio negL = new LoteNegocio();
                    Compra c = (Compra)dgvCompras.CurrentRow.DataBoundItem;
                    c.LstLotes = negL.Listar(c.IdCompra);
                    ModCompra detalles = new ModCompra(c, false);
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
                Mensaje m = new Mensaje("Ningun item seleccionado.");
                m.ShowDialog();
            }

        }

        private void DgvCompras_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ModCompra))
                {
                    item.Focus();
                    return;
                }
            }
            try
            {
                ModCompra detalles = new ModCompra((Compra)dgvCompras.CurrentRow.DataBoundItem, false);
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
            if (dgvCompras.SelectedCells.Count > 0)
            {
                foreach (Form item in Application.OpenForms)
                {
                    if (item.GetType() == typeof(ModCompra))
                    {
                        item.Focus();
                        return;
                    }
                }
                try
                {
                    LoteNegocio negL = new LoteNegocio();
                    Compra c = (Compra)dgvCompras.CurrentRow.DataBoundItem;
                    c.LstLotes = negL.Listar(c.IdCompra);
                    ModCompra detalles = new ModCompra(c, true);
                    detalles.ShowDialog();
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
            if (dgvCompras.SelectedCells.Count > 0)
            {
                CompraNegocio negC = new CompraNegocio();
                LoteNegocio negL = new LoteNegocio();
                Compra c = (Compra)dgvCompras.CurrentRow.DataBoundItem;
                try
                {
                    using (var popup = new Confirmacion(@"eliminar """ + c.ToString() + @""""))
                    {
                        var R = popup.ShowDialog();
                        if (R == DialogResult.OK)
                        {
                            bool conf = popup.R;
                            if (c != null && conf == true)
                            {
                                negL.EliminarLotesDeCompra(c.IdCompra);
                                negC.EliminarLogico(c.IdCompra);
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

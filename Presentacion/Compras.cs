using System;
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
    public partial class Compras : Presentacion.Metro_Template
    {
        public Compras()
        {
            InitializeComponent();
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            LlenarTabla();
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
                MessageBox.Show(ex.ToString());
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
                mod.Show();
                LlenarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnDetalles_Click(object sender, EventArgs e)
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
                ModCompra detalles = new ModCompra(c);
                detalles.Show();
                LlenarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                ModCompra detalles = new ModCompra((Compra)dgvCompras.CurrentRow.DataBoundItem);
                detalles.Show();
                LlenarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

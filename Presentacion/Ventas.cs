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
    public partial class Ventas : MetroFramework.Forms.MetroForm
    {
        MenuPrincipal menu;
        int permisos, activo = 1;

        public Ventas(int p, MenuPrincipal mp)
        {
            InitializeComponent();
            menu = mp;
            permisos = p;
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            LlenarTabla();
            if (permisos == 2)
            {
                BtnAnular.Enabled = false;
            }
            if (permisos == 3)
            {
                BtnAnular.Enabled = false;
                BtnAnular.Enabled = false;
            }
        }

        private void LlenarTabla()
        {
            VentaNegocio neg = new VentaNegocio();
            try
            {
                dgvVentas.DataSource = neg.Listar(activo, TxtBuscar.Text);
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
                    v.LstProductosVendidos = negPV.Listar(v.IdVenta,activo);
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
                Mensaje m = new Mensaje("Ningun item seleccionado.");
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

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Focus();
        }

        private void TglActivo_CheckedChanged(object sender, EventArgs e)
        {
            if( activo == 1 ) { activo = 0; }
            else { activo = 1; }
            LlenarTabla();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
             LlenarTabla();
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
                {
                   e.Handled = true;
                }
        }

        private void BtnPDF_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedCells.Count > 0)
            {
                try
                {
                    ProductoVendidoNegocio NegPV = new ProductoVendidoNegocio();
                    Venta v = (Venta)dgvVentas.CurrentRow.DataBoundItem;
                    v.LstProductosVendidos = NegPV.Listar(v.IdVenta, 1);
                    Invoicer i = new Invoicer();
                    i.Go(v);
                    Mensaje m = new Mensaje("PDF Generado.");
                    m.ShowDialog();
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

        private void BtnAnular_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedCells.Count > 0)
            {
                VentaNegocio negV = new VentaNegocio();
                ProductoVendidoNegocio negPV = new ProductoVendidoNegocio();
                Venta v = (Venta)dgvVentas.CurrentRow.DataBoundItem;
                try
                {
                    using (var popup = new Confirmacion(@"anular la venta """ + v.ToString() + @""""))
                    {
                        var R = popup.ShowDialog(); 
                        if (R == DialogResult.OK)
                        {
                            bool conf = popup.R;
                            if (v != null && conf == true)
                            {
                                negV.AnularVenta(v);
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
    }
}
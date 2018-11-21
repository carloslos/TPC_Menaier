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
    public partial class Compras : MetroFramework.Forms.MetroForm
    {
        int permisos;
        MenuPrincipal menu;
        public Compras(int p, MenuPrincipal mp)
        {
            InitializeComponent();
            menu = mp;
            permisos = p;
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            LlenarTabla();
            if (permisos == 2)
            {
                BtnAnular.Enabled = false;
            }
            if (permisos == 3)
            {
                BtnAnular.Enabled = false;
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

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            menu.Focus();
        }

        private void BtnAnular_Click(object sender, EventArgs e)
        {
            if (dgvCompras.SelectedCells.Count > 0)
            {
                CompraNegocio neg = new CompraNegocio();
                Compra c = (Compra)dgvCompras.CurrentRow.DataBoundItem;
                try
                {
                    using (var popup = new Confirmacion(@"anular la compra """ + c.ToString() + @""""))
                    {
                        var R = popup.ShowDialog();
                        if (R == DialogResult.OK)
                        {
                            bool conf = popup.R;
                            if (c != null && conf == true)
                            {
                                if(neg.AnularCompra(c))
                                {
                                    LlenarTabla();
                                }
                                else
                                {
                                    Mensaje me = new Mensaje("No se puede anular compra con productos faltantes."); me.ShowDialog();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Mensaje mex = new Mensaje(ex.ToString()); mex.ShowDialog();
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

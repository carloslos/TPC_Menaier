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
    public partial class ModCompra : MetroFramework.Forms.MetroForm
    {
        private bool[] EntradasVal = new bool[3];
        Compra c;
        bool edit;
        Validaciones val = new Validaciones();
        BindingList<Lote> BindLotes;

        public ModCompra()
        {
            InitializeComponent();
            this.Text = "Registrar " + this.Text;
            BtnMod.Text = "Registrar";
            DateCompra.CustomFormat = " ";
            DateCompra.Format = DateTimePickerFormat.Custom;
            edit = true;
            c = new Compra
            {
                LstLotes = new List<Lote>()
            };
        }

        public ModCompra(Compra C, bool edit)
        {
            InitializeComponent();
            this.Text = this.Text + " " + C.IdCompra.ToString();
            BtnMod.Enabled = false;
            c = C;
            LlenarTabla();
            this.edit = edit;
            DateCompra.CustomFormat = "dd/MM/yyyy";
            DateCompra.Value = C.FechaCompra;

            if(edit == false)
            {
                BtnMod.Text = "----";
                BtnAgregar.Visible = false;
                BtnEditar.Visible = false;
                BtnEliminar.Visible = false;
                BoxProveedor.Enabled = false;
                DateCompra.Enabled = false;
            }
            else
            {
                BtnMod.Text = "Editar";
            }
        }

        private void ModCompra_Load(object sender, EventArgs e)
        {
            bool b;
            if (c.IdCompra != 0) { b = true; }
            else { b = false; }
            for (int i = 0; i < EntradasVal.Length; i++)
            {
                EntradasVal[i] = b;
            }


            ProveedorNegocio negP = new ProveedorNegocio();
            BoxProveedor.DisplayMember = "Empresa";
            BoxProveedor.ValueMember = "IdProveedor";
            BoxProveedor.DataSource = negP.Listar();

            try
            {
                BindLotes = new BindingList<Lote>(c.LstLotes);

                if (c.Proveedor != null)
                {
                    BoxProveedor.SelectedValue = c.Proveedor.IdProveedor;
                    BoxProveedor.SelectedText = c.Proveedor.Empresa;
                    RealizarValidaciones();
                }
                else
                {
                    BoxProveedor.SelectedIndex = -1;
                }
                LlenarTabla();
                ValidarEntradas();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LlenarTabla()
        {
            try
            {
                dgvLotes.DataSource = BindLotes;
                //dgvLotes.Columns["IdLote"].HeaderText = "ID";
                //dgvLotes.Columns["UnidadesE"].HeaderText = "U. Existentes";
                //dgvLotes.Columns["UnidadesP"].HeaderText = "U. Pedidas";
                //dgvLotes.Columns["CostoPU"].HeaderText = "Costo x Unidad";
                //dgvLotes.Columns["CostoT"].HeaderText = "Costo Total";
                //dgvLotes.Columns["Activo"].Visible = false;
                //dgvLotes.Columns["IdCompra"].Visible = false;
                dgvLotes.Update();
                dgvLotes.Refresh();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMod_Click(object sender, EventArgs e)
        {
            CompraNegocio negC = new CompraNegocio();
            LoteNegocio negL = new LoteNegocio();
            try
            {
                if (c.IdCompra == 0)
                {
                    c.Proveedor = new Proveedor();
                }
                c.Proveedor = (Proveedor)BoxProveedor.SelectedItem;
                c.FechaCompra = DateCompra.Value;
                if (c.IdCompra != 0)
                {
                    negC.Modificar(c);
                    negL.EliminarLotesDeCompra(c.IdCompra);
                }
                else
                {
                    c.IdCompra = Convert.ToInt32(negC.Agregar(c));
                }
                foreach (Lote l in c.LstLotes)
                {
                    l.IdCompra = c.IdCompra;
                    negL.Agregar(l);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DgvLotes_Changed()
        {
            ValidarDgv(0, dgvLotes);
            ActualizarTotal();
        }

        private void DgvLotes_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DgvLotes_Changed();
        }

        private void DgvLotes_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            DgvLotes_Changed();
        }

        private void BoxProveedor_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidarBox(1, BoxProveedor, tileProveedor, lblProveedor);
        }

        private void DateCompra_ValueChanged(object sender, EventArgs e)
        {
            DateCompra.CustomFormat = "dd/MM/yyyy";
            ValidarDate(2, DateCompra.Value, tileFechaCompra, lblFechaCompra);
        }

        private void RealizarValidaciones()
        {
            ValidarDgv(0, dgvLotes);
            ValidarBox(1, BoxProveedor, tileProveedor, lblProveedor);
            DateCompra.CustomFormat = "dd/MM/yyyy";
            ValidarDate(2, DateCompra.Value, tileFechaCompra, lblFechaCompra);
        }

        private void ValidarDgv(int c, MetroFramework.Controls.MetroGrid DgvLotes)
        {
            if(dgvLotes.RowCount == 0)
            {
                EntradasVal[c] = false;
            }
            else
            {
                EntradasVal[c] = true;
            }
            ValidarEntradas();
        }

        private void ActualizarTotal()
        {
            float total = 0;
            for (int i = 0; i < dgvLotes.RowCount; i++)
            {
                Lote l = (Lote)dgvLotes.Rows[i].DataBoundItem;
                total += l.CostoT;
            }
            TxtTotal.Text = "$ " + total.ToString();
        }

        private void ValidarBox(int c, MetroFramework.Controls.MetroComboBox b, MetroFramework.Controls.MetroTile t, MetroFramework.Controls.MetroLabel l)
        {
            if (b.SelectedIndex != -1)
            {
                EntradasVal[c] = true;
                val.CambiarColor(t, l, 'g');
            }
            else
            {
                EntradasVal[c] = false;
                val.CambiarColor(t, l, 'b');
            }
            ValidarEntradas();
        }

        private void LimpiarEntradas()
        {
            c = new Compra
            {
                LstLotes = new List<Lote>()
            };
            dgvLotes.DataSource = c.LstLotes;
            dgvLotes.Update();
            dgvLotes.Refresh();
            BoxProveedor.SelectedIndex = -1;;
            DateCompra.CustomFormat = " ";
            DateCompra.Format = DateTimePickerFormat.Custom;
            val.CambiarColor(tileProveedor, lblProveedor, 'b');
            val.CambiarColor(tileFechaCompra, lblFechaCompra, 'b');
        }

        private void ValidarDate(int c, DateTime d, MetroFramework.Controls.MetroTile t, MetroFramework.Controls.MetroLabel l)
        {
            DateTime v = new DateTime(1900, 1, 1), a = DateTime.Today;
            if (DateCompra.CustomFormat == " ")
            {
                val.CambiarColor(t, l, 'b');
            }
            else
            {
                if (d > v && d <= a)
                {
                    EntradasVal[c] = true;
                    val.CambiarColor(t, l, 'g');
                }
                else
                {
                    EntradasVal[c] = false;
                    val.CambiarColor(t, l, 'r');
                }
            }
            ValidarEntradas();
        }

        private void ValidarEntradas()
        {
            int i;
            bool v = true;
            for (i = 0; i < EntradasVal.Length - 1; i++)
            {
                if (EntradasVal[i] == false)
                {
                    v = false;
                    break;
                }
            }
            if (v == true && edit == true) { BtnMod.Enabled = true; }
            else { BtnMod.Enabled = false; }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ModLote))
                {
                    item.Focus();
                    return;
                }
            }
            try
            {
                ModLote mod = new ModLote(c.IdCompra);
                DialogResult res = mod.ShowDialog();
                if (res == DialogResult.OK)
                {
                    c.LstLotes.Add(mod.l);
                    BindLotes.ResetBindings();
                }             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ModLote))
                {
                    item.Focus();
                    return;
                }
            }
            try
            {
                Lote obj = (Lote)dgvLotes.CurrentRow.DataBoundItem;
                ModLote mod = new ModLote(obj);
                DialogResult res = mod.ShowDialog();
                if (res == DialogResult.OK)
                {
                    obj = mod.l;
                    BindLotes.ResetBindings();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            LoteNegocio neg = new LoteNegocio();
            Lote l = (Lote)dgvLotes.CurrentRow.DataBoundItem;
            try
            {
                using (var popup = new Confirmacion(@"eliminar """ + l.ToString() + @""""))
                {
                    var R = popup.ShowDialog();
                    if (R == DialogResult.OK)
                    {
                        bool conf = popup.R;
                        if (l != null && conf == true)
                        {
                            neg.EliminarLogico(l.IdLote);
                            BindLotes.Remove(l);
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

/*
CREATE TABLE LOTES
(
	IDLOTE BIGINT IDENTITY(140000000,1) NOT NULL PRIMARY KEY,
	IDPRODUCTO INT NOT NULL FOREIGN KEY REFERENCES PRODUCTOS(IDPRODUCTO),
	UNIDADES INT NOT NULL,
	COSTOPU FLOAT NOT NULL,
	VENCIMIENTO DATE,
	ACTIVO BIT NOT NULL
)
*/

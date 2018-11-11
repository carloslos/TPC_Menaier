using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
/// <summary>
/// TODO: MOD VENTA
/// </summary>
namespace Presentacion
{
    public partial class ModVenta : MetroFramework.Forms.MetroForm
    { 
        /*
        private bool[] EntradasVal = new bool[4];
        Venta v;
        bool edit;
        Validaciones val = new Validaciones();
        List<Cliente> LstClientes;
        BindingList<ProductoVendido> BindProductos;

        public ModVenta()
        {
            InitializeComponent();
            this.Text = "Registrar " + this.Text;
            BtnMod.Text = "Registrar";
            DateFecha.CustomFormat = " ";
            DateFecha.Format = DateTimePickerFormat.Custom;
            edit = true;
            v = new Venta
            {
                LstProductosVendidos = new List<ProductoVendido>()
            };
        }

        public ModVenta(Venta V, bool edit)
        {
            InitializeComponent();
            this.Text = this.Text + " " + V.IdVenta.ToString();
            BtnMod.Enabled = false;
            v = V;
            LlenarTabla();
            this.edit = edit;
            DateFecha.CustomFormat = "dd/MM/yyyy";
            DateFecha.Value = v.FechaVenta;

            if (edit == false)
            {
                BtnMod.Text = "----";
                BtnAgregarP.Visible = false;
                BtnEditarP.Visible = false;
                BtnEliminarP.Visible = false;
                BoxCliente.Enabled = false;
                BoxEmpleado.Enabled = false;
                DateFecha.Enabled = false;
            }
            else
            {
                BtnMod.Text = "Editar";
            }
        }
        
        private void ModVenta_Load(object sender, EventArgs e)
        {
            bool b;
            if (v.IdVenta != 0) { b = true; }
            else { b = false; }
            for (int i = 0; i < EntradasVal.Length; i++)
            {
                EntradasVal[i] = b;
            }

            try
            {
                LstClientes = new List<Cliente>();
                ClienteENegocio negCE = new ClienteENegocio();
                ClientePNegocio negCP = new ClientePNegocio();
                LstClientes.AddRange(negCE.Listar());
                LstClientes.AddRange(negCP.Listar());
                BoxCliente.DisplayMember = "Nombre";
                BoxCliente.ValueMember = "IdCliente";
                BoxCliente.DataSource = LstClientes;

                EmpleadoNegocio negE = new EmpleadoNegocio();
                BoxCliente.DisplayMember = "IdEmpleado";
                BoxCliente.ValueMember = "IdEmpleado";
                BoxCliente.DataSource = negE.Listar();

                ProductoVendidoNegocio negP = new ProductoVendidoNegocio();
                BindProductos = new BindingList<ProductoVendido>(v.LstProductosVendidos);
                BoxCliente.DataSource = BindProductos;
                
                if (v.Cliente != null)
                {
                    BoxCliente.SelectedValue = v.Cliente.IdCliente;
                    BoxCliente.SelectedText = v.Cliente.Nombre;
                    RealizarValidaciones();
                }
                else
                {
                    BoxCliente.SelectedIndex = -1;
                }

                if (v.Empleado != null)
                {
                    BoxEmpleado.SelectedValue = v.Cliente.IdCliente;
                    BoxEmpleado.SelectedText = v.Cliente.Nombre;
                    RealizarValidaciones();
                }
                else
                {
                    BoxEmpleado.SelectedIndex = -1;
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
                dgvVenta.DataSource = BindProductos;
                dgvVenta.Update();
                dgvVenta.Refresh();
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
            VentaNegocio negV = new VentaNegocio();
            ProductoVendidoNegocio negP = new ProductoVendidoNegocio();
            try
            {
                if (v.IdVenta == 0)
                {
                    v.Cliente = new Cliente();
                    v.Empleado = new Empleado();
                }
                v.Cliente = (Cliente)BoxCliente.SelectedItem;
                v.Empleado = (Empleado)BoxEmpleado.SelectedItem;
                v.FechaVenta = DateFecha.Value;
                if (v.IdVenta != 0)
                {
                    negV.Modificar(v);
                    negP.EliminarProductosDeVenta(v.IdVenta);
                }
                else
                {
                    v.IdVenta = Convert.ToInt32(negV.Agregar(v));
                }
                foreach (ProductoVendido pv in v.LstProductosVendidos)
                {
                    pv.IdVenta = v.IdVenta;
                    negP.Agregar(pv);
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
            ValidarDgv(0, dgvVenta);
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
            if (dgvLotes.RowCount == 0)
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
            BoxProveedor.SelectedIndex = -1; ;
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
        }*/
    }
}

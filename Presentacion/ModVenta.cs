using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class ModVenta : MetroFramework.Forms.MetroForm
    { 
        private bool[] EntradasVal = new bool[4];
        private bool[] ProductoVal = new bool[2];
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
                BtnMod.Enabled = false;
                BtnAgregarP.Enabled = false;
                BtnEliminarP.Enabled = false;
                BoxCliente.Enabled = false;
                BoxEmpleado.Enabled = false;
                DateFecha.Enabled = false;
                BoxProducto.Enabled = false;
                TxtCantidad.Enabled = false;
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

            for (int i = 0; i < ProductoVal.Length; i++)
            {
                ProductoVal[i] = false;
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
                BoxEmpleado.DisplayMember = "Nombre";
                BoxEmpleado.ValueMember = "IdEmpleado";
                BoxEmpleado.DataSource = negE.Listar();

                ProductoNegocio negP = new ProductoNegocio();
                BoxProducto.DisplayMember = "Descripcion";
                BoxProducto.ValueMember = "IdProducto";
                BoxProducto.DataSource = negP.Listar(0);

                ProductoVendidoNegocio negPV = new ProductoVendidoNegocio();
                BindProductos = new BindingList<ProductoVendido>(v.LstProductosVendidos);
                dgvVenta.DataSource = BindProductos;
                
                if (v.Cliente != null)
                {
                    BoxCliente.SelectedValue = v.Cliente.IdCliente;
                    BoxCliente.SelectedText = v.Cliente.Nombre;
                }
                else
                {
                    BoxCliente.SelectedIndex = -1;
                }

                if (v.Empleado != null)
                {
                    BoxEmpleado.SelectedValue = v.Empleado.IdEmpleado;
                    BoxEmpleado.SelectedText = v.Empleado.IdEmpleado.ToString();
                    RealizarValidaciones();
                }
                else
                {
                    BoxEmpleado.SelectedIndex = -1;
                }
                BoxProducto.SelectedIndex = -1;

                LlenarTabla();
                ValidarEntradas();
            }

            catch (Exception ex)
            {
                Mensaje m = new Mensaje(ex.ToString()); m.ShowDialog();
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
            ProductoVendidoNegocio negPV = new ProductoVendidoNegocio();
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
                v.Monto = (float)Convert.ToDouble(TxtTotal.Text);
                if (v.IdVenta != 0)
                {
                    negV.Modificar(v);
                    negPV.EliminarProductosDeVenta(v.IdVenta);
                }
                else
                {
                    v.IdVenta = Convert.ToInt32(negV.Agregar(v));
                }
                foreach (ProductoVendido pv in v.LstProductosVendidos)
                {
                    pv.IdVenta = v.IdVenta;
                    negPV.DescontarStock(pv);
                    negPV.Agregar(pv);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                Mensaje m = new Mensaje(ex.ToString()); m.ShowDialog();
            }
        }

        private void DgvProductos_Changed()
        {
            ValidarDgv(0, dgvVenta);
            ActualizarTotal();
        }

        private void DgvProductos_Changed_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DgvProductos_Changed();
        }

        private void DgvProductos_Changed_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            DgvProductos_Changed();
        }

        private void BoxCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidarBox(1, BoxCliente, tileCliente, lblCliente);
        }

        private void BoxEmpleado_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidarBox(2, BoxEmpleado, tileEmpleado, lblEmpleado);
        }

        private void DateFecha_ValueChanged(object sender, EventArgs e)
        {
            DateFecha.CustomFormat = "dd/MM/yyyy";
            ValidarDate(3, DateFecha.Value, tileFecha, lblFecha);
        }

        private void RealizarValidaciones()
        {
            ValidarDgv(0, dgvVenta);
            ValidarBox(1, BoxCliente, tileCliente, lblCliente);
            ValidarBox(2, BoxEmpleado, tileEmpleado, lblEmpleado);
            DateFecha.CustomFormat = "dd/MM/yyyy";
            ValidarDate(3, DateFecha.Value, tileFecha, lblFecha);
        }

        private void ValidarDgv(int c, MetroFramework.Controls.MetroGrid DgvLotes)
        {
            if (dgvVenta.RowCount == 0) { EntradasVal[c] = false; }
            else { EntradasVal[c] = true; }
            ValidarEntradas();
        }

        private void ActualizarTotal()
        {
            float total = 0;
            for (int i = 0; i < dgvVenta.RowCount; i++)
            {
                ProductoVendido pv = (ProductoVendido)dgvVenta.Rows[i].DataBoundItem;
                total += pv.PrecioT;
            }
            TxtTotal.Text = total.ToString();
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
            v = new Venta
            {
                LstProductosVendidos = new List<ProductoVendido>()
            };
            dgvVenta.DataSource = v.LstProductosVendidos;
            dgvVenta.Update();
            dgvVenta.Refresh();
            BoxCliente.SelectedIndex = -1;
            BoxEmpleado.SelectedIndex = -1;
            DateFecha.CustomFormat = " ";
            DateFecha.Format = DateTimePickerFormat.Custom;
            val.CambiarColor(tileCliente, lblCliente, 'b');
            val.CambiarColor(tileEmpleado, lblEmpleado, 'b');
            val.CambiarColor(tileFecha, lblFecha, 'b');
        }

        private void ValidarDate(int c, DateTime d, MetroFramework.Controls.MetroTile t, MetroFramework.Controls.MetroLabel l)
        {
            DateTime v = new DateTime(1900, 1, 1), a = DateTime.Today;
            if (DateFecha.CustomFormat == " ")
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
            try
            {
                ProductoVendidoNegocio negPV = new ProductoVendidoNegocio();
                ProductoVendido pv = new ProductoVendido
                {
                    Producto = (Producto)BoxProducto.SelectedItem,
                    Cantidad = Convert.ToInt32(TxtCantidad.Text)
                };
                foreach(ProductoVendido PV in v.LstProductosVendidos)
                {
                    if(PV.Producto.IdProducto == pv.Producto.IdProducto)
                    {
                        pv.Cantidad += PV.Cantidad;
                        if (negPV.ControlarStock(pv))
                        {
                            v.LstProductosVendidos.Remove(PV);
                        }
                        break;
                    }
                }
                if ( negPV.ControlarStock(pv) )
                {
                    //pv.PrecioU = (float)Math.Round(negPV.CalcularPrecio(pv.Producto.IdProducto), 3);
                    //pv.PrecioT = (float)Math.Round(pv.PrecioU * pv.Cantidad, 3);
                    pv.PrecioU = negPV.CalcularPrecio(pv.Producto.IdProducto);
                    pv.PrecioT = pv.PrecioU * pv.Cantidad;
                    v.LstProductosVendidos.Add(pv);
                    BindProductos.ResetBindings();

                    BoxProducto.SelectedIndex = -1;
                    TxtCantidad.Text = "";
                    ProductoVal[0] = false;
                    ProductoVal[1] = false;
                }
                else
                {
                    Mensaje m = new Mensaje("No hay stock suficiente.");
                    m.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Mensaje m = new Mensaje(ex.ToString()); m.ShowDialog();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvVenta.SelectedCells.Count > 0)
            {
                ProductoVendidoNegocio neg = new ProductoVendidoNegocio();
                ProductoVendido l = (ProductoVendido)dgvVenta.CurrentRow.DataBoundItem;
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
                                neg.EliminarFisico(l.IdPxv);
                                BindProductos.Remove(l);
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

        private void TxtCantidad_TextChanged(object sender, EventArgs e)
        {
            TxtCantidad.Text = TxtCantidad.Text.Trim();
            if (val.EsNumeroEntero(TxtCantidad.Text)) { ProductoVal[1] = true; }
            else { ProductoVal[1] = false; }
            ValidarProducto();
        }

        private void ValidarProducto()
        {
            if (ProductoVal[0] == true && ProductoVal[1] == true) { BtnAgregarP.Enabled = true; }
            else { BtnAgregarP.Enabled = false; }
        }

        private void BoxProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            if(BoxProducto.SelectedIndex != -1) { ProductoVal[0] = true; }
            else { ProductoVal[0] = false; }
            ValidarProducto();
        }
    }
}

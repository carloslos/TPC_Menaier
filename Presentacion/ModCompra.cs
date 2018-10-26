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
    public partial class ModCompra : Presentacion.Metro_Template
    {
        private bool[] EntradasVal = new bool[3];
        Compra c;
        Validaciones val = new Validaciones();

        public ModCompra()
        {
            InitializeComponent();
            this.Text = "Agregar " + this.Text;
            BtnMod.Text = "Agregar";
            BtnMod.Enabled = false;
            DateCompra.CustomFormat = " ";
            DateCompra.Format = DateTimePickerFormat.Custom;
            c = new Compra
            {
                LstLotes = new List<Lote>()
            };
        }

        public ModCompra(Compra C)
        {
            InitializeComponent();
            this.Text = "Editar " + this.Text;
            BtnMod.Text = "Editar";
            BtnMod.Enabled = false;
            c = C;
            dgvLotes.DataSource = c.LstLotes;
            BoxProveedor.SelectedItem = C.Proveedor;
            DateCompra.CustomFormat = "dd/MM/yyyy";
        }

        private void ModProducto_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < EntradasVal.Length; i++)
            {
                EntradasVal[i] = false;
            }
            DateCompra.Value = c.FechaCompra;

            ProveedorNegocio negP = new ProveedorNegocio();
            try
            {
                BoxProveedor.DisplayMember = "Empresa";
                BoxProveedor.ValueMember = "IdProveedor";
                BoxProveedor.DataSource = negP.Listar();

                dgvLotes.Update();
                dgvLotes.Refresh();

                if (c.Proveedor != null)
                {
                    BoxProveedor.SelectedValue = c.Proveedor.IdProveedor;
                    RealizarValidaciones();
                }
                else
                {
                    BoxProveedor.SelectedIndex = -1;
                }
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
            try
            {
                
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        private void DgvLotes_Changed()
        {
            ValidarGgv(0, dgvLotes);
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

        private void DateVencimiento_ValueChanged(object sender, EventArgs e)
        {
            DateCompra.CustomFormat = "dd/MM/yyyy";
            ValidarDate(2, DateCompra.Value, tileFechaCompra, lblFechaCompra);
        }

        private void RealizarValidaciones()
        {
            ValidarGgv(0, dgvLotes);
            ValidarBox(1, BoxProveedor, tileProveedor, lblProveedor);
            DateCompra.CustomFormat = "dd/MM/yyyy";
            ValidarDate(2, DateCompra.Value, tileFechaCompra, lblFechaCompra);
        }

        private void ValidarGgv(int c, MetroFramework.Controls.MetroGrid DgvLotes)
        {
            if(DgvLotes.RowCount == 0)
            {
                EntradasVal[c] = false;
            }
            else
            {
                EntradasVal[c] = true;
            }
            ValidarEntradas();
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
            DateTime v = new DateTime(1900, 1, 1), a = DateTime.Today.AddYears(-18);
            if (DateCompra.CustomFormat == " ")
            {
                val.CambiarColor(t, l, 'b');
            }
            else
            {
                if (d > v && d < a)
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
            if (v == true) { BtnMod.Enabled = true; }
            else { BtnMod.Enabled = false; }
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

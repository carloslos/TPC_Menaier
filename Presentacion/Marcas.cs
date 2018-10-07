using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class Marcas : MetroFramework.Forms.MetroForm
    {
        public Marcas()
        {
            InitializeComponent();
        }

        private void LlenarTabla()
        {
            MarcasNegocio neg = new MarcasNegocio();
            try
            {
                dgvMarcas.DataSource = neg.Listar();
                dgvMarcas.Columns["IDMARCA"].HeaderText = "ID";
                dgvMarcas.Columns["DESCRIPCION"].HeaderText = "Descripción";
                dgvMarcas.Columns["Activo"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Marcas_Load(object sender, EventArgs e)
        {
            MarcasNegocio neg = new MarcasNegocio();
            try
            {
                LlenarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            {
                foreach (Form item in Application.OpenForms)
                {
                    if (item.GetType() == typeof(ModMarca))
                    {
                        item.Focus();
                        return;
                    }
                }
                try
                {
                    ModMarca wndAgregarTipoProducto = new ModMarca("Agregar");
                    wndAgregarTipoProducto.ShowDialog();
                    LlenarTabla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}

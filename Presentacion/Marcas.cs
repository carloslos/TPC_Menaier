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

        private void Marcas_Load(object sender, EventArgs e)
        {
            MarcaNegocio neg = new MarcaNegocio();
            try
            {
                dgvMarcas.DataSource = neg.listar();
                dgvMarcas.Columns["idMarca"].HeaderText = "ID";
                dgvMarcas.Columns["descripcion"].HeaderText = "Descripcion";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}

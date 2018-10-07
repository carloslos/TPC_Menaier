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
    public partial class ModEmpleado : Presentacion.Metro_Template
    {
        public ModEmpleado(string title)
        {
            InitializeComponent();
            this.Text = title + " " + this.Text;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            EmpleadosNegocio neg = new EmpleadosNegocio();
            Empleado empleado = new Empleado
            {
                Nombre = txtNombre.Text.Trim(), // VALIDAR
                Apellido = txtApellido.Text.Trim()
            };
            try
            {
                neg.Agregar(empleado);
                txtNombre.Text = "";
                txtApellido.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
using Dominio;

namespace Presentacion
{
    public partial class Empleados : MetroFramework.Forms.MetroForm
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            LlenarTabla();
        }
        
        private void LlenarTabla()
        {
            EmpleadosNegocio neg = new EmpleadosNegocio();
            try
            {
                dgvEmpleados.DataSource = neg.Listar();
                dgvEmpleados.Columns["Nombre"].DisplayIndex = 0; dgvEmpleados.Columns["NOMBRE"].HeaderText = "Nombre";
                dgvEmpleados.Columns["Apellido"].DisplayIndex = 1; dgvEmpleados.Columns["Apellido"].HeaderText = "Apellido";
                dgvEmpleados.Columns["Dni"].DisplayIndex = 2; dgvEmpleados.Columns["DNI"].HeaderText = "DNI";
                dgvEmpleados.Columns["Email"].DisplayIndex = 3; dgvEmpleados.Columns["EMAIL"].HeaderText = "Email";
                dgvEmpleados.Columns["IdEmpleado"].DisplayIndex = 4; dgvEmpleados.Columns["IDEMPLEADO"].HeaderText = "ID";
                dgvEmpleados.Columns["FechaNac"].DisplayIndex = 5; dgvEmpleados.Columns["FECHANAC"].HeaderText = "Fecha de nacimiento";
                dgvEmpleados.Columns["TipoPerfil"].DisplayIndex = 6; dgvEmpleados.Columns["TIPOPERFIL"].HeaderText = "Tipo de perfil";
                dgvEmpleados.Columns["Usuario"].Visible = false;
                dgvEmpleados.Columns["Contrasenia"].Visible = false;
                dgvEmpleados.Columns["Activo"].Visible = false;
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
                    if (item.GetType() == typeof(ModEmpleado))
                    {
                        item.Focus();
                        return;
                    }
                }
                try
                {
                    ModEmpleado mod = new ModEmpleado();
                    mod.Show();
                    LlenarTabla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            {
                foreach (Form item in Application.OpenForms)
                {
                    if (item.GetType() == typeof(ModEmpleado))
                    {
                        item.Focus();
                        return;
                    }
                }
                try
                {
                    Empleado obj = (Empleado)dgvEmpleados.CurrentRow.DataBoundItem;
                    ModEmpleado mod = new ModEmpleado(obj);
                    mod.Show();
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

/*
CREATE TABLE EMPLEADOS
(
	NOMBRE VARCHAR(60) NOT NULL,
	APELLIDO VARCHAR(60) NOT NULL,
	DNI INT NOT NULL,
	IDEMPLEADO INT NOT NULL PRIMARY KEY,
	FECHANAC DATE,
	USUARIO VARCHAR(60) NOT NULL,
	CONTRASENIA VARCHAR(60) NOT NULL,
	TIPOPERFIL CHAR NOT NULL,
	EMAIL VARCHAR(60) NOT NULL
)
*/

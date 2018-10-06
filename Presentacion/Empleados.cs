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
    public partial class Empleados : MetroFramework.Forms.MetroForm
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            EmpleadosNegocio neg = new EmpleadosNegocio();
            try
            {
                dgvEmpleados.DataSource = neg.listar();
                dgvEmpleados.Columns["nombre"].DisplayIndex = 0; dgvEmpleados.Columns["Nombre"].HeaderText = "Nombre";
                dgvEmpleados.Columns["apellido"].DisplayIndex = 1; dgvEmpleados.Columns["Apellido"].HeaderText = "Apellido";
                dgvEmpleados.Columns["dni"].DisplayIndex = 2; dgvEmpleados.Columns["dni"].HeaderText = "DNI";
                dgvEmpleados.Columns["email"].DisplayIndex = 3; dgvEmpleados.Columns["email"].HeaderText = "Email";
                dgvEmpleados.Columns["idEmpleado"].DisplayIndex = 4; dgvEmpleados.Columns["idEmpleado"].HeaderText = "ID";
                dgvEmpleados.Columns["fechaNac"].DisplayIndex = 5; dgvEmpleados.Columns["fechaNac"].HeaderText = "Fecha de nacimiento";
                dgvEmpleados.Columns["tipoPerfil"].DisplayIndex = 6; dgvEmpleados.Columns["tipoPerfil"].HeaderText = "Tipo de perfil";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

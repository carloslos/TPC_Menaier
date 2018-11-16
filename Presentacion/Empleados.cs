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
        int permisos;
        public Empleados(int p)
        {
            InitializeComponent();
            permisos = p;
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            LlenarTabla();
            if (permisos == 2)
            {
                BtnEliminar.Enabled = false;
            }
            if (permisos == 3)
            {
                BtnEditar.Enabled = false;
                BtnEliminar.Enabled = false;
                BtnAgregar.Enabled = false;
            }
        }
        
        private void LlenarTabla()
        {
            EmpleadoNegocio neg = new EmpleadoNegocio();
            try
            {
                dgvEmpleados.DataSource = neg.Listar();
                dgvEmpleados.Columns["IdEmpleado"].DisplayIndex = 0; dgvEmpleados.Columns["IdEmpleado"].HeaderText = "ID";
                dgvEmpleados.Columns["Nombre"].DisplayIndex = 1;
                dgvEmpleados.Columns["Apellido"].DisplayIndex = 2;
                dgvEmpleados.Columns["Dni"].DisplayIndex = 3; dgvEmpleados.Columns["Dni"].HeaderText = "DNI";
                dgvEmpleados.Columns["Email"].DisplayIndex = 4;
                dgvEmpleados.Columns["FechaNac"].DisplayIndex = 5; dgvEmpleados.Columns["FechaNac"].HeaderText = "Fecha de nacimiento";
                dgvEmpleados.Columns["TipoPerfilS"].DisplayIndex = 6; dgvEmpleados.Columns["TipoPerfilS"].HeaderText = "Tipo de perfil";
                dgvEmpleados.Columns["TipoPerfil"].Visible = false;
                dgvEmpleados.Columns["IdContacto"].Visible = false;
                dgvEmpleados.Columns["Usuario"].Visible = false;
                dgvEmpleados.Columns["Pass"].Visible = false;
                dgvEmpleados.Columns["Activo"].Visible = false;
                dgvEmpleados.Update();
                dgvEmpleados.Refresh();
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
                if (item.GetType() == typeof(ModEmpleado))
                {
                   item.Focus();
                   return;
                }
            }
            try
            {
                ModEmpleado mod = new ModEmpleado();
                mod.ShowDialog();
                LlenarTabla();
            }
            catch (Exception ex)
            {
                Mensaje m = new Mensaje(ex.ToString()); m.ShowDialog();
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedCells.Count > 0)
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
                    mod.ShowDialog();
                    LlenarTabla();
                }
                catch (Exception ex)
                {
                    Mensaje m = new Mensaje(ex.ToString()); m.ShowDialog();
                }
            }
            else
            {
                Mensaje m = new Mensaje("Ningun item seleccion.");
                m.ShowDialog();
            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EmpleadoNegocio neg = new EmpleadoNegocio();
            Empleado em = (Empleado)dgvEmpleados.CurrentRow.DataBoundItem;
            try
            {
                using (var popup = new Confirmacion(@"eliminar """ + em.ToString() + @""""))
                {
                    var R = popup.ShowDialog();
                    if (R == DialogResult.OK)
                    {
                        bool conf = popup.R;
                        if (em != null && conf == true)
                        {
                            neg.EliminarLogico(em.IdEmpleado);
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

        private void BtnDetalles_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedCells.Count > 0)
            {
                foreach (Form item in Application.OpenForms)
                {
                    if (item.GetType() == typeof(DetallesContacto))
                    {
                        item.Focus();
                        return;
                    }
                }
                try
                {
                    DetallesContacto detalles = new DetallesContacto((Empleado)dgvEmpleados.CurrentRow.DataBoundItem);
                    detalles.Show();
                    LlenarTabla();
                }
                catch (Exception ex)
                {
                    Mensaje m = new Mensaje(ex.ToString()); m.ShowDialog();
                }
            }
            else
            {
                Mensaje m = new Mensaje("Ningun item seleccion.");
                m.ShowDialog();
            }

        }

        private void DgvEmpleados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmpleados.SelectedCells.Count > 0)
            {
                foreach (Form item in Application.OpenForms)
                {
                    if (item.GetType() == typeof(DetallesContacto))
                    {
                        item.Focus();
                        return;
                    }
                }
                try
                {
                    DetallesContacto detalles = new DetallesContacto((Empleado)dgvEmpleados.CurrentRow.DataBoundItem);
                    detalles.Show();
                    LlenarTabla();
                }
                catch (Exception ex)
                {
                    Mensaje m = new Mensaje(ex.ToString()); m.ShowDialog();
                }
            }
            else
            {
                Mensaje m = new Mensaje("Ningun item seleccion.");
                m.ShowDialog();
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
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

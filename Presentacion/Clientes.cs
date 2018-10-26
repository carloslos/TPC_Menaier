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
    public partial class Clientes : MetroFramework.Forms.MetroForm
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            try
            {
                RadClientesP.Checked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LlenarTablaP()
        {
            ClientePNegocio neg = new ClientePNegocio();
            try
            {
                dgvClientesP.DataSource = neg.Listar();
                dgvClientesP.Columns["IdCliente"].DisplayIndex = 0; dgvClientesP.Columns["IdCliente"].HeaderText = "ID";
                dgvClientesP.Columns["Nombre"].DisplayIndex = 1;
                dgvClientesP.Columns["Apellido"].DisplayIndex = 2;
                dgvClientesP.Columns["Dni"].DisplayIndex = 3; dgvClientesP.Columns["Dni"].HeaderText = "DNI";
                dgvClientesP.Columns["Email"].DisplayIndex = 4;
                dgvClientesP.Columns["IdContacto"].Visible = false;
                dgvClientesP.Columns["Activo"].Visible = false;
                dgvClientesP.Update();
                dgvClientesP.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LlenarTablaE()
        {
            ClienteENegocio neg = new ClienteENegocio();
            try
            {
                dgvClientesE.DataSource = neg.Listar();
                dgvClientesE.Columns["IdCliente"].DisplayIndex = 0; dgvClientesE.Columns["IdCliente"].HeaderText = "ID";
                dgvClientesE.Columns["Empresa"].DisplayIndex = 1;
                dgvClientesE.Columns["Cuit"].DisplayIndex = 2; dgvClientesE.Columns["Cuit"].HeaderText = "CUIT";
                dgvClientesE.Columns["Activo"].Visible = false;
                dgvClientesE.Update();
                dgvClientesE.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void RadClientesP_CheckedChanged(object sender, EventArgs e)
        {
            LlenarTablaP();
            dgvClientesP.Visible = true;
            BtnAgregarP.Visible = true;
            BtnEditarP.Visible = true;
            BtnDetallesP.Visible = true;
            BtnEliminarP.Visible = true;

            dgvClientesE.Visible = false;
            BtnAgregarE.Visible = false;
            BtnEditarE.Visible = false;
            BtnContactosE.Visible = false;
            BtnEliminarE.Visible = false;
        }

        private void RadClientesE_CheckedChanged(object sender, EventArgs e)
        {
            LlenarTablaE();
            dgvClientesP.Visible = false;
            BtnAgregarP.Visible = false;
            BtnEditarP.Visible = false;
            BtnDetallesP.Visible = false;
            BtnEliminarP.Visible = false;

            dgvClientesE.Visible = true;
            BtnAgregarE.Visible = true;
            BtnEditarE.Visible = true;
            BtnContactosE.Visible = true;
            BtnEliminarE.Visible = true;
        }

        private void BtnAgregarP_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ModClienteP))
                {
                    item.Focus();
                    return;
                }
            }
            try
            {
                ModClienteP mod = new ModClienteP();
                mod.Show();
                LlenarTablaP();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnEditarP_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ModClienteP))
                {
                    item.Focus();
                    return;
                }
            }
            try
            {
                ClienteP obj = (ClienteP)dgvClientesP.CurrentRow.DataBoundItem;
                ModClienteP mod = new ModClienteP(obj);
                mod.Show();
                LlenarTablaP();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnDetallesP_Click(object sender, EventArgs e)
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
                DetallesContacto detalles = new DetallesContacto((ClienteP)dgvClientesP.CurrentRow.DataBoundItem);
                detalles.Show();
                LlenarTablaP();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnEliminarP_Click(object sender, EventArgs e)
        {
            ClientePNegocio neg = new ClientePNegocio();
            ClienteP c = (ClienteP)dgvClientesP.CurrentRow.DataBoundItem;
            try
            {
                using (var popup = new Confirmacion(@"eliminar """ + c.ToString() + @""""))
                {
                    var R = popup.ShowDialog();
                    if (R == DialogResult.OK)
                    {
                        bool conf = popup.R;
                        if (c != null && conf == true)
                        {
                            neg.EliminarLogico(c.IdCliente);
                            LlenarTablaP();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnAgregarE_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ModClienteE))
                {
                    item.Focus();
                    return;
                }
            }
            try
            {
                ModClienteE mod = new ModClienteE();
                mod.Show();
                LlenarTablaE();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnEditarE_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ModClienteE))
                {
                    item.Focus();
                    return;
                }
            }
            try
            {
                ClienteE obj = (ClienteE)dgvClientesE.CurrentRow.DataBoundItem;
                ModClienteE mod = new ModClienteE(obj);
                mod.Show();
                LlenarTablaE();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnContactosE_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Contactos))
                {
                    item.Focus();
                    return;
                }
            }
            try
            {
                ClienteE E = new ClienteE();
                E = (ClienteE)dgvClientesE.CurrentRow.DataBoundItem;
                Contactos c = new Contactos(E.GetId());
                c.Show();
                LlenarTablaE();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnEliminarE_Click(object sender, EventArgs e)
        {
            ClienteENegocio neg = new ClienteENegocio();
            ClienteE c = (ClienteE)dgvClientesE.CurrentRow.DataBoundItem;
            try
            {
                using (var popup = new Confirmacion(@"eliminar """ + c.ToString() + @""""))
                {
                    var R = popup.ShowDialog();
                    if (R == DialogResult.OK)
                    {
                        bool conf = popup.R;
                        if (c != null && conf == true)
                        {
                            neg.EliminarLogico(c.IdCliente);
                            LlenarTablaE();
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

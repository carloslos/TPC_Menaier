namespace Presentacion
{
    partial class ModVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvVenta = new MetroFramework.Controls.MetroGrid();
            this.BoxCliente = new MetroFramework.Controls.MetroComboBox();
            this.tileCliente = new MetroFramework.Controls.MetroTile();
            this.lblCliente = new MetroFramework.Controls.MetroLabel();
            this.BoxEmpleado = new MetroFramework.Controls.MetroComboBox();
            this.tileEmpleado = new MetroFramework.Controls.MetroTile();
            this.lblEmpleado = new MetroFramework.Controls.MetroLabel();
            this.DateFecha = new MetroFramework.Controls.MetroDateTime();
            this.tileFecha = new MetroFramework.Controls.MetroTile();
            this.lblFecha = new MetroFramework.Controls.MetroLabel();
            this.BtnAgregarP = new MetroFramework.Controls.MetroButton();
            this.BtnVolver = new MetroFramework.Controls.MetroButton();
            this.BtnMod = new MetroFramework.Controls.MetroButton();
            this.BtnEliminarP = new MetroFramework.Controls.MetroButton();
            this.BtnEditarP = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.tileCliente.SuspendLayout();
            this.tileEmpleado.SuspendLayout();
            this.tileFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVenta
            // 
            this.dgvVenta.AllowUserToAddRows = false;
            this.dgvVenta.AllowUserToDeleteRows = false;
            this.dgvVenta.AllowUserToResizeRows = false;
            this.dgvVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVenta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVenta.EnableHeadersVisualStyles = false;
            this.dgvVenta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvVenta.Location = new System.Drawing.Point(23, 63);
            this.dgvVenta.MultiSelect = false;
            this.dgvVenta.Name = "dgvVenta";
            this.dgvVenta.ReadOnly = true;
            this.dgvVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVenta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVenta.Size = new System.Drawing.Size(544, 475);
            this.dgvVenta.TabIndex = 13;
            this.dgvVenta.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // BoxCliente
            // 
            this.BoxCliente.FormattingEnabled = true;
            this.BoxCliente.ItemHeight = 23;
            this.BoxCliente.Location = new System.Drawing.Point(748, 142);
            this.BoxCliente.Name = "BoxCliente";
            this.BoxCliente.Size = new System.Drawing.Size(177, 29);
            this.BoxCliente.TabIndex = 57;
            this.BoxCliente.UseSelectable = true;
            // 
            // tileCliente
            // 
            this.tileCliente.ActiveControl = null;
            this.tileCliente.Controls.Add(this.lblCliente);
            this.tileCliente.Enabled = false;
            this.tileCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileCliente.Location = new System.Drawing.Point(648, 142);
            this.tileCliente.Name = "tileCliente";
            this.tileCliente.Size = new System.Drawing.Size(104, 29);
            this.tileCliente.TabIndex = 58;
            this.tileCliente.UseSelectable = true;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Enabled = false;
            this.lblCliente.Location = new System.Drawing.Point(40, 6);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(49, 19);
            this.lblCliente.TabIndex = 5;
            this.lblCliente.Text = "Cliente";
            // 
            // BoxEmpleado
            // 
            this.BoxEmpleado.FormattingEnabled = true;
            this.BoxEmpleado.ItemHeight = 23;
            this.BoxEmpleado.Location = new System.Drawing.Point(748, 203);
            this.BoxEmpleado.Name = "BoxEmpleado";
            this.BoxEmpleado.Size = new System.Drawing.Size(177, 29);
            this.BoxEmpleado.TabIndex = 59;
            this.BoxEmpleado.UseSelectable = true;
            // 
            // tileEmpleado
            // 
            this.tileEmpleado.ActiveControl = null;
            this.tileEmpleado.Controls.Add(this.lblEmpleado);
            this.tileEmpleado.Enabled = false;
            this.tileEmpleado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileEmpleado.Location = new System.Drawing.Point(648, 203);
            this.tileEmpleado.Name = "tileEmpleado";
            this.tileEmpleado.Size = new System.Drawing.Size(104, 29);
            this.tileEmpleado.TabIndex = 60;
            this.tileEmpleado.UseSelectable = true;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Enabled = false;
            this.lblEmpleado.Location = new System.Drawing.Point(16, 6);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(73, 19);
            this.lblEmpleado.TabIndex = 5;
            this.lblEmpleado.Text = " Empleado";
            // 
            // DateFecha
            // 
            this.DateFecha.CustomFormat = "dd/mm/yyyy";
            this.DateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFecha.Location = new System.Drawing.Point(748, 260);
            this.DateFecha.MaxDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.DateFecha.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DateFecha.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateFecha.Name = "DateFecha";
            this.DateFecha.Size = new System.Drawing.Size(177, 29);
            this.DateFecha.TabIndex = 61;
            this.DateFecha.Value = new System.DateTime(2018, 11, 11, 0, 0, 0, 0);
            // 
            // tileFecha
            // 
            this.tileFecha.ActiveControl = null;
            this.tileFecha.Controls.Add(this.lblFecha);
            this.tileFecha.Enabled = false;
            this.tileFecha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileFecha.Location = new System.Drawing.Point(648, 260);
            this.tileFecha.Name = "tileFecha";
            this.tileFecha.Size = new System.Drawing.Size(104, 29);
            this.tileFecha.TabIndex = 62;
            this.tileFecha.UseSelectable = true;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Enabled = false;
            this.lblFecha.Location = new System.Drawing.Point(46, 6);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(43, 19);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha";
            // 
            // BtnAgregarP
            // 
            this.BtnAgregarP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnAgregarP.Location = new System.Drawing.Point(627, 332);
            this.BtnAgregarP.Name = "BtnAgregarP";
            this.BtnAgregarP.Size = new System.Drawing.Size(104, 23);
            this.BtnAgregarP.TabIndex = 65;
            this.BtnAgregarP.Text = "Agregar Producto";
            this.BtnAgregarP.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnAgregarP.UseSelectable = true;
            // 
            // BtnVolver
            // 
            this.BtnVolver.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnVolver.Location = new System.Drawing.Point(817, 519);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(123, 32);
            this.BtnVolver.TabIndex = 64;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnVolver.UseSelectable = true;
            // 
            // BtnMod
            // 
            this.BtnMod.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnMod.Location = new System.Drawing.Point(653, 519);
            this.BtnMod.Name = "BtnMod";
            this.BtnMod.Size = new System.Drawing.Size(123, 32);
            this.BtnMod.TabIndex = 63;
            this.BtnMod.Text = "Mod";
            this.BtnMod.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnMod.UseSelectable = true;
            // 
            // BtnEliminarP
            // 
            this.BtnEliminarP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnEliminarP.Location = new System.Drawing.Point(847, 332);
            this.BtnEliminarP.Name = "BtnEliminarP";
            this.BtnEliminarP.Size = new System.Drawing.Size(104, 23);
            this.BtnEliminarP.TabIndex = 66;
            this.BtnEliminarP.Text = "Eliminar Producto";
            this.BtnEliminarP.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnEliminarP.UseSelectable = true;
            // 
            // BtnEditarP
            // 
            this.BtnEditarP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnEditarP.Location = new System.Drawing.Point(737, 332);
            this.BtnEditarP.Name = "BtnEditarP";
            this.BtnEditarP.Size = new System.Drawing.Size(104, 23);
            this.BtnEditarP.TabIndex = 67;
            this.BtnEditarP.Text = "Editar Producto";
            this.BtnEditarP.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnEditarP.UseSelectable = true;
            // 
            // ModVenta
            // 
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.BtnEditarP);
            this.Controls.Add(this.BtnEliminarP);
            this.Controls.Add(this.BtnAgregarP);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnMod);
            this.Controls.Add(this.DateFecha);
            this.Controls.Add(this.tileFecha);
            this.Controls.Add(this.BoxEmpleado);
            this.Controls.Add(this.tileEmpleado);
            this.Controls.Add(this.BoxCliente);
            this.Controls.Add(this.tileCliente);
            this.Controls.Add(this.dgvVenta);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "ModVenta";
            this.Text = "Venta";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.tileCliente.ResumeLayout(false);
            this.tileCliente.PerformLayout();
            this.tileEmpleado.ResumeLayout(false);
            this.tileEmpleado.PerformLayout();
            this.tileFecha.ResumeLayout(false);
            this.tileFecha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvVenta;
        private MetroFramework.Controls.MetroComboBox BoxCliente;
        private MetroFramework.Controls.MetroTile tileCliente;
        private MetroFramework.Controls.MetroLabel lblCliente;
        private MetroFramework.Controls.MetroComboBox BoxEmpleado;
        private MetroFramework.Controls.MetroTile tileEmpleado;
        private MetroFramework.Controls.MetroLabel lblEmpleado;
        private MetroFramework.Controls.MetroDateTime DateFecha;
        private MetroFramework.Controls.MetroTile tileFecha;
        private MetroFramework.Controls.MetroLabel lblFecha;
        private MetroFramework.Controls.MetroButton BtnAgregarP;
        private MetroFramework.Controls.MetroButton BtnVolver;
        private MetroFramework.Controls.MetroButton BtnMod;
        private MetroFramework.Controls.MetroButton BtnEliminarP;
        private MetroFramework.Controls.MetroButton BtnEditarP;
    }
}

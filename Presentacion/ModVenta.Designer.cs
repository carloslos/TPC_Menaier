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
            this.tileTotal = new MetroFramework.Controls.MetroTile();
            this.lblTotal = new MetroFramework.Controls.MetroLabel();
            this.TxtTotal = new MetroFramework.Controls.MetroTextBox();
            this.BoxProducto = new MetroFramework.Controls.MetroComboBox();
            this.lblProducto = new MetroFramework.Controls.MetroLabel();
            this.tileProducto = new MetroFramework.Controls.MetroTile();
            this.tileCantidad = new MetroFramework.Controls.MetroTile();
            this.lblCantidad = new MetroFramework.Controls.MetroLabel();
            this.TxtCantidad = new MetroFramework.Controls.MetroTextBox();
            this.IdPxv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.tileCliente.SuspendLayout();
            this.tileEmpleado.SuspendLayout();
            this.tileFecha.SuspendLayout();
            this.tileTotal.SuspendLayout();
            this.tileProducto.SuspendLayout();
            this.tileCantidad.SuspendLayout();
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
            this.dgvVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPxv,
            this.IdVenta,
            this.Producto,
            this.Cantidad,
            this.PrecioU,
            this.PrecioT});
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
            this.dgvVenta.Size = new System.Drawing.Size(576, 475);
            this.dgvVenta.TabIndex = 13;
            this.dgvVenta.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // BoxCliente
            // 
            this.BoxCliente.FormattingEnabled = true;
            this.BoxCliente.ItemHeight = 23;
            this.BoxCliente.Location = new System.Drawing.Point(758, 114);
            this.BoxCliente.Name = "BoxCliente";
            this.BoxCliente.Size = new System.Drawing.Size(177, 29);
            this.BoxCliente.TabIndex = 57;
            this.BoxCliente.UseSelectable = true;
            this.BoxCliente.SelectedValueChanged += new System.EventHandler(this.BoxCliente_SelectedValueChanged);
            // 
            // tileCliente
            // 
            this.tileCliente.ActiveControl = null;
            this.tileCliente.Controls.Add(this.lblCliente);
            this.tileCliente.Enabled = false;
            this.tileCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileCliente.Location = new System.Drawing.Point(658, 114);
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
            this.BoxEmpleado.Location = new System.Drawing.Point(758, 173);
            this.BoxEmpleado.Name = "BoxEmpleado";
            this.BoxEmpleado.Size = new System.Drawing.Size(177, 29);
            this.BoxEmpleado.TabIndex = 59;
            this.BoxEmpleado.UseSelectable = true;
            this.BoxEmpleado.SelectedValueChanged += new System.EventHandler(this.BoxEmpleado_SelectedValueChanged);
            // 
            // tileEmpleado
            // 
            this.tileEmpleado.ActiveControl = null;
            this.tileEmpleado.Controls.Add(this.lblEmpleado);
            this.tileEmpleado.Enabled = false;
            this.tileEmpleado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileEmpleado.Location = new System.Drawing.Point(658, 173);
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
            this.DateFecha.Location = new System.Drawing.Point(758, 232);
            this.DateFecha.MaxDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.DateFecha.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DateFecha.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateFecha.Name = "DateFecha";
            this.DateFecha.Size = new System.Drawing.Size(177, 29);
            this.DateFecha.TabIndex = 61;
            this.DateFecha.Value = new System.DateTime(2018, 11, 11, 0, 0, 0, 0);
            this.DateFecha.ValueChanged += new System.EventHandler(this.DateFecha_ValueChanged);
            // 
            // tileFecha
            // 
            this.tileFecha.ActiveControl = null;
            this.tileFecha.Controls.Add(this.lblFecha);
            this.tileFecha.Enabled = false;
            this.tileFecha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileFecha.Location = new System.Drawing.Point(658, 232);
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
            this.BtnAgregarP.Location = new System.Drawing.Point(686, 423);
            this.BtnAgregarP.Name = "BtnAgregarP";
            this.BtnAgregarP.Size = new System.Drawing.Size(104, 23);
            this.BtnAgregarP.TabIndex = 65;
            this.BtnAgregarP.Text = "Agregar Producto";
            this.BtnAgregarP.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnAgregarP.UseSelectable = true;
            this.BtnAgregarP.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnVolver
            // 
            this.BtnVolver.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnVolver.Location = new System.Drawing.Point(813, 519);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(123, 32);
            this.BtnVolver.TabIndex = 64;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnVolver.UseSelectable = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
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
            this.BtnMod.Click += new System.EventHandler(this.BtnMod_Click);
            // 
            // BtnEliminarP
            // 
            this.BtnEliminarP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnEliminarP.Location = new System.Drawing.Point(796, 423);
            this.BtnEliminarP.Name = "BtnEliminarP";
            this.BtnEliminarP.Size = new System.Drawing.Size(104, 23);
            this.BtnEliminarP.TabIndex = 66;
            this.BtnEliminarP.Text = "Eliminar Producto";
            this.BtnEliminarP.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnEliminarP.UseSelectable = true;
            this.BtnEliminarP.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // tileTotal
            // 
            this.tileTotal.ActiveControl = null;
            this.tileTotal.Controls.Add(this.lblTotal);
            this.tileTotal.Enabled = false;
            this.tileTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileTotal.Location = new System.Drawing.Point(363, 544);
            this.tileTotal.Name = "tileTotal";
            this.tileTotal.Size = new System.Drawing.Size(74, 20);
            this.tileTotal.Style = MetroFramework.MetroColorStyle.Silver;
            this.tileTotal.TabIndex = 69;
            this.tileTotal.UseSelectable = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Enabled = false;
            this.lblTotal.Location = new System.Drawing.Point(27, 1);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(38, 19);
            this.lblTotal.Style = MetroFramework.MetroColorStyle.Silver;
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total";
            // 
            // TxtTotal
            // 
            // 
            // 
            // 
            this.TxtTotal.CustomButton.Image = null;
            this.TxtTotal.CustomButton.Location = new System.Drawing.Point(117, 2);
            this.TxtTotal.CustomButton.Name = "";
            this.TxtTotal.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TxtTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtTotal.CustomButton.TabIndex = 1;
            this.TxtTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtTotal.CustomButton.UseSelectable = true;
            this.TxtTotal.CustomButton.Visible = false;
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Lines = new string[0];
            this.TxtTotal.Location = new System.Drawing.Point(432, 544);
            this.TxtTotal.MaxLength = 60;
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.PasswordChar = '\0';
            this.TxtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtTotal.SelectedText = "";
            this.TxtTotal.SelectionLength = 0;
            this.TxtTotal.SelectionStart = 0;
            this.TxtTotal.ShortcutsEnabled = true;
            this.TxtTotal.Size = new System.Drawing.Size(135, 20);
            this.TxtTotal.TabIndex = 68;
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtTotal.UseSelectable = true;
            this.TxtTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BoxProducto
            // 
            this.BoxProducto.FormattingEnabled = true;
            this.BoxProducto.ItemHeight = 23;
            this.BoxProducto.Location = new System.Drawing.Point(758, 340);
            this.BoxProducto.Name = "BoxProducto";
            this.BoxProducto.Size = new System.Drawing.Size(177, 29);
            this.BoxProducto.TabIndex = 70;
            this.BoxProducto.UseSelectable = true;
            this.BoxProducto.SelectedValueChanged += new System.EventHandler(this.BoxProducto_SelectedValueChanged);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Enabled = false;
            this.lblProducto.Location = new System.Drawing.Point(16, 6);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(63, 19);
            this.lblProducto.TabIndex = 5;
            this.lblProducto.Text = "Producto";
            // 
            // tileProducto
            // 
            this.tileProducto.ActiveControl = null;
            this.tileProducto.Controls.Add(this.lblProducto);
            this.tileProducto.Enabled = false;
            this.tileProducto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileProducto.Location = new System.Drawing.Point(658, 340);
            this.tileProducto.Name = "tileProducto";
            this.tileProducto.Size = new System.Drawing.Size(104, 29);
            this.tileProducto.TabIndex = 71;
            this.tileProducto.UseSelectable = true;
            // 
            // tileCantidad
            // 
            this.tileCantidad.ActiveControl = null;
            this.tileCantidad.Controls.Add(this.lblCantidad);
            this.tileCantidad.Enabled = false;
            this.tileCantidad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileCantidad.Location = new System.Drawing.Point(658, 384);
            this.tileCantidad.Name = "tileCantidad";
            this.tileCantidad.Size = new System.Drawing.Size(100, 20);
            this.tileCantidad.TabIndex = 73;
            this.tileCantidad.UseSelectable = true;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Enabled = false;
            this.lblCantidad.Location = new System.Drawing.Point(31, 1);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(62, 19);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad";
            // 
            // TxtCantidad
            // 
            // 
            // 
            // 
            this.TxtCantidad.CustomButton.Image = null;
            this.TxtCantidad.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.TxtCantidad.CustomButton.Name = "";
            this.TxtCantidad.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TxtCantidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtCantidad.CustomButton.TabIndex = 1;
            this.TxtCantidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtCantidad.CustomButton.UseSelectable = true;
            this.TxtCantidad.CustomButton.Visible = false;
            this.TxtCantidad.Lines = new string[0];
            this.TxtCantidad.Location = new System.Drawing.Point(758, 384);
            this.TxtCantidad.MaxLength = 60;
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.PasswordChar = '\0';
            this.TxtCantidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtCantidad.SelectedText = "";
            this.TxtCantidad.SelectionLength = 0;
            this.TxtCantidad.SelectionStart = 0;
            this.TxtCantidad.ShortcutsEnabled = true;
            this.TxtCantidad.Size = new System.Drawing.Size(177, 20);
            this.TxtCantidad.TabIndex = 72;
            this.TxtCantidad.UseSelectable = true;
            this.TxtCantidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtCantidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtCantidad.TextChanged += new System.EventHandler(this.TxtCantidad_TextChanged);
            // 
            // IdPxv
            // 
            this.IdPxv.DataPropertyName = "IdPxv";
            this.IdPxv.HeaderText = "ID";
            this.IdPxv.Name = "IdPxv";
            this.IdPxv.ReadOnly = true;
            // 
            // IdVenta
            // 
            this.IdVenta.DataPropertyName = "IdVenta";
            this.IdVenta.HeaderText = "IdVenta";
            this.IdVenta.Name = "IdVenta";
            this.IdVenta.ReadOnly = true;
            this.IdVenta.Visible = false;
            // 
            // Producto
            // 
            this.Producto.DataPropertyName = "Producto";
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // PrecioU
            // 
            this.PrecioU.DataPropertyName = "PrecioU";
            this.PrecioU.HeaderText = "Monto x Unidad";
            this.PrecioU.Name = "PrecioU";
            this.PrecioU.ReadOnly = true;
            // 
            // PrecioT
            // 
            this.PrecioT.DataPropertyName = "PrecioT";
            this.PrecioT.HeaderText = "Monto Total";
            this.PrecioT.Name = "PrecioT";
            this.PrecioT.ReadOnly = true;
            // 
            // ModVenta
            // 
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.dgvVenta);
            this.Controls.Add(this.tileCantidad);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.BoxProducto);
            this.Controls.Add(this.tileProducto);
            this.Controls.Add(this.tileTotal);
            this.Controls.Add(this.TxtTotal);
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
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "ModVenta";
            this.Text = "Venta";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.ModVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.tileCliente.ResumeLayout(false);
            this.tileCliente.PerformLayout();
            this.tileEmpleado.ResumeLayout(false);
            this.tileEmpleado.PerformLayout();
            this.tileFecha.ResumeLayout(false);
            this.tileFecha.PerformLayout();
            this.tileTotal.ResumeLayout(false);
            this.tileTotal.PerformLayout();
            this.tileProducto.ResumeLayout(false);
            this.tileProducto.PerformLayout();
            this.tileCantidad.ResumeLayout(false);
            this.tileCantidad.PerformLayout();
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
        private MetroFramework.Controls.MetroTile tileTotal;
        private MetroFramework.Controls.MetroLabel lblTotal;
        private MetroFramework.Controls.MetroTextBox TxtTotal;
        private MetroFramework.Controls.MetroComboBox BoxProducto;
        private MetroFramework.Controls.MetroLabel lblProducto;
        private MetroFramework.Controls.MetroTile tileProducto;
        private MetroFramework.Controls.MetroTile tileCantidad;
        private MetroFramework.Controls.MetroLabel lblCantidad;
        private MetroFramework.Controls.MetroTextBox TxtCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPxv;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioU;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioT;
    }
}

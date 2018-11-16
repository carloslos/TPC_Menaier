namespace Presentacion
{
    partial class ModCompra
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
            this.tileTotal = new MetroFramework.Controls.MetroTile();
            this.lblTotal = new MetroFramework.Controls.MetroLabel();
            this.tileFechaCompra = new MetroFramework.Controls.MetroTile();
            this.lblFechaCompra = new MetroFramework.Controls.MetroLabel();
            this.tileProveedor = new MetroFramework.Controls.MetroTile();
            this.lblProveedor = new MetroFramework.Controls.MetroLabel();
            this.BoxProveedor = new MetroFramework.Controls.MetroComboBox();
            this.DateCompra = new MetroFramework.Controls.MetroDateTime();
            this.BtnVolver = new MetroFramework.Controls.MetroButton();
            this.BtnMod = new MetroFramework.Controls.MetroButton();
            this.dgvLotes = new MetroFramework.Controls.MetroGrid();
            this.IdLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadesP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadesE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEditar = new MetroFramework.Controls.MetroButton();
            this.BtnAgregar = new MetroFramework.Controls.MetroButton();
            this.BtnEliminar = new MetroFramework.Controls.MetroButton();
            this.TxtTotal = new MetroFramework.Controls.MetroTextBox();
            this.tileTotal.SuspendLayout();
            this.tileFechaCompra.SuspendLayout();
            this.tileProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotes)).BeginInit();
            this.SuspendLayout();
            // 
            // tileTotal
            // 
            this.tileTotal.ActiveControl = null;
            this.tileTotal.Controls.Add(this.lblTotal);
            this.tileTotal.Enabled = false;
            this.tileTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileTotal.Location = new System.Drawing.Point(464, 482);
            this.tileTotal.Name = "tileTotal";
            this.tileTotal.Size = new System.Drawing.Size(74, 20);
            this.tileTotal.Style = MetroFramework.MetroColorStyle.Silver;
            this.tileTotal.TabIndex = 46;
            this.tileTotal.UseSelectable = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Enabled = false;
            this.lblTotal.Location = new System.Drawing.Point(27, 1);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(36, 19);
            this.lblTotal.Style = MetroFramework.MetroColorStyle.Silver;
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total";
            // 
            // tileFechaCompra
            // 
            this.tileFechaCompra.ActiveControl = null;
            this.tileFechaCompra.Controls.Add(this.lblFechaCompra);
            this.tileFechaCompra.Enabled = false;
            this.tileFechaCompra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileFechaCompra.Location = new System.Drawing.Point(752, 308);
            this.tileFechaCompra.Name = "tileFechaCompra";
            this.tileFechaCompra.Size = new System.Drawing.Size(100, 29);
            this.tileFechaCompra.TabIndex = 44;
            this.tileFechaCompra.UseSelectable = true;
            // 
            // lblFechaCompra
            // 
            this.lblFechaCompra.AutoSize = true;
            this.lblFechaCompra.Enabled = false;
            this.lblFechaCompra.Location = new System.Drawing.Point(47, 8);
            this.lblFechaCompra.Name = "lblFechaCompra";
            this.lblFechaCompra.Size = new System.Drawing.Size(43, 19);
            this.lblFechaCompra.TabIndex = 5;
            this.lblFechaCompra.Text = "Fecha";
            // 
            // tileProveedor
            // 
            this.tileProveedor.ActiveControl = null;
            this.tileProveedor.Controls.Add(this.lblProveedor);
            this.tileProveedor.Enabled = false;
            this.tileProveedor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileProveedor.Location = new System.Drawing.Point(752, 214);
            this.tileProveedor.Name = "tileProveedor";
            this.tileProveedor.Size = new System.Drawing.Size(100, 29);
            this.tileProveedor.TabIndex = 43;
            this.tileProveedor.UseSelectable = true;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Enabled = false;
            this.lblProveedor.Location = new System.Drawing.Point(19, 8);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(71, 19);
            this.lblProveedor.TabIndex = 5;
            this.lblProveedor.Text = "Proveedor";
            // 
            // BoxProveedor
            // 
            this.BoxProveedor.FormattingEnabled = true;
            this.BoxProveedor.ItemHeight = 23;
            this.BoxProveedor.Location = new System.Drawing.Point(848, 214);
            this.BoxProveedor.Name = "BoxProveedor";
            this.BoxProveedor.Size = new System.Drawing.Size(142, 29);
            this.BoxProveedor.TabIndex = 0;
            this.BoxProveedor.UseSelectable = true;
            this.BoxProveedor.SelectedValueChanged += new System.EventHandler(this.BoxProveedor_SelectedValueChanged);
            // 
            // DateCompra
            // 
            this.DateCompra.CustomFormat = "dd/mm/yyyy";
            this.DateCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateCompra.Location = new System.Drawing.Point(848, 308);
            this.DateCompra.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateCompra.Name = "DateCompra";
            this.DateCompra.Size = new System.Drawing.Size(142, 29);
            this.DateCompra.TabIndex = 1;
            this.DateCompra.Value = new System.DateTime(2018, 11, 11, 0, 0, 0, 0);
            this.DateCompra.ValueChanged += new System.EventHandler(this.DateCompra_ValueChanged);
            // 
            // BtnVolver
            // 
            this.BtnVolver.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnVolver.Location = new System.Drawing.Point(532, 554);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(104, 28);
            this.BtnVolver.TabIndex = 6;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnVolver.UseSelectable = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // BtnMod
            // 
            this.BtnMod.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnMod.Location = new System.Drawing.Point(388, 554);
            this.BtnMod.Name = "BtnMod";
            this.BtnMod.Size = new System.Drawing.Size(104, 28);
            this.BtnMod.TabIndex = 5;
            this.BtnMod.Text = "Mod";
            this.BtnMod.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnMod.UseSelectable = true;
            this.BtnMod.Click += new System.EventHandler(this.BtnMod_Click);
            // 
            // dgvLotes
            // 
            this.dgvLotes.AllowUserToAddRows = false;
            this.dgvLotes.AllowUserToDeleteRows = false;
            this.dgvLotes.AllowUserToResizeRows = false;
            this.dgvLotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLotes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvLotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLotes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLotes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLote,
            this.IdCompra,
            this.Producto,
            this.UnidadesP,
            this.UnidadesE,
            this.CostoPU,
            this.CostoT,
            this.Activo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLotes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLotes.EnableHeadersVisualStyles = false;
            this.dgvLotes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvLotes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvLotes.Location = new System.Drawing.Point(23, 63);
            this.dgvLotes.MultiSelect = false;
            this.dgvLotes.Name = "dgvLotes";
            this.dgvLotes.ReadOnly = true;
            this.dgvLotes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLotes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLotes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLotes.Size = new System.Drawing.Size(697, 413);
            this.dgvLotes.TabIndex = 13;
            this.dgvLotes.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvLotes.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DgvLotes_RowsAdded);
            this.dgvLotes.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DgvLotes_RowsRemoved);
            // 
            // IdLote
            // 
            this.IdLote.DataPropertyName = "IdLote";
            this.IdLote.HeaderText = "ID";
            this.IdLote.Name = "IdLote";
            this.IdLote.ReadOnly = true;
            // 
            // IdCompra
            // 
            this.IdCompra.DataPropertyName = "IdCompra";
            this.IdCompra.HeaderText = "IdCompra";
            this.IdCompra.Name = "IdCompra";
            this.IdCompra.ReadOnly = true;
            this.IdCompra.Visible = false;
            // 
            // Producto
            // 
            this.Producto.DataPropertyName = "Producto";
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // UnidadesP
            // 
            this.UnidadesP.DataPropertyName = "UnidadesP";
            this.UnidadesP.HeaderText = "U. Pedidas";
            this.UnidadesP.Name = "UnidadesP";
            this.UnidadesP.ReadOnly = true;
            // 
            // UnidadesE
            // 
            this.UnidadesE.DataPropertyName = "UnidadesE";
            this.UnidadesE.HeaderText = "U. Existentes";
            this.UnidadesE.Name = "UnidadesE";
            this.UnidadesE.ReadOnly = true;
            // 
            // CostoPU
            // 
            this.CostoPU.DataPropertyName = "CostoPU";
            this.CostoPU.HeaderText = "Costo x Unidad";
            this.CostoPU.Name = "CostoPU";
            this.CostoPU.ReadOnly = true;
            // 
            // CostoT
            // 
            this.CostoT.DataPropertyName = "CostoT";
            this.CostoT.HeaderText = "Costo Total";
            this.CostoT.Name = "CostoT";
            this.CostoT.ReadOnly = true;
            // 
            // Activo
            // 
            this.Activo.DataPropertyName = "Activo";
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Visible = false;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnEditar.Location = new System.Drawing.Point(121, 483);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(92, 23);
            this.BtnEditar.TabIndex = 3;
            this.BtnEditar.Text = "Editar Lote";
            this.BtnEditar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnEditar.UseSelectable = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnAgregar.Location = new System.Drawing.Point(23, 482);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(92, 23);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "Agregar Lote";
            this.BtnAgregar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnAgregar.UseSelectable = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnEliminar.Location = new System.Drawing.Point(219, 483);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(92, 23);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "Eliminar Lote";
            this.BtnEliminar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnEliminar.UseSelectable = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
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
            this.TxtTotal.Location = new System.Drawing.Point(533, 482);
            this.TxtTotal.MaxLength = 60;
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.PasswordChar = '\0';
            this.TxtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtTotal.SelectedText = "";
            this.TxtTotal.SelectionLength = 0;
            this.TxtTotal.SelectionStart = 0;
            this.TxtTotal.ShortcutsEnabled = true;
            this.TxtTotal.Size = new System.Drawing.Size(135, 20);
            this.TxtTotal.TabIndex = 45;
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtTotal.UseSelectable = true;
            this.TxtTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ModCompra
            // 
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.dgvLotes);
            this.Controls.Add(this.tileTotal);
            this.Controls.Add(this.tileFechaCompra);
            this.Controls.Add(this.tileProveedor);
            this.Controls.Add(this.BoxProveedor);
            this.Controls.Add(this.DateCompra);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnMod);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.TxtTotal);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "ModCompra";
            this.Text = "Compra";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.ModCompra_Load);
            this.tileTotal.ResumeLayout(false);
            this.tileTotal.PerformLayout();
            this.tileFechaCompra.ResumeLayout(false);
            this.tileFechaCompra.PerformLayout();
            this.tileProveedor.ResumeLayout(false);
            this.tileProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvLotes;
        private MetroFramework.Controls.MetroButton BtnEditar;
        private MetroFramework.Controls.MetroButton BtnAgregar;
        private MetroFramework.Controls.MetroButton BtnEliminar;
        private MetroFramework.Controls.MetroButton BtnMod;
        private MetroFramework.Controls.MetroButton BtnVolver;
        private MetroFramework.Controls.MetroDateTime DateCompra;
        private MetroFramework.Controls.MetroComboBox BoxProveedor;
        private MetroFramework.Controls.MetroTile tileProveedor;
        private MetroFramework.Controls.MetroLabel lblProveedor;
        private MetroFramework.Controls.MetroTile tileFechaCompra;
        private MetroFramework.Controls.MetroLabel lblFechaCompra;
        private MetroFramework.Controls.MetroTextBox TxtTotal;
        private MetroFramework.Controls.MetroTile tileTotal;
        private MetroFramework.Controls.MetroLabel lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadesP;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadesE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
    }
}

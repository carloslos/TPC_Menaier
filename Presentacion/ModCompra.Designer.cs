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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLotes = new MetroFramework.Controls.MetroGrid();
            this.BtnEditar = new MetroFramework.Controls.MetroButton();
            this.BtnAgregar = new MetroFramework.Controls.MetroButton();
            this.BtnEliminar = new MetroFramework.Controls.MetroButton();
            this.BtnMod = new MetroFramework.Controls.MetroButton();
            this.BtnVolver = new MetroFramework.Controls.MetroButton();
            this.DateCompra = new MetroFramework.Controls.MetroDateTime();
            this.BoxProveedor = new MetroFramework.Controls.MetroComboBox();
            this.tileProveedor = new MetroFramework.Controls.MetroTile();
            this.lblProveedor = new MetroFramework.Controls.MetroLabel();
            this.tileFechaCompra = new MetroFramework.Controls.MetroTile();
            this.lblFechaCompra = new MetroFramework.Controls.MetroLabel();
            this.TxtTotal = new MetroFramework.Controls.MetroTextBox();
            this.tileTotal = new MetroFramework.Controls.MetroTile();
            this.lblTotal = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotes)).BeginInit();
            this.tileProveedor.SuspendLayout();
            this.tileFechaCompra.SuspendLayout();
            this.tileTotal.SuspendLayout();
            this.SuspendLayout();
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLotes.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLotes.EnableHeadersVisualStyles = false;
            this.dgvLotes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvLotes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvLotes.Location = new System.Drawing.Point(23, 63);
            this.dgvLotes.MultiSelect = false;
            this.dgvLotes.Name = "dgvLotes";
            this.dgvLotes.ReadOnly = true;
            this.dgvLotes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLotes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLotes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLotes.Size = new System.Drawing.Size(697, 413);
            this.dgvLotes.TabIndex = 13;
            this.dgvLotes.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dgvLotes.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DgvLotes_RowsAdded);
            this.dgvLotes.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DgvLotes_RowsRemoved);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnEditar.Location = new System.Drawing.Point(121, 482);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.TabIndex = 14;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnEditar.UseSelectable = true;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnAgregar.Location = new System.Drawing.Point(23, 482);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 12;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnAgregar.UseSelectable = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnEliminar.Location = new System.Drawing.Point(219, 482);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 11;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnEliminar.UseSelectable = true;
            // 
            // BtnMod
            // 
            this.BtnMod.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnMod.Location = new System.Drawing.Point(421, 556);
            this.BtnMod.Name = "BtnMod";
            this.BtnMod.Size = new System.Drawing.Size(75, 23);
            this.BtnMod.TabIndex = 15;
            this.BtnMod.Text = "Mod";
            this.BtnMod.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnMod.UseSelectable = true;
            // 
            // BtnVolver
            // 
            this.BtnVolver.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnVolver.Location = new System.Drawing.Point(529, 556);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(75, 23);
            this.BtnVolver.TabIndex = 16;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnVolver.UseSelectable = true;
            // 
            // DateCompra
            // 
            this.DateCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateCompra.Location = new System.Drawing.Point(848, 308);
            this.DateCompra.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateCompra.Name = "DateCompra";
            this.DateCompra.Size = new System.Drawing.Size(142, 29);
            this.DateCompra.TabIndex = 17;
            // 
            // BoxProveedor
            // 
            this.BoxProveedor.FormattingEnabled = true;
            this.BoxProveedor.ItemHeight = 23;
            this.BoxProveedor.Location = new System.Drawing.Point(848, 214);
            this.BoxProveedor.Name = "BoxProveedor";
            this.BoxProveedor.Size = new System.Drawing.Size(142, 29);
            this.BoxProveedor.TabIndex = 18;
            this.BoxProveedor.UseSelectable = true;
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
            this.TxtTotal.Lines = new string[0];
            this.TxtTotal.Location = new System.Drawing.Point(482, 482);
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
            this.TxtTotal.UseSelectable = true;
            this.TxtTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tileTotal
            // 
            this.tileTotal.ActiveControl = null;
            this.tileTotal.Controls.Add(this.lblTotal);
            this.tileTotal.Enabled = false;
            this.tileTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileTotal.Location = new System.Drawing.Point(413, 482);
            this.tileTotal.Name = "tileTotal";
            this.tileTotal.Size = new System.Drawing.Size(74, 20);
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
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total";
            // 
            // ModCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.tileTotal);
            this.Controls.Add(this.tileFechaCompra);
            this.Controls.Add(this.tileProveedor);
            this.Controls.Add(this.BoxProveedor);
            this.Controls.Add(this.DateCompra);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnMod);
            this.Controls.Add(this.dgvLotes);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.TxtTotal);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "ModCompra";
            this.Text = "Compra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLotes)).EndInit();
            this.tileProveedor.ResumeLayout(false);
            this.tileProveedor.PerformLayout();
            this.tileFechaCompra.ResumeLayout(false);
            this.tileFechaCompra.PerformLayout();
            this.tileTotal.ResumeLayout(false);
            this.tileTotal.PerformLayout();
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
    }
}

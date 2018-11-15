namespace Presentacion
{
    partial class ProductosProv
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnVolver = new MetroFramework.Controls.MetroButton();
            this.dgvProductos = new MetroFramework.Controls.MetroGrid();
            this.dgvProductosProv = new MetroFramework.Controls.MetroGrid();
            this.tileProductos = new MetroFramework.Controls.MetroTile();
            this.lblProductos = new MetroFramework.Controls.MetroLabel();
            this.tileProveedor = new MetroFramework.Controls.MetroTile();
            this.lblProveedor = new MetroFramework.Controls.MetroLabel();
            this.BtnQuitar = new MetroFramework.Controls.MetroButton();
            this.BtnAgregar = new MetroFramework.Controls.MetroButton();
            this.BtnAceptar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosProv)).BeginInit();
            this.tileProductos.SuspendLayout();
            this.tileProveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnVolver
            // 
            this.BtnVolver.Location = new System.Drawing.Point(494, 525);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(50, 50);
            this.BtnVolver.TabIndex = 55;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnVolver.UseSelectable = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvProductos.Location = new System.Drawing.Point(584, 122);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(430, 455);
            this.dgvProductos.TabIndex = 32;
            this.dgvProductos.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dgvProductosProv
            // 
            this.dgvProductosProv.AllowUserToAddRows = false;
            this.dgvProductosProv.AllowUserToDeleteRows = false;
            this.dgvProductosProv.AllowUserToResizeRows = false;
            this.dgvProductosProv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductosProv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductosProv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvProductosProv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductosProv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProductosProv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductosProv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvProductosProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductosProv.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvProductosProv.EnableHeadersVisualStyles = false;
            this.dgvProductosProv.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvProductosProv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvProductosProv.Location = new System.Drawing.Point(23, 122);
            this.dgvProductosProv.MultiSelect = false;
            this.dgvProductosProv.Name = "dgvProductosProv";
            this.dgvProductosProv.ReadOnly = true;
            this.dgvProductosProv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductosProv.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvProductosProv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProductosProv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosProv.Size = new System.Drawing.Size(430, 455);
            this.dgvProductosProv.TabIndex = 28;
            this.dgvProductosProv.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tileProductos
            // 
            this.tileProductos.ActiveControl = null;
            this.tileProductos.Controls.Add(this.lblProductos);
            this.tileProductos.Enabled = false;
            this.tileProductos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileProductos.Location = new System.Drawing.Point(584, 96);
            this.tileProductos.Name = "tileProductos";
            this.tileProductos.Size = new System.Drawing.Size(116, 20);
            this.tileProductos.TabIndex = 54;
            this.tileProductos.UseSelectable = true;
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Enabled = false;
            this.lblProductos.Location = new System.Drawing.Point(48, 1);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(68, 19);
            this.lblProductos.TabIndex = 5;
            this.lblProductos.Text = "Productos";
            // 
            // tileProveedor
            // 
            this.tileProveedor.ActiveControl = null;
            this.tileProveedor.Controls.Add(this.lblProveedor);
            this.tileProveedor.Enabled = false;
            this.tileProveedor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileProveedor.Location = new System.Drawing.Point(23, 96);
            this.tileProveedor.Name = "tileProveedor";
            this.tileProveedor.Size = new System.Drawing.Size(116, 20);
            this.tileProveedor.TabIndex = 53;
            this.tileProveedor.UseSelectable = true;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Enabled = false;
            this.lblProveedor.Location = new System.Drawing.Point(34, 1);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(71, 19);
            this.lblProveedor.TabIndex = 0;
            this.lblProveedor.Text = "Proveedor";
            // 
            // BtnQuitar
            // 
            this.BtnQuitar.Location = new System.Drawing.Point(494, 347);
            this.BtnQuitar.Name = "BtnQuitar";
            this.BtnQuitar.Size = new System.Drawing.Size(50, 50);
            this.BtnQuitar.TabIndex = 34;
            this.BtnQuitar.Text = ">";
            this.BtnQuitar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnQuitar.UseSelectable = true;
            this.BtnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(494, 258);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(50, 50);
            this.BtnAgregar.TabIndex = 33;
            this.BtnAgregar.Text = "<";
            this.BtnAgregar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnAgregar.UseSelectable = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(494, 436);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(50, 50);
            this.BtnAceptar.TabIndex = 56;
            this.BtnAceptar.Text = "Guardar";
            this.BtnAceptar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnAceptar.UseSelectable = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // ProductosProv
            // 
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.dgvProductosProv);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.tileProductos);
            this.Controls.Add(this.tileProveedor);
            this.Controls.Add(this.BtnQuitar);
            this.Controls.Add(this.BtnAgregar);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "ProductosProv";
            this.Text = "Productos por Proveedor";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.ProductosProv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosProv)).EndInit();
            this.tileProductos.ResumeLayout(false);
            this.tileProductos.PerformLayout();
            this.tileProveedor.ResumeLayout(false);
            this.tileProveedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvProductosProv;
        private MetroFramework.Controls.MetroGrid dgvProductos;
        private MetroFramework.Controls.MetroButton BtnAgregar;
        private MetroFramework.Controls.MetroButton BtnQuitar;
        private MetroFramework.Controls.MetroLabel lblProveedor;
        private MetroFramework.Controls.MetroTile tileProductos;
        private MetroFramework.Controls.MetroLabel lblProductos;
        private MetroFramework.Controls.MetroTile tileProveedor;
        private MetroFramework.Controls.MetroButton BtnVolver;
        private MetroFramework.Controls.MetroButton BtnAceptar;
    }
}

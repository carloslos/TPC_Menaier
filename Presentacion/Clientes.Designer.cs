namespace Presentacion
{
    partial class Clientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RadClientesE = new MetroFramework.Controls.MetroRadioButton();
            this.RadClientesP = new MetroFramework.Controls.MetroRadioButton();
            this.BtnEditarP = new MetroFramework.Controls.MetroButton();
            this.dgvClientesP = new MetroFramework.Controls.MetroGrid();
            this.BtnEliminarP = new MetroFramework.Controls.MetroButton();
            this.BtnDetallesP = new MetroFramework.Controls.MetroButton();
            this.BtnAgregarP = new MetroFramework.Controls.MetroButton();
            this.BtnEditarE = new MetroFramework.Controls.MetroButton();
            this.dgvClientesE = new MetroFramework.Controls.MetroGrid();
            this.BtnEliminarE = new MetroFramework.Controls.MetroButton();
            this.BtnContactosE = new MetroFramework.Controls.MetroButton();
            this.BtnAgregarE = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesE)).BeginInit();
            this.SuspendLayout();
            // 
            // RadClientesE
            // 
            this.RadClientesE.AutoSize = true;
            this.RadClientesE.Location = new System.Drawing.Point(117, 42);
            this.RadClientesE.Name = "RadClientesE";
            this.RadClientesE.Size = new System.Drawing.Size(73, 15);
            this.RadClientesE.TabIndex = 0;
            this.RadClientesE.Text = "Empresas";
            this.RadClientesE.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RadClientesE.UseSelectable = true;
            this.RadClientesE.CheckedChanged += new System.EventHandler(this.RadClientesE_CheckedChanged);
            // 
            // RadClientesP
            // 
            this.RadClientesP.AutoSize = true;
            this.RadClientesP.Location = new System.Drawing.Point(117, 21);
            this.RadClientesP.Name = "RadClientesP";
            this.RadClientesP.Size = new System.Drawing.Size(84, 15);
            this.RadClientesP.TabIndex = 1;
            this.RadClientesP.Text = "Particulares";
            this.RadClientesP.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RadClientesP.UseSelectable = true;
            this.RadClientesP.CheckedChanged += new System.EventHandler(this.RadClientesP_CheckedChanged);
            // 
            // BtnEditarP
            // 
            this.BtnEditarP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnEditarP.Location = new System.Drawing.Point(378, 563);
            this.BtnEditarP.Name = "BtnEditarP";
            this.BtnEditarP.Size = new System.Drawing.Size(118, 23);
            this.BtnEditarP.TabIndex = 28;
            this.BtnEditarP.Text = "Editar";
            this.BtnEditarP.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnEditarP.UseSelectable = true;
            this.BtnEditarP.Click += new System.EventHandler(this.BtnEditarP_Click);
            // 
            // dgvClientesP
            // 
            this.dgvClientesP.AllowUserToAddRows = false;
            this.dgvClientesP.AllowUserToDeleteRows = false;
            this.dgvClientesP.AllowUserToResizeRows = false;
            this.dgvClientesP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientesP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientesP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvClientesP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientesP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvClientesP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientesP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvClientesP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientesP.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvClientesP.EnableHeadersVisualStyles = false;
            this.dgvClientesP.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvClientesP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvClientesP.Location = new System.Drawing.Point(23, 63);
            this.dgvClientesP.MultiSelect = false;
            this.dgvClientesP.Name = "dgvClientesP";
            this.dgvClientesP.ReadOnly = true;
            this.dgvClientesP.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientesP.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvClientesP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvClientesP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientesP.Size = new System.Drawing.Size(978, 476);
            this.dgvClientesP.TabIndex = 27;
            this.dgvClientesP.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // BtnEliminarP
            // 
            this.BtnEliminarP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnEliminarP.Location = new System.Drawing.Point(678, 563);
            this.BtnEliminarP.Name = "BtnEliminarP";
            this.BtnEliminarP.Size = new System.Drawing.Size(118, 23);
            this.BtnEliminarP.TabIndex = 26;
            this.BtnEliminarP.Text = "Eliminar";
            this.BtnEliminarP.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnEliminarP.UseSelectable = true;
            this.BtnEliminarP.Click += new System.EventHandler(this.BtnEliminarP_Click);
            // 
            // BtnDetallesP
            // 
            this.BtnDetallesP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnDetallesP.Location = new System.Drawing.Point(528, 563);
            this.BtnDetallesP.Name = "BtnDetallesP";
            this.BtnDetallesP.Size = new System.Drawing.Size(118, 23);
            this.BtnDetallesP.TabIndex = 25;
            this.BtnDetallesP.Text = "Detalles";
            this.BtnDetallesP.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnDetallesP.UseSelectable = true;
            this.BtnDetallesP.Click += new System.EventHandler(this.BtnDetallesP_Click);
            // 
            // BtnAgregarP
            // 
            this.BtnAgregarP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnAgregarP.Location = new System.Drawing.Point(228, 563);
            this.BtnAgregarP.Name = "BtnAgregarP";
            this.BtnAgregarP.Size = new System.Drawing.Size(118, 23);
            this.BtnAgregarP.TabIndex = 24;
            this.BtnAgregarP.Text = "Agregar";
            this.BtnAgregarP.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnAgregarP.UseSelectable = true;
            this.BtnAgregarP.Click += new System.EventHandler(this.BtnAgregarP_Click);
            // 
            // BtnEditarE
            // 
            this.BtnEditarE.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnEditarE.Location = new System.Drawing.Point(378, 563);
            this.BtnEditarE.Name = "BtnEditarE";
            this.BtnEditarE.Size = new System.Drawing.Size(118, 23);
            this.BtnEditarE.TabIndex = 33;
            this.BtnEditarE.Text = "Editar";
            this.BtnEditarE.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnEditarE.UseSelectable = true;
            this.BtnEditarE.Click += new System.EventHandler(this.BtnEditarE_Click);
            // 
            // dgvClientesE
            // 
            this.dgvClientesE.AllowUserToAddRows = false;
            this.dgvClientesE.AllowUserToDeleteRows = false;
            this.dgvClientesE.AllowUserToResizeRows = false;
            this.dgvClientesE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientesE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientesE.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvClientesE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientesE.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvClientesE.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientesE.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvClientesE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientesE.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvClientesE.EnableHeadersVisualStyles = false;
            this.dgvClientesE.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvClientesE.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.dgvClientesE.Location = new System.Drawing.Point(23, 63);
            this.dgvClientesE.MultiSelect = false;
            this.dgvClientesE.Name = "dgvClientesE";
            this.dgvClientesE.ReadOnly = true;
            this.dgvClientesE.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientesE.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvClientesE.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvClientesE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientesE.Size = new System.Drawing.Size(978, 476);
            this.dgvClientesE.TabIndex = 32;
            this.dgvClientesE.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // BtnEliminarE
            // 
            this.BtnEliminarE.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnEliminarE.Location = new System.Drawing.Point(678, 563);
            this.BtnEliminarE.Name = "BtnEliminarE";
            this.BtnEliminarE.Size = new System.Drawing.Size(118, 23);
            this.BtnEliminarE.TabIndex = 31;
            this.BtnEliminarE.Text = "Eliminar";
            this.BtnEliminarE.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnEliminarE.UseSelectable = true;
            this.BtnEliminarE.Click += new System.EventHandler(this.BtnEliminarE_Click);
            // 
            // BtnContactosE
            // 
            this.BtnContactosE.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnContactosE.Location = new System.Drawing.Point(528, 563);
            this.BtnContactosE.Name = "BtnContactosE";
            this.BtnContactosE.Size = new System.Drawing.Size(118, 23);
            this.BtnContactosE.TabIndex = 30;
            this.BtnContactosE.Text = "Contactos";
            this.BtnContactosE.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnContactosE.UseSelectable = true;
            this.BtnContactosE.Click += new System.EventHandler(this.BtnContactosE_Click);
            // 
            // BtnAgregarE
            // 
            this.BtnAgregarE.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnAgregarE.Location = new System.Drawing.Point(228, 563);
            this.BtnAgregarE.Name = "BtnAgregarE";
            this.BtnAgregarE.Size = new System.Drawing.Size(118, 23);
            this.BtnAgregarE.TabIndex = 29;
            this.BtnAgregarE.Text = "Agregar";
            this.BtnAgregarE.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnAgregarE.UseSelectable = true;
            this.BtnAgregarE.Click += new System.EventHandler(this.BtnAgregarE_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.BtnEditarE);
            this.Controls.Add(this.dgvClientesE);
            this.Controls.Add(this.BtnEliminarE);
            this.Controls.Add(this.BtnContactosE);
            this.Controls.Add(this.BtnAgregarE);
            this.Controls.Add(this.BtnEditarP);
            this.Controls.Add(this.dgvClientesP);
            this.Controls.Add(this.BtnEliminarP);
            this.Controls.Add(this.BtnDetallesP);
            this.Controls.Add(this.BtnAgregarP);
            this.Controls.Add(this.RadClientesP);
            this.Controls.Add(this.RadClientesE);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "Clientes";
            this.ShowInTaskbar = false;
            this.Text = "Clientes";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton RadClientesE;
        private MetroFramework.Controls.MetroRadioButton RadClientesP;
        private MetroFramework.Controls.MetroButton BtnEditarP;
        private MetroFramework.Controls.MetroGrid dgvClientesP;
        private MetroFramework.Controls.MetroButton BtnEliminarP;
        private MetroFramework.Controls.MetroButton BtnDetallesP;
        private MetroFramework.Controls.MetroButton BtnAgregarP;
        private MetroFramework.Controls.MetroButton BtnEditarE;
        private MetroFramework.Controls.MetroGrid dgvClientesE;
        private MetroFramework.Controls.MetroButton BtnEliminarE;
        private MetroFramework.Controls.MetroButton BtnContactosE;
        private MetroFramework.Controls.MetroButton BtnAgregarE;
    }
}
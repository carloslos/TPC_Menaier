namespace Presentacion
{
    partial class Proveedores
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
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.btnContactos = new MetroFramework.Controls.MetroButton();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminar.Location = new System.Drawing.Point(507, 516);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(118, 23);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnEliminar.UseSelectable = true;
            // 
            // btnContactos
            // 
            this.btnContactos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnContactos.Location = new System.Drawing.Point(333, 516);
            this.btnContactos.Name = "btnContactos";
            this.btnContactos.Size = new System.Drawing.Size(118, 23);
            this.btnContactos.TabIndex = 16;
            this.btnContactos.Text = "Contactos";
            this.btnContactos.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnContactos.UseSelectable = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregar.Location = new System.Drawing.Point(159, 516);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(118, 23);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAgregar.UseSelectable = true;
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(12, 62);
            this.dgvProveedores.MultiSelect = false;
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.Size = new System.Drawing.Size(760, 439);
            this.dgvProveedores.TabIndex = 14;
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 553);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnContactos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvProveedores);
            this.MinimumSize = new System.Drawing.Size(784, 553);
            this.Name = "Proveedores";
            this.ShowInTaskbar = false;
            this.Text = "Proveedores";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnEliminar;
        private MetroFramework.Controls.MetroButton btnContactos;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private System.Windows.Forms.DataGridView dgvProveedores;
    }
}
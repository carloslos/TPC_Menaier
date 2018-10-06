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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.btnContactos = new MetroFramework.Controls.MetroButton();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 63);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(760, 438);
            this.dgvClientes.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregar.Location = new System.Drawing.Point(159, 516);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(118, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnContactos
            // 
            this.btnContactos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnContactos.Location = new System.Drawing.Point(333, 516);
            this.btnContactos.Name = "btnContactos";
            this.btnContactos.Size = new System.Drawing.Size(118, 23);
            this.btnContactos.TabIndex = 12;
            this.btnContactos.Text = "Contactos";
            this.btnContactos.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnContactos.UseSelectable = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminar.Location = new System.Drawing.Point(507, 516);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(118, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnEliminar.UseSelectable = true;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 553);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnContactos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvClientes);
            this.MinimumSize = new System.Drawing.Size(784, 553);
            this.Name = "Clientes";
            this.ShowInTaskbar = false;
            this.Text = "Clientes";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroButton btnContactos;
        private MetroFramework.Controls.MetroButton btnEliminar;
    }
}
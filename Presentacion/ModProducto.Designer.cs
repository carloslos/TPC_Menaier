namespace Presentacion
{
    partial class ModProducto
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
            this.tileTipoProducto = new MetroFramework.Controls.MetroTile();
            this.lblTipoProducto = new MetroFramework.Controls.MetroLabel();
            this.BoxTipoProducto = new MetroFramework.Controls.MetroComboBox();
            this.TxtDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.tileStockMin = new MetroFramework.Controls.MetroTile();
            this.lblStockMin = new MetroFramework.Controls.MetroLabel();
            this.TxtGanancia = new MetroFramework.Controls.MetroTextBox();
            this.tileGanancia = new MetroFramework.Controls.MetroTile();
            this.lblGanancia = new MetroFramework.Controls.MetroLabel();
            this.TxtStockMin = new MetroFramework.Controls.MetroTextBox();
            this.tileDescripcion = new MetroFramework.Controls.MetroTile();
            this.lblDescripcion = new MetroFramework.Controls.MetroLabel();
            this.BtnVolver = new MetroFramework.Controls.MetroButton();
            this.BtnMod = new MetroFramework.Controls.MetroButton();
            this.tileMarca = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.BoxMarca = new MetroFramework.Controls.MetroComboBox();
            this.tileTipoProducto.SuspendLayout();
            this.tileStockMin.SuspendLayout();
            this.tileGanancia.SuspendLayout();
            this.tileDescripcion.SuspendLayout();
            this.tileMarca.SuspendLayout();
            this.SuspendLayout();
            // 
            // tileTipoProducto
            // 
            this.tileTipoProducto.ActiveControl = null;
            this.tileTipoProducto.Controls.Add(this.lblTipoProducto);
            this.tileTipoProducto.Enabled = false;
            this.tileTipoProducto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileTipoProducto.Location = new System.Drawing.Point(89, 324);
            this.tileTipoProducto.Name = "tileTipoProducto";
            this.tileTipoProducto.Size = new System.Drawing.Size(100, 29);
            this.tileTipoProducto.TabIndex = 54;
            this.tileTipoProducto.UseSelectable = true;
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Enabled = false;
            this.lblTipoProducto.Location = new System.Drawing.Point(1, 7);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(112, 19);
            this.lblTipoProducto.TabIndex = 5;
            this.lblTipoProducto.Text = "Tipo de Producto";
            // 
            // BoxTipoProducto
            // 
            this.BoxTipoProducto.FormattingEnabled = true;
            this.BoxTipoProducto.ItemHeight = 23;
            this.BoxTipoProducto.Items.AddRange(new object[] {
            "Administrador",
            "Supervisor",
            "Vendedor"});
            this.BoxTipoProducto.Location = new System.Drawing.Point(185, 324);
            this.BoxTipoProducto.Name = "BoxTipoProducto";
            this.BoxTipoProducto.Size = new System.Drawing.Size(177, 29);
            this.BoxTipoProducto.TabIndex = 49;
            this.BoxTipoProducto.UseSelectable = true;
            // 
            // TxtDescripcion
            // 
            // 
            // 
            // 
            this.TxtDescripcion.CustomButton.Image = null;
            this.TxtDescripcion.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.TxtDescripcion.CustomButton.Name = "";
            this.TxtDescripcion.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TxtDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtDescripcion.CustomButton.TabIndex = 1;
            this.TxtDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtDescripcion.CustomButton.UseSelectable = true;
            this.TxtDescripcion.CustomButton.Visible = false;
            this.TxtDescripcion.Lines = new string[0];
            this.TxtDescripcion.Location = new System.Drawing.Point(185, 117);
            this.TxtDescripcion.MaxLength = 32767;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.PasswordChar = '\0';
            this.TxtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtDescripcion.SelectedText = "";
            this.TxtDescripcion.SelectionLength = 0;
            this.TxtDescripcion.SelectionStart = 0;
            this.TxtDescripcion.ShortcutsEnabled = true;
            this.TxtDescripcion.Size = new System.Drawing.Size(177, 20);
            this.TxtDescripcion.TabIndex = 45;
            this.TxtDescripcion.UseSelectable = true;
            this.TxtDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtDescripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtDescripcion.TextChanged += new System.EventHandler(this.TxtDescripcion_TextChanged);
            // 
            // tileStockMin
            // 
            this.tileStockMin.ActiveControl = null;
            this.tileStockMin.Controls.Add(this.lblStockMin);
            this.tileStockMin.Enabled = false;
            this.tileStockMin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileStockMin.Location = new System.Drawing.Point(89, 255);
            this.tileStockMin.Name = "tileStockMin";
            this.tileStockMin.Size = new System.Drawing.Size(100, 20);
            this.tileStockMin.TabIndex = 53;
            this.tileStockMin.UseSelectable = true;
            // 
            // lblStockMin
            // 
            this.lblStockMin.AutoSize = true;
            this.lblStockMin.Enabled = false;
            this.lblStockMin.Location = new System.Drawing.Point(0, 0);
            this.lblStockMin.Name = "lblStockMin";
            this.lblStockMin.Size = new System.Drawing.Size(89, 19);
            this.lblStockMin.TabIndex = 5;
            this.lblStockMin.Text = "Stock Minimo";
            // 
            // TxtGanancia
            // 
            // 
            // 
            // 
            this.TxtGanancia.CustomButton.Image = null;
            this.TxtGanancia.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.TxtGanancia.CustomButton.Name = "";
            this.TxtGanancia.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TxtGanancia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtGanancia.CustomButton.TabIndex = 1;
            this.TxtGanancia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtGanancia.CustomButton.UseSelectable = true;
            this.TxtGanancia.CustomButton.Visible = false;
            this.TxtGanancia.Lines = new string[0];
            this.TxtGanancia.Location = new System.Drawing.Point(185, 190);
            this.TxtGanancia.MaxLength = 32767;
            this.TxtGanancia.Name = "TxtGanancia";
            this.TxtGanancia.PasswordChar = '\0';
            this.TxtGanancia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtGanancia.SelectedText = "";
            this.TxtGanancia.SelectionLength = 0;
            this.TxtGanancia.SelectionStart = 0;
            this.TxtGanancia.ShortcutsEnabled = true;
            this.TxtGanancia.Size = new System.Drawing.Size(177, 20);
            this.TxtGanancia.TabIndex = 47;
            this.TxtGanancia.UseSelectable = true;
            this.TxtGanancia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtGanancia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tileGanancia
            // 
            this.tileGanancia.ActiveControl = null;
            this.tileGanancia.Controls.Add(this.lblGanancia);
            this.tileGanancia.Enabled = false;
            this.tileGanancia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileGanancia.Location = new System.Drawing.Point(89, 190);
            this.tileGanancia.Name = "tileGanancia";
            this.tileGanancia.Size = new System.Drawing.Size(100, 20);
            this.tileGanancia.TabIndex = 52;
            this.tileGanancia.UseSelectable = true;
            // 
            // lblGanancia
            // 
            this.lblGanancia.AutoSize = true;
            this.lblGanancia.Enabled = false;
            this.lblGanancia.Location = new System.Drawing.Point(27, 1);
            this.lblGanancia.Name = "lblGanancia";
            this.lblGanancia.Size = new System.Drawing.Size(62, 19);
            this.lblGanancia.TabIndex = 5;
            this.lblGanancia.Text = "Ganancia";
            // 
            // TxtStockMin
            // 
            // 
            // 
            // 
            this.TxtStockMin.CustomButton.Image = null;
            this.TxtStockMin.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.TxtStockMin.CustomButton.Name = "";
            this.TxtStockMin.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TxtStockMin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtStockMin.CustomButton.TabIndex = 1;
            this.TxtStockMin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtStockMin.CustomButton.UseSelectable = true;
            this.TxtStockMin.CustomButton.Visible = false;
            this.TxtStockMin.Lines = new string[0];
            this.TxtStockMin.Location = new System.Drawing.Point(185, 255);
            this.TxtStockMin.MaxLength = 32767;
            this.TxtStockMin.Name = "TxtStockMin";
            this.TxtStockMin.PasswordChar = '\0';
            this.TxtStockMin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtStockMin.SelectedText = "";
            this.TxtStockMin.SelectionLength = 0;
            this.TxtStockMin.SelectionStart = 0;
            this.TxtStockMin.ShortcutsEnabled = true;
            this.TxtStockMin.Size = new System.Drawing.Size(177, 20);
            this.TxtStockMin.TabIndex = 48;
            this.TxtStockMin.UseSelectable = true;
            this.TxtStockMin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtStockMin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tileDescripcion
            // 
            this.tileDescripcion.ActiveControl = null;
            this.tileDescripcion.Controls.Add(this.lblDescripcion);
            this.tileDescripcion.Enabled = false;
            this.tileDescripcion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileDescripcion.Location = new System.Drawing.Point(89, 117);
            this.tileDescripcion.Name = "tileDescripcion";
            this.tileDescripcion.Size = new System.Drawing.Size(100, 20);
            this.tileDescripcion.TabIndex = 50;
            this.tileDescripcion.UseSelectable = true;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Enabled = false;
            this.lblDescripcion.Location = new System.Drawing.Point(13, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(76, 19);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // BtnVolver
            // 
            this.BtnVolver.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnVolver.Location = new System.Drawing.Point(240, 529);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(99, 23);
            this.BtnVolver.TabIndex = 56;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnVolver.UseSelectable = true;
            // 
            // BtnMod
            // 
            this.BtnMod.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnMod.Location = new System.Drawing.Point(112, 529);
            this.BtnMod.Name = "BtnMod";
            this.BtnMod.Size = new System.Drawing.Size(100, 23);
            this.BtnMod.TabIndex = 55;
            this.BtnMod.Text = "Mod";
            this.BtnMod.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnMod.UseSelectable = true;
            // 
            // tileMarca
            // 
            this.tileMarca.ActiveControl = null;
            this.tileMarca.Controls.Add(this.metroLabel1);
            this.tileMarca.Enabled = false;
            this.tileMarca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileMarca.Location = new System.Drawing.Point(89, 409);
            this.tileMarca.Name = "tileMarca";
            this.tileMarca.Size = new System.Drawing.Size(100, 29);
            this.tileMarca.TabIndex = 58;
            this.tileMarca.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Enabled = false;
            this.metroLabel1.Location = new System.Drawing.Point(43, 6);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Marca";
            // 
            // BoxMarca
            // 
            this.BoxMarca.FormattingEnabled = true;
            this.BoxMarca.ItemHeight = 23;
            this.BoxMarca.Items.AddRange(new object[] {
            "Administrador",
            "Supervisor",
            "Vendedor"});
            this.BoxMarca.Location = new System.Drawing.Point(185, 409);
            this.BoxMarca.Name = "BoxMarca";
            this.BoxMarca.Size = new System.Drawing.Size(177, 29);
            this.BoxMarca.TabIndex = 57;
            this.BoxMarca.UseSelectable = true;
            // 
            // ModProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(450, 600);
            this.Controls.Add(this.BoxMarca);
            this.Controls.Add(this.BoxTipoProducto);
            this.Controls.Add(this.TxtStockMin);
            this.Controls.Add(this.tileMarca);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnMod);
            this.Controls.Add(this.tileTipoProducto);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.tileStockMin);
            this.Controls.Add(this.TxtGanancia);
            this.Controls.Add(this.tileGanancia);
            this.Controls.Add(this.tileDescripcion);
            this.MinimumSize = new System.Drawing.Size(450, 600);
            this.Name = "ModProducto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.ModProducto_Load);
            this.tileTipoProducto.ResumeLayout(false);
            this.tileTipoProducto.PerformLayout();
            this.tileStockMin.ResumeLayout(false);
            this.tileStockMin.PerformLayout();
            this.tileGanancia.ResumeLayout(false);
            this.tileGanancia.PerformLayout();
            this.tileDescripcion.ResumeLayout(false);
            this.tileDescripcion.PerformLayout();
            this.tileMarca.ResumeLayout(false);
            this.tileMarca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileTipoProducto;
        private MetroFramework.Controls.MetroLabel lblTipoProducto;
        private MetroFramework.Controls.MetroComboBox BoxTipoProducto;
        private MetroFramework.Controls.MetroTextBox TxtDescripcion;
        private MetroFramework.Controls.MetroTile tileStockMin;
        private MetroFramework.Controls.MetroLabel lblStockMin;
        private MetroFramework.Controls.MetroTextBox TxtGanancia;
        private MetroFramework.Controls.MetroTile tileGanancia;
        private MetroFramework.Controls.MetroLabel lblGanancia;
        private MetroFramework.Controls.MetroTextBox TxtStockMin;
        private MetroFramework.Controls.MetroTile tileDescripcion;
        private MetroFramework.Controls.MetroLabel lblDescripcion;
        private MetroFramework.Controls.MetroButton BtnVolver;
        private MetroFramework.Controls.MetroButton BtnMod;
        private MetroFramework.Controls.MetroTile tileMarca;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox BoxMarca;
    }
}

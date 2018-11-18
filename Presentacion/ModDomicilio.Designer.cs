namespace Presentacion
{
    partial class ModDomicilio
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
            this.tileAltura = new MetroFramework.Controls.MetroTile();
            this.lblAltura = new MetroFramework.Controls.MetroLabel();
            this.TxtAltura = new MetroFramework.Controls.MetroTextBox();
            this.BtnVolver = new MetroFramework.Controls.MetroButton();
            this.BtnMod = new MetroFramework.Controls.MetroButton();
            this.tileCalle = new MetroFramework.Controls.MetroTile();
            this.lblCalle = new MetroFramework.Controls.MetroLabel();
            this.TxtCalle = new MetroFramework.Controls.MetroTextBox();
            this.tileDepartamento = new MetroFramework.Controls.MetroTile();
            this.lblDepartamento = new MetroFramework.Controls.MetroLabel();
            this.TxtDepartamento = new MetroFramework.Controls.MetroTextBox();
            this.tileBarrio = new MetroFramework.Controls.MetroTile();
            this.lblBarrio = new MetroFramework.Controls.MetroLabel();
            this.TxtBarrio = new MetroFramework.Controls.MetroTextBox();
            this.tileCiudad = new MetroFramework.Controls.MetroTile();
            this.lblCiudad = new MetroFramework.Controls.MetroLabel();
            this.TxtCiudad = new MetroFramework.Controls.MetroTextBox();
            this.tilePais = new MetroFramework.Controls.MetroTile();
            this.lblPais = new MetroFramework.Controls.MetroLabel();
            this.TxtPais = new MetroFramework.Controls.MetroTextBox();
            this.tileCP = new MetroFramework.Controls.MetroTile();
            this.lblCP = new MetroFramework.Controls.MetroLabel();
            this.TxtCP = new MetroFramework.Controls.MetroTextBox();
            this.tileAltura.SuspendLayout();
            this.tileCalle.SuspendLayout();
            this.tileDepartamento.SuspendLayout();
            this.tileBarrio.SuspendLayout();
            this.tileCiudad.SuspendLayout();
            this.tilePais.SuspendLayout();
            this.tileCP.SuspendLayout();
            this.SuspendLayout();
            // 
            // tileAltura
            // 
            this.tileAltura.ActiveControl = null;
            this.tileAltura.Controls.Add(this.lblAltura);
            this.tileAltura.Enabled = false;
            this.tileAltura.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileAltura.Location = new System.Drawing.Point(80, 179);
            this.tileAltura.Name = "tileAltura";
            this.tileAltura.Size = new System.Drawing.Size(113, 20);
            this.tileAltura.TabIndex = 18;
            this.tileAltura.UseSelectable = true;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Enabled = false;
            this.lblAltura.Location = new System.Drawing.Point(59, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(44, 19);
            this.lblAltura.TabIndex = 5;
            this.lblAltura.Text = "Altura";
            // 
            // TxtAltura
            // 
            // 
            // 
            // 
            this.TxtAltura.CustomButton.Image = null;
            this.TxtAltura.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.TxtAltura.CustomButton.Name = "";
            this.TxtAltura.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TxtAltura.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtAltura.CustomButton.TabIndex = 1;
            this.TxtAltura.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtAltura.CustomButton.UseSelectable = true;
            this.TxtAltura.CustomButton.Visible = false;
            this.TxtAltura.Lines = new string[0];
            this.TxtAltura.Location = new System.Drawing.Point(193, 179);
            this.TxtAltura.MaxLength = 60;
            this.TxtAltura.Name = "TxtAltura";
            this.TxtAltura.PasswordChar = '\0';
            this.TxtAltura.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtAltura.SelectedText = "";
            this.TxtAltura.SelectionLength = 0;
            this.TxtAltura.SelectionStart = 0;
            this.TxtAltura.ShortcutsEnabled = true;
            this.TxtAltura.Size = new System.Drawing.Size(177, 20);
            this.TxtAltura.TabIndex = 1;
            this.TxtAltura.UseSelectable = true;
            this.TxtAltura.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtAltura.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtAltura.TextChanged += new System.EventHandler(this.TxtAltura_TextChanged);
            // 
            // BtnVolver
            // 
            this.BtnVolver.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnVolver.Location = new System.Drawing.Point(242, 501);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(99, 23);
            this.BtnVolver.TabIndex = 8;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnVolver.UseSelectable = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // BtnMod
            // 
            this.BtnMod.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnMod.Location = new System.Drawing.Point(110, 501);
            this.BtnMod.Name = "BtnMod";
            this.BtnMod.Size = new System.Drawing.Size(100, 23);
            this.BtnMod.TabIndex = 7;
            this.BtnMod.Text = "Mod";
            this.BtnMod.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnMod.UseSelectable = true;
            this.BtnMod.Click += new System.EventHandler(this.BtnMod_Click);
            // 
            // tileCalle
            // 
            this.tileCalle.ActiveControl = null;
            this.tileCalle.Controls.Add(this.lblCalle);
            this.tileCalle.Enabled = false;
            this.tileCalle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileCalle.Location = new System.Drawing.Point(80, 132);
            this.tileCalle.Name = "tileCalle";
            this.tileCalle.Size = new System.Drawing.Size(113, 20);
            this.tileCalle.TabIndex = 16;
            this.tileCalle.UseSelectable = true;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Enabled = false;
            this.lblCalle.Location = new System.Drawing.Point(65, 1);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(38, 19);
            this.lblCalle.TabIndex = 5;
            this.lblCalle.Text = "Calle";
            // 
            // TxtCalle
            // 
            // 
            // 
            // 
            this.TxtCalle.CustomButton.Image = null;
            this.TxtCalle.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.TxtCalle.CustomButton.Name = "";
            this.TxtCalle.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TxtCalle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtCalle.CustomButton.TabIndex = 1;
            this.TxtCalle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtCalle.CustomButton.UseSelectable = true;
            this.TxtCalle.CustomButton.Visible = false;
            this.TxtCalle.Lines = new string[0];
            this.TxtCalle.Location = new System.Drawing.Point(193, 132);
            this.TxtCalle.MaxLength = 60;
            this.TxtCalle.Name = "TxtCalle";
            this.TxtCalle.PasswordChar = '\0';
            this.TxtCalle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtCalle.SelectedText = "";
            this.TxtCalle.SelectionLength = 0;
            this.TxtCalle.SelectionStart = 0;
            this.TxtCalle.ShortcutsEnabled = true;
            this.TxtCalle.Size = new System.Drawing.Size(177, 20);
            this.TxtCalle.TabIndex = 0;
            this.TxtCalle.UseSelectable = true;
            this.TxtCalle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtCalle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtCalle.TextChanged += new System.EventHandler(this.TxtCalle_TextChanged);
            // 
            // tileDepartamento
            // 
            this.tileDepartamento.ActiveControl = null;
            this.tileDepartamento.Controls.Add(this.lblDepartamento);
            this.tileDepartamento.Enabled = false;
            this.tileDepartamento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileDepartamento.Location = new System.Drawing.Point(80, 226);
            this.tileDepartamento.Name = "tileDepartamento";
            this.tileDepartamento.Size = new System.Drawing.Size(113, 20);
            this.tileDepartamento.TabIndex = 20;
            this.tileDepartamento.UseSelectable = true;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Enabled = false;
            this.lblDepartamento.Location = new System.Drawing.Point(8, 0);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(95, 19);
            this.lblDepartamento.TabIndex = 5;
            this.lblDepartamento.Text = "Departamento";
            // 
            // TxtDepartamento
            // 
            // 
            // 
            // 
            this.TxtDepartamento.CustomButton.Image = null;
            this.TxtDepartamento.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.TxtDepartamento.CustomButton.Name = "";
            this.TxtDepartamento.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TxtDepartamento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtDepartamento.CustomButton.TabIndex = 1;
            this.TxtDepartamento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtDepartamento.CustomButton.UseSelectable = true;
            this.TxtDepartamento.CustomButton.Visible = false;
            this.TxtDepartamento.Lines = new string[0];
            this.TxtDepartamento.Location = new System.Drawing.Point(193, 226);
            this.TxtDepartamento.MaxLength = 60;
            this.TxtDepartamento.Name = "TxtDepartamento";
            this.TxtDepartamento.PasswordChar = '\0';
            this.TxtDepartamento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtDepartamento.SelectedText = "";
            this.TxtDepartamento.SelectionLength = 0;
            this.TxtDepartamento.SelectionStart = 0;
            this.TxtDepartamento.ShortcutsEnabled = true;
            this.TxtDepartamento.Size = new System.Drawing.Size(177, 20);
            this.TxtDepartamento.TabIndex = 2;
            this.TxtDepartamento.UseSelectable = true;
            this.TxtDepartamento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtDepartamento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtDepartamento.TextChanged += new System.EventHandler(this.TxtDepartamento_TextChanged);
            // 
            // tileBarrio
            // 
            this.tileBarrio.ActiveControl = null;
            this.tileBarrio.Controls.Add(this.lblBarrio);
            this.tileBarrio.Enabled = false;
            this.tileBarrio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileBarrio.Location = new System.Drawing.Point(80, 271);
            this.tileBarrio.Name = "tileBarrio";
            this.tileBarrio.Size = new System.Drawing.Size(113, 20);
            this.tileBarrio.TabIndex = 22;
            this.tileBarrio.UseSelectable = true;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Enabled = false;
            this.lblBarrio.Location = new System.Drawing.Point(58, 1);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(45, 19);
            this.lblBarrio.TabIndex = 5;
            this.lblBarrio.Text = "Barrio";
            // 
            // TxtBarrio
            // 
            // 
            // 
            // 
            this.TxtBarrio.CustomButton.Image = null;
            this.TxtBarrio.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.TxtBarrio.CustomButton.Name = "";
            this.TxtBarrio.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TxtBarrio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBarrio.CustomButton.TabIndex = 1;
            this.TxtBarrio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBarrio.CustomButton.UseSelectable = true;
            this.TxtBarrio.CustomButton.Visible = false;
            this.TxtBarrio.Lines = new string[0];
            this.TxtBarrio.Location = new System.Drawing.Point(193, 271);
            this.TxtBarrio.MaxLength = 60;
            this.TxtBarrio.Name = "TxtBarrio";
            this.TxtBarrio.PasswordChar = '\0';
            this.TxtBarrio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBarrio.SelectedText = "";
            this.TxtBarrio.SelectionLength = 0;
            this.TxtBarrio.SelectionStart = 0;
            this.TxtBarrio.ShortcutsEnabled = true;
            this.TxtBarrio.Size = new System.Drawing.Size(177, 20);
            this.TxtBarrio.TabIndex = 3;
            this.TxtBarrio.UseSelectable = true;
            this.TxtBarrio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBarrio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtBarrio.TextChanged += new System.EventHandler(this.TxtBarrio_TextChanged);
            // 
            // tileCiudad
            // 
            this.tileCiudad.ActiveControl = null;
            this.tileCiudad.Controls.Add(this.lblCiudad);
            this.tileCiudad.Enabled = false;
            this.tileCiudad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileCiudad.Location = new System.Drawing.Point(80, 317);
            this.tileCiudad.Name = "tileCiudad";
            this.tileCiudad.Size = new System.Drawing.Size(113, 20);
            this.tileCiudad.TabIndex = 24;
            this.tileCiudad.UseSelectable = true;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Enabled = false;
            this.lblCiudad.Location = new System.Drawing.Point(52, 0);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(51, 19);
            this.lblCiudad.TabIndex = 5;
            this.lblCiudad.Text = "Ciudad";
            // 
            // TxtCiudad
            // 
            // 
            // 
            // 
            this.TxtCiudad.CustomButton.Image = null;
            this.TxtCiudad.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.TxtCiudad.CustomButton.Name = "";
            this.TxtCiudad.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TxtCiudad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtCiudad.CustomButton.TabIndex = 1;
            this.TxtCiudad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtCiudad.CustomButton.UseSelectable = true;
            this.TxtCiudad.CustomButton.Visible = false;
            this.TxtCiudad.Lines = new string[0];
            this.TxtCiudad.Location = new System.Drawing.Point(193, 317);
            this.TxtCiudad.MaxLength = 60;
            this.TxtCiudad.Name = "TxtCiudad";
            this.TxtCiudad.PasswordChar = '\0';
            this.TxtCiudad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtCiudad.SelectedText = "";
            this.TxtCiudad.SelectionLength = 0;
            this.TxtCiudad.SelectionStart = 0;
            this.TxtCiudad.ShortcutsEnabled = true;
            this.TxtCiudad.Size = new System.Drawing.Size(177, 20);
            this.TxtCiudad.TabIndex = 4;
            this.TxtCiudad.UseSelectable = true;
            this.TxtCiudad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtCiudad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtCiudad.TextChanged += new System.EventHandler(this.TxtCiudad_TextChanged);
            // 
            // tilePais
            // 
            this.tilePais.ActiveControl = null;
            this.tilePais.Controls.Add(this.lblPais);
            this.tilePais.Enabled = false;
            this.tilePais.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tilePais.Location = new System.Drawing.Point(80, 365);
            this.tilePais.Name = "tilePais";
            this.tilePais.Size = new System.Drawing.Size(113, 20);
            this.tilePais.TabIndex = 26;
            this.tilePais.UseSelectable = true;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Enabled = false;
            this.lblPais.Location = new System.Drawing.Point(72, 0);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(31, 19);
            this.lblPais.TabIndex = 5;
            this.lblPais.Text = "Pais";
            // 
            // TxtPais
            // 
            // 
            // 
            // 
            this.TxtPais.CustomButton.Image = null;
            this.TxtPais.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.TxtPais.CustomButton.Name = "";
            this.TxtPais.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TxtPais.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPais.CustomButton.TabIndex = 1;
            this.TxtPais.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPais.CustomButton.UseSelectable = true;
            this.TxtPais.CustomButton.Visible = false;
            this.TxtPais.Lines = new string[0];
            this.TxtPais.Location = new System.Drawing.Point(193, 365);
            this.TxtPais.MaxLength = 60;
            this.TxtPais.Name = "TxtPais";
            this.TxtPais.PasswordChar = '\0';
            this.TxtPais.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPais.SelectedText = "";
            this.TxtPais.SelectionLength = 0;
            this.TxtPais.SelectionStart = 0;
            this.TxtPais.ShortcutsEnabled = true;
            this.TxtPais.Size = new System.Drawing.Size(177, 20);
            this.TxtPais.TabIndex = 5;
            this.TxtPais.UseSelectable = true;
            this.TxtPais.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPais.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtPais.TextChanged += new System.EventHandler(this.TxtPais_TextChanged);
            // 
            // tileCP
            // 
            this.tileCP.ActiveControl = null;
            this.tileCP.Controls.Add(this.lblCP);
            this.tileCP.Enabled = false;
            this.tileCP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileCP.Location = new System.Drawing.Point(80, 415);
            this.tileCP.Name = "tileCP";
            this.tileCP.Size = new System.Drawing.Size(113, 20);
            this.tileCP.TabIndex = 28;
            this.tileCP.UseSelectable = true;
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Enabled = false;
            this.lblCP.Location = new System.Drawing.Point(77, 0);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(26, 19);
            this.lblCP.TabIndex = 5;
            this.lblCP.Text = "CP";
            // 
            // TxtCP
            // 
            // 
            // 
            // 
            this.TxtCP.CustomButton.Image = null;
            this.TxtCP.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.TxtCP.CustomButton.Name = "";
            this.TxtCP.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TxtCP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtCP.CustomButton.TabIndex = 1;
            this.TxtCP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtCP.CustomButton.UseSelectable = true;
            this.TxtCP.CustomButton.Visible = false;
            this.TxtCP.Lines = new string[0];
            this.TxtCP.Location = new System.Drawing.Point(193, 415);
            this.TxtCP.MaxLength = 60;
            this.TxtCP.Name = "TxtCP";
            this.TxtCP.PasswordChar = '\0';
            this.TxtCP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtCP.SelectedText = "";
            this.TxtCP.SelectionLength = 0;
            this.TxtCP.SelectionStart = 0;
            this.TxtCP.ShortcutsEnabled = true;
            this.TxtCP.Size = new System.Drawing.Size(177, 20);
            this.TxtCP.TabIndex = 6;
            this.TxtCP.UseSelectable = true;
            this.TxtCP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtCP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtCP.TextChanged += new System.EventHandler(this.TxtCP_TextChanged);
            // 
            // ModDomicilio
            // 
            this.ClientSize = new System.Drawing.Size(450, 600);
            this.Controls.Add(this.tileCP);
            this.Controls.Add(this.TxtCP);
            this.Controls.Add(this.tilePais);
            this.Controls.Add(this.TxtPais);
            this.Controls.Add(this.tileCiudad);
            this.Controls.Add(this.TxtCiudad);
            this.Controls.Add(this.tileBarrio);
            this.Controls.Add(this.TxtBarrio);
            this.Controls.Add(this.tileDepartamento);
            this.Controls.Add(this.TxtDepartamento);
            this.Controls.Add(this.tileAltura);
            this.Controls.Add(this.TxtAltura);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnMod);
            this.Controls.Add(this.tileCalle);
            this.Controls.Add(this.TxtCalle);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(450, 600);
            this.Name = "ModDomicilio";
            this.ShowInTaskbar = false;
            this.Text = "Domicilio";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.ModDomicilio_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModDomicilio_KeyPress);
            this.tileAltura.ResumeLayout(false);
            this.tileAltura.PerformLayout();
            this.tileCalle.ResumeLayout(false);
            this.tileCalle.PerformLayout();
            this.tileDepartamento.ResumeLayout(false);
            this.tileDepartamento.PerformLayout();
            this.tileBarrio.ResumeLayout(false);
            this.tileBarrio.PerformLayout();
            this.tileCiudad.ResumeLayout(false);
            this.tileCiudad.PerformLayout();
            this.tilePais.ResumeLayout(false);
            this.tilePais.PerformLayout();
            this.tileCP.ResumeLayout(false);
            this.tileCP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileAltura;
        private MetroFramework.Controls.MetroLabel lblAltura;
        private MetroFramework.Controls.MetroTextBox TxtAltura;
        private MetroFramework.Controls.MetroButton BtnVolver;
        private MetroFramework.Controls.MetroButton BtnMod;
        private MetroFramework.Controls.MetroTile tileCalle;
        private MetroFramework.Controls.MetroLabel lblCalle;
        private MetroFramework.Controls.MetroTextBox TxtCalle;
        private MetroFramework.Controls.MetroTile tileDepartamento;
        private MetroFramework.Controls.MetroLabel lblDepartamento;
        private MetroFramework.Controls.MetroTextBox TxtDepartamento;
        private MetroFramework.Controls.MetroTile tileBarrio;
        private MetroFramework.Controls.MetroLabel lblBarrio;
        private MetroFramework.Controls.MetroTextBox TxtBarrio;
        private MetroFramework.Controls.MetroTile tileCiudad;
        private MetroFramework.Controls.MetroLabel lblCiudad;
        private MetroFramework.Controls.MetroTextBox TxtCiudad;
        private MetroFramework.Controls.MetroTile tilePais;
        private MetroFramework.Controls.MetroLabel lblPais;
        private MetroFramework.Controls.MetroTextBox TxtPais;
        private MetroFramework.Controls.MetroTile tileCP;
        private MetroFramework.Controls.MetroLabel lblCP;
        private MetroFramework.Controls.MetroTextBox TxtCP;
    }
}

namespace Presentacion
{
    partial class ModEmpleado
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
            this.DateFechaNac = new MetroFramework.Controls.MetroDateTime();
            this.BoxTipoPerfil = new MetroFramework.Controls.MetroComboBox();
            this.TxtEmail = new MetroFramework.Controls.MetroTextBox();
            this.tileTipoPerfil = new MetroFramework.Controls.MetroTile();
            this.lblTipoPerfil = new MetroFramework.Controls.MetroLabel();
            this.tileFechaNac = new MetroFramework.Controls.MetroTile();
            this.lblFechaNac = new MetroFramework.Controls.MetroLabel();
            this.TxtNombre = new MetroFramework.Controls.MetroTextBox();
            this.TxtApellido = new MetroFramework.Controls.MetroTextBox();
            this.tileEmail = new MetroFramework.Controls.MetroTile();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.TxtDNI = new MetroFramework.Controls.MetroTextBox();
            this.tileDNI = new MetroFramework.Controls.MetroTile();
            this.lblDNI = new MetroFramework.Controls.MetroLabel();
            this.tileApellido = new MetroFramework.Controls.MetroTile();
            this.lblApellido = new MetroFramework.Controls.MetroLabel();
            this.tileNombre = new MetroFramework.Controls.MetroTile();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.BtnVolver = new MetroFramework.Controls.MetroButton();
            this.BtnMod = new MetroFramework.Controls.MetroButton();
            this.tileTipoPerfil.SuspendLayout();
            this.tileFechaNac.SuspendLayout();
            this.tileEmail.SuspendLayout();
            this.tileDNI.SuspendLayout();
            this.tileApellido.SuspendLayout();
            this.tileNombre.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateFechaNac
            // 
            this.DateFechaNac.Location = new System.Drawing.Point(173, 410);
            this.DateFechaNac.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateFechaNac.Name = "DateFechaNac";
            this.DateFechaNac.Size = new System.Drawing.Size(200, 29);
            this.DateFechaNac.TabIndex = 5;
            // 
            // BoxTipoPerfil
            // 
            this.BoxTipoPerfil.FormattingEnabled = true;
            this.BoxTipoPerfil.ItemHeight = 23;
            this.BoxTipoPerfil.Items.AddRange(new object[] {
            "Administrador",
            "Supervisor",
            "Vendedor"});
            this.BoxTipoPerfil.Location = new System.Drawing.Point(173, 350);
            this.BoxTipoPerfil.Name = "BoxTipoPerfil";
            this.BoxTipoPerfil.Size = new System.Drawing.Size(177, 29);
            this.BoxTipoPerfil.TabIndex = 4;
            this.BoxTipoPerfil.UseSelectable = true;
            // 
            // TxtEmail
            // 
            // 
            // 
            // 
            this.TxtEmail.CustomButton.Image = null;
            this.TxtEmail.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.TxtEmail.CustomButton.Name = "";
            this.TxtEmail.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TxtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtEmail.CustomButton.TabIndex = 1;
            this.TxtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtEmail.CustomButton.UseSelectable = true;
            this.TxtEmail.CustomButton.Visible = false;
            this.TxtEmail.Lines = new string[0];
            this.TxtEmail.Location = new System.Drawing.Point(173, 300);
            this.TxtEmail.MaxLength = 60;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PasswordChar = '\0';
            this.TxtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtEmail.SelectedText = "";
            this.TxtEmail.SelectionLength = 0;
            this.TxtEmail.SelectionStart = 0;
            this.TxtEmail.ShortcutsEnabled = true;
            this.TxtEmail.Size = new System.Drawing.Size(177, 20);
            this.TxtEmail.TabIndex = 3;
            this.TxtEmail.UseSelectable = true;
            this.TxtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtEmail.TextChanged += new System.EventHandler(this.TxtEmail_TextChanged);
            // 
            // tileTipoPerfil
            // 
            this.tileTipoPerfil.ActiveControl = null;
            this.tileTipoPerfil.Controls.Add(this.lblTipoPerfil);
            this.tileTipoPerfil.Enabled = false;
            this.tileTipoPerfil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileTipoPerfil.Location = new System.Drawing.Point(77, 350);
            this.tileTipoPerfil.Name = "tileTipoPerfil";
            this.tileTipoPerfil.Size = new System.Drawing.Size(100, 29);
            this.tileTipoPerfil.TabIndex = 44;
            this.tileTipoPerfil.UseSelectable = true;
            // 
            // lblTipoPerfil
            // 
            this.lblTipoPerfil.AutoSize = true;
            this.lblTipoPerfil.Enabled = false;
            this.lblTipoPerfil.Location = new System.Drawing.Point(3, 6);
            this.lblTipoPerfil.Name = "lblTipoPerfil";
            this.lblTipoPerfil.Size = new System.Drawing.Size(88, 19);
            this.lblTipoPerfil.TabIndex = 5;
            this.lblTipoPerfil.Text = "Tipo de Perfil";
            // 
            // tileFechaNac
            // 
            this.tileFechaNac.ActiveControl = null;
            this.tileFechaNac.Controls.Add(this.lblFechaNac);
            this.tileFechaNac.Enabled = false;
            this.tileFechaNac.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileFechaNac.Location = new System.Drawing.Point(77, 410);
            this.tileFechaNac.Name = "tileFechaNac";
            this.tileFechaNac.Size = new System.Drawing.Size(100, 29);
            this.tileFechaNac.TabIndex = 42;
            this.tileFechaNac.UseSelectable = true;
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Enabled = false;
            this.lblFechaNac.Location = new System.Drawing.Point(14, 7);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(76, 19);
            this.lblFechaNac.TabIndex = 5;
            this.lblFechaNac.Text = "Nacimiento";
            // 
            // TxtNombre
            // 
            // 
            // 
            // 
            this.TxtNombre.CustomButton.Image = null;
            this.TxtNombre.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.TxtNombre.CustomButton.Name = "";
            this.TxtNombre.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TxtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtNombre.CustomButton.TabIndex = 1;
            this.TxtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtNombre.CustomButton.UseSelectable = true;
            this.TxtNombre.CustomButton.Visible = false;
            this.TxtNombre.Lines = new string[0];
            this.TxtNombre.Location = new System.Drawing.Point(173, 150);
            this.TxtNombre.MaxLength = 60;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.PasswordChar = '\0';
            this.TxtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtNombre.SelectedText = "";
            this.TxtNombre.SelectionLength = 0;
            this.TxtNombre.SelectionStart = 0;
            this.TxtNombre.ShortcutsEnabled = true;
            this.TxtNombre.Size = new System.Drawing.Size(177, 20);
            this.TxtNombre.TabIndex = 0;
            this.TxtNombre.UseSelectable = true;
            this.TxtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtApellido
            // 
            // 
            // 
            // 
            this.TxtApellido.CustomButton.Image = null;
            this.TxtApellido.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.TxtApellido.CustomButton.Name = "";
            this.TxtApellido.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TxtApellido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtApellido.CustomButton.TabIndex = 1;
            this.TxtApellido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtApellido.CustomButton.UseSelectable = true;
            this.TxtApellido.CustomButton.Visible = false;
            this.TxtApellido.Lines = new string[0];
            this.TxtApellido.Location = new System.Drawing.Point(173, 200);
            this.TxtApellido.MaxLength = 60;
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.PasswordChar = '\0';
            this.TxtApellido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtApellido.SelectedText = "";
            this.TxtApellido.SelectionLength = 0;
            this.TxtApellido.SelectionStart = 0;
            this.TxtApellido.ShortcutsEnabled = true;
            this.TxtApellido.Size = new System.Drawing.Size(177, 20);
            this.TxtApellido.TabIndex = 1;
            this.TxtApellido.UseSelectable = true;
            this.TxtApellido.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtApellido.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tileEmail
            // 
            this.tileEmail.ActiveControl = null;
            this.tileEmail.Controls.Add(this.lblEmail);
            this.tileEmail.Enabled = false;
            this.tileEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileEmail.Location = new System.Drawing.Point(77, 300);
            this.tileEmail.Name = "tileEmail";
            this.tileEmail.Size = new System.Drawing.Size(100, 20);
            this.tileEmail.TabIndex = 37;
            this.tileEmail.UseSelectable = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Enabled = false;
            this.lblEmail.Location = new System.Drawing.Point(48, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 19);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // TxtDNI
            // 
            // 
            // 
            // 
            this.TxtDNI.CustomButton.Image = null;
            this.TxtDNI.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.TxtDNI.CustomButton.Name = "";
            this.TxtDNI.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TxtDNI.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtDNI.CustomButton.TabIndex = 1;
            this.TxtDNI.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtDNI.CustomButton.UseSelectable = true;
            this.TxtDNI.CustomButton.Visible = false;
            this.TxtDNI.Lines = new string[0];
            this.TxtDNI.Location = new System.Drawing.Point(173, 250);
            this.TxtDNI.MaxLength = 8;
            this.TxtDNI.Name = "TxtDNI";
            this.TxtDNI.PasswordChar = '\0';
            this.TxtDNI.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtDNI.SelectedText = "";
            this.TxtDNI.SelectionLength = 0;
            this.TxtDNI.SelectionStart = 0;
            this.TxtDNI.ShortcutsEnabled = true;
            this.TxtDNI.Size = new System.Drawing.Size(177, 20);
            this.TxtDNI.TabIndex = 2;
            this.TxtDNI.UseSelectable = true;
            this.TxtDNI.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtDNI.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tileDNI
            // 
            this.tileDNI.ActiveControl = null;
            this.tileDNI.Controls.Add(this.lblDNI);
            this.tileDNI.Enabled = false;
            this.tileDNI.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileDNI.Location = new System.Drawing.Point(77, 250);
            this.tileDNI.Name = "tileDNI";
            this.tileDNI.Size = new System.Drawing.Size(100, 20);
            this.tileDNI.TabIndex = 35;
            this.tileDNI.UseSelectable = true;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Enabled = false;
            this.lblDNI.Location = new System.Drawing.Point(58, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(31, 19);
            this.lblDNI.TabIndex = 5;
            this.lblDNI.Text = "DNI";
            // 
            // tileApellido
            // 
            this.tileApellido.ActiveControl = null;
            this.tileApellido.Controls.Add(this.lblApellido);
            this.tileApellido.Enabled = false;
            this.tileApellido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileApellido.Location = new System.Drawing.Point(77, 200);
            this.tileApellido.Name = "tileApellido";
            this.tileApellido.Size = new System.Drawing.Size(100, 20);
            this.tileApellido.TabIndex = 33;
            this.tileApellido.UseSelectable = true;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Enabled = false;
            this.lblApellido.Location = new System.Drawing.Point(31, 1);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 19);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "Apellido";
            // 
            // tileNombre
            // 
            this.tileNombre.ActiveControl = null;
            this.tileNombre.Controls.Add(this.lblNombre);
            this.tileNombre.Enabled = false;
            this.tileNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileNombre.Location = new System.Drawing.Point(77, 150);
            this.tileNombre.Name = "tileNombre";
            this.tileNombre.Size = new System.Drawing.Size(100, 20);
            this.tileNombre.TabIndex = 31;
            this.tileNombre.UseSelectable = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Enabled = false;
            this.lblNombre.Location = new System.Drawing.Point(30, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // BtnVolver
            // 
            this.BtnVolver.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnVolver.Location = new System.Drawing.Point(237, 554);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(99, 23);
            this.BtnVolver.TabIndex = 7;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnVolver.UseSelectable = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnMod
            // 
            this.BtnMod.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnMod.Location = new System.Drawing.Point(109, 554);
            this.BtnMod.Name = "BtnMod";
            this.BtnMod.Size = new System.Drawing.Size(100, 23);
            this.BtnMod.TabIndex = 6;
            this.BtnMod.Text = "Mod";
            this.BtnMod.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnMod.UseSelectable = true;
            this.BtnMod.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // ModEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(450, 600);
            this.Controls.Add(this.DateFechaNac);
            this.Controls.Add(this.BoxTipoPerfil);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.tileTipoPerfil);
            this.Controls.Add(this.tileFechaNac);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.tileEmail);
            this.Controls.Add(this.TxtDNI);
            this.Controls.Add(this.tileDNI);
            this.Controls.Add(this.tileApellido);
            this.Controls.Add(this.tileNombre);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnMod);
            this.MinimumSize = new System.Drawing.Size(450, 600);
            this.Name = "ModEmpleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.ModEmpleado_Load);
            this.tileTipoPerfil.ResumeLayout(false);
            this.tileTipoPerfil.PerformLayout();
            this.tileFechaNac.ResumeLayout(false);
            this.tileFechaNac.PerformLayout();
            this.tileEmail.ResumeLayout(false);
            this.tileEmail.PerformLayout();
            this.tileDNI.ResumeLayout(false);
            this.tileDNI.PerformLayout();
            this.tileApellido.ResumeLayout(false);
            this.tileApellido.PerformLayout();
            this.tileNombre.ResumeLayout(false);
            this.tileNombre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnVolver;
        private MetroFramework.Controls.MetroButton BtnMod;
        private MetroFramework.Controls.MetroTile tileNombre;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private MetroFramework.Controls.MetroTile tileApellido;
        private MetroFramework.Controls.MetroLabel lblApellido;
        private MetroFramework.Controls.MetroTile tileDNI;
        private MetroFramework.Controls.MetroLabel lblDNI;
        private MetroFramework.Controls.MetroTextBox TxtEmail;
        private MetroFramework.Controls.MetroTile tileEmail;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroTextBox TxtDNI;
        private MetroFramework.Controls.MetroTextBox TxtApellido;
        private MetroFramework.Controls.MetroTextBox TxtNombre;
        private MetroFramework.Controls.MetroDateTime DateFechaNac;
        private MetroFramework.Controls.MetroLabel lblFechaNac;
        private MetroFramework.Controls.MetroTile tileFechaNac;
        private MetroFramework.Controls.MetroComboBox BoxTipoPerfil;
        private MetroFramework.Controls.MetroLabel lblTipoPerfil;
        private MetroFramework.Controls.MetroTile tileTipoPerfil;
    }
}

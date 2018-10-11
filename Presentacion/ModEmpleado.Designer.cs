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
            this.BtnVolver = new MetroFramework.Controls.MetroButton();
            this.BtnAgregar = new MetroFramework.Controls.MetroButton();
            this.tileNombre = new MetroFramework.Controls.MetroTile();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.tileApellido = new MetroFramework.Controls.MetroTile();
            this.lblApellido = new MetroFramework.Controls.MetroLabel();
            this.tileDNI = new MetroFramework.Controls.MetroTile();
            this.lblDNI = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.tileEmail = new MetroFramework.Controls.MetroTile();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.txtDNI = new MetroFramework.Controls.MetroTextBox();
            this.txtApellido = new MetroFramework.Controls.MetroTextBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.dateFechaNac = new MetroFramework.Controls.MetroDateTime();
            this.lblFechaNac = new MetroFramework.Controls.MetroLabel();
            this.tileFechaNac = new MetroFramework.Controls.MetroTile();
            this.boxTipoPerfil = new MetroFramework.Controls.MetroComboBox();
            this.lblTipoPerfil = new MetroFramework.Controls.MetroLabel();
            this.tileTipoPerfil = new MetroFramework.Controls.MetroTile();
            this.tileNombre.SuspendLayout();
            this.tileApellido.SuspendLayout();
            this.tileDNI.SuspendLayout();
            this.tileEmail.SuspendLayout();
            this.tileFechaNac.SuspendLayout();
            this.tileTipoPerfil.SuspendLayout();
            this.SuspendLayout();
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
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnAgregar.Location = new System.Drawing.Point(109, 554);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(100, 23);
            this.BtnAgregar.TabIndex = 6;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnAgregar.UseSelectable = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
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
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(173, 300);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(177, 20);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.TextChanged += new System.EventHandler(this.TxtEmail_TextChanged);
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
            // txtDNI
            // 
            // 
            // 
            // 
            this.txtDNI.CustomButton.Image = null;
            this.txtDNI.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.txtDNI.CustomButton.Name = "";
            this.txtDNI.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtDNI.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDNI.CustomButton.TabIndex = 1;
            this.txtDNI.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDNI.CustomButton.UseSelectable = true;
            this.txtDNI.CustomButton.Visible = false;
            this.txtDNI.Lines = new string[0];
            this.txtDNI.Location = new System.Drawing.Point(173, 250);
            this.txtDNI.MaxLength = 32767;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.PasswordChar = '\0';
            this.txtDNI.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDNI.SelectedText = "";
            this.txtDNI.SelectionLength = 0;
            this.txtDNI.SelectionStart = 0;
            this.txtDNI.ShortcutsEnabled = true;
            this.txtDNI.Size = new System.Drawing.Size(177, 20);
            this.txtDNI.TabIndex = 2;
            this.txtDNI.UseSelectable = true;
            this.txtDNI.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDNI.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtApellido
            // 
            // 
            // 
            // 
            this.txtApellido.CustomButton.Image = null;
            this.txtApellido.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.txtApellido.CustomButton.Name = "";
            this.txtApellido.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtApellido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApellido.CustomButton.TabIndex = 1;
            this.txtApellido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApellido.CustomButton.UseSelectable = true;
            this.txtApellido.CustomButton.Visible = false;
            this.txtApellido.Lines = new string[0];
            this.txtApellido.Location = new System.Drawing.Point(173, 200);
            this.txtApellido.MaxLength = 32767;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PasswordChar = '\0';
            this.txtApellido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApellido.SelectedText = "";
            this.txtApellido.SelectionLength = 0;
            this.txtApellido.SelectionStart = 0;
            this.txtApellido.ShortcutsEnabled = true;
            this.txtApellido.Size = new System.Drawing.Size(177, 20);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.UseSelectable = true;
            this.txtApellido.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApellido.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(173, 150);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(177, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dateFechaNac
            // 
            this.dateFechaNac.Location = new System.Drawing.Point(173, 410);
            this.dateFechaNac.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateFechaNac.Name = "dateFechaNac";
            this.dateFechaNac.Size = new System.Drawing.Size(200, 29);
            this.dateFechaNac.TabIndex = 5;
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
            // boxTipoPerfil
            // 
            this.boxTipoPerfil.FormattingEnabled = true;
            this.boxTipoPerfil.ItemHeight = 23;
            this.boxTipoPerfil.Items.AddRange(new object[] {
            "Administrador",
            "Supervisor",
            "Vendedor"});
            this.boxTipoPerfil.Location = new System.Drawing.Point(173, 350);
            this.boxTipoPerfil.Name = "boxTipoPerfil";
            this.boxTipoPerfil.Size = new System.Drawing.Size(177, 29);
            this.boxTipoPerfil.TabIndex = 4;
            this.boxTipoPerfil.UseSelectable = true;
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
            // ModEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(450, 600);
            this.Controls.Add(this.tileTipoPerfil);
            this.Controls.Add(this.boxTipoPerfil);
            this.Controls.Add(this.tileFechaNac);
            this.Controls.Add(this.dateFechaNac);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.tileEmail);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.tileDNI);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.tileApellido);
            this.Controls.Add(this.tileNombre);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnAgregar);
            this.MinimumSize = new System.Drawing.Size(450, 600);
            this.Name = "ModEmpleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.ModEmpleado_Load);
            this.tileNombre.ResumeLayout(false);
            this.tileNombre.PerformLayout();
            this.tileApellido.ResumeLayout(false);
            this.tileApellido.PerformLayout();
            this.tileDNI.ResumeLayout(false);
            this.tileDNI.PerformLayout();
            this.tileEmail.ResumeLayout(false);
            this.tileEmail.PerformLayout();
            this.tileFechaNac.ResumeLayout(false);
            this.tileFechaNac.PerformLayout();
            this.tileTipoPerfil.ResumeLayout(false);
            this.tileTipoPerfil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnVolver;
        private MetroFramework.Controls.MetroButton BtnAgregar;
        private MetroFramework.Controls.MetroTile tileNombre;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private MetroFramework.Controls.MetroTile tileApellido;
        private MetroFramework.Controls.MetroLabel lblApellido;
        private MetroFramework.Controls.MetroTile tileDNI;
        private MetroFramework.Controls.MetroLabel lblDNI;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTile tileEmail;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroTextBox txtDNI;
        private MetroFramework.Controls.MetroTextBox txtApellido;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroDateTime dateFechaNac;
        private MetroFramework.Controls.MetroLabel lblFechaNac;
        private MetroFramework.Controls.MetroTile tileFechaNac;
        private MetroFramework.Controls.MetroComboBox boxTipoPerfil;
        private MetroFramework.Controls.MetroLabel lblTipoPerfil;
        private MetroFramework.Controls.MetroTile tileTipoPerfil;
    }
}

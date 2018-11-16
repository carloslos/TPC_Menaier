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
            this.TxtDni = new MetroFramework.Controls.MetroTextBox();
            this.tileDni = new MetroFramework.Controls.MetroTile();
            this.lblDni = new MetroFramework.Controls.MetroLabel();
            this.tileApellido = new MetroFramework.Controls.MetroTile();
            this.lblApellido = new MetroFramework.Controls.MetroLabel();
            this.tileNombre = new MetroFramework.Controls.MetroTile();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.BtnVolver = new MetroFramework.Controls.MetroButton();
            this.BtnMod = new MetroFramework.Controls.MetroButton();
            this.TxtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.TxtPass = new MetroFramework.Controls.MetroTextBox();
            this.tilePass = new MetroFramework.Controls.MetroTile();
            this.lblPass = new MetroFramework.Controls.MetroLabel();
            this.tileUsuario = new MetroFramework.Controls.MetroTile();
            this.lblUsuario = new MetroFramework.Controls.MetroLabel();
            this.tileTipoPerfil.SuspendLayout();
            this.tileFechaNac.SuspendLayout();
            this.tileEmail.SuspendLayout();
            this.tileDni.SuspendLayout();
            this.tileApellido.SuspendLayout();
            this.tileNombre.SuspendLayout();
            this.tilePass.SuspendLayout();
            this.tileUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateFechaNac
            // 
            this.DateFechaNac.CustomFormat = "dd/mm/yyyy";
            this.DateFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFechaNac.Location = new System.Drawing.Point(173, 465);
            this.DateFechaNac.MaxDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.DateFechaNac.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DateFechaNac.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateFechaNac.Name = "DateFechaNac";
            this.DateFechaNac.Size = new System.Drawing.Size(177, 29);
            this.DateFechaNac.TabIndex = 7;
            this.DateFechaNac.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.DateFechaNac.ValueChanged += new System.EventHandler(this.DateFechaNac_ValueChanged);
            // 
            // BoxTipoPerfil
            // 
            this.BoxTipoPerfil.FormattingEnabled = true;
            this.BoxTipoPerfil.ItemHeight = 23;
            this.BoxTipoPerfil.Items.AddRange(new object[] {
            "Administrador",
            "Supervisor",
            "Vendedor"});
            this.BoxTipoPerfil.Location = new System.Drawing.Point(173, 408);
            this.BoxTipoPerfil.Name = "BoxTipoPerfil";
            this.BoxTipoPerfil.Size = new System.Drawing.Size(177, 29);
            this.BoxTipoPerfil.TabIndex = 6;
            this.BoxTipoPerfil.UseSelectable = true;
            this.BoxTipoPerfil.SelectedValueChanged += new System.EventHandler(this.BoxTipoPerfil_SelectedValueChanged);
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
            this.TxtEmail.Location = new System.Drawing.Point(173, 360);
            this.TxtEmail.MaxLength = 60;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PasswordChar = '\0';
            this.TxtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtEmail.SelectedText = "";
            this.TxtEmail.SelectionLength = 0;
            this.TxtEmail.SelectionStart = 0;
            this.TxtEmail.ShortcutsEnabled = true;
            this.TxtEmail.Size = new System.Drawing.Size(177, 20);
            this.TxtEmail.TabIndex = 5;
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
            this.tileTipoPerfil.Location = new System.Drawing.Point(77, 408);
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
            this.tileFechaNac.Location = new System.Drawing.Point(77, 465);
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
            this.TxtNombre.Location = new System.Drawing.Point(173, 120);
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
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
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
            this.TxtApellido.Location = new System.Drawing.Point(173, 168);
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
            this.TxtApellido.TextChanged += new System.EventHandler(this.TxtApellido_TextChanged);
            // 
            // tileEmail
            // 
            this.tileEmail.ActiveControl = null;
            this.tileEmail.Controls.Add(this.lblEmail);
            this.tileEmail.Enabled = false;
            this.tileEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileEmail.Location = new System.Drawing.Point(77, 360);
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
            // TxtDni
            // 
            // 
            // 
            // 
            this.TxtDni.CustomButton.Image = null;
            this.TxtDni.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.TxtDni.CustomButton.Name = "";
            this.TxtDni.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TxtDni.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtDni.CustomButton.TabIndex = 1;
            this.TxtDni.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtDni.CustomButton.UseSelectable = true;
            this.TxtDni.CustomButton.Visible = false;
            this.TxtDni.Lines = new string[0];
            this.TxtDni.Location = new System.Drawing.Point(173, 312);
            this.TxtDni.MaxLength = 8;
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.PasswordChar = '\0';
            this.TxtDni.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtDni.SelectedText = "";
            this.TxtDni.SelectionLength = 0;
            this.TxtDni.SelectionStart = 0;
            this.TxtDni.ShortcutsEnabled = true;
            this.TxtDni.Size = new System.Drawing.Size(177, 20);
            this.TxtDni.TabIndex = 4;
            this.TxtDni.UseSelectable = true;
            this.TxtDni.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtDni.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtDni.TextChanged += new System.EventHandler(this.TxtDni_TextChanged);
            // 
            // tileDni
            // 
            this.tileDni.ActiveControl = null;
            this.tileDni.Controls.Add(this.lblDni);
            this.tileDni.Enabled = false;
            this.tileDni.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileDni.Location = new System.Drawing.Point(77, 312);
            this.tileDni.Name = "tileDni";
            this.tileDni.Size = new System.Drawing.Size(100, 20);
            this.tileDni.TabIndex = 35;
            this.tileDni.UseSelectable = true;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Enabled = false;
            this.lblDni.Location = new System.Drawing.Point(58, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(31, 19);
            this.lblDni.TabIndex = 5;
            this.lblDni.Text = "DNI";
            // 
            // tileApellido
            // 
            this.tileApellido.ActiveControl = null;
            this.tileApellido.Controls.Add(this.lblApellido);
            this.tileApellido.Enabled = false;
            this.tileApellido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileApellido.Location = new System.Drawing.Point(77, 168);
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
            this.tileNombre.Location = new System.Drawing.Point(77, 120);
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
            this.BtnVolver.TabIndex = 9;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnVolver.UseSelectable = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // BtnMod
            // 
            this.BtnMod.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnMod.Location = new System.Drawing.Point(109, 554);
            this.BtnMod.Name = "BtnMod";
            this.BtnMod.Size = new System.Drawing.Size(100, 23);
            this.BtnMod.TabIndex = 8;
            this.BtnMod.Text = "Mod";
            this.BtnMod.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnMod.UseSelectable = true;
            this.BtnMod.Click += new System.EventHandler(this.BtnMod_Click);
            // 
            // TxtUsuario
            // 
            // 
            // 
            // 
            this.TxtUsuario.CustomButton.Image = null;
            this.TxtUsuario.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.TxtUsuario.CustomButton.Name = "";
            this.TxtUsuario.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TxtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtUsuario.CustomButton.TabIndex = 1;
            this.TxtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtUsuario.CustomButton.UseSelectable = true;
            this.TxtUsuario.CustomButton.Visible = false;
            this.TxtUsuario.Enabled = false;
            this.TxtUsuario.Lines = new string[0];
            this.TxtUsuario.Location = new System.Drawing.Point(173, 216);
            this.TxtUsuario.MaxLength = 60;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.PasswordChar = '\0';
            this.TxtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtUsuario.SelectedText = "";
            this.TxtUsuario.SelectionLength = 0;
            this.TxtUsuario.SelectionStart = 0;
            this.TxtUsuario.ShortcutsEnabled = true;
            this.TxtUsuario.Size = new System.Drawing.Size(177, 20);
            this.TxtUsuario.TabIndex = 2;
            this.TxtUsuario.UseSelectable = true;
            this.TxtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtPass
            // 
            // 
            // 
            // 
            this.TxtPass.CustomButton.Image = null;
            this.TxtPass.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.TxtPass.CustomButton.Name = "";
            this.TxtPass.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TxtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPass.CustomButton.TabIndex = 1;
            this.TxtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPass.CustomButton.UseSelectable = true;
            this.TxtPass.CustomButton.Visible = false;
            this.TxtPass.Lines = new string[0];
            this.TxtPass.Location = new System.Drawing.Point(173, 264);
            this.TxtPass.MaxLength = 60;
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.PasswordChar = '\0';
            this.TxtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPass.SelectedText = "";
            this.TxtPass.SelectionLength = 0;
            this.TxtPass.SelectionStart = 0;
            this.TxtPass.ShortcutsEnabled = true;
            this.TxtPass.Size = new System.Drawing.Size(177, 20);
            this.TxtPass.TabIndex = 3;
            this.TxtPass.UseSelectable = true;
            this.TxtPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtPass.TextChanged += new System.EventHandler(this.TxtPass_TextChanged);
            // 
            // tilePass
            // 
            this.tilePass.ActiveControl = null;
            this.tilePass.Controls.Add(this.lblPass);
            this.tilePass.Enabled = false;
            this.tilePass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tilePass.Location = new System.Drawing.Point(77, 264);
            this.tilePass.Name = "tilePass";
            this.tilePass.Size = new System.Drawing.Size(100, 20);
            this.tilePass.TabIndex = 48;
            this.tilePass.UseSelectable = true;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Enabled = false;
            this.lblPass.Location = new System.Drawing.Point(14, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(75, 19);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "Contraseña";
            // 
            // tileUsuario
            // 
            this.tileUsuario.ActiveControl = null;
            this.tileUsuario.Controls.Add(this.lblUsuario);
            this.tileUsuario.Enabled = false;
            this.tileUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileUsuario.Location = new System.Drawing.Point(77, 216);
            this.tileUsuario.Name = "tileUsuario";
            this.tileUsuario.Size = new System.Drawing.Size(100, 20);
            this.tileUsuario.Style = MetroFramework.MetroColorStyle.Silver;
            this.tileUsuario.TabIndex = 47;
            this.tileUsuario.UseSelectable = true;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Enabled = false;
            this.lblUsuario.Location = new System.Drawing.Point(36, 1);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(53, 19);
            this.lblUsuario.Style = MetroFramework.MetroColorStyle.Silver;
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // ModEmpleado
            // 
            this.ClientSize = new System.Drawing.Size(450, 600);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.tilePass);
            this.Controls.Add(this.tileUsuario);
            this.Controls.Add(this.DateFechaNac);
            this.Controls.Add(this.BoxTipoPerfil);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.tileTipoPerfil);
            this.Controls.Add(this.tileFechaNac);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.tileEmail);
            this.Controls.Add(this.TxtDni);
            this.Controls.Add(this.tileDni);
            this.Controls.Add(this.tileApellido);
            this.Controls.Add(this.tileNombre);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnMod);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(450, 600);
            this.Name = "ModEmpleado";
            this.Text = "Empleado";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.ModEmpleado_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModEmpleado_KeyPress);
            this.tileTipoPerfil.ResumeLayout(false);
            this.tileTipoPerfil.PerformLayout();
            this.tileFechaNac.ResumeLayout(false);
            this.tileFechaNac.PerformLayout();
            this.tileEmail.ResumeLayout(false);
            this.tileEmail.PerformLayout();
            this.tileDni.ResumeLayout(false);
            this.tileDni.PerformLayout();
            this.tileApellido.ResumeLayout(false);
            this.tileApellido.PerformLayout();
            this.tileNombre.ResumeLayout(false);
            this.tileNombre.PerformLayout();
            this.tilePass.ResumeLayout(false);
            this.tilePass.PerformLayout();
            this.tileUsuario.ResumeLayout(false);
            this.tileUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnVolver;
        private MetroFramework.Controls.MetroButton BtnMod;
        private MetroFramework.Controls.MetroTile tileNombre;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private MetroFramework.Controls.MetroTile tileApellido;
        private MetroFramework.Controls.MetroLabel lblApellido;
        private MetroFramework.Controls.MetroTile tileDni;
        private MetroFramework.Controls.MetroLabel lblDni;
        private MetroFramework.Controls.MetroTextBox TxtEmail;
        private MetroFramework.Controls.MetroTile tileEmail;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroTextBox TxtDni;
        private MetroFramework.Controls.MetroTextBox TxtApellido;
        private MetroFramework.Controls.MetroTextBox TxtNombre;
        private MetroFramework.Controls.MetroDateTime DateFechaNac;
        private MetroFramework.Controls.MetroLabel lblFechaNac;
        private MetroFramework.Controls.MetroTile tileFechaNac;
        private MetroFramework.Controls.MetroComboBox BoxTipoPerfil;
        private MetroFramework.Controls.MetroLabel lblTipoPerfil;
        private MetroFramework.Controls.MetroTile tileTipoPerfil;
        private MetroFramework.Controls.MetroTextBox TxtUsuario;
        private MetroFramework.Controls.MetroTextBox TxtPass;
        private MetroFramework.Controls.MetroTile tilePass;
        private MetroFramework.Controls.MetroLabel lblPass;
        private MetroFramework.Controls.MetroTile tileUsuario;
        private MetroFramework.Controls.MetroLabel lblUsuario;
    }
}

namespace Presentacion
{
    partial class Login
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
            this.txtContrasenia = new PasswordTextBoxControl.PasswordTextBox();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.tileContrasenia = new MetroFramework.Controls.MetroTile();
            this.lblContrasenia = new MetroFramework.Controls.MetroLabel();
            this.tileUsuario = new MetroFramework.Controls.MetroTile();
            this.lblUsuario = new MetroFramework.Controls.MetroLabel();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.tileContrasenia.SuspendLayout();
            this.tileUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.HideSelection = false;
            this.txtContrasenia.Location = new System.Drawing.Point(226, 182);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(146, 20);
            this.txtContrasenia.TabIndex = 0;
            // 
            // txtUsuario
            // 
            // 
            // 
            // 
            this.txtUsuario.CustomButton.Image = null;
            this.txtUsuario.CustomButton.Location = new System.Drawing.Point(128, 2);
            this.txtUsuario.CustomButton.Name = "";
            this.txtUsuario.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsuario.CustomButton.TabIndex = 1;
            this.txtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuario.CustomButton.UseSelectable = true;
            this.txtUsuario.CustomButton.Visible = false;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(226, 126);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(146, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.UseSelectable = true;
            this.txtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tileContrasenia
            // 
            this.tileContrasenia.ActiveControl = null;
            this.tileContrasenia.Controls.Add(this.lblContrasenia);
            this.tileContrasenia.Location = new System.Drawing.Point(126, 182);
            this.tileContrasenia.Name = "tileContrasenia";
            this.tileContrasenia.Size = new System.Drawing.Size(100, 20);
            this.tileContrasenia.TabIndex = 3;
            this.tileContrasenia.UseSelectable = true;
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Location = new System.Drawing.Point(12, 0);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(75, 19);
            this.lblContrasenia.TabIndex = 6;
            this.lblContrasenia.Text = "Contraseña";
            // 
            // tileUsuario
            // 
            this.tileUsuario.ActiveControl = null;
            this.tileUsuario.Controls.Add(this.lblUsuario);
            this.tileUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileUsuario.Location = new System.Drawing.Point(126, 126);
            this.tileUsuario.Name = "tileUsuario";
            this.tileUsuario.Size = new System.Drawing.Size(100, 20);
            this.tileUsuario.TabIndex = 2;
            this.tileUsuario.UseSelectable = true;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(34, 1);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(53, 19);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuario";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(198, 262);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(113, 27);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Iniciar Sesión";
            this.btnLogin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 357);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tileContrasenia);
            this.Controls.Add(this.tileUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtContrasenia);
            this.Name = "Login";
            this.Text = "Login";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tileContrasenia.ResumeLayout(false);
            this.tileContrasenia.PerformLayout();
            this.tileUsuario.ResumeLayout(false);
            this.tileUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PasswordTextBoxControl.PasswordTextBox txtContrasenia;
        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroTile tileContrasenia;
        private MetroFramework.Controls.MetroTile tileUsuario;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroLabel lblContrasenia;
        private MetroFramework.Controls.MetroLabel lblUsuario;
    }
}
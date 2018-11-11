namespace Presentacion
{
    partial class ModClienteE
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
            this.BtnMod = new MetroFramework.Controls.MetroButton();
            this.TxtEmpresa = new MetroFramework.Controls.MetroTextBox();
            this.TxtCuit = new MetroFramework.Controls.MetroTextBox();
            this.tileCuit = new MetroFramework.Controls.MetroTile();
            this.lblCuit = new MetroFramework.Controls.MetroLabel();
            this.tileEmpresa = new MetroFramework.Controls.MetroTile();
            this.lblEmpresa = new MetroFramework.Controls.MetroLabel();
            this.tileCuit.SuspendLayout();
            this.tileEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnVolver
            // 
            this.BtnVolver.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnVolver.Location = new System.Drawing.Point(214, 287);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(99, 23);
            this.BtnVolver.TabIndex = 11;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnVolver.UseSelectable = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // BtnMod
            // 
            this.BtnMod.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnMod.Location = new System.Drawing.Point(71, 287);
            this.BtnMod.Name = "BtnMod";
            this.BtnMod.Size = new System.Drawing.Size(100, 23);
            this.BtnMod.TabIndex = 10;
            this.BtnMod.Text = "Mod";
            this.BtnMod.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnMod.UseSelectable = true;
            this.BtnMod.Click += new System.EventHandler(this.BtnMod_Click);
            // 
            // TxtEmpresa
            // 
            // 
            // 
            // 
            this.TxtEmpresa.CustomButton.Image = null;
            this.TxtEmpresa.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.TxtEmpresa.CustomButton.Name = "";
            this.TxtEmpresa.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TxtEmpresa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtEmpresa.CustomButton.TabIndex = 1;
            this.TxtEmpresa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtEmpresa.CustomButton.UseSelectable = true;
            this.TxtEmpresa.CustomButton.Visible = false;
            this.TxtEmpresa.Lines = new string[0];
            this.TxtEmpresa.Location = new System.Drawing.Point(152, 109);
            this.TxtEmpresa.MaxLength = 60;
            this.TxtEmpresa.Name = "TxtEmpresa";
            this.TxtEmpresa.PasswordChar = '\0';
            this.TxtEmpresa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtEmpresa.SelectedText = "";
            this.TxtEmpresa.SelectionLength = 0;
            this.TxtEmpresa.SelectionStart = 0;
            this.TxtEmpresa.ShortcutsEnabled = true;
            this.TxtEmpresa.Size = new System.Drawing.Size(177, 20);
            this.TxtEmpresa.TabIndex = 56;
            this.TxtEmpresa.UseSelectable = true;
            this.TxtEmpresa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtEmpresa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtEmpresa.TextChanged += new System.EventHandler(this.TxtEmpresa_TextChanged);
            // 
            // TxtCuit
            // 
            // 
            // 
            // 
            this.TxtCuit.CustomButton.Image = null;
            this.TxtCuit.CustomButton.Location = new System.Drawing.Point(159, 2);
            this.TxtCuit.CustomButton.Name = "";
            this.TxtCuit.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TxtCuit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtCuit.CustomButton.TabIndex = 1;
            this.TxtCuit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtCuit.CustomButton.UseSelectable = true;
            this.TxtCuit.CustomButton.Visible = false;
            this.TxtCuit.Lines = new string[0];
            this.TxtCuit.Location = new System.Drawing.Point(152, 179);
            this.TxtCuit.MaxLength = 8;
            this.TxtCuit.Name = "TxtCuit";
            this.TxtCuit.PasswordChar = '\0';
            this.TxtCuit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtCuit.SelectedText = "";
            this.TxtCuit.SelectionLength = 0;
            this.TxtCuit.SelectionStart = 0;
            this.TxtCuit.ShortcutsEnabled = true;
            this.TxtCuit.Size = new System.Drawing.Size(177, 20);
            this.TxtCuit.TabIndex = 58;
            this.TxtCuit.UseSelectable = true;
            this.TxtCuit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtCuit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtCuit.TextChanged += new System.EventHandler(this.TxtEmpresa_TextChanged);
            // 
            // tileCuit
            // 
            this.tileCuit.ActiveControl = null;
            this.tileCuit.Controls.Add(this.lblCuit);
            this.tileCuit.Enabled = false;
            this.tileCuit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileCuit.Location = new System.Drawing.Point(56, 179);
            this.tileCuit.Name = "tileCuit";
            this.tileCuit.Size = new System.Drawing.Size(100, 20);
            this.tileCuit.TabIndex = 62;
            this.tileCuit.UseSelectable = true;
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Enabled = false;
            this.lblCuit.Location = new System.Drawing.Point(52, 1);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(37, 19);
            this.lblCuit.TabIndex = 5;
            this.lblCuit.Text = "CUIT";
            // 
            // tileEmpresa
            // 
            this.tileEmpresa.ActiveControl = null;
            this.tileEmpresa.Controls.Add(this.lblEmpresa);
            this.tileEmpresa.Enabled = false;
            this.tileEmpresa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileEmpresa.Location = new System.Drawing.Point(56, 109);
            this.tileEmpresa.Name = "tileEmpresa";
            this.tileEmpresa.Size = new System.Drawing.Size(100, 20);
            this.tileEmpresa.TabIndex = 60;
            this.tileEmpresa.UseSelectable = true;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Enabled = false;
            this.lblEmpresa.Location = new System.Drawing.Point(30, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(60, 19);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "Empresa";
            // 
            // ModClienteE
            // 
            this.ClientSize = new System.Drawing.Size(385, 376);
            this.Controls.Add(this.TxtEmpresa);
            this.Controls.Add(this.TxtCuit);
            this.Controls.Add(this.tileCuit);
            this.Controls.Add(this.tileEmpresa);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnMod);
            this.MinimumSize = new System.Drawing.Size(385, 376);
            this.Name = "ModClienteE";
            this.Text = "Cliente";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.ModClienteE_Load);
            this.tileCuit.ResumeLayout(false);
            this.tileCuit.PerformLayout();
            this.tileEmpresa.ResumeLayout(false);
            this.tileEmpresa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnVolver;
        private MetroFramework.Controls.MetroButton BtnMod;
        private MetroFramework.Controls.MetroTextBox TxtEmpresa;
        private MetroFramework.Controls.MetroTextBox TxtCuit;
        private MetroFramework.Controls.MetroTile tileCuit;
        private MetroFramework.Controls.MetroLabel lblCuit;
        private MetroFramework.Controls.MetroTile tileEmpresa;
        private MetroFramework.Controls.MetroLabel lblEmpresa;
    }
}

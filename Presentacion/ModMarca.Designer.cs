namespace Presentacion
{
    partial class ModMarca
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
            this.tileDescripcion = new MetroFramework.Controls.MetroTile();
            this.lblDescripcion = new MetroFramework.Controls.MetroLabel();
            this.TxtDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.tileDescripcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnVolver
            // 
            this.BtnVolver.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnVolver.Location = new System.Drawing.Point(204, 267);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(99, 23);
            this.BtnVolver.TabIndex = 2;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnVolver.UseSelectable = true;
            this.BtnVolver.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnMod
            // 
            this.BtnMod.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnMod.Location = new System.Drawing.Point(76, 267);
            this.BtnMod.Name = "BtnMod";
            this.BtnMod.Size = new System.Drawing.Size(100, 23);
            this.BtnMod.TabIndex = 1;
            this.BtnMod.Text = "Mod";
            this.BtnMod.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnMod.UseSelectable = true;
            this.BtnMod.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // tileDescripcion
            // 
            this.tileDescripcion.ActiveControl = null;
            this.tileDescripcion.Controls.Add(this.lblDescripcion);
            this.tileDescripcion.Enabled = false;
            this.tileDescripcion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileDescripcion.Location = new System.Drawing.Point(50, 175);
            this.tileDescripcion.Name = "tileDescripcion";
            this.tileDescripcion.Size = new System.Drawing.Size(100, 20);
            this.tileDescripcion.TabIndex = 25;
            this.tileDescripcion.UseSelectable = true;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Enabled = false;
            this.lblDescripcion.Location = new System.Drawing.Point(13, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(76, 19);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción";
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
            this.TxtDescripcion.Location = new System.Drawing.Point(150, 175);
            this.TxtDescripcion.MaxLength = 60;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.PasswordChar = '\0';
            this.TxtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtDescripcion.SelectedText = "";
            this.TxtDescripcion.SelectionLength = 0;
            this.TxtDescripcion.SelectionStart = 0;
            this.TxtDescripcion.ShortcutsEnabled = true;
            this.TxtDescripcion.Size = new System.Drawing.Size(177, 20);
            this.TxtDescripcion.TabIndex = 0;
            this.TxtDescripcion.UseSelectable = true;
            this.TxtDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtDescripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtDescripcion.TextChanged += new System.EventHandler(this.TxtDescripcion_TextChanged);
            // 
            // ModMarca
            // 
            this.ClientSize = new System.Drawing.Size(385, 376);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnMod);
            this.Controls.Add(this.tileDescripcion);
            this.Controls.Add(this.TxtDescripcion);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(385, 376);
            this.MinimumSize = new System.Drawing.Size(385, 376);
            this.Name = "ModMarca";
            this.ShowInTaskbar = false;
            this.Text = "Marca";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModMarca_KeyPress);
            this.tileDescripcion.ResumeLayout(false);
            this.tileDescripcion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnVolver;
        private MetroFramework.Controls.MetroButton BtnMod;
        private MetroFramework.Controls.MetroTile tileDescripcion;
        private MetroFramework.Controls.MetroLabel lblDescripcion;
        private MetroFramework.Controls.MetroTextBox TxtDescripcion;
    }
}

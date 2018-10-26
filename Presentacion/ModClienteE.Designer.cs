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
            this.SuspendLayout();
            // 
            // BtnVolver
            // 
            this.BtnVolver.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnVolver.Location = new System.Drawing.Point(415, 214);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(99, 23);
            this.BtnVolver.TabIndex = 11;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnVolver.UseSelectable = true;
            // 
            // BtnMod
            // 
            this.BtnMod.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnMod.Location = new System.Drawing.Point(287, 214);
            this.BtnMod.Name = "BtnMod";
            this.BtnMod.Size = new System.Drawing.Size(100, 23);
            this.BtnMod.TabIndex = 10;
            this.BtnMod.Text = "Mod";
            this.BtnMod.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnMod.UseSelectable = true;
            // 
            // ModClienteE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnMod);
            this.Name = "ModClienteE";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnVolver;
        private MetroFramework.Controls.MetroButton BtnMod;
    }
}

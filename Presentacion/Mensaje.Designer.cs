namespace Presentacion
{
    partial class Mensaje
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
            this.tileTxt = new MetroFramework.Controls.MetroTile();
            this.BtnAceptar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // tileTxt
            // 
            this.tileTxt.ActiveControl = null;
            this.tileTxt.Enabled = false;
            this.tileTxt.Location = new System.Drawing.Point(23, 70);
            this.tileTxt.Name = "tileTxt";
            this.tileTxt.Size = new System.Drawing.Size(334, 116);
            this.tileTxt.TabIndex = 6;
            this.tileTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileTxt.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileTxt.UseSelectable = true;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(153, 216);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 4;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnAceptar.UseSelectable = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // Mensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 260);
            this.Controls.Add(this.tileTxt);
            this.Controls.Add(this.BtnAceptar);
            this.MaximumSize = new System.Drawing.Size(380, 260);
            this.MinimumSize = new System.Drawing.Size(380, 260);
            this.Name = "Mensaje";
            this.Text = "Advertencia";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileTxt;
        private MetroFramework.Controls.MetroButton BtnAceptar;
    }
}
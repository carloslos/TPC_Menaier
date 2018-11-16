namespace Presentacion
{
    partial class Confirmacion
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
            this.BtnSi = new MetroFramework.Controls.MetroButton();
            this.BtnNo = new MetroFramework.Controls.MetroButton();
            this.tileTxt = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // BtnSi
            // 
            this.BtnSi.Location = new System.Drawing.Point(98, 200);
            this.BtnSi.Name = "BtnSi";
            this.BtnSi.Size = new System.Drawing.Size(75, 23);
            this.BtnSi.TabIndex = 1;
            this.BtnSi.Text = "Si";
            this.BtnSi.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnSi.UseSelectable = true;
            this.BtnSi.Click += new System.EventHandler(this.BtnSi_Click);
            // 
            // BtnNo
            // 
            this.BtnNo.Location = new System.Drawing.Point(207, 200);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.Size = new System.Drawing.Size(75, 23);
            this.BtnNo.TabIndex = 0;
            this.BtnNo.Text = "No";
            this.BtnNo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnNo.UseSelectable = true;
            this.BtnNo.Click += new System.EventHandler(this.BtnNo_Click);
            // 
            // tileTxt
            // 
            this.tileTxt.ActiveControl = null;
            this.tileTxt.Enabled = false;
            this.tileTxt.Location = new System.Drawing.Point(23, 45);
            this.tileTxt.Name = "tileTxt";
            this.tileTxt.Size = new System.Drawing.Size(334, 116);
            this.tileTxt.TabIndex = 3;
            this.tileTxt.Text = "¿Está seguro que desea ";
            this.tileTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileTxt.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileTxt.UseSelectable = true;
            // 
            // Confirmacion
            // 
            this.ClientSize = new System.Drawing.Size(380, 260);
            this.Controls.Add(this.tileTxt);
            this.Controls.Add(this.BtnSi);
            this.Controls.Add(this.BtnNo);
            this.MaximumSize = new System.Drawing.Size(380, 260);
            this.MinimumSize = new System.Drawing.Size(380, 260);
            this.Name = "Confirmacion";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnSi;
        private MetroFramework.Controls.MetroButton BtnNo;
        private MetroFramework.Controls.MetroTile tileTxt;
    }
}

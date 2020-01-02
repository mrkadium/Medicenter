namespace Informes.GUI.Inventario
{
    partial class crvInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crvInventario));
            this.txbIdMarca = new System.Windows.Forms.TextBox();
            this.crInventa = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // txbIdMarca
            // 
            this.txbIdMarca.Location = new System.Drawing.Point(12, 12);
            this.txbIdMarca.Name = "txbIdMarca";
            this.txbIdMarca.ReadOnly = true;
            this.txbIdMarca.Size = new System.Drawing.Size(100, 20);
            this.txbIdMarca.TabIndex = 44;
            this.txbIdMarca.TabStop = false;
            this.txbIdMarca.Visible = false;
            // 
            // crInventa
            // 
            this.crInventa.ActiveViewIndex = -1;
            this.crInventa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crInventa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crInventa.Cursor = System.Windows.Forms.Cursors.Default;
            this.crInventa.Location = new System.Drawing.Point(12, 12);
            this.crInventa.Name = "crInventa";
            this.crInventa.Size = new System.Drawing.Size(1275, 696);
            this.crInventa.TabIndex = 45;
            this.crInventa.Load += new System.EventHandler(this.crInventa_Load);
            // 
            // crvInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1299, 720);
            this.Controls.Add(this.crInventa);
            this.Controls.Add(this.txbIdMarca);
            this.Name = "crvInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de inventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txbIdMarca;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crInventa;
    }
}
namespace Informes.GUI.Compras
{
    partial class crvComprasMarcaEspecifica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crvComprasMarcaEspecifica));
            this.txbFechaFin = new System.Windows.Forms.TextBox();
            this.txbFechaInicio = new System.Windows.Forms.TextBox();
            this.txbIdMarca = new System.Windows.Forms.TextBox();
            this.crComprasMarca = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // txbFechaFin
            // 
            this.txbFechaFin.Location = new System.Drawing.Point(118, 12);
            this.txbFechaFin.Name = "txbFechaFin";
            this.txbFechaFin.ReadOnly = true;
            this.txbFechaFin.Size = new System.Drawing.Size(100, 20);
            this.txbFechaFin.TabIndex = 53;
            this.txbFechaFin.TabStop = false;
            this.txbFechaFin.Visible = false;
            // 
            // txbFechaInicio
            // 
            this.txbFechaInicio.Location = new System.Drawing.Point(12, 12);
            this.txbFechaInicio.Name = "txbFechaInicio";
            this.txbFechaInicio.ReadOnly = true;
            this.txbFechaInicio.Size = new System.Drawing.Size(100, 20);
            this.txbFechaInicio.TabIndex = 52;
            this.txbFechaInicio.TabStop = false;
            this.txbFechaInicio.Visible = false;
            // 
            // txbIdMarca
            // 
            this.txbIdMarca.Location = new System.Drawing.Point(224, 12);
            this.txbIdMarca.Name = "txbIdMarca";
            this.txbIdMarca.ReadOnly = true;
            this.txbIdMarca.Size = new System.Drawing.Size(100, 20);
            this.txbIdMarca.TabIndex = 54;
            this.txbIdMarca.TabStop = false;
            this.txbIdMarca.Visible = false;
            // 
            // crComprasMarca
            // 
            this.crComprasMarca.ActiveViewIndex = -1;
            this.crComprasMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crComprasMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crComprasMarca.Cursor = System.Windows.Forms.Cursors.Default;
            this.crComprasMarca.Location = new System.Drawing.Point(12, 12);
            this.crComprasMarca.Name = "crComprasMarca";
            this.crComprasMarca.Size = new System.Drawing.Size(1275, 696);
            this.crComprasMarca.TabIndex = 55;
            // 
            // crvComprasMarcaEspecifica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1299, 720);
            this.Controls.Add(this.crComprasMarca);
            this.Controls.Add(this.txbFechaFin);
            this.Controls.Add(this.txbFechaInicio);
            this.Controls.Add(this.txbIdMarca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "crvComprasMarcaEspecifica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de compras de marca";
            this.Load += new System.EventHandler(this.crvComprasMarcaEspecifica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txbFechaFin;
        public System.Windows.Forms.TextBox txbFechaInicio;
        public System.Windows.Forms.TextBox txbIdMarca;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crComprasMarca;
    }
}
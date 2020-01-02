namespace Informes.GUI.Ventas
{
    partial class crvProductoEspecifico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crvProductoEspecifico));
            this.txbFechaFin = new System.Windows.Forms.TextBox();
            this.txbFechaInicio = new System.Windows.Forms.TextBox();
            this.txbIdProducto = new System.Windows.Forms.TextBox();
            this.crVentasProduc = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // txbFechaFin
            // 
            this.txbFechaFin.Location = new System.Drawing.Point(118, 12);
            this.txbFechaFin.Name = "txbFechaFin";
            this.txbFechaFin.ReadOnly = true;
            this.txbFechaFin.Size = new System.Drawing.Size(100, 20);
            this.txbFechaFin.TabIndex = 47;
            this.txbFechaFin.TabStop = false;
            this.txbFechaFin.Visible = false;
            // 
            // txbFechaInicio
            // 
            this.txbFechaInicio.Location = new System.Drawing.Point(12, 12);
            this.txbFechaInicio.Name = "txbFechaInicio";
            this.txbFechaInicio.ReadOnly = true;
            this.txbFechaInicio.Size = new System.Drawing.Size(100, 20);
            this.txbFechaInicio.TabIndex = 46;
            this.txbFechaInicio.TabStop = false;
            this.txbFechaInicio.Visible = false;
            // 
            // txbIdProducto
            // 
            this.txbIdProducto.Location = new System.Drawing.Point(224, 12);
            this.txbIdProducto.Name = "txbIdProducto";
            this.txbIdProducto.ReadOnly = true;
            this.txbIdProducto.Size = new System.Drawing.Size(100, 20);
            this.txbIdProducto.TabIndex = 48;
            this.txbIdProducto.TabStop = false;
            this.txbIdProducto.Visible = false;
            // 
            // crVentasProduc
            // 
            this.crVentasProduc.ActiveViewIndex = -1;
            this.crVentasProduc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crVentasProduc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crVentasProduc.Cursor = System.Windows.Forms.Cursors.Default;
            this.crVentasProduc.Location = new System.Drawing.Point(12, 12);
            this.crVentasProduc.Name = "crVentasProduc";
            this.crVentasProduc.Size = new System.Drawing.Size(1275, 696);
            this.crVentasProduc.TabIndex = 49;
            // 
            // crvProductoEspecifico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1299, 720);
            this.Controls.Add(this.crVentasProduc);
            this.Controls.Add(this.txbFechaFin);
            this.Controls.Add(this.txbFechaInicio);
            this.Controls.Add(this.txbIdProducto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "crvProductoEspecifico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de ventas de producto específico";
            this.Load += new System.EventHandler(this.crvProductoEspecifico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txbFechaFin;
        public System.Windows.Forms.TextBox txbFechaInicio;
        public System.Windows.Forms.TextBox txbIdProducto;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crVentasProduc;
    }
}
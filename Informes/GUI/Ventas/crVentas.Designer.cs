namespace Informes.GUI
{
    partial class crVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crVentas));
            this.crvVentas = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txbFechaInicio = new System.Windows.Forms.TextBox();
            this.txbFechaFin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // crvVentas
            // 
            this.crvVentas.ActiveViewIndex = -1;
            this.crvVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crvVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvVentas.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvVentas.Location = new System.Drawing.Point(12, 12);
            this.crvVentas.Name = "crvVentas";
            this.crvVentas.Size = new System.Drawing.Size(1275, 696);
            this.crvVentas.TabIndex = 37;
            // 
            // txbFechaInicio
            // 
            this.txbFechaInicio.Location = new System.Drawing.Point(14, 12);
            this.txbFechaInicio.Name = "txbFechaInicio";
            this.txbFechaInicio.ReadOnly = true;
            this.txbFechaInicio.Size = new System.Drawing.Size(100, 20);
            this.txbFechaInicio.TabIndex = 38;
            this.txbFechaInicio.TabStop = false;
            this.txbFechaInicio.Visible = false;
            // 
            // txbFechaFin
            // 
            this.txbFechaFin.Location = new System.Drawing.Point(120, 12);
            this.txbFechaFin.Name = "txbFechaFin";
            this.txbFechaFin.ReadOnly = true;
            this.txbFechaFin.Size = new System.Drawing.Size(100, 20);
            this.txbFechaFin.TabIndex = 39;
            this.txbFechaFin.TabStop = false;
            this.txbFechaFin.Visible = false;
            // 
            // crVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1299, 720);
            this.Controls.Add(this.crvVentas);
            this.Controls.Add(this.txbFechaFin);
            this.Controls.Add(this.txbFechaInicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "crVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de ventas general";
            this.Load += new System.EventHandler(this.crVentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvVentas;
        public System.Windows.Forms.TextBox txbFechaFin;
        public System.Windows.Forms.TextBox txbFechaInicio;
    }
}
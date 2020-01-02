namespace Informes.GUI.Constancias
{
    partial class crConstanciaMedica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crConstanciaMedica));
            this.txbIncapacidad = new System.Windows.Forms.TextBox();
            this.txbPaciente = new System.Windows.Forms.TextBox();
            this.txbIdPaciente = new System.Windows.Forms.TextBox();
            this.crvConstanciaMedica = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // txbIncapacidad
            // 
            this.txbIncapacidad.Location = new System.Drawing.Point(130, 12);
            this.txbIncapacidad.Name = "txbIncapacidad";
            this.txbIncapacidad.Size = new System.Drawing.Size(100, 20);
            this.txbIncapacidad.TabIndex = 31;
            this.txbIncapacidad.Visible = false;
            // 
            // txbPaciente
            // 
            this.txbPaciente.Location = new System.Drawing.Point(12, 12);
            this.txbPaciente.Name = "txbPaciente";
            this.txbPaciente.Size = new System.Drawing.Size(100, 20);
            this.txbPaciente.TabIndex = 30;
            this.txbPaciente.Visible = false;
            // 
            // txbIdPaciente
            // 
            this.txbIdPaciente.Location = new System.Drawing.Point(236, 12);
            this.txbIdPaciente.Name = "txbIdPaciente";
            this.txbIdPaciente.Size = new System.Drawing.Size(100, 20);
            this.txbIdPaciente.TabIndex = 32;
            this.txbIdPaciente.Visible = false;
            // 
            // crvConstanciaMedica
            // 
            this.crvConstanciaMedica.ActiveViewIndex = -1;
            this.crvConstanciaMedica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crvConstanciaMedica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvConstanciaMedica.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvConstanciaMedica.Location = new System.Drawing.Point(12, 12);
            this.crvConstanciaMedica.Name = "crvConstanciaMedica";
            this.crvConstanciaMedica.Size = new System.Drawing.Size(1275, 633);
            this.crvConstanciaMedica.TabIndex = 33;
            // 
            // crConstanciaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1299, 657);
            this.Controls.Add(this.crvConstanciaMedica);
            this.Controls.Add(this.txbIncapacidad);
            this.Controls.Add(this.txbPaciente);
            this.Controls.Add(this.txbIdPaciente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "crConstanciaMedica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Constancia médica";
            this.Load += new System.EventHandler(this.crConstanciaMedica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txbIncapacidad;
        public System.Windows.Forms.TextBox txbPaciente;
        public System.Windows.Forms.TextBox txbIdPaciente;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvConstanciaMedica;
    }
}
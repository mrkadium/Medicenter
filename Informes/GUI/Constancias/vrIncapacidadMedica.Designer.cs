namespace Informes.GUI.Constancias
{
    partial class vrIncapacidadMedica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vrIncapacidadMedica));
            this.txbIncapacidad = new System.Windows.Forms.TextBox();
            this.txbPaciente = new System.Windows.Forms.TextBox();
            this.crvIncapacidadMedica = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txbIdPaciente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbIncapacidad
            // 
            this.txbIncapacidad.Location = new System.Drawing.Point(130, 12);
            this.txbIncapacidad.Name = "txbIncapacidad";
            this.txbIncapacidad.Size = new System.Drawing.Size(100, 20);
            this.txbIncapacidad.TabIndex = 24;
            this.txbIncapacidad.Visible = false;
            // 
            // txbPaciente
            // 
            this.txbPaciente.Location = new System.Drawing.Point(12, 12);
            this.txbPaciente.Name = "txbPaciente";
            this.txbPaciente.Size = new System.Drawing.Size(100, 20);
            this.txbPaciente.TabIndex = 22;
            this.txbPaciente.Visible = false;
            // 
            // crvIncapacidadMedica
            // 
            this.crvIncapacidadMedica.ActiveViewIndex = -1;
            this.crvIncapacidadMedica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crvIncapacidadMedica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvIncapacidadMedica.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvIncapacidadMedica.Location = new System.Drawing.Point(12, 12);
            this.crvIncapacidadMedica.Name = "crvIncapacidadMedica";
            this.crvIncapacidadMedica.Size = new System.Drawing.Size(1275, 633);
            this.crvIncapacidadMedica.TabIndex = 28;
            // 
            // txbIdPaciente
            // 
            this.txbIdPaciente.Location = new System.Drawing.Point(236, 12);
            this.txbIdPaciente.Name = "txbIdPaciente";
            this.txbIdPaciente.Size = new System.Drawing.Size(100, 20);
            this.txbIdPaciente.TabIndex = 29;
            this.txbIdPaciente.Visible = false;
            // 
            // vrIncapacidadMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1299, 657);
            this.Controls.Add(this.crvIncapacidadMedica);
            this.Controls.Add(this.txbIncapacidad);
            this.Controls.Add(this.txbPaciente);
            this.Controls.Add(this.txbIdPaciente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "vrIncapacidadMedica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incapacidad médica";
            this.Load += new System.EventHandler(this.vrIncapacidadMedica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txbIncapacidad;
        public System.Windows.Forms.TextBox txbPaciente;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvIncapacidadMedica;
        public System.Windows.Forms.TextBox txbIdPaciente;
    }
}
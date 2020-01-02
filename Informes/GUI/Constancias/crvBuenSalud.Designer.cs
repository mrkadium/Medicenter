namespace Informes.GUI.Constancias
{
    partial class crvBuenSalud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(crvBuenSalud));
            this.txbidMedico = new System.Windows.Forms.TextBox();
            this.txbPaciente = new System.Windows.Forms.TextBox();
            this.txbIdPaciente = new System.Windows.Forms.TextBox();
            this.crvBuenaSalud = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // txbidMedico
            // 
            this.txbidMedico.Location = new System.Drawing.Point(130, 30);
            this.txbidMedico.Name = "txbidMedico";
            this.txbidMedico.Size = new System.Drawing.Size(100, 20);
            this.txbidMedico.TabIndex = 34;
            this.txbidMedico.Visible = false;
            // 
            // txbPaciente
            // 
            this.txbPaciente.Location = new System.Drawing.Point(12, 30);
            this.txbPaciente.Name = "txbPaciente";
            this.txbPaciente.Size = new System.Drawing.Size(100, 20);
            this.txbPaciente.TabIndex = 33;
            this.txbPaciente.Visible = false;
            // 
            // txbIdPaciente
            // 
            this.txbIdPaciente.Location = new System.Drawing.Point(236, 30);
            this.txbIdPaciente.Name = "txbIdPaciente";
            this.txbIdPaciente.Size = new System.Drawing.Size(100, 20);
            this.txbIdPaciente.TabIndex = 35;
            this.txbIdPaciente.Visible = false;
            // 
            // crvBuenaSalud
            // 
            this.crvBuenaSalud.ActiveViewIndex = -1;
            this.crvBuenaSalud.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crvBuenaSalud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvBuenaSalud.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvBuenaSalud.Location = new System.Drawing.Point(12, 12);
            this.crvBuenaSalud.Name = "crvBuenaSalud";
            this.crvBuenaSalud.Size = new System.Drawing.Size(1275, 633);
            this.crvBuenaSalud.TabIndex = 36;
            // 
            // crvBuenSalud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1299, 657);
            this.Controls.Add(this.crvBuenaSalud);
            this.Controls.Add(this.txbidMedico);
            this.Controls.Add(this.txbPaciente);
            this.Controls.Add(this.txbIdPaciente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "crvBuenSalud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Constancia de buena salud";
            this.Load += new System.EventHandler(this.crvBuenSalud_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txbidMedico;
        public System.Windows.Forms.TextBox txbPaciente;
        public System.Windows.Forms.TextBox txbIdPaciente;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvBuenaSalud;
    }
}
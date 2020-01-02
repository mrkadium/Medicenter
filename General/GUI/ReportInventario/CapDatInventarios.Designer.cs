namespace General.GUI.ReportInventario
{
    partial class CapDatInventarios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CapDatInventarios));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbTipoReporte = new System.Windows.Forms.GroupBox();
            this.rdbGeneral = new System.Windows.Forms.RadioButton();
            this.rdbMarca = new System.Windows.Forms.RadioButton();
            this.txbIdMarca = new System.Windows.Forms.TextBox();
            this.btnMarca = new System.Windows.Forms.Button();
            this.txbMarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpbTipoReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.AutoEllipsis = true;
            this.btnCerrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(267, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(41, 32);
            this.btnCerrar.TabIndex = 42;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(30, 15, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Tipo de reporte";
            // 
            // gpbTipoReporte
            // 
            this.gpbTipoReporte.Controls.Add(this.rdbGeneral);
            this.gpbTipoReporte.Controls.Add(this.rdbMarca);
            this.gpbTipoReporte.Location = new System.Drawing.Point(77, 54);
            this.gpbTipoReporte.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.gpbTipoReporte.Name = "gpbTipoReporte";
            this.gpbTipoReporte.Size = new System.Drawing.Size(146, 83);
            this.gpbTipoReporte.TabIndex = 0;
            this.gpbTipoReporte.TabStop = false;
            // 
            // rdbGeneral
            // 
            this.rdbGeneral.AutoSize = true;
            this.rdbGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGeneral.Location = new System.Drawing.Point(15, 17);
            this.rdbGeneral.Name = "rdbGeneral";
            this.rdbGeneral.Size = new System.Drawing.Size(74, 20);
            this.rdbGeneral.TabIndex = 1;
            this.rdbGeneral.Text = "General";
            this.rdbGeneral.UseVisualStyleBackColor = true;
            this.rdbGeneral.CheckedChanged += new System.EventHandler(this.rdbGeneral_CheckedChanged);
            // 
            // rdbMarca
            // 
            this.rdbMarca.AutoSize = true;
            this.rdbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMarca.Location = new System.Drawing.Point(15, 43);
            this.rdbMarca.Name = "rdbMarca";
            this.rdbMarca.Size = new System.Drawing.Size(64, 20);
            this.rdbMarca.TabIndex = 2;
            this.rdbMarca.Text = "Marca";
            this.rdbMarca.UseVisualStyleBackColor = true;
            this.rdbMarca.CheckedChanged += new System.EventHandler(this.rdbMarca_CheckedChanged);
            // 
            // txbIdMarca
            // 
            this.txbIdMarca.Location = new System.Drawing.Point(36, 176);
            this.txbIdMarca.Name = "txbIdMarca";
            this.txbIdMarca.Size = new System.Drawing.Size(13, 20);
            this.txbIdMarca.TabIndex = 3;
            this.txbIdMarca.TabStop = false;
            this.txbIdMarca.Visible = false;
            // 
            // btnMarca
            // 
            this.btnMarca.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMarca.BackgroundImage = global::General.Properties.Resources.archive1;
            this.btnMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMarca.Enabled = false;
            this.btnMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnMarca.ForeColor = System.Drawing.Color.White;
            this.btnMarca.Location = new System.Drawing.Point(213, 171);
            this.btnMarca.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(36, 28);
            this.btnMarca.TabIndex = 5;
            this.btnMarca.UseVisualStyleBackColor = false;
            this.btnMarca.Click += new System.EventHandler(this.btnMarca_Click);
            this.btnMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnMarca_KeyPress);
            // 
            // txbMarca
            // 
            this.txbMarca.Enabled = false;
            this.txbMarca.Location = new System.Drawing.Point(50, 176);
            this.txbMarca.Name = "txbMarca";
            this.txbMarca.ReadOnly = true;
            this.txbMarca.Size = new System.Drawing.Size(160, 20);
            this.txbMarca.TabIndex = 4;
            this.txbMarca.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 57;
            this.label4.Text = "Marca";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(168, 239);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 40);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnCancelar_KeyPress);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(50, 239);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(87, 40);
            this.btnGenerar.TabIndex = 6;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            this.btnGenerar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnGenerar_KeyPress);
            // 
            // Notificador
            // 
            this.Notificador.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Notificador.ContainerControl = this;
            // 
            // CapDatInventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(308, 317);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txbIdMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMarca);
            this.Controls.Add(this.gpbTipoReporte);
            this.Controls.Add(this.txbMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CapDatInventarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion de reporte de inventario";
            this.gpbTipoReporte.ResumeLayout(false);
            this.gpbTipoReporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.GroupBox gpbTipoReporte;
        public System.Windows.Forms.RadioButton rdbGeneral;
        public System.Windows.Forms.RadioButton rdbMarca;
        public System.Windows.Forms.TextBox txbIdMarca;
        public System.Windows.Forms.Button btnMarca;
        public System.Windows.Forms.TextBox txbMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ErrorProvider Notificador;
    }
}
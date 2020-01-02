namespace General.GUI.Constancias
{
    partial class CapDatIncapacidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CapDatIncapacidad));
            this.txbIncapacidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txbIdPaciente = new System.Windows.Forms.TextBox();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbRadioB = new System.Windows.Forms.GroupBox();
            this.rdbBuenaSalud = new System.Windows.Forms.RadioButton();
            this.rdbConstanciaMedica = new System.Windows.Forms.RadioButton();
            this.rdbIncapacidad = new System.Windows.Forms.RadioButton();
            this.txbidMedico = new System.Windows.Forms.TextBox();
            this.btnMedico = new System.Windows.Forms.Button();
            this.txbMedico = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gpbRadioB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // txbIncapacidad
            // 
            this.txbIncapacidad.Location = new System.Drawing.Point(40, 290);
            this.txbIncapacidad.Name = "txbIncapacidad";
            this.txbIncapacidad.ReadOnly = true;
            this.txbIncapacidad.Size = new System.Drawing.Size(58, 20);
            this.txbIncapacidad.TabIndex = 10;
            this.txbIncapacidad.TabStop = false;
            this.txbIncapacidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbIncapacidad_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Dias de incapacidad";
            // 
            // txbPaciente
            // 
            this.txbPaciente.Location = new System.Drawing.Point(40, 182);
            this.txbPaciente.Name = "txbPaciente";
            this.txbPaciente.ReadOnly = true;
            this.txbPaciente.Size = new System.Drawing.Size(191, 20);
            this.txbPaciente.TabIndex = 5;
            this.txbPaciente.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Paciente";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(166, 337);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 40);
            this.btnCancelar.TabIndex = 12;
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
            this.btnGenerar.Location = new System.Drawing.Point(48, 337);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(87, 40);
            this.btnGenerar.TabIndex = 11;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            this.btnGenerar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnGenerar_KeyPress);
            // 
            // txbIdPaciente
            // 
            this.txbIdPaciente.Location = new System.Drawing.Point(21, 181);
            this.txbIdPaciente.Name = "txbIdPaciente";
            this.txbIdPaciente.Size = new System.Drawing.Size(13, 20);
            this.txbIdPaciente.TabIndex = 4;
            this.txbIdPaciente.TabStop = false;
            this.txbIdPaciente.Visible = false;
            // 
            // btnPaciente
            // 
            this.btnPaciente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPaciente.BackgroundImage = global::General.Properties.Resources.archive1;
            this.btnPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnPaciente.ForeColor = System.Drawing.Color.White;
            this.btnPaciente.Location = new System.Drawing.Point(234, 177);
            this.btnPaciente.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(36, 28);
            this.btnPaciente.TabIndex = 6;
            this.btnPaciente.UseVisualStyleBackColor = false;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            this.btnPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnPaciente_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(30, 15, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Tipo de constancia";
            // 
            // gpbRadioB
            // 
            this.gpbRadioB.Controls.Add(this.rdbBuenaSalud);
            this.gpbRadioB.Controls.Add(this.rdbConstanciaMedica);
            this.gpbRadioB.Controls.Add(this.rdbIncapacidad);
            this.gpbRadioB.Location = new System.Drawing.Point(66, 50);
            this.gpbRadioB.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.gpbRadioB.Name = "gpbRadioB";
            this.gpbRadioB.Size = new System.Drawing.Size(165, 100);
            this.gpbRadioB.TabIndex = 0;
            this.gpbRadioB.TabStop = false;
            // 
            // rdbBuenaSalud
            // 
            this.rdbBuenaSalud.AutoSize = true;
            this.rdbBuenaSalud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBuenaSalud.Location = new System.Drawing.Point(15, 74);
            this.rdbBuenaSalud.Name = "rdbBuenaSalud";
            this.rdbBuenaSalud.Size = new System.Drawing.Size(101, 20);
            this.rdbBuenaSalud.TabIndex = 3;
            this.rdbBuenaSalud.Text = "Buena salud";
            this.rdbBuenaSalud.UseVisualStyleBackColor = true;
            this.rdbBuenaSalud.CheckedChanged += new System.EventHandler(this.rdbBuenaSalud_CheckedChanged);
            // 
            // rdbConstanciaMedica
            // 
            this.rdbConstanciaMedica.AutoSize = true;
            this.rdbConstanciaMedica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbConstanciaMedica.Location = new System.Drawing.Point(15, 45);
            this.rdbConstanciaMedica.Name = "rdbConstanciaMedica";
            this.rdbConstanciaMedica.Size = new System.Drawing.Size(141, 20);
            this.rdbConstanciaMedica.TabIndex = 2;
            this.rdbConstanciaMedica.Text = "Constancia médica";
            this.rdbConstanciaMedica.UseVisualStyleBackColor = true;
            this.rdbConstanciaMedica.CheckedChanged += new System.EventHandler(this.rdbConstanciaMedica_CheckedChanged);
            // 
            // rdbIncapacidad
            // 
            this.rdbIncapacidad.AutoSize = true;
            this.rdbIncapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbIncapacidad.Location = new System.Drawing.Point(15, 19);
            this.rdbIncapacidad.Name = "rdbIncapacidad";
            this.rdbIncapacidad.Size = new System.Drawing.Size(101, 20);
            this.rdbIncapacidad.TabIndex = 1;
            this.rdbIncapacidad.Text = "Incapacidad";
            this.rdbIncapacidad.UseVisualStyleBackColor = true;
            this.rdbIncapacidad.CheckedChanged += new System.EventHandler(this.rdbIncapacidad_CheckedChanged);
            // 
            // txbidMedico
            // 
            this.txbidMedico.Location = new System.Drawing.Point(21, 235);
            this.txbidMedico.Name = "txbidMedico";
            this.txbidMedico.Size = new System.Drawing.Size(13, 20);
            this.txbidMedico.TabIndex = 7;
            this.txbidMedico.TabStop = false;
            this.txbidMedico.Visible = false;
            // 
            // btnMedico
            // 
            this.btnMedico.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMedico.BackgroundImage = global::General.Properties.Resources.archive1;
            this.btnMedico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMedico.Enabled = false;
            this.btnMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnMedico.ForeColor = System.Drawing.Color.White;
            this.btnMedico.Location = new System.Drawing.Point(234, 231);
            this.btnMedico.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Size = new System.Drawing.Size(36, 28);
            this.btnMedico.TabIndex = 9;
            this.btnMedico.UseVisualStyleBackColor = false;
            this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click);
            this.btnMedico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnMedico_KeyPress);
            // 
            // txbMedico
            // 
            this.txbMedico.Location = new System.Drawing.Point(40, 236);
            this.txbMedico.Name = "txbMedico";
            this.txbMedico.ReadOnly = true;
            this.txbMedico.Size = new System.Drawing.Size(191, 20);
            this.txbMedico.TabIndex = 8;
            this.txbMedico.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Médico";
            // 
            // Notificador
            // 
            this.Notificador.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Notificador.ContainerControl = this;
            // 
            // btnCerrar
            // 
            this.btnCerrar.AutoEllipsis = true;
            this.btnCerrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(269, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(41, 32);
            this.btnCerrar.TabIndex = 40;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // CapDatIncapacidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(310, 398);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txbidMedico);
            this.Controls.Add(this.btnMedico);
            this.Controls.Add(this.txbMedico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gpbRadioB);
            this.Controls.Add(this.txbIdPaciente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnPaciente);
            this.Controls.Add(this.txbIncapacidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbPaciente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CapDatIncapacidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos para la constancia";
            this.gpbRadioB.ResumeLayout(false);
            this.gpbRadioB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnPaciente;
        public System.Windows.Forms.TextBox txbIncapacidad;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txbPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGenerar;
        public System.Windows.Forms.TextBox txbIdPaciente;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.GroupBox gpbRadioB;
        public System.Windows.Forms.RadioButton rdbBuenaSalud;
        public System.Windows.Forms.RadioButton rdbConstanciaMedica;
        public System.Windows.Forms.RadioButton rdbIncapacidad;
        public System.Windows.Forms.TextBox txbidMedico;
        public System.Windows.Forms.Button btnMedico;
        public System.Windows.Forms.TextBox txbMedico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider Notificador;
        private System.Windows.Forms.Button btnCerrar;
    }
}
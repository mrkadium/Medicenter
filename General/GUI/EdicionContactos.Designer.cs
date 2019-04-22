namespace General.GUI
{
    partial class EdicionContactos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbIDContacto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPropietario = new System.Windows.Forms.TextBox();
            this.btnBuscarPropietario = new System.Windows.Forms.Button();
            this.rdbEmpleado = new System.Windows.Forms.RadioButton();
            this.rdbMedico = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txbContacto = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gpbFuenteContacto = new System.Windows.Forms.GroupBox();
            this.lblIDPropietario = new System.Windows.Forms.Label();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpbFuenteContacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Contacto";
            // 
            // txbIDContacto
            // 
            this.txbIDContacto.Location = new System.Drawing.Point(47, 57);
            this.txbIDContacto.Name = "txbIDContacto";
            this.txbIDContacto.ReadOnly = true;
            this.txbIDContacto.Size = new System.Drawing.Size(85, 22);
            this.txbIDContacto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(218, 55);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(172, 24);
            this.cmbTipo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Propietario";
            // 
            // txbPropietario
            // 
            this.txbPropietario.Location = new System.Drawing.Point(47, 175);
            this.txbPropietario.Name = "txbPropietario";
            this.txbPropietario.ReadOnly = true;
            this.txbPropietario.Size = new System.Drawing.Size(266, 22);
            this.txbPropietario.TabIndex = 5;
            // 
            // btnBuscarPropietario
            // 
            this.btnBuscarPropietario.Location = new System.Drawing.Point(321, 171);
            this.btnBuscarPropietario.Name = "btnBuscarPropietario";
            this.btnBuscarPropietario.Size = new System.Drawing.Size(71, 29);
            this.btnBuscarPropietario.TabIndex = 6;
            this.btnBuscarPropietario.Text = "Buscar";
            this.btnBuscarPropietario.UseVisualStyleBackColor = true;
            this.btnBuscarPropietario.Click += new System.EventHandler(this.btnBuscarPropietario_Click);
            // 
            // rdbEmpleado
            // 
            this.rdbEmpleado.AutoSize = true;
            this.rdbEmpleado.Location = new System.Drawing.Point(40, 23);
            this.rdbEmpleado.Name = "rdbEmpleado";
            this.rdbEmpleado.Size = new System.Drawing.Size(89, 20);
            this.rdbEmpleado.TabIndex = 7;
            this.rdbEmpleado.Text = "Empleado";
            this.rdbEmpleado.UseVisualStyleBackColor = true;
            // 
            // rdbMedico
            // 
            this.rdbMedico.AutoSize = true;
            this.rdbMedico.Location = new System.Drawing.Point(202, 23);
            this.rdbMedico.Name = "rdbMedico";
            this.rdbMedico.Size = new System.Drawing.Size(71, 20);
            this.rdbMedico.TabIndex = 8;
            this.rdbMedico.Text = "Médico";
            this.rdbMedico.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Contacto";
            // 
            // txbContacto
            // 
            this.txbContacto.Location = new System.Drawing.Point(47, 237);
            this.txbContacto.Name = "txbContacto";
            this.txbContacto.Size = new System.Drawing.Size(343, 22);
            this.txbContacto.TabIndex = 11;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(163, 287);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 29);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(291, 287);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 29);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gpbFuenteContacto
            // 
            this.gpbFuenteContacto.Controls.Add(this.rdbEmpleado);
            this.gpbFuenteContacto.Controls.Add(this.rdbMedico);
            this.gpbFuenteContacto.Location = new System.Drawing.Point(47, 90);
            this.gpbFuenteContacto.Name = "gpbFuenteContacto";
            this.gpbFuenteContacto.Size = new System.Drawing.Size(345, 61);
            this.gpbFuenteContacto.TabIndex = 14;
            this.gpbFuenteContacto.TabStop = false;
            this.gpbFuenteContacto.Text = "Seleccione la fuente del contacto";
            // 
            // lblIDPropietario
            // 
            this.lblIDPropietario.AutoSize = true;
            this.lblIDPropietario.Location = new System.Drawing.Point(321, 154);
            this.lblIDPropietario.Name = "lblIDPropietario";
            this.lblIDPropietario.Size = new System.Drawing.Size(0, 16);
            this.lblIDPropietario.TabIndex = 15;
            this.lblIDPropietario.Visible = false;
            // 
            // Notificador
            // 
            this.Notificador.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Notificador.ContainerControl = this;
            // 
            // EdicionContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 336);
            this.Controls.Add(this.lblIDPropietario);
            this.Controls.Add(this.gpbFuenteContacto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txbContacto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBuscarPropietario);
            this.Controls.Add(this.txbPropietario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbIDContacto);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EdicionContactos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edición de contactos";
            this.gpbFuenteContacto.ResumeLayout(false);
            this.gpbFuenteContacto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarPropietario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txbIDContacto;
        public System.Windows.Forms.ComboBox cmbTipo;
        public System.Windows.Forms.TextBox txbPropietario;
        public System.Windows.Forms.TextBox txbContacto;
        public System.Windows.Forms.Label lblIDPropietario;
        public System.Windows.Forms.RadioButton rdbEmpleado;
        public System.Windows.Forms.RadioButton rdbMedico;
        public System.Windows.Forms.GroupBox gpbFuenteContacto;
        private System.Windows.Forms.ErrorProvider Notificador;
    }
}
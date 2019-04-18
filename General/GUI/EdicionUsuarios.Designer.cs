namespace General.GUI
{
    partial class EdicionUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdicionUsuarios));
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbEmpleado = new System.Windows.Forms.TextBox();
            this.txbCredencial = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txbIdUsuario = new System.Windows.Forms.TextBox();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.txbIdEmpleado = new System.Windows.Forms.TextBox();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.txbMedico = new System.Windows.Forms.TextBox();
            this.btnMedicos = new System.Windows.Forms.Button();
            this.lblMedico = new System.Windows.Forms.Label();
            this.txbJVPM = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.BackgroundImage")));
            this.btnEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Location = new System.Drawing.Point(407, 259);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(35, 30);
            this.btnEmpleados.TabIndex = 6;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(138, 340);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 41);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(264, 340);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 41);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "IDUsuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rol";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(54, 266);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(71, 16);
            this.lblEmpleado.TabIndex = 9;
            this.lblEmpleado.Text = "Empleado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(267, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Credencial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(267, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Estado";
            // 
            // txbEmpleado
            // 
            this.txbEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmpleado.Location = new System.Drawing.Point(199, 263);
            this.txbEmpleado.Name = "txbEmpleado";
            this.txbEmpleado.ReadOnly = true;
            this.txbEmpleado.Size = new System.Drawing.Size(202, 22);
            this.txbEmpleado.TabIndex = 12;
            // 
            // txbCredencial
            // 
            this.txbCredencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCredencial.Location = new System.Drawing.Point(270, 45);
            this.txbCredencial.Name = "txbCredencial";
            this.txbCredencial.Size = new System.Drawing.Size(173, 22);
            this.txbCredencial.TabIndex = 3;
            this.txbCredencial.UseSystemPasswordChar = true;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(270, 107);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(173, 24);
            this.cmbEstado.TabIndex = 4;
            // 
            // txbIdUsuario
            // 
            this.txbIdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdUsuario.Location = new System.Drawing.Point(58, 46);
            this.txbIdUsuario.Name = "txbIdUsuario";
            this.txbIdUsuario.ReadOnly = true;
            this.txbIdUsuario.Size = new System.Drawing.Size(172, 22);
            this.txbIdUsuario.TabIndex = 15;
            // 
            // txbUsuario
            // 
            this.txbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsuario.Location = new System.Drawing.Point(58, 107);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(172, 22);
            this.txbUsuario.TabIndex = 0;
            // 
            // txbIdEmpleado
            // 
            this.txbIdEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdEmpleado.Location = new System.Drawing.Point(138, 263);
            this.txbIdEmpleado.Name = "txbIdEmpleado";
            this.txbIdEmpleado.ReadOnly = true;
            this.txbIdEmpleado.Size = new System.Drawing.Size(55, 22);
            this.txbIdEmpleado.TabIndex = 11;
            // 
            // Notificador
            // 
            this.Notificador.ContainerControl = this;
            // 
            // cmbRol
            // 
            this.cmbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(58, 192);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(215, 24);
            this.cmbRol.TabIndex = 5;
            // 
            // txbMedico
            // 
            this.txbMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMedico.Location = new System.Drawing.Point(199, 263);
            this.txbMedico.Name = "txbMedico";
            this.txbMedico.ReadOnly = true;
            this.txbMedico.Size = new System.Drawing.Size(202, 22);
            this.txbMedico.TabIndex = 12;
            // 
            // btnMedicos
            // 
            this.btnMedicos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMedicos.BackgroundImage")));
            this.btnMedicos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicos.Location = new System.Drawing.Point(407, 259);
            this.btnMedicos.Name = "btnMedicos";
            this.btnMedicos.Size = new System.Drawing.Size(35, 30);
            this.btnMedicos.TabIndex = 6;
            this.btnMedicos.UseVisualStyleBackColor = true;
            this.btnMedicos.Click += new System.EventHandler(this.btnMedicos_Click);
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedico.Location = new System.Drawing.Point(54, 266);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(53, 16);
            this.lblMedico.TabIndex = 9;
            this.lblMedico.Text = "Médico";
            // 
            // txbJVPM
            // 
            this.txbJVPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbJVPM.Location = new System.Drawing.Point(138, 263);
            this.txbJVPM.Name = "txbJVPM";
            this.txbJVPM.ReadOnly = true;
            this.txbJVPM.Size = new System.Drawing.Size(55, 22);
            this.txbJVPM.TabIndex = 11;
            // 
            // EdicionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 422);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.txbJVPM);
            this.Controls.Add(this.txbIdEmpleado);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txbCredencial);
            this.Controls.Add(this.btnMedicos);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.txbMedico);
            this.Controls.Add(this.txbEmpleado);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.txbIdUsuario);
            this.Name = "EdicionUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EdicionUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txbEmpleado;
        public System.Windows.Forms.TextBox txbCredencial;
        public System.Windows.Forms.ComboBox cmbEstado;
        public System.Windows.Forms.TextBox txbIdUsuario;
        public System.Windows.Forms.TextBox txbUsuario;
        public System.Windows.Forms.TextBox txbIdEmpleado;
        private System.Windows.Forms.ErrorProvider Notificador;
        public System.Windows.Forms.ComboBox cmbRol;
        public System.Windows.Forms.TextBox txbJVPM;
        public System.Windows.Forms.TextBox txbMedico;
        public System.Windows.Forms.Button btnEmpleados;
        public System.Windows.Forms.Label lblEmpleado;
        public System.Windows.Forms.Label lblMedico;
        public System.Windows.Forms.Button btnMedicos;
    }
}
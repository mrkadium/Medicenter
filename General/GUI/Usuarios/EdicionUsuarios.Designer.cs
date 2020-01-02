namespace General.GUI.Usuarios
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.txbIdUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.ckbVerPass = new System.Windows.Forms.CheckBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txbPassConfir = new System.Windows.Forms.TextBox();
            this.ckbVerPass2 = new System.Windows.Forms.CheckBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.gpEleccionEstado = new System.Windows.Forms.GroupBox();
            this.rdbBloqueado = new System.Windows.Forms.RadioButton();
            this.rdbActivo = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbMedico = new System.Windows.Forms.RadioButton();
            this.rdbEmpleado = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txbPropietario = new System.Windows.Forms.TextBox();
            this.btnPropietario = new System.Windows.Forms.Button();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblIdAInsertarReferencia = new System.Windows.Forms.Label();
            this.txbIdPropietario = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.gpEleccionEstado.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(271, 322);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 40);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnCancelar_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(153, 322);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 40);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnGuardar_KeyPress);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblID);
            this.flowLayoutPanel1.Controls.Add(this.txbIdUsuario);
            this.flowLayoutPanel1.Controls.Add(this.lblUsuario);
            this.flowLayoutPanel1.Controls.Add(this.txbUsuario);
            this.flowLayoutPanel1.Controls.Add(this.lblPass);
            this.flowLayoutPanel1.Controls.Add(this.txbPass);
            this.flowLayoutPanel1.Controls.Add(this.ckbVerPass);
            this.flowLayoutPanel1.Controls.Add(this.lblApellidos);
            this.flowLayoutPanel1.Controls.Add(this.txbPassConfir);
            this.flowLayoutPanel1.Controls.Add(this.ckbVerPass2);
            this.flowLayoutPanel1.Controls.Add(this.lblRol);
            this.flowLayoutPanel1.Controls.Add(this.cmbRoles);
            this.flowLayoutPanel1.Controls.Add(this.lblEstado);
            this.flowLayoutPanel1.Controls.Add(this.gpEleccionEstado);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(30, 45);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(486, 271);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(0, 0);
            this.lblID.Margin = new System.Windows.Forms.Padding(0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 16);
            this.lblID.TabIndex = 25;
            this.lblID.Text = "ID";
            // 
            // txbIdUsuario
            // 
            this.txbIdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdUsuario.Location = new System.Drawing.Point(3, 21);
            this.txbIdUsuario.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.txbIdUsuario.Name = "txbIdUsuario";
            this.txbIdUsuario.ReadOnly = true;
            this.txbIdUsuario.Size = new System.Drawing.Size(50, 22);
            this.txbIdUsuario.TabIndex = 1;
            this.txbIdUsuario.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(0, 58);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(55, 16);
            this.lblUsuario.TabIndex = 17;
            this.lblUsuario.Text = "Usuario";
            // 
            // txbUsuario
            // 
            this.txbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsuario.Location = new System.Drawing.Point(3, 79);
            this.txbUsuario.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(200, 22);
            this.txbUsuario.TabIndex = 2;
            this.txbUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbUsuario_KeyPress);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(3, 116);
            this.lblPass.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(77, 16);
            this.lblPass.TabIndex = 19;
            this.lblPass.Text = "Contraseña";
            // 
            // txbPass
            // 
            this.txbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPass.Location = new System.Drawing.Point(3, 137);
            this.txbPass.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.txbPass.Name = "txbPass";
            this.txbPass.PasswordChar = '●';
            this.txbPass.Size = new System.Drawing.Size(200, 22);
            this.txbPass.TabIndex = 3;
            this.txbPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPass_KeyPress);
            // 
            // ckbVerPass
            // 
            this.ckbVerPass.AutoSize = true;
            this.ckbVerPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbVerPass.Location = new System.Drawing.Point(100, 162);
            this.ckbVerPass.Margin = new System.Windows.Forms.Padding(100, 3, 3, 3);
            this.ckbVerPass.Name = "ckbVerPass";
            this.ckbVerPass.Size = new System.Drawing.Size(108, 19);
            this.ckbVerPass.TabIndex = 4;
            this.ckbVerPass.Text = "Ver contraseña";
            this.ckbVerPass.UseVisualStyleBackColor = true;
            this.ckbVerPass.CheckedChanged += new System.EventHandler(this.ckbVerPass_CheckedChanged);
            this.ckbVerPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ckbVerPass_KeyPress);
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(3, 199);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(135, 16);
            this.lblApellidos.TabIndex = 21;
            this.lblApellidos.Text = "Confirmar contraseña";
            // 
            // txbPassConfir
            // 
            this.txbPassConfir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassConfir.Location = new System.Drawing.Point(3, 220);
            this.txbPassConfir.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.txbPassConfir.Name = "txbPassConfir";
            this.txbPassConfir.PasswordChar = '●';
            this.txbPassConfir.Size = new System.Drawing.Size(200, 22);
            this.txbPassConfir.TabIndex = 5;
            this.txbPassConfir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPassConfir_KeyPress);
            this.txbPassConfir.Leave += new System.EventHandler(this.txbPassConfir_Leave);
            // 
            // ckbVerPass2
            // 
            this.ckbVerPass2.AutoSize = true;
            this.ckbVerPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbVerPass2.Location = new System.Drawing.Point(100, 245);
            this.ckbVerPass2.Margin = new System.Windows.Forms.Padding(100, 3, 3, 3);
            this.ckbVerPass2.Name = "ckbVerPass2";
            this.ckbVerPass2.Size = new System.Drawing.Size(108, 19);
            this.ckbVerPass2.TabIndex = 6;
            this.ckbVerPass2.Text = "Ver contraseña";
            this.ckbVerPass2.UseVisualStyleBackColor = true;
            this.ckbVerPass2.CheckedChanged += new System.EventHandler(this.ckbVerPass2_CheckedChanged);
            this.ckbVerPass2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ckbVerPass2_KeyPress);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(241, 0);
            this.lblRol.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(29, 16);
            this.lblRol.TabIndex = 23;
            this.lblRol.Text = "Rol";
            // 
            // cmbRoles
            // 
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(241, 21);
            this.cmbRoles.Margin = new System.Windows.Forms.Padding(30, 5, 3, 0);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(200, 21);
            this.cmbRoles.TabIndex = 7;
            this.cmbRoles.Enter += new System.EventHandler(this.cmbRoles_Enter);
            this.cmbRoles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbRoles_KeyPress);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(241, 57);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(30, 15, 3, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(51, 16);
            this.lblEstado.TabIndex = 25;
            this.lblEstado.Text = "Estado";
            // 
            // gpEleccionEstado
            // 
            this.gpEleccionEstado.Controls.Add(this.rdbBloqueado);
            this.gpEleccionEstado.Controls.Add(this.rdbActivo);
            this.gpEleccionEstado.Location = new System.Drawing.Point(241, 73);
            this.gpEleccionEstado.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.gpEleccionEstado.Name = "gpEleccionEstado";
            this.gpEleccionEstado.Size = new System.Drawing.Size(215, 50);
            this.gpEleccionEstado.TabIndex = 8;
            this.gpEleccionEstado.TabStop = false;
            // 
            // rdbBloqueado
            // 
            this.rdbBloqueado.AutoSize = true;
            this.rdbBloqueado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBloqueado.Location = new System.Drawing.Point(107, 19);
            this.rdbBloqueado.Name = "rdbBloqueado";
            this.rdbBloqueado.Size = new System.Drawing.Size(93, 20);
            this.rdbBloqueado.TabIndex = 10;
            this.rdbBloqueado.Text = "Bloqueado";
            this.rdbBloqueado.UseVisualStyleBackColor = true;
            this.rdbBloqueado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rdbBloqueado_KeyPress);
            // 
            // rdbActivo
            // 
            this.rdbActivo.AutoSize = true;
            this.rdbActivo.Checked = true;
            this.rdbActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbActivo.Location = new System.Drawing.Point(15, 19);
            this.rdbActivo.Name = "rdbActivo";
            this.rdbActivo.Size = new System.Drawing.Size(63, 20);
            this.rdbActivo.TabIndex = 9;
            this.rdbActivo.TabStop = true;
            this.rdbActivo.Text = "Activo";
            this.rdbActivo.UseVisualStyleBackColor = true;
            this.rdbActivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rdbActivo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(30, 15, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Seleccione la referencia";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbMedico);
            this.groupBox1.Controls.Add(this.rdbEmpleado);
            this.groupBox1.Location = new System.Drawing.Point(241, 154);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 50);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // rdbMedico
            // 
            this.rdbMedico.AutoSize = true;
            this.rdbMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMedico.Location = new System.Drawing.Point(110, 19);
            this.rdbMedico.Name = "rdbMedico";
            this.rdbMedico.Size = new System.Drawing.Size(71, 20);
            this.rdbMedico.TabIndex = 13;
            this.rdbMedico.Text = "Medico";
            this.rdbMedico.UseVisualStyleBackColor = true;
            this.rdbMedico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rdbMedico_KeyPress);
            // 
            // rdbEmpleado
            // 
            this.rdbEmpleado.AutoSize = true;
            this.rdbEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEmpleado.Location = new System.Drawing.Point(15, 19);
            this.rdbEmpleado.Name = "rdbEmpleado";
            this.rdbEmpleado.Size = new System.Drawing.Size(89, 20);
            this.rdbEmpleado.TabIndex = 12;
            this.rdbEmpleado.TabStop = true;
            this.rdbEmpleado.Text = "Empleado";
            this.rdbEmpleado.UseVisualStyleBackColor = true;
            this.rdbEmpleado.CheckedChanged += new System.EventHandler(this.rdbEmpleado_CheckedChanged);
            this.rdbEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rdbEmpleado_KeyPress);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.txbPropietario);
            this.flowLayoutPanel2.Controls.Add(this.btnPropietario);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(241, 207);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(215, 40);
            this.flowLayoutPanel2.TabIndex = 14;
            // 
            // txbPropietario
            // 
            this.txbPropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPropietario.Location = new System.Drawing.Point(0, 13);
            this.txbPropietario.Margin = new System.Windows.Forms.Padding(0, 13, 3, 0);
            this.txbPropietario.Name = "txbPropietario";
            this.txbPropietario.ReadOnly = true;
            this.txbPropietario.Size = new System.Drawing.Size(165, 20);
            this.txbPropietario.TabIndex = 15;
            this.txbPropietario.TabStop = false;
            this.txbPropietario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPropietario_KeyPress);
            // 
            // btnPropietario
            // 
            this.btnPropietario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPropietario.BackgroundImage = global::General.Properties.Resources.archive;
            this.btnPropietario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnPropietario.ForeColor = System.Drawing.Color.White;
            this.btnPropietario.Location = new System.Drawing.Point(168, 10);
            this.btnPropietario.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.btnPropietario.Name = "btnPropietario";
            this.btnPropietario.Size = new System.Drawing.Size(47, 28);
            this.btnPropietario.TabIndex = 16;
            this.btnPropietario.UseVisualStyleBackColor = false;
            this.btnPropietario.Click += new System.EventHandler(this.btnPropietario_Click);
            this.btnPropietario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnPropietario_KeyPress);
            // 
            // Notificador
            // 
            this.Notificador.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Notificador.ContainerControl = this;
            // 
            // lblIdAInsertarReferencia
            // 
            this.lblIdAInsertarReferencia.AutoSize = true;
            this.lblIdAInsertarReferencia.Location = new System.Drawing.Point(399, 307);
            this.lblIdAInsertarReferencia.Name = "lblIdAInsertarReferencia";
            this.lblIdAInsertarReferencia.Size = new System.Drawing.Size(0, 13);
            this.lblIdAInsertarReferencia.TabIndex = 12;
            this.lblIdAInsertarReferencia.Visible = false;
            // 
            // txbIdPropietario
            // 
            this.txbIdPropietario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbIdPropietario.Location = new System.Drawing.Point(506, 341);
            this.txbIdPropietario.Name = "txbIdPropietario";
            this.txbIdPropietario.Size = new System.Drawing.Size(3, 13);
            this.txbIdPropietario.TabIndex = 17;
            this.txbIdPropietario.Visible = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.AutoEllipsis = true;
            this.btnCerrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(477, -1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(41, 32);
            this.btnCerrar.TabIndex = 19;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // EdicionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(518, 395);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txbIdPropietario);
            this.Controls.Add(this.lblIdAInsertarReferencia);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EdicionUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edicion de usuarios";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.gpEleccionEstado.ResumeLayout(false);
            this.gpEleccionEstado.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.TextBox txbIdUsuario;
        public System.Windows.Forms.Label lblUsuario;
        public System.Windows.Forms.TextBox txbUsuario;
        public System.Windows.Forms.Label lblPass;
        public System.Windows.Forms.TextBox txbPass;
        public System.Windows.Forms.Label lblApellidos;
        public System.Windows.Forms.TextBox txbPassConfir;
        public System.Windows.Forms.Label lblRol;
        public System.Windows.Forms.ComboBox cmbRoles;
        public System.Windows.Forms.Label lblEstado;
        public System.Windows.Forms.GroupBox gpEleccionEstado;
        private System.Windows.Forms.ErrorProvider Notificador;
        private System.Windows.Forms.CheckBox ckbVerPass;
        private System.Windows.Forms.CheckBox ckbVerPass2;
        public System.Windows.Forms.RadioButton rdbBloqueado;
        public System.Windows.Forms.RadioButton rdbActivo;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton rdbMedico;
        public System.Windows.Forms.RadioButton rdbEmpleado;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        public System.Windows.Forms.TextBox txbPropietario;
        private System.Windows.Forms.Button btnPropietario;
        public System.Windows.Forms.Label lblIdAInsertarReferencia;
        public System.Windows.Forms.TextBox txbIdPropietario;
        private System.Windows.Forms.Button btnCerrar;
    }
}
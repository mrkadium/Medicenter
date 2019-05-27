namespace General.GUI.Medicos
{
    partial class EdicionMedicos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdicionMedicos));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblJVPM = new System.Windows.Forms.Label();
            this.txbIDMedico = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbJVPM = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txbNombres = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txbApellidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpContratacion = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbDui = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbNit = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbMunicipio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtgvDatosContactos = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txbContacto = new System.Windows.Forms.TextBox();
            this.btnAgregarContacto = new System.Windows.Forms.Button();
            this.btnEliminarContacto = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dtgvDatosEspecialidad = new System.Windows.Forms.DataGridView();
            this.idespecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregarEspecialidad = new System.Windows.Forms.Button();
            this.btnEliminarEspecialidad = new System.Windows.Forms.Button();
            this.lblIDpropietario = new System.Windows.Forms.Label();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblContac = new System.Windows.Forms.Label();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcontacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatosContactos)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatosEspecialidad)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(676, 351);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 40);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(558, 351);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 40);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.lblNombres);
            this.flowLayoutPanel1.Controls.Add(this.txbNombres);
            this.flowLayoutPanel1.Controls.Add(this.lblApellidos);
            this.flowLayoutPanel1.Controls.Add(this.txbApellidos);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.dtpFechaNacimiento);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.dtpContratacion);
            this.flowLayoutPanel1.Controls.Add(this.label11);
            this.flowLayoutPanel1.Controls.Add(this.cmbGenero);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.txbDui);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.txbNit);
            this.flowLayoutPanel1.Controls.Add(this.label10);
            this.flowLayoutPanel1.Controls.Add(this.cmbEstado);
            this.flowLayoutPanel1.Controls.Add(this.label9);
            this.flowLayoutPanel1.Controls.Add(this.dtpSalida);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.cmbDepartamento);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.txbMunicipio);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.txbDireccion);
            this.flowLayoutPanel1.Controls.Add(this.label13);
            this.flowLayoutPanel1.Controls.Add(this.dtgvDatosContactos);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.label12);
            this.flowLayoutPanel1.Controls.Add(this.dtgvDatosEspecialidad);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1297, 304);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblJVPM);
            this.flowLayoutPanel2.Controls.Add(this.txbIDMedico);
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Controls.Add(this.txbJVPM);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 52);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // lblJVPM
            // 
            this.lblJVPM.AutoSize = true;
            this.lblJVPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJVPM.Location = new System.Drawing.Point(0, 0);
            this.lblJVPM.Margin = new System.Windows.Forms.Padding(0);
            this.lblJVPM.Name = "lblJVPM";
            this.lblJVPM.Size = new System.Drawing.Size(69, 16);
            this.lblJVPM.TabIndex = 0;
            this.lblJVPM.Text = "ID Médico";
            // 
            // txbIDMedico
            // 
            this.txbIDMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDMedico.Location = new System.Drawing.Point(3, 21);
            this.txbIDMedico.Margin = new System.Windows.Forms.Padding(3, 5, 0, 3);
            this.txbIDMedico.Name = "txbIDMedico";
            this.txbIDMedico.ReadOnly = true;
            this.txbIDMedico.Size = new System.Drawing.Size(81, 22);
            this.txbIDMedico.TabIndex = 0;
            this.txbIDMedico.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(84, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "JVPM";
            // 
            // txbJVPM
            // 
            this.txbJVPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbJVPM.Location = new System.Drawing.Point(87, 21);
            this.txbJVPM.Margin = new System.Windows.Forms.Padding(3, 5, 0, 3);
            this.txbJVPM.Name = "txbJVPM";
            this.txbJVPM.Size = new System.Drawing.Size(113, 22);
            this.txbJVPM.TabIndex = 2;
            this.txbJVPM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbJVPM_KeyPress);
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(3, 73);
            this.lblNombres.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(64, 16);
            this.lblNombres.TabIndex = 0;
            this.lblNombres.Text = "Nombres";
            // 
            // txbNombres
            // 
            this.txbNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombres.Location = new System.Drawing.Point(3, 94);
            this.txbNombres.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.txbNombres.Name = "txbNombres";
            this.txbNombres.Size = new System.Drawing.Size(200, 22);
            this.txbNombres.TabIndex = 3;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(3, 134);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(65, 16);
            this.lblApellidos.TabIndex = 0;
            this.lblApellidos.Text = "Apellidos";
            // 
            // txbApellidos
            // 
            this.txbApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbApellidos.Location = new System.Drawing.Point(3, 155);
            this.txbApellidos.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.txbApellidos.Name = "txbApellidos";
            this.txbApellidos.Size = new System.Drawing.Size(200, 22);
            this.txbApellidos.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha de nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(3, 216);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaNacimiento.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha de contratación";
            // 
            // dtpContratacion
            // 
            this.dtpContratacion.Checked = false;
            this.dtpContratacion.CustomFormat = "yyyy-MM-dd";
            this.dtpContratacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpContratacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpContratacion.Location = new System.Drawing.Point(3, 277);
            this.dtpContratacion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.dtpContratacion.Name = "dtpContratacion";
            this.dtpContratacion.ShowCheckBox = true;
            this.dtpContratacion.Size = new System.Drawing.Size(200, 22);
            this.dtpContratacion.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(236, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Género";
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(236, 26);
            this.cmbGenero.Margin = new System.Windows.Forms.Padding(30, 10, 3, 3);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(200, 21);
            this.cmbGenero.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(236, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(30, 25, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "DUI";
            // 
            // txbDui
            // 
            this.txbDui.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDui.Location = new System.Drawing.Point(236, 94);
            this.txbDui.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.txbDui.Name = "txbDui";
            this.txbDui.Size = new System.Drawing.Size(200, 22);
            this.txbDui.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(236, 134);
            this.label6.Margin = new System.Windows.Forms.Padding(30, 15, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "NIT";
            // 
            // txbNit
            // 
            this.txbNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNit.Location = new System.Drawing.Point(236, 155);
            this.txbNit.Margin = new System.Windows.Forms.Padding(30, 5, 3, 3);
            this.txbNit.Name = "txbNit";
            this.txbNit.Size = new System.Drawing.Size(200, 22);
            this.txbNit.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(236, 197);
            this.label10.Margin = new System.Windows.Forms.Padding(30, 17, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(236, 216);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(200, 21);
            this.cmbEstado.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(236, 258);
            this.label9.Margin = new System.Windows.Forms.Padding(30, 18, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Fecha de salida";
            // 
            // dtpSalida
            // 
            this.dtpSalida.Checked = false;
            this.dtpSalida.CustomFormat = "yyyy-MM-dd";
            this.dtpSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSalida.Location = new System.Drawing.Point(236, 277);
            this.dtpSalida.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.ShowCheckBox = true;
            this.dtpSalida.Size = new System.Drawing.Size(200, 22);
            this.dtpSalida.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departamento";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(469, 26);
            this.cmbDepartamento.Margin = new System.Windows.Forms.Padding(30, 10, 3, 3);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(200, 21);
            this.cmbDepartamento.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(469, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(30, 20, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Municipio";
            // 
            // txbMunicipio
            // 
            this.txbMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMunicipio.Location = new System.Drawing.Point(469, 94);
            this.txbMunicipio.Margin = new System.Windows.Forms.Padding(30, 8, 3, 3);
            this.txbMunicipio.Multiline = true;
            this.txbMunicipio.Name = "txbMunicipio";
            this.txbMunicipio.Size = new System.Drawing.Size(200, 22);
            this.txbMunicipio.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(469, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(30, 17, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dirección";
            // 
            // txbDireccion
            // 
            this.txbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDireccion.Location = new System.Drawing.Point(469, 155);
            this.txbDireccion.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.txbDireccion.Multiline = true;
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(200, 144);
            this.txbDireccion.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(702, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Contactos";
            // 
            // dtgvDatosContactos
            // 
            this.dtgvDatosContactos.AllowUserToAddRows = false;
            this.dtgvDatosContactos.AllowUserToDeleteRows = false;
            this.dtgvDatosContactos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgvDatosContactos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDatosContactos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvDatosContactos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvDatosContactos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgvDatosContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDatosContactos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipo,
            this.contacto,
            this.idcontacto});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDatosContactos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvDatosContactos.Location = new System.Drawing.Point(702, 26);
            this.dtgvDatosContactos.Margin = new System.Windows.Forms.Padding(30, 10, 3, 3);
            this.dtgvDatosContactos.MultiSelect = false;
            this.dtgvDatosContactos.Name = "dtgvDatosContactos";
            this.dtgvDatosContactos.ReadOnly = true;
            this.dtgvDatosContactos.RowHeadersVisible = false;
            this.dtgvDatosContactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDatosContactos.Size = new System.Drawing.Size(280, 198);
            this.dtgvDatosContactos.TabIndex = 0;
            this.dtgvDatosContactos.TabStop = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.cmbTipo);
            this.flowLayoutPanel3.Controls.Add(this.txbContacto);
            this.flowLayoutPanel3.Controls.Add(this.btnAgregarContacto);
            this.flowLayoutPanel3.Controls.Add(this.btnEliminarContacto);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(702, 230);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(30, 3, 3, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(280, 74);
            this.flowLayoutPanel3.TabIndex = 15;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(0, 8);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(0, 8, 3, 3);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(172, 21);
            this.cmbTipo.TabIndex = 16;
            // 
            // txbContacto
            // 
            this.txbContacto.Location = new System.Drawing.Point(177, 8);
            this.txbContacto.Margin = new System.Windows.Forms.Padding(2, 8, 3, 3);
            this.txbContacto.Name = "txbContacto";
            this.txbContacto.Size = new System.Drawing.Size(100, 20);
            this.txbContacto.TabIndex = 17;
            this.txbContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbContacto_KeyPress);
            // 
            // btnAgregarContacto
            // 
            this.btnAgregarContacto.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregarContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarContacto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarContacto.Location = new System.Drawing.Point(2, 34);
            this.btnAgregarContacto.Margin = new System.Windows.Forms.Padding(2, 2, 0, 3);
            this.btnAgregarContacto.Name = "btnAgregarContacto";
            this.btnAgregarContacto.Size = new System.Drawing.Size(141, 40);
            this.btnAgregarContacto.TabIndex = 18;
            this.btnAgregarContacto.Text = "Agregar contacto";
            this.btnAgregarContacto.UseVisualStyleBackColor = false;
            this.btnAgregarContacto.Click += new System.EventHandler(this.btnAgregarContacto_Click);
            // 
            // btnEliminarContacto
            // 
            this.btnEliminarContacto.BackColor = System.Drawing.Color.Gray;
            this.btnEliminarContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarContacto.ForeColor = System.Drawing.Color.White;
            this.btnEliminarContacto.Location = new System.Drawing.Point(145, 35);
            this.btnEliminarContacto.Margin = new System.Windows.Forms.Padding(2, 3, 0, 3);
            this.btnEliminarContacto.Name = "btnEliminarContacto";
            this.btnEliminarContacto.Size = new System.Drawing.Size(133, 40);
            this.btnEliminarContacto.TabIndex = 19;
            this.btnEliminarContacto.Text = "Eliminar contacto";
            this.btnEliminarContacto.UseVisualStyleBackColor = false;
            this.btnEliminarContacto.Click += new System.EventHandler(this.btnEliminarContacto_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1015, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Especialidad";
            // 
            // dtgvDatosEspecialidad
            // 
            this.dtgvDatosEspecialidad.AllowUserToAddRows = false;
            this.dtgvDatosEspecialidad.AllowUserToDeleteRows = false;
            this.dtgvDatosEspecialidad.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgvDatosEspecialidad.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvDatosEspecialidad.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvDatosEspecialidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvDatosEspecialidad.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgvDatosEspecialidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDatosEspecialidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idespecialidad,
            this.especialidad});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDatosEspecialidad.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvDatosEspecialidad.Location = new System.Drawing.Point(1015, 26);
            this.dtgvDatosEspecialidad.Margin = new System.Windows.Forms.Padding(30, 10, 3, 3);
            this.dtgvDatosEspecialidad.MultiSelect = false;
            this.dtgvDatosEspecialidad.Name = "dtgvDatosEspecialidad";
            this.dtgvDatosEspecialidad.ReadOnly = true;
            this.dtgvDatosEspecialidad.RowHeadersVisible = false;
            this.dtgvDatosEspecialidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDatosEspecialidad.Size = new System.Drawing.Size(280, 198);
            this.dtgvDatosEspecialidad.TabIndex = 0;
            this.dtgvDatosEspecialidad.TabStop = false;
            // 
            // idespecialidad
            // 
            this.idespecialidad.DataPropertyName = "idespecialidad";
            this.idespecialidad.HeaderText = "ID";
            this.idespecialidad.MinimumWidth = 75;
            this.idespecialidad.Name = "idespecialidad";
            this.idespecialidad.ReadOnly = true;
            this.idespecialidad.Width = 75;
            // 
            // especialidad
            // 
            this.especialidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.especialidad.DataPropertyName = "especialidad";
            this.especialidad.HeaderText = "Especialidad";
            this.especialidad.MinimumWidth = 200;
            this.especialidad.Name = "especialidad";
            this.especialidad.ReadOnly = true;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.btnAgregarEspecialidad);
            this.flowLayoutPanel4.Controls.Add(this.btnEliminarEspecialidad);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(1015, 230);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(30, 3, 3, 0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(280, 74);
            this.flowLayoutPanel4.TabIndex = 20;
            // 
            // btnAgregarEspecialidad
            // 
            this.btnAgregarEspecialidad.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregarEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEspecialidad.ForeColor = System.Drawing.Color.White;
            this.btnAgregarEspecialidad.Location = new System.Drawing.Point(2, 35);
            this.btnAgregarEspecialidad.Margin = new System.Windows.Forms.Padding(2, 35, 0, 3);
            this.btnAgregarEspecialidad.Name = "btnAgregarEspecialidad";
            this.btnAgregarEspecialidad.Size = new System.Drawing.Size(141, 40);
            this.btnAgregarEspecialidad.TabIndex = 21;
            this.btnAgregarEspecialidad.Text = "Agregar especialidad";
            this.btnAgregarEspecialidad.UseVisualStyleBackColor = false;
            this.btnAgregarEspecialidad.Click += new System.EventHandler(this.btnAgregarEspecialidad_Click);
            // 
            // btnEliminarEspecialidad
            // 
            this.btnEliminarEspecialidad.BackColor = System.Drawing.Color.Gray;
            this.btnEliminarEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEspecialidad.ForeColor = System.Drawing.Color.White;
            this.btnEliminarEspecialidad.Location = new System.Drawing.Point(145, 35);
            this.btnEliminarEspecialidad.Margin = new System.Windows.Forms.Padding(2, 35, 0, 3);
            this.btnEliminarEspecialidad.Name = "btnEliminarEspecialidad";
            this.btnEliminarEspecialidad.Size = new System.Drawing.Size(133, 40);
            this.btnEliminarEspecialidad.TabIndex = 22;
            this.btnEliminarEspecialidad.Text = "Eliminar especialidad";
            this.btnEliminarEspecialidad.UseVisualStyleBackColor = false;
            this.btnEliminarEspecialidad.Click += new System.EventHandler(this.btnEliminarEspecialidad_Click);
            // 
            // lblIDpropietario
            // 
            this.lblIDpropietario.AutoSize = true;
            this.lblIDpropietario.Location = new System.Drawing.Point(918, 329);
            this.lblIDpropietario.Name = "lblIDpropietario";
            this.lblIDpropietario.Size = new System.Drawing.Size(0, 13);
            this.lblIDpropietario.TabIndex = 74;
            this.lblIDpropietario.Visible = false;
            // 
            // Notificador
            // 
            this.Notificador.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Notificador.ContainerControl = this;
            // 
            // lblContac
            // 
            this.lblContac.AutoSize = true;
            this.lblContac.Location = new System.Drawing.Point(848, 333);
            this.lblContac.Name = "lblContac";
            this.lblContac.Size = new System.Drawing.Size(0, 13);
            this.lblContac.TabIndex = 75;
            this.lblContac.Visible = false;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "tipo";
            this.tipo.HeaderText = "Tipo";
            this.tipo.MinimumWidth = 75;
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 75;
            // 
            // contacto
            // 
            this.contacto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contacto.DataPropertyName = "contacto";
            this.contacto.HeaderText = "Contacto";
            this.contacto.MinimumWidth = 200;
            this.contacto.Name = "contacto";
            this.contacto.ReadOnly = true;
            // 
            // idcontacto
            // 
            this.idcontacto.DataPropertyName = "idcontacto";
            this.idcontacto.HeaderText = "idcontacto";
            this.idcontacto.Name = "idcontacto";
            this.idcontacto.ReadOnly = true;
            this.idcontacto.Visible = false;
            // 
            // EdicionMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1320, 403);
            this.Controls.Add(this.lblContac);
            this.Controls.Add(this.lblIDpropietario);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EdicionMedicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edicion de médicos";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatosContactos)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatosEspecialidad)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        public System.Windows.Forms.Label lblJVPM;
        public System.Windows.Forms.TextBox txbIDMedico;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txbJVPM;
        public System.Windows.Forms.Label lblNombres;
        public System.Windows.Forms.TextBox txbNombres;
        public System.Windows.Forms.Label lblApellidos;
        public System.Windows.Forms.TextBox txbApellidos;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker dtpContratacion;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox cmbGenero;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.MaskedTextBox txbDui;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.MaskedTextBox txbNit;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cmbEstado;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.DateTimePicker dtpSalida;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbDepartamento;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txbMunicipio;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txbDireccion;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.DataGridView dtgvDatosContactos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        public System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txbContacto;
        private System.Windows.Forms.ErrorProvider Notificador;
        private System.Windows.Forms.Button btnAgregarContacto;
        private System.Windows.Forms.Button btnEliminarContacto;
        public System.Windows.Forms.Label lblIDpropietario;
        public System.Windows.Forms.Label lblContac;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.DataGridView dtgvDatosEspecialidad;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button btnAgregarEspecialidad;
        private System.Windows.Forms.Button btnEliminarEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idespecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcontacto;
    }
}
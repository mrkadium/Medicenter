namespace General.GUI.Empleados
{
    partial class EdicionEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdicionEmpleados));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpID = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txbIDEmpleado = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txbNombres = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txbApellidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpContratacion = new System.Windows.Forms.DateTimePicker();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.lblDUI = new System.Windows.Forms.Label();
            this.txbDui = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbNit = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.txbMunicipio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCargos = new System.Windows.Forms.ComboBox();
            this.lblContactos = new System.Windows.Forms.Label();
            this.dtgvDatosContactos = new System.Windows.Forms.DataGridView();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcontacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txbContacto = new System.Windows.Forms.TextBox();
            this.btnAgregarContacto = new System.Windows.Forms.Button();
            this.btnEliminarContacto = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblContac = new System.Windows.Forms.Label();
            this.lblIDpropietario = new System.Windows.Forms.Label();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCerrar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flpID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatosContactos)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.flpID);
            this.flowLayoutPanel1.Controls.Add(this.lblNombres);
            this.flowLayoutPanel1.Controls.Add(this.txbNombres);
            this.flowLayoutPanel1.Controls.Add(this.lblApellidos);
            this.flowLayoutPanel1.Controls.Add(this.txbApellidos);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.dtpFechaNacimiento);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.dtpContratacion);
            this.flowLayoutPanel1.Controls.Add(this.lblGenero);
            this.flowLayoutPanel1.Controls.Add(this.cmbGenero);
            this.flowLayoutPanel1.Controls.Add(this.lblDUI);
            this.flowLayoutPanel1.Controls.Add(this.txbDui);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.txbNit);
            this.flowLayoutPanel1.Controls.Add(this.label10);
            this.flowLayoutPanel1.Controls.Add(this.cmbEstado);
            this.flowLayoutPanel1.Controls.Add(this.label9);
            this.flowLayoutPanel1.Controls.Add(this.dtpSalida);
            this.flowLayoutPanel1.Controls.Add(this.lblDepartamento);
            this.flowLayoutPanel1.Controls.Add(this.cmbDepartamento);
            this.flowLayoutPanel1.Controls.Add(this.lblMunicipio);
            this.flowLayoutPanel1.Controls.Add(this.txbMunicipio);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.txbDireccion);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.cmbCargos);
            this.flowLayoutPanel1.Controls.Add(this.lblContactos);
            this.flowLayoutPanel1.Controls.Add(this.dtgvDatosContactos);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 41);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1013, 307);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flpID
            // 
            this.flpID.Controls.Add(this.lbl1);
            this.flpID.Controls.Add(this.txbIDEmpleado);
            this.flpID.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpID.Location = new System.Drawing.Point(3, 3);
            this.flpID.Name = "flpID";
            this.flpID.Size = new System.Drawing.Size(200, 52);
            this.flpID.TabIndex = 1;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(0, 0);
            this.lbl1.Margin = new System.Windows.Forms.Padding(0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(21, 16);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "ID";
            // 
            // txbIDEmpleado
            // 
            this.txbIDEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDEmpleado.Location = new System.Drawing.Point(3, 21);
            this.txbIDEmpleado.Margin = new System.Windows.Forms.Padding(3, 5, 0, 3);
            this.txbIDEmpleado.Name = "txbIDEmpleado";
            this.txbIDEmpleado.ReadOnly = true;
            this.txbIDEmpleado.Size = new System.Drawing.Size(81, 22);
            this.txbIDEmpleado.TabIndex = 2;
            this.txbIDEmpleado.TabStop = false;
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
            this.txbNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNombres_KeyPress);
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
            this.txbApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbApellidos_KeyPress);
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
            this.dtpFechaNacimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFechaNacimiento_KeyPress);
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
            this.dtpContratacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpContratacion_KeyPress);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(236, 0);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(53, 16);
            this.lblGenero.TabIndex = 0;
            this.lblGenero.Text = "Género";
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(236, 26);
            this.cmbGenero.Margin = new System.Windows.Forms.Padding(30, 10, 3, 3);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(200, 21);
            this.cmbGenero.TabIndex = 7;
            this.cmbGenero.Enter += new System.EventHandler(this.cmbGenero_Enter);
            this.cmbGenero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbGenero_KeyPress);
            // 
            // lblDUI
            // 
            this.lblDUI.AutoSize = true;
            this.lblDUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDUI.Location = new System.Drawing.Point(236, 75);
            this.lblDUI.Margin = new System.Windows.Forms.Padding(30, 25, 3, 0);
            this.lblDUI.Name = "lblDUI";
            this.lblDUI.Size = new System.Drawing.Size(31, 16);
            this.lblDUI.TabIndex = 0;
            this.lblDUI.Text = "DUI";
            // 
            // txbDui
            // 
            this.txbDui.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDui.Location = new System.Drawing.Point(236, 94);
            this.txbDui.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.txbDui.Mask = "00000000-0";
            this.txbDui.Name = "txbDui";
            this.txbDui.PromptChar = ' ';
            this.txbDui.Size = new System.Drawing.Size(200, 22);
            this.txbDui.TabIndex = 8;
            this.txbDui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbDui_KeyPress);
            this.txbDui.Leave += new System.EventHandler(this.txbDui_Leave);
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
            this.txbNit.Mask = "0000-000000-000-0";
            this.txbNit.Name = "txbNit";
            this.txbNit.PromptChar = ' ';
            this.txbNit.Size = new System.Drawing.Size(200, 22);
            this.txbNit.TabIndex = 9;
            this.txbNit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNit_KeyPress);
            this.txbNit.Leave += new System.EventHandler(this.txbNit_Leave);
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
            this.cmbEstado.Enter += new System.EventHandler(this.cmbEstado_Enter);
            this.cmbEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEstado_KeyPress);
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
            this.dtpSalida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpSalida_KeyPress);
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(469, 0);
            this.lblDepartamento.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(94, 16);
            this.lblDepartamento.TabIndex = 0;
            this.lblDepartamento.Text = "Departamento";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(469, 26);
            this.cmbDepartamento.Margin = new System.Windows.Forms.Padding(30, 10, 3, 3);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(200, 21);
            this.cmbDepartamento.TabIndex = 12;
            this.cmbDepartamento.Enter += new System.EventHandler(this.cmbDepartamento_Enter);
            this.cmbDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbDepartamento_KeyPress);
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipio.Location = new System.Drawing.Point(469, 70);
            this.lblMunicipio.Margin = new System.Windows.Forms.Padding(30, 20, 3, 0);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(65, 16);
            this.lblMunicipio.TabIndex = 0;
            this.lblMunicipio.Text = "Municipio";
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
            this.txbMunicipio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMunicipio_KeyPress);
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
            this.txbDireccion.Size = new System.Drawing.Size(200, 82);
            this.txbDireccion.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(469, 255);
            this.label7.Margin = new System.Windows.Forms.Padding(30, 15, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cargo";
            // 
            // cmbCargos
            // 
            this.cmbCargos.FormattingEnabled = true;
            this.cmbCargos.Location = new System.Drawing.Point(469, 277);
            this.cmbCargos.Margin = new System.Windows.Forms.Padding(30, 6, 3, 3);
            this.cmbCargos.Name = "cmbCargos";
            this.cmbCargos.Size = new System.Drawing.Size(200, 21);
            this.cmbCargos.TabIndex = 15;
            this.cmbCargos.Enter += new System.EventHandler(this.cmbCargos_Enter);
            this.cmbCargos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCargos_KeyPress);
            // 
            // lblContactos
            // 
            this.lblContactos.AutoSize = true;
            this.lblContactos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactos.Location = new System.Drawing.Point(702, 0);
            this.lblContactos.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.lblContactos.Name = "lblContactos";
            this.lblContactos.Size = new System.Drawing.Size(68, 16);
            this.lblContactos.TabIndex = 33;
            this.lblContactos.Text = "Contactos";
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
            this.dtgvDatosContactos.TabIndex = 16;
            this.dtgvDatosContactos.TabStop = false;
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
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.cmbTipo);
            this.flowLayoutPanel3.Controls.Add(this.txbContacto);
            this.flowLayoutPanel3.Controls.Add(this.btnAgregarContacto);
            this.flowLayoutPanel3.Controls.Add(this.btnEliminarContacto);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(702, 230);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(30, 3, 3, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(310, 74);
            this.flowLayoutPanel3.TabIndex = 17;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(0, 8);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(0, 8, 3, 3);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(172, 21);
            this.cmbTipo.TabIndex = 18;
            this.cmbTipo.Enter += new System.EventHandler(this.cmbTipo_Enter);
            // 
            // txbContacto
            // 
            this.txbContacto.Location = new System.Drawing.Point(177, 8);
            this.txbContacto.Margin = new System.Windows.Forms.Padding(2, 8, 3, 3);
            this.txbContacto.Name = "txbContacto";
            this.txbContacto.Size = new System.Drawing.Size(100, 20);
            this.txbContacto.TabIndex = 19;
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
            this.btnAgregarContacto.TabIndex = 20;
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
            this.btnEliminarContacto.TabIndex = 21;
            this.btnEliminarContacto.Text = "Eliminar contacto";
            this.btnEliminarContacto.UseVisualStyleBackColor = false;
            this.btnEliminarContacto.Click += new System.EventHandler(this.btnEliminarContacto_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(534, 366);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 40);
            this.btnCancelar.TabIndex = 23;
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
            this.btnGuardar.Location = new System.Drawing.Point(416, 366);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 40);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnGuardar_KeyPress);
            // 
            // lblContac
            // 
            this.lblContac.AutoSize = true;
            this.lblContac.Location = new System.Drawing.Point(938, 336);
            this.lblContac.Name = "lblContac";
            this.lblContac.Size = new System.Drawing.Size(0, 13);
            this.lblContac.TabIndex = 28;
            this.lblContac.Visible = false;
            // 
            // lblIDpropietario
            // 
            this.lblIDpropietario.AutoSize = true;
            this.lblIDpropietario.Location = new System.Drawing.Point(825, 347);
            this.lblIDpropietario.Name = "lblIDpropietario";
            this.lblIDpropietario.Size = new System.Drawing.Size(0, 13);
            this.lblIDpropietario.TabIndex = 29;
            this.lblIDpropietario.Visible = false;
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
            this.btnCerrar.Location = new System.Drawing.Point(998, -1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(41, 32);
            this.btnCerrar.TabIndex = 30;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // EdicionEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1037, 436);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblIDpropietario);
            this.Controls.Add(this.lblContac);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EdicionEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edición de empleados";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flpID.ResumeLayout(false);
            this.flpID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatosContactos)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Label lbl1;
        public System.Windows.Forms.TextBox txbIDEmpleado;
        public System.Windows.Forms.Label lblNombres;
        public System.Windows.Forms.TextBox txbNombres;
        public System.Windows.Forms.Label lblApellidos;
        public System.Windows.Forms.TextBox txbApellidos;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker dtpContratacion;
        public System.Windows.Forms.Label lblGenero;
        public System.Windows.Forms.ComboBox cmbGenero;
        public System.Windows.Forms.Label lblDUI;
        public System.Windows.Forms.MaskedTextBox txbDui;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.MaskedTextBox txbNit;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cmbEstado;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.DateTimePicker dtpSalida;
        public System.Windows.Forms.Label lblDepartamento;
        public System.Windows.Forms.ComboBox cmbDepartamento;
        public System.Windows.Forms.Label lblMunicipio;
        public System.Windows.Forms.TextBox txbMunicipio;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cmbCargos;
        public System.Windows.Forms.Label lblContactos;
        public System.Windows.Forms.DataGridView dtgvDatosContactos;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcontacto;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        public System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txbContacto;
        private System.Windows.Forms.Button btnAgregarContacto;
        private System.Windows.Forms.Button btnEliminarContacto;
        public System.Windows.Forms.Label lblContac;
        public System.Windows.Forms.Label lblIDpropietario;
        private System.Windows.Forms.ErrorProvider Notificador;
        public System.Windows.Forms.FlowLayoutPanel flpID;
        private System.Windows.Forms.Button btnCerrar;
    }
}
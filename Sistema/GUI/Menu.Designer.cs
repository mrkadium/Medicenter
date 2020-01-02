namespace Sistema.GUI
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnInventarios = new System.Windows.Forms.Button();
            this.btnGestiones = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.flpGestiones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGestionMedicos = new System.Windows.Forms.Button();
            this.btnGestionEspecialidades = new System.Windows.Forms.Button();
            this.btnGestionPermisos = new System.Windows.Forms.Button();
            this.btnGestionCargos = new System.Windows.Forms.Button();
            this.btnGestionPacientes = new System.Windows.Forms.Button();
            this.btnGestionRoles = new System.Windows.Forms.Button();
            this.btnGestionEmpleados = new System.Windows.Forms.Button();
            this.btnGestionUsuarios = new System.Windows.Forms.Button();
            this.btnGestionConsumibles = new System.Windows.Forms.Button();
            this.btnGestionLaboratorios = new System.Windows.Forms.Button();
            this.btnGestionMarcas = new System.Windows.Forms.Button();
            this.flpReportes = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flpGestiones.SuspendLayout();
            this.flpReportes.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.btnConsultas);
            this.flowLayoutPanel1.Controls.Add(this.btnVentas);
            this.flowLayoutPanel1.Controls.Add(this.btnCompras);
            this.flowLayoutPanel1.Controls.Add(this.btnInventarios);
            this.flowLayoutPanel1.Controls.Add(this.btnGestiones);
            this.flowLayoutPanel1.Controls.Add(this.btnReportes);
            this.flowLayoutPanel3.SetFlowBreak(this.flowLayoutPanel1, true);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(349, 489);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnConsultas
            // 
            this.btnConsultas.BackColor = System.Drawing.Color.White;
            this.btnConsultas.BackgroundImage = global::Sistema.Properties.Resources.report;
            this.btnConsultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConsultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnConsultas.ForeColor = System.Drawing.Color.Black;
            this.btnConsultas.Location = new System.Drawing.Point(3, 3);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(155, 155);
            this.btnConsultas.TabIndex = 0;
            this.btnConsultas.UseVisualStyleBackColor = false;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            this.btnConsultas.Enter += new System.EventHandler(this.btnConsultas_Enter);
            this.btnConsultas.MouseEnter += new System.EventHandler(this.btnConsultas_MouseEnter);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.White;
            this.btnVentas.BackgroundImage = global::Sistema.Properties.Resources.cashier;
            this.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.Black;
            this.btnVentas.Location = new System.Drawing.Point(164, 3);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(155, 155);
            this.btnVentas.TabIndex = 1;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            this.btnVentas.Enter += new System.EventHandler(this.btnVentas_Enter);
            this.btnVentas.MouseEnter += new System.EventHandler(this.btnVentas_MouseEnter);
            // 
            // btnCompras
            // 
            this.btnCompras.BackColor = System.Drawing.Color.White;
            this.btnCompras.BackgroundImage = global::Sistema.Properties.Resources.medicine;
            this.btnCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.Black;
            this.btnCompras.Location = new System.Drawing.Point(3, 164);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(155, 155);
            this.btnCompras.TabIndex = 2;
            this.btnCompras.UseVisualStyleBackColor = false;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            this.btnCompras.Enter += new System.EventHandler(this.btnCompras_Enter);
            this.btnCompras.MouseEnter += new System.EventHandler(this.btnCompras_MouseEnter);
            // 
            // btnInventarios
            // 
            this.btnInventarios.BackColor = System.Drawing.Color.White;
            this.btnInventarios.BackgroundImage = global::Sistema.Properties.Resources.shelf;
            this.btnInventarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInventarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventarios.ForeColor = System.Drawing.Color.Black;
            this.btnInventarios.Location = new System.Drawing.Point(164, 164);
            this.btnInventarios.Name = "btnInventarios";
            this.btnInventarios.Size = new System.Drawing.Size(155, 155);
            this.btnInventarios.TabIndex = 5;
            this.btnInventarios.UseVisualStyleBackColor = false;
            this.btnInventarios.Click += new System.EventHandler(this.btnInventarios_Click);
            this.btnInventarios.Enter += new System.EventHandler(this.btnInventarios_Enter);
            this.btnInventarios.MouseEnter += new System.EventHandler(this.btnInventarios_MouseEnter);
            // 
            // btnGestiones
            // 
            this.btnGestiones.BackColor = System.Drawing.Color.White;
            this.btnGestiones.BackgroundImage = global::Sistema.Properties.Resources.management;
            this.btnGestiones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGestiones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnGestiones.ForeColor = System.Drawing.Color.Black;
            this.btnGestiones.Location = new System.Drawing.Point(3, 325);
            this.btnGestiones.Name = "btnGestiones";
            this.btnGestiones.Size = new System.Drawing.Size(155, 155);
            this.btnGestiones.TabIndex = 3;
            this.btnGestiones.UseVisualStyleBackColor = false;
            this.btnGestiones.Click += new System.EventHandler(this.btnGestiones_Click);
            this.btnGestiones.Enter += new System.EventHandler(this.btnGestiones_Enter);
            this.btnGestiones.MouseEnter += new System.EventHandler(this.btnGestiones_MouseEnter);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.White;
            this.btnReportes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReportes.BackgroundImage")));
            this.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.Black;
            this.btnReportes.Location = new System.Drawing.Point(164, 325);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(155, 155);
            this.btnReportes.TabIndex = 4;
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            this.btnReportes.Enter += new System.EventHandler(this.btnReportes_Enter);
            this.btnReportes.MouseEnter += new System.EventHandler(this.btnReportes_MouseEnter);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Controls.Add(this.lblMenu);
            this.flowLayoutPanel2.Controls.Add(this.lblDescripcion);
            this.flowLayoutPanel2.Controls.Add(this.flpGestiones);
            this.flowLayoutPanel2.Controls.Add(this.flpReportes);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(358, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(486, 489);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // lblMenu
            // 
            this.lblMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMenu.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lblMenu.ForeColor = System.Drawing.Color.DarkGray;
            this.lblMenu.Location = new System.Drawing.Point(3, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(437, 143);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Consultas";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.DimGray;
            this.lblDescripcion.Location = new System.Drawing.Point(3, 143);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(437, 245);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Consultas";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpGestiones
            // 
            this.flpGestiones.Controls.Add(this.btnGestionMedicos);
            this.flpGestiones.Controls.Add(this.btnGestionEspecialidades);
            this.flpGestiones.Controls.Add(this.btnGestionPermisos);
            this.flpGestiones.Controls.Add(this.btnGestionCargos);
            this.flpGestiones.Controls.Add(this.btnGestionPacientes);
            this.flpGestiones.Controls.Add(this.btnGestionRoles);
            this.flpGestiones.Controls.Add(this.btnGestionEmpleados);
            this.flpGestiones.Controls.Add(this.btnGestionUsuarios);
            this.flpGestiones.Controls.Add(this.btnGestionConsumibles);
            this.flpGestiones.Controls.Add(this.btnGestionLaboratorios);
            this.flpGestiones.Controls.Add(this.btnGestionMarcas);
            this.flpGestiones.Location = new System.Drawing.Point(3, 391);
            this.flpGestiones.Name = "flpGestiones";
            this.flpGestiones.Size = new System.Drawing.Size(455, 656);
            this.flpGestiones.TabIndex = 2;
            this.flpGestiones.Visible = false;
            // 
            // btnGestionMedicos
            // 
            this.btnGestionMedicos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGestionMedicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionMedicos.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnGestionMedicos.ForeColor = System.Drawing.Color.White;
            this.btnGestionMedicos.Location = new System.Drawing.Point(10, 10);
            this.btnGestionMedicos.Margin = new System.Windows.Forms.Padding(10);
            this.btnGestionMedicos.Name = "btnGestionMedicos";
            this.btnGestionMedicos.Size = new System.Drawing.Size(425, 39);
            this.btnGestionMedicos.TabIndex = 0;
            this.btnGestionMedicos.Text = "Gestión de médicos";
            this.btnGestionMedicos.UseVisualStyleBackColor = false;
            this.btnGestionMedicos.Click += new System.EventHandler(this.btnGestionMedicos_Click);
            // 
            // btnGestionEspecialidades
            // 
            this.btnGestionEspecialidades.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGestionEspecialidades.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnGestionEspecialidades.ForeColor = System.Drawing.Color.White;
            this.btnGestionEspecialidades.Location = new System.Drawing.Point(10, 69);
            this.btnGestionEspecialidades.Margin = new System.Windows.Forms.Padding(10);
            this.btnGestionEspecialidades.Name = "btnGestionEspecialidades";
            this.btnGestionEspecialidades.Size = new System.Drawing.Size(425, 39);
            this.btnGestionEspecialidades.TabIndex = 1;
            this.btnGestionEspecialidades.Text = "Gestión de especialidades";
            this.btnGestionEspecialidades.UseVisualStyleBackColor = false;
            this.btnGestionEspecialidades.Click += new System.EventHandler(this.btnGestionEspecialidades_Click);
            // 
            // btnGestionPermisos
            // 
            this.btnGestionPermisos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGestionPermisos.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnGestionPermisos.ForeColor = System.Drawing.Color.White;
            this.btnGestionPermisos.Location = new System.Drawing.Point(10, 128);
            this.btnGestionPermisos.Margin = new System.Windows.Forms.Padding(10);
            this.btnGestionPermisos.Name = "btnGestionPermisos";
            this.btnGestionPermisos.Size = new System.Drawing.Size(425, 39);
            this.btnGestionPermisos.TabIndex = 3;
            this.btnGestionPermisos.Text = "Gestión de permisos";
            this.btnGestionPermisos.UseVisualStyleBackColor = false;
            this.btnGestionPermisos.Click += new System.EventHandler(this.btnGestionPermisos_Click);
            // 
            // btnGestionCargos
            // 
            this.btnGestionCargos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGestionCargos.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnGestionCargos.ForeColor = System.Drawing.Color.White;
            this.btnGestionCargos.Location = new System.Drawing.Point(10, 187);
            this.btnGestionCargos.Margin = new System.Windows.Forms.Padding(10);
            this.btnGestionCargos.Name = "btnGestionCargos";
            this.btnGestionCargos.Size = new System.Drawing.Size(425, 39);
            this.btnGestionCargos.TabIndex = 4;
            this.btnGestionCargos.Text = "Gestión de cargos";
            this.btnGestionCargos.UseVisualStyleBackColor = false;
            this.btnGestionCargos.Click += new System.EventHandler(this.btnGestionCargos_Click);
            // 
            // btnGestionPacientes
            // 
            this.btnGestionPacientes.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGestionPacientes.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnGestionPacientes.ForeColor = System.Drawing.Color.White;
            this.btnGestionPacientes.Location = new System.Drawing.Point(10, 246);
            this.btnGestionPacientes.Margin = new System.Windows.Forms.Padding(10);
            this.btnGestionPacientes.Name = "btnGestionPacientes";
            this.btnGestionPacientes.Size = new System.Drawing.Size(425, 39);
            this.btnGestionPacientes.TabIndex = 5;
            this.btnGestionPacientes.Text = "Gestión de pacientes";
            this.btnGestionPacientes.UseVisualStyleBackColor = false;
            this.btnGestionPacientes.Click += new System.EventHandler(this.btnGestionPacientes_Click);
            // 
            // btnGestionRoles
            // 
            this.btnGestionRoles.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGestionRoles.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnGestionRoles.ForeColor = System.Drawing.Color.White;
            this.btnGestionRoles.Location = new System.Drawing.Point(10, 305);
            this.btnGestionRoles.Margin = new System.Windows.Forms.Padding(10);
            this.btnGestionRoles.Name = "btnGestionRoles";
            this.btnGestionRoles.Size = new System.Drawing.Size(425, 39);
            this.btnGestionRoles.TabIndex = 6;
            this.btnGestionRoles.Text = "Gestión de roles";
            this.btnGestionRoles.UseVisualStyleBackColor = false;
            this.btnGestionRoles.Click += new System.EventHandler(this.btnGestionRoles_Click);
            // 
            // btnGestionEmpleados
            // 
            this.btnGestionEmpleados.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGestionEmpleados.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnGestionEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnGestionEmpleados.Location = new System.Drawing.Point(10, 364);
            this.btnGestionEmpleados.Margin = new System.Windows.Forms.Padding(10);
            this.btnGestionEmpleados.Name = "btnGestionEmpleados";
            this.btnGestionEmpleados.Size = new System.Drawing.Size(425, 39);
            this.btnGestionEmpleados.TabIndex = 7;
            this.btnGestionEmpleados.Text = "Gestión de empleados";
            this.btnGestionEmpleados.UseVisualStyleBackColor = false;
            this.btnGestionEmpleados.Click += new System.EventHandler(this.btnGestionEmpleados_Click);
            // 
            // btnGestionUsuarios
            // 
            this.btnGestionUsuarios.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGestionUsuarios.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnGestionUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnGestionUsuarios.Location = new System.Drawing.Point(10, 423);
            this.btnGestionUsuarios.Margin = new System.Windows.Forms.Padding(10);
            this.btnGestionUsuarios.Name = "btnGestionUsuarios";
            this.btnGestionUsuarios.Size = new System.Drawing.Size(425, 39);
            this.btnGestionUsuarios.TabIndex = 9;
            this.btnGestionUsuarios.Text = "Gestión de usuarios";
            this.btnGestionUsuarios.UseVisualStyleBackColor = false;
            this.btnGestionUsuarios.Click += new System.EventHandler(this.btnGestionUsuarios_Click);
            // 
            // btnGestionConsumibles
            // 
            this.btnGestionConsumibles.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGestionConsumibles.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnGestionConsumibles.ForeColor = System.Drawing.Color.White;
            this.btnGestionConsumibles.Location = new System.Drawing.Point(10, 482);
            this.btnGestionConsumibles.Margin = new System.Windows.Forms.Padding(10);
            this.btnGestionConsumibles.Name = "btnGestionConsumibles";
            this.btnGestionConsumibles.Size = new System.Drawing.Size(425, 39);
            this.btnGestionConsumibles.TabIndex = 10;
            this.btnGestionConsumibles.Text = "Gestión de consumibles";
            this.btnGestionConsumibles.UseVisualStyleBackColor = false;
            this.btnGestionConsumibles.Click += new System.EventHandler(this.btnGestionConsumibles_Click);
            // 
            // btnGestionLaboratorios
            // 
            this.btnGestionLaboratorios.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGestionLaboratorios.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnGestionLaboratorios.ForeColor = System.Drawing.Color.White;
            this.btnGestionLaboratorios.Location = new System.Drawing.Point(10, 541);
            this.btnGestionLaboratorios.Margin = new System.Windows.Forms.Padding(10);
            this.btnGestionLaboratorios.Name = "btnGestionLaboratorios";
            this.btnGestionLaboratorios.Size = new System.Drawing.Size(425, 39);
            this.btnGestionLaboratorios.TabIndex = 11;
            this.btnGestionLaboratorios.Text = "Gestión de laboratorios";
            this.btnGestionLaboratorios.UseVisualStyleBackColor = false;
            this.btnGestionLaboratorios.Click += new System.EventHandler(this.btnGestionLaboratorios_Click);
            // 
            // btnGestionMarcas
            // 
            this.btnGestionMarcas.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGestionMarcas.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnGestionMarcas.ForeColor = System.Drawing.Color.White;
            this.btnGestionMarcas.Location = new System.Drawing.Point(10, 600);
            this.btnGestionMarcas.Margin = new System.Windows.Forms.Padding(10);
            this.btnGestionMarcas.Name = "btnGestionMarcas";
            this.btnGestionMarcas.Size = new System.Drawing.Size(425, 39);
            this.btnGestionMarcas.TabIndex = 12;
            this.btnGestionMarcas.Text = "Gestión de Marcas";
            this.btnGestionMarcas.UseVisualStyleBackColor = false;
            this.btnGestionMarcas.Click += new System.EventHandler(this.btnGestionMarcas_Click);
            // 
            // flpReportes
            // 
            this.flpReportes.Controls.Add(this.button1);
            this.flpReportes.Controls.Add(this.button4);
            this.flpReportes.Controls.Add(this.button7);
            this.flpReportes.Controls.Add(this.button6);
            this.flpReportes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpReportes.Location = new System.Drawing.Point(3, 1053);
            this.flpReportes.Name = "flpReportes";
            this.flpReportes.Size = new System.Drawing.Size(455, 366);
            this.flpReportes.TabIndex = 3;
            this.flpReportes.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(10, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(425, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reporte de ventas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(10, 69);
            this.button4.Margin = new System.Windows.Forms.Padding(10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(425, 39);
            this.button4.TabIndex = 2;
            this.button4.Text = "Reporte de compras";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DodgerBlue;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(10, 128);
            this.button7.Margin = new System.Windows.Forms.Padding(10);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(425, 39);
            this.button7.TabIndex = 5;
            this.button7.Text = "Reporte de inventario";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DodgerBlue;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(10, 187);
            this.button6.Margin = new System.Windows.Forms.Padding(10);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(425, 39);
            this.button6.TabIndex = 4;
            this.button6.Text = "Constancias";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(904, 501);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(916, 513);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flpGestiones.ResumeLayout(false);
            this.flpReportes.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnGestiones;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.FlowLayoutPanel flpGestiones;
        private System.Windows.Forms.Button btnGestionMedicos;
        private System.Windows.Forms.Button btnGestionEspecialidades;
        private System.Windows.Forms.FlowLayoutPanel flpReportes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGestionPermisos;
        private System.Windows.Forms.Button btnGestionCargos;
        private System.Windows.Forms.Button btnGestionPacientes;
        private System.Windows.Forms.Button btnGestionRoles;
        private System.Windows.Forms.Button btnGestionEmpleados;
        private System.Windows.Forms.Button btnGestionUsuarios;
        private System.Windows.Forms.Button btnGestionConsumibles;
        private System.Windows.Forms.Button btnGestionLaboratorios;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnInventarios;
        private System.Windows.Forms.Button btnGestionMarcas;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    }
}
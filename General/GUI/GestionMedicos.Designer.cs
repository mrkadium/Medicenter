﻿namespace General.GUI
{
    partial class GestionMedicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionMedicos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.sep2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.txbFiltro = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnSeleccionar = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            this.dtgvDatos = new System.Windows.Forms.DataGridView();
            this.JVPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DUI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contratacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.sep1,
            this.btnEditar,
            this.sep2,
            this.btnEliminar,
            this.txbFiltro,
            this.toolStripLabel1,
            this.btnSeleccionar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(69, 22);
            this.btnAgregar.Text = "Agregar";
            // 
            // sep1
            // 
            this.sep1.Name = "sep1";
            this.sep1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(57, 22);
            this.btnEditar.Text = "Editar";
            // 
            // sep2
            // 
            this.sep2.Name = "sep2";
            this.sep2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 22);
            this.btnEliminar.Text = "Eliminar";
            // 
            // txbFiltro
            // 
            this.txbFiltro.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txbFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbFiltro.Name = "txbFiltro";
            this.txbFiltro.Size = new System.Drawing.Size(200, 25);
            this.txbFiltro.TextChanged += new System.EventHandler(this.txbFiltro_TextChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel1.Text = "Filtrar";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.Image")));
            this.btnSeleccionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(87, 22);
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.Visible = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblRegistros});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblRegistros
            // 
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(133, 17);
            this.lblRegistros.Text = "0 Registros encontrados";
            // 
            // dtgvDatos
            // 
            this.dtgvDatos.AllowUserToAddRows = false;
            this.dtgvDatos.AllowUserToDeleteRows = false;
            this.dtgvDatos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JVPM,
            this.Nombres,
            this.Apellidos,
            this.Fecha_Nacimiento,
            this.DUI,
            this.NIT,
            this.Direccion,
            this.Contratacion,
            this.Salida,
            this.Estado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDatos.Location = new System.Drawing.Point(0, 25);
            this.dtgvDatos.MultiSelect = false;
            this.dtgvDatos.Name = "dtgvDatos";
            this.dtgvDatos.ReadOnly = true;
            this.dtgvDatos.RowHeadersVisible = false;
            this.dtgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDatos.Size = new System.Drawing.Size(800, 403);
            this.dtgvDatos.TabIndex = 4;
            // 
            // JVPM
            // 
            this.JVPM.DataPropertyName = "jvpm";
            this.JVPM.HeaderText = "JVPM";
            this.JVPM.Name = "JVPM";
            this.JVPM.ReadOnly = true;
            this.JVPM.Width = 60;
            // 
            // Nombres
            // 
            this.Nombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombres.DataPropertyName = "nombres";
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.MinimumWidth = 150;
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Apellidos.DataPropertyName = "apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.MinimumWidth = 150;
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // Fecha_Nacimiento
            // 
            this.Fecha_Nacimiento.DataPropertyName = "fecha_nacimiento";
            this.Fecha_Nacimiento.HeaderText = "Nacimiento";
            this.Fecha_Nacimiento.MinimumWidth = 75;
            this.Fecha_Nacimiento.Name = "Fecha_Nacimiento";
            this.Fecha_Nacimiento.ReadOnly = true;
            // 
            // DUI
            // 
            this.DUI.DataPropertyName = "dui";
            this.DUI.HeaderText = "DUI";
            this.DUI.MinimumWidth = 70;
            this.DUI.Name = "DUI";
            this.DUI.ReadOnly = true;
            this.DUI.Width = 70;
            // 
            // NIT
            // 
            this.NIT.DataPropertyName = "nit";
            this.NIT.HeaderText = "NIT";
            this.NIT.MinimumWidth = 100;
            this.NIT.Name = "NIT";
            this.NIT.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Direccion.DataPropertyName = "direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 150;
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Contratacion
            // 
            this.Contratacion.DataPropertyName = "fechacontratacion";
            this.Contratacion.HeaderText = "Contratación";
            this.Contratacion.MinimumWidth = 75;
            this.Contratacion.Name = "Contratacion";
            this.Contratacion.ReadOnly = true;
            // 
            // Salida
            // 
            this.Salida.DataPropertyName = "fechasalida";
            this.Salida.HeaderText = "Salida";
            this.Salida.MinimumWidth = 75;
            this.Salida.Name = "Salida";
            this.Salida.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // GestionMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgvDatos);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "GestionMedicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionMedicos";
            this.Load += new System.EventHandler(this.GestionMedicos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton btnAgregar;
        public System.Windows.Forms.ToolStripSeparator sep1;
        public System.Windows.Forms.ToolStripButton btnEditar;
        public System.Windows.Forms.ToolStripSeparator sep2;
        public System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripTextBox txbFiltro;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        public System.Windows.Forms.ToolStripButton btnSeleccionar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblRegistros;
        public System.Windows.Forms.DataGridView dtgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn JVPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contratacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}
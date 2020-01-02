namespace General.GUI.ReportVentas
{
    partial class CapDatReporteVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CapDatReporteVentas));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbTipoVenta = new System.Windows.Forms.GroupBox();
            this.rdbGeneral = new System.Windows.Forms.RadioButton();
            this.rdbProducto = new System.Windows.Forms.RadioButton();
            this.rdbServicio = new System.Windows.Forms.RadioButton();
            this.gpbProMarEspe = new System.Windows.Forms.GroupBox();
            this.rdbAllProMar = new System.Windows.Forms.RadioButton();
            this.rdbMarcaEspecifica = new System.Windows.Forms.RadioButton();
            this.rdbProEspecifico = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMarca = new System.Windows.Forms.Button();
            this.txbMarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnProducto = new System.Windows.Forms.Button();
            this.txbProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbIdMarca = new System.Windows.Forms.TextBox();
            this.txbIdProducto = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpbTipoVenta.SuspendLayout();
            this.gpbProMarEspe.SuspendLayout();
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
            this.btnCerrar.Location = new System.Drawing.Point(525, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(41, 32);
            this.btnCerrar.TabIndex = 41;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(30, 15, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Tipo de ventas";
            // 
            // gpbTipoVenta
            // 
            this.gpbTipoVenta.Controls.Add(this.rdbGeneral);
            this.gpbTipoVenta.Controls.Add(this.rdbProducto);
            this.gpbTipoVenta.Controls.Add(this.rdbServicio);
            this.gpbTipoVenta.Location = new System.Drawing.Point(52, 51);
            this.gpbTipoVenta.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.gpbTipoVenta.Name = "gpbTipoVenta";
            this.gpbTipoVenta.Size = new System.Drawing.Size(146, 104);
            this.gpbTipoVenta.TabIndex = 0;
            this.gpbTipoVenta.TabStop = false;
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
            // rdbProducto
            // 
            this.rdbProducto.AutoSize = true;
            this.rdbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbProducto.Location = new System.Drawing.Point(15, 69);
            this.rdbProducto.Name = "rdbProducto";
            this.rdbProducto.Size = new System.Drawing.Size(87, 20);
            this.rdbProducto.TabIndex = 3;
            this.rdbProducto.Text = "Productos";
            this.rdbProducto.UseVisualStyleBackColor = true;
            this.rdbProducto.CheckedChanged += new System.EventHandler(this.rdbProducto_CheckedChanged);
            // 
            // rdbServicio
            // 
            this.rdbServicio.AutoSize = true;
            this.rdbServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbServicio.Location = new System.Drawing.Point(15, 43);
            this.rdbServicio.Name = "rdbServicio";
            this.rdbServicio.Size = new System.Drawing.Size(82, 20);
            this.rdbServicio.TabIndex = 2;
            this.rdbServicio.Text = "Servicios";
            this.rdbServicio.UseVisualStyleBackColor = true;
            this.rdbServicio.CheckedChanged += new System.EventHandler(this.rdbServicio_CheckedChanged);
            // 
            // gpbProMarEspe
            // 
            this.gpbProMarEspe.Controls.Add(this.rdbAllProMar);
            this.gpbProMarEspe.Controls.Add(this.rdbMarcaEspecifica);
            this.gpbProMarEspe.Controls.Add(this.rdbProEspecifico);
            this.gpbProMarEspe.Location = new System.Drawing.Point(280, 51);
            this.gpbProMarEspe.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.gpbProMarEspe.Name = "gpbProMarEspe";
            this.gpbProMarEspe.Size = new System.Drawing.Size(236, 104);
            this.gpbProMarEspe.TabIndex = 4;
            this.gpbProMarEspe.TabStop = false;
            // 
            // rdbAllProMar
            // 
            this.rdbAllProMar.AutoSize = true;
            this.rdbAllProMar.Enabled = false;
            this.rdbAllProMar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAllProMar.Location = new System.Drawing.Point(15, 17);
            this.rdbAllProMar.Name = "rdbAllProMar";
            this.rdbAllProMar.Size = new System.Drawing.Size(208, 20);
            this.rdbAllProMar.TabIndex = 5;
            this.rdbAllProMar.TabStop = true;
            this.rdbAllProMar.Text = "Todos los productos y marcas";
            this.rdbAllProMar.UseVisualStyleBackColor = true;
            this.rdbAllProMar.CheckedChanged += new System.EventHandler(this.rdbAllProMar_CheckedChanged);
            // 
            // rdbMarcaEspecifica
            // 
            this.rdbMarcaEspecifica.AutoSize = true;
            this.rdbMarcaEspecifica.Enabled = false;
            this.rdbMarcaEspecifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMarcaEspecifica.Location = new System.Drawing.Point(15, 69);
            this.rdbMarcaEspecifica.Name = "rdbMarcaEspecifica";
            this.rdbMarcaEspecifica.Size = new System.Drawing.Size(129, 20);
            this.rdbMarcaEspecifica.TabIndex = 7;
            this.rdbMarcaEspecifica.Text = "Marca específica";
            this.rdbMarcaEspecifica.UseVisualStyleBackColor = true;
            this.rdbMarcaEspecifica.CheckedChanged += new System.EventHandler(this.rdbMarcaEspecifica_CheckedChanged);
            // 
            // rdbProEspecifico
            // 
            this.rdbProEspecifico.AutoSize = true;
            this.rdbProEspecifico.Enabled = false;
            this.rdbProEspecifico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbProEspecifico.Location = new System.Drawing.Point(15, 43);
            this.rdbProEspecifico.Name = "rdbProEspecifico";
            this.rdbProEspecifico.Size = new System.Drawing.Size(145, 20);
            this.rdbProEspecifico.TabIndex = 6;
            this.rdbProEspecifico.Text = "Producto específico";
            this.rdbProEspecifico.UseVisualStyleBackColor = true;
            this.rdbProEspecifico.CheckedChanged += new System.EventHandler(this.rdbProEspecifico_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 223);
            this.label1.Margin = new System.Windows.Forms.Padding(30, 15, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Desde";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Checked = false;
            this.dtpFechaInicio.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Location = new System.Drawing.Point(52, 244);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(160, 22);
            this.dtpFechaInicio.TabIndex = 14;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Checked = false;
            this.dtpFechaFin.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(294, 242);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(160, 22);
            this.dtpFechaFin.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(30, 15, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Hasta";
            // 
            // btnMarca
            // 
            this.btnMarca.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMarca.BackgroundImage = global::General.Properties.Resources.archive1;
            this.btnMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMarca.Enabled = false;
            this.btnMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnMarca.ForeColor = System.Drawing.Color.White;
            this.btnMarca.Location = new System.Drawing.Point(457, 180);
            this.btnMarca.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(36, 28);
            this.btnMarca.TabIndex = 13;
            this.btnMarca.UseVisualStyleBackColor = false;
            this.btnMarca.Click += new System.EventHandler(this.btnMarca_Click);
            this.btnMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnMarca_KeyPress);
            // 
            // txbMarca
            // 
            this.txbMarca.Enabled = false;
            this.txbMarca.Location = new System.Drawing.Point(294, 185);
            this.txbMarca.Name = "txbMarca";
            this.txbMarca.ReadOnly = true;
            this.txbMarca.Size = new System.Drawing.Size(160, 20);
            this.txbMarca.TabIndex = 12;
            this.txbMarca.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 53;
            this.label4.Text = "Marca";
            // 
            // btnProducto
            // 
            this.btnProducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnProducto.BackgroundImage = global::General.Properties.Resources.archive1;
            this.btnProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProducto.Enabled = false;
            this.btnProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnProducto.ForeColor = System.Drawing.Color.White;
            this.btnProducto.Location = new System.Drawing.Point(215, 180);
            this.btnProducto.Margin = new System.Windows.Forms.Padding(0, 10, 0, 3);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(36, 28);
            this.btnProducto.TabIndex = 10;
            this.btnProducto.UseVisualStyleBackColor = false;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            this.btnProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnProducto_KeyPress);
            // 
            // txbProducto
            // 
            this.txbProducto.Enabled = false;
            this.txbProducto.Location = new System.Drawing.Point(52, 185);
            this.txbProducto.Name = "txbProducto";
            this.txbProducto.ReadOnly = true;
            this.txbProducto.Size = new System.Drawing.Size(160, 20);
            this.txbProducto.TabIndex = 9;
            this.txbProducto.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 52;
            this.label5.Text = "Producto";
            // 
            // txbIdMarca
            // 
            this.txbIdMarca.Location = new System.Drawing.Point(280, 185);
            this.txbIdMarca.Name = "txbIdMarca";
            this.txbIdMarca.Size = new System.Drawing.Size(13, 20);
            this.txbIdMarca.TabIndex = 11;
            this.txbIdMarca.TabStop = false;
            this.txbIdMarca.Visible = false;
            // 
            // txbIdProducto
            // 
            this.txbIdProducto.Location = new System.Drawing.Point(37, 185);
            this.txbIdProducto.Name = "txbIdProducto";
            this.txbIdProducto.Size = new System.Drawing.Size(13, 20);
            this.txbIdProducto.TabIndex = 8;
            this.txbIdProducto.TabStop = false;
            this.txbIdProducto.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(301, 292);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 40);
            this.btnCancelar.TabIndex = 17;
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
            this.btnGenerar.Location = new System.Drawing.Point(183, 292);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(87, 40);
            this.btnGenerar.TabIndex = 16;
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
            // CapDatReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(566, 356);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txbIdMarca);
            this.Controls.Add(this.txbIdProducto);
            this.Controls.Add(this.btnMarca);
            this.Controls.Add(this.txbMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnProducto);
            this.Controls.Add(this.txbProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpbProMarEspe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gpbTipoVenta);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CapDatReporteVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos para el reporte de ventas";
            this.gpbTipoVenta.ResumeLayout(false);
            this.gpbTipoVenta.PerformLayout();
            this.gpbProMarEspe.ResumeLayout(false);
            this.gpbProMarEspe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.GroupBox gpbTipoVenta;
        public System.Windows.Forms.RadioButton rdbProducto;
        public System.Windows.Forms.RadioButton rdbServicio;
        public System.Windows.Forms.RadioButton rdbGeneral;
        public System.Windows.Forms.GroupBox gpbProMarEspe;
        public System.Windows.Forms.RadioButton rdbAllProMar;
        public System.Windows.Forms.RadioButton rdbMarcaEspecifica;
        public System.Windows.Forms.RadioButton rdbProEspecifico;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dtpFechaInicio;
        public System.Windows.Forms.DateTimePicker dtpFechaFin;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnMarca;
        public System.Windows.Forms.TextBox txbMarca;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnProducto;
        public System.Windows.Forms.TextBox txbProducto;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txbIdMarca;
        public System.Windows.Forms.TextBox txbIdProducto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ErrorProvider Notificador;
    }
}
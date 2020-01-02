namespace General.GUI.Ventas
{
    partial class DetalleVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txbIdOperacion = new System.Windows.Forms.TextBox();
            this.lblIdTitular = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txbIdTitular = new System.Windows.Forms.TextBox();
            this.txbTitular = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.productos = new System.Windows.Forms.Label();
            this.dtgvDatosProducto = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.idconsumible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatosProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.txbIdOperacion);
            this.flowLayoutPanel1.Controls.Add(this.lblIdTitular);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.lblFecha);
            this.flowLayoutPanel1.Controls.Add(this.dtpFechaCompra);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.txbTotal);
            this.flowLayoutPanel1.Controls.Add(this.productos);
            this.flowLayoutPanel1.Controls.Add(this.dtgvDatosProducto);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(579, 429);
            this.flowLayoutPanel1.TabIndex = 37;
            // 
            // txbIdOperacion
            // 
            this.txbIdOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdOperacion.Location = new System.Drawing.Point(3, 5);
            this.txbIdOperacion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.txbIdOperacion.Name = "txbIdOperacion";
            this.txbIdOperacion.ReadOnly = true;
            this.txbIdOperacion.Size = new System.Drawing.Size(47, 22);
            this.txbIdOperacion.TabIndex = 7;
            this.txbIdOperacion.TabStop = false;
            this.txbIdOperacion.Visible = false;
            // 
            // lblIdTitular
            // 
            this.lblIdTitular.AutoSize = true;
            this.lblIdTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdTitular.Location = new System.Drawing.Point(3, 33);
            this.lblIdTitular.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblIdTitular.Name = "lblIdTitular";
            this.lblIdTitular.Size = new System.Drawing.Size(45, 16);
            this.lblIdTitular.TabIndex = 12;
            this.lblIdTitular.Text = "Titular";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.txbIdTitular);
            this.flowLayoutPanel2.Controls.Add(this.txbTitular);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 52);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(315, 38);
            this.flowLayoutPanel2.TabIndex = 13;
            // 
            // txbIdTitular
            // 
            this.txbIdTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdTitular.Location = new System.Drawing.Point(3, 5);
            this.txbIdTitular.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.txbIdTitular.Name = "txbIdTitular";
            this.txbIdTitular.ReadOnly = true;
            this.txbIdTitular.Size = new System.Drawing.Size(47, 22);
            this.txbIdTitular.TabIndex = 7;
            this.txbIdTitular.TabStop = false;
            // 
            // txbTitular
            // 
            this.txbTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTitular.Location = new System.Drawing.Point(56, 5);
            this.txbTitular.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.txbTitular.Name = "txbTitular";
            this.txbTitular.ReadOnly = true;
            this.txbTitular.Size = new System.Drawing.Size(200, 22);
            this.txbTitular.TabIndex = 8;
            this.txbTitular.TabStop = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(3, 96);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(101, 16);
            this.lblFecha.TabIndex = 12;
            this.lblFecha.Text = "Fecha de venta";
            // 
            // dtpFechaCompra
            // 
            this.dtpFechaCompra.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaCompra.Location = new System.Drawing.Point(3, 115);
            this.dtpFechaCompra.Name = "dtpFechaCompra";
            this.dtpFechaCompra.Size = new System.Drawing.Size(256, 23);
            this.dtpFechaCompra.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Total de venta";
            // 
            // txbTotal
            // 
            this.txbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotal.Location = new System.Drawing.Point(3, 165);
            this.txbTotal.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.ReadOnly = true;
            this.txbTotal.Size = new System.Drawing.Size(107, 22);
            this.txbTotal.TabIndex = 8;
            this.txbTotal.TabStop = false;
            // 
            // productos
            // 
            this.productos.AutoSize = true;
            this.productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productos.Location = new System.Drawing.Point(3, 220);
            this.productos.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.productos.Name = "productos";
            this.productos.Size = new System.Drawing.Size(141, 16);
            this.productos.TabIndex = 12;
            this.productos.Text = "Productos comprados";
            // 
            // dtgvDatosProducto
            // 
            this.dtgvDatosProducto.AllowUserToAddRows = false;
            this.dtgvDatosProducto.AllowUserToDeleteRows = false;
            this.dtgvDatosProducto.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgvDatosProducto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgvDatosProducto.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvDatosProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvDatosProducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgvDatosProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDatosProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idconsumible,
            this.consumible,
            this.cantidad,
            this.precioventa});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDatosProducto.DefaultCellStyle = dataGridViewCellStyle10;
            this.dtgvDatosProducto.Location = new System.Drawing.Point(326, 5);
            this.dtgvDatosProducto.Margin = new System.Windows.Forms.Padding(5);
            this.dtgvDatosProducto.MultiSelect = false;
            this.dtgvDatosProducto.Name = "dtgvDatosProducto";
            this.dtgvDatosProducto.ReadOnly = true;
            this.dtgvDatosProducto.RowHeadersVisible = false;
            this.dtgvDatosProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDatosProducto.Size = new System.Drawing.Size(554, 186);
            this.dtgvDatosProducto.TabIndex = 11;
            this.dtgvDatosProducto.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(153, 457);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 40);
            this.btnGuardar.TabIndex = 38;
            this.btnGuardar.Text = "Factura";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(344, 457);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 40);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // idconsumible
            // 
            this.idconsumible.DataPropertyName = "idconsumible";
            this.idconsumible.HeaderText = "ID";
            this.idconsumible.MinimumWidth = 50;
            this.idconsumible.Name = "idconsumible";
            this.idconsumible.ReadOnly = true;
            this.idconsumible.Width = 50;
            // 
            // consumible
            // 
            this.consumible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.consumible.DataPropertyName = "consumible";
            this.consumible.HeaderText = "Producto";
            this.consumible.MinimumWidth = 200;
            this.consumible.Name = "consumible";
            this.consumible.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // precioventa
            // 
            this.precioventa.DataPropertyName = "precioventa";
            this.precioventa.HeaderText = "Precio de venta";
            this.precioventa.Name = "precioventa";
            this.precioventa.ReadOnly = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.AutoEllipsis = true;
            this.btnCerrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(567, -2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(41, 32);
            this.btnCerrar.TabIndex = 40;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // DetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(608, 523);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetalleVenta";
            this.Text = "DetalleVenta";
            this.Load += new System.EventHandler(this.DetalleVenta_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatosProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.TextBox txbIdOperacion;
        public System.Windows.Forms.Label lblIdTitular;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        public System.Windows.Forms.TextBox txbIdTitular;
        public System.Windows.Forms.TextBox txbTitular;
        public System.Windows.Forms.Label lblFecha;
        public System.Windows.Forms.DateTimePicker dtpFechaCompra;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txbTotal;
        public System.Windows.Forms.Label productos;
        public System.Windows.Forms.DataGridView dtgvDatosProducto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idconsumible;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumible;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioventa;
        private System.Windows.Forms.Button btnCerrar;
    }
}
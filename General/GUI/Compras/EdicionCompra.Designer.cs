namespace General.GUI.Compras
{
    partial class EdicionCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdicionCompra));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblIdTitular = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txbIdProveedor = new System.Windows.Forms.TextBox();
            this.txbProveedor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtgvDatosProducto = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.txbIdProducto = new System.Windows.Forms.TextBox();
            this.txbProducto = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPrecioCompra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbPrecioVenta = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregarProd = new System.Windows.Forms.Button();
            this.btnQuitarProd = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.txbIdOperacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbIdTitular = new System.Windows.Forms.TextBox();
            this.txbTitular = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.idconsumible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciocompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatosProducto)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblIdTitular);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.dtgvDatosProducto);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 8);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(495, 414);
            this.flowLayoutPanel1.TabIndex = 29;
            // 
            // lblIdTitular
            // 
            this.lblIdTitular.AutoSize = true;
            this.lblIdTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdTitular.Location = new System.Drawing.Point(3, 3);
            this.lblIdTitular.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblIdTitular.Name = "lblIdTitular";
            this.lblIdTitular.Size = new System.Drawing.Size(72, 16);
            this.lblIdTitular.TabIndex = 5;
            this.lblIdTitular.Text = "Proveedor";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.txbIdProveedor);
            this.flowLayoutPanel2.Controls.Add(this.txbProveedor);
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 22);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(315, 38);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // txbIdProveedor
            // 
            this.txbIdProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdProveedor.Location = new System.Drawing.Point(3, 5);
            this.txbIdProveedor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.txbIdProveedor.Name = "txbIdProveedor";
            this.txbIdProveedor.ReadOnly = true;
            this.txbIdProveedor.Size = new System.Drawing.Size(47, 22);
            this.txbIdProveedor.TabIndex = 7;
            this.txbIdProveedor.TabStop = false;
            // 
            // txbProveedor
            // 
            this.txbProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProveedor.Location = new System.Drawing.Point(56, 5);
            this.txbProveedor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.txbProveedor.Name = "txbProveedor";
            this.txbProveedor.ReadOnly = true;
            this.txbProveedor.Size = new System.Drawing.Size(200, 22);
            this.txbProveedor.TabIndex = 8;
            this.txbProveedor.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::General.Properties.Resources.archive;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(262, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 24);
            this.button1.TabIndex = 0;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgvDatosProducto
            // 
            this.dtgvDatosProducto.AllowUserToAddRows = false;
            this.dtgvDatosProducto.AllowUserToDeleteRows = false;
            this.dtgvDatosProducto.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgvDatosProducto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDatosProducto.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvDatosProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvDatosProducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dtgvDatosProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDatosProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idconsumible,
            this.consumible,
            this.cantidad,
            this.preciocompra,
            this.precioventa});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDatosProducto.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvDatosProducto.Location = new System.Drawing.Point(5, 68);
            this.dtgvDatosProducto.Margin = new System.Windows.Forms.Padding(5);
            this.dtgvDatosProducto.MultiSelect = false;
            this.dtgvDatosProducto.Name = "dtgvDatosProducto";
            this.dtgvDatosProducto.ReadOnly = true;
            this.dtgvDatosProducto.RowHeadersVisible = false;
            this.dtgvDatosProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDatosProducto.Size = new System.Drawing.Size(480, 131);
            this.dtgvDatosProducto.TabIndex = 10;
            this.dtgvDatosProducto.TabStop = false;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label1);
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel4.Controls.Add(this.label2);
            this.flowLayoutPanel4.Controls.Add(this.txbCantidad);
            this.flowLayoutPanel4.Controls.Add(this.label3);
            this.flowLayoutPanel4.Controls.Add(this.txbPrecioCompra);
            this.flowLayoutPanel4.Controls.Add(this.label5);
            this.flowLayoutPanel4.Controls.Add(this.txbPrecioVenta);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 207);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(422, 124);
            this.flowLayoutPanel4.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Producto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.txbIdProducto);
            this.flowLayoutPanel5.Controls.Add(this.txbProducto);
            this.flowLayoutPanel5.Controls.Add(this.button2);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(81, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(315, 38);
            this.flowLayoutPanel5.TabIndex = 10;
            // 
            // txbIdProducto
            // 
            this.txbIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdProducto.Location = new System.Drawing.Point(3, 5);
            this.txbIdProducto.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.txbIdProducto.Name = "txbIdProducto";
            this.txbIdProducto.ReadOnly = true;
            this.txbIdProducto.Size = new System.Drawing.Size(47, 22);
            this.txbIdProducto.TabIndex = 7;
            this.txbIdProducto.TabStop = false;
            // 
            // txbProducto
            // 
            this.txbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProducto.Location = new System.Drawing.Point(56, 5);
            this.txbProducto.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.txbProducto.Name = "txbProducto";
            this.txbProducto.ReadOnly = true;
            this.txbProducto.Size = new System.Drawing.Size(200, 22);
            this.txbProducto.TabIndex = 8;
            this.txbProducto.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::General.Properties.Resources.archive;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(262, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 24);
            this.button2.TabIndex = 1;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Cantidad";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txbCantidad
            // 
            this.flowLayoutPanel4.SetFlowBreak(this.txbCantidad, true);
            this.txbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCantidad.Location = new System.Drawing.Point(71, 49);
            this.txbCantidad.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(102, 22);
            this.txbCantidad.TabIndex = 2;
            this.txbCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCantidad_KeyPress);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Precio de compra";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txbPrecioCompra
            // 
            this.txbPrecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrecioCompra.Location = new System.Drawing.Point(133, 79);
            this.txbPrecioCompra.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.txbPrecioCompra.Name = "txbPrecioCompra";
            this.txbPrecioCompra.Size = new System.Drawing.Size(44, 22);
            this.txbPrecioCompra.TabIndex = 3;
            this.txbPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrecioCompra_KeyPress);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(183, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Precio de venta";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txbPrecioVenta
            // 
            this.txbPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrecioVenta.Location = new System.Drawing.Point(313, 79);
            this.txbPrecioVenta.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.txbPrecioVenta.Name = "txbPrecioVenta";
            this.txbPrecioVenta.Size = new System.Drawing.Size(44, 22);
            this.txbPrecioVenta.TabIndex = 4;
            this.txbPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrecioVenta_KeyPress);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnAgregarProd);
            this.flowLayoutPanel3.Controls.Add(this.btnQuitarProd);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 337);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(315, 48);
            this.flowLayoutPanel3.TabIndex = 12;
            // 
            // btnAgregarProd
            // 
            this.btnAgregarProd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProd.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProd.Location = new System.Drawing.Point(2, 2);
            this.btnAgregarProd.Margin = new System.Windows.Forms.Padding(2, 2, 0, 3);
            this.btnAgregarProd.Name = "btnAgregarProd";
            this.btnAgregarProd.Size = new System.Drawing.Size(156, 41);
            this.btnAgregarProd.TabIndex = 5;
            this.btnAgregarProd.Text = "Agregar productos";
            this.btnAgregarProd.UseVisualStyleBackColor = false;
            this.btnAgregarProd.Click += new System.EventHandler(this.btnAgregarProd_Click);
            // 
            // btnQuitarProd
            // 
            this.btnQuitarProd.BackColor = System.Drawing.Color.Gray;
            this.btnQuitarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarProd.ForeColor = System.Drawing.Color.White;
            this.btnQuitarProd.Location = new System.Drawing.Point(160, 3);
            this.btnQuitarProd.Margin = new System.Windows.Forms.Padding(2, 3, 0, 3);
            this.btnQuitarProd.Name = "btnQuitarProd";
            this.btnQuitarProd.Size = new System.Drawing.Size(155, 40);
            this.btnQuitarProd.TabIndex = 6;
            this.btnQuitarProd.Text = "Quitar productos";
            this.btnQuitarProd.UseVisualStyleBackColor = false;
            this.btnQuitarProd.Click += new System.EventHandler(this.btnQuitarProd_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(645, 353);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 40);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(527, 353);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 40);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Notificador
            // 
            this.Notificador.ContainerControl = this;
            // 
            // txbIdOperacion
            // 
            this.txbIdOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdOperacion.Location = new System.Drawing.Point(513, 39);
            this.txbIdOperacion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.txbIdOperacion.Name = "txbIdOperacion";
            this.txbIdOperacion.ReadOnly = true;
            this.txbIdOperacion.Size = new System.Drawing.Size(101, 22);
            this.txbIdOperacion.TabIndex = 7;
            this.txbIdOperacion.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(510, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID Operación";
            this.label4.Visible = false;
            // 
            // txbIdTitular
            // 
            this.txbIdTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdTitular.Location = new System.Drawing.Point(514, 69);
            this.txbIdTitular.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.txbIdTitular.Name = "txbIdTitular";
            this.txbIdTitular.ReadOnly = true;
            this.txbIdTitular.Size = new System.Drawing.Size(47, 22);
            this.txbIdTitular.TabIndex = 32;
            this.txbIdTitular.Visible = false;
            this.txbIdTitular.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txbTitular
            // 
            this.txbTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTitular.Location = new System.Drawing.Point(567, 69);
            this.txbTitular.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.txbTitular.Name = "txbTitular";
            this.txbTitular.ReadOnly = true;
            this.txbTitular.Size = new System.Drawing.Size(122, 22);
            this.txbTitular.TabIndex = 33;
            this.txbTitular.Visible = false;
            this.txbTitular.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnCerrar
            // 
            this.btnCerrar.AutoEllipsis = true;
            this.btnCerrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(722, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(41, 32);
            this.btnCerrar.TabIndex = 34;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
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
            // preciocompra
            // 
            this.preciocompra.DataPropertyName = "preciocompra";
            this.preciocompra.HeaderText = "Precio de compra";
            this.preciocompra.Name = "preciocompra";
            this.preciocompra.ReadOnly = true;
            // 
            // precioventa
            // 
            this.precioventa.DataPropertyName = "precioventa";
            this.precioventa.HeaderText = "Precio de venta";
            this.precioventa.Name = "precioventa";
            this.precioventa.ReadOnly = true;
            // 
            // EdicionCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(765, 434);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txbIdTitular);
            this.Controls.Add(this.txbTitular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbIdOperacion);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EdicionCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edició de compra";
            this.Load += new System.EventHandler(this.EdicionCompra_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatosProducto)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Label lblIdTitular;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        public System.Windows.Forms.TextBox txbIdProveedor;
        public System.Windows.Forms.TextBox txbProveedor;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dtgvDatosProducto;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnQuitarProd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button btnAgregarProd;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txbCantidad;
        public System.Windows.Forms.TextBox txbPrecioCompra;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        public System.Windows.Forms.TextBox txbIdProducto;
        public System.Windows.Forms.TextBox txbProducto;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider Notificador;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txbIdOperacion;
        public System.Windows.Forms.TextBox txbIdTitular;
        public System.Windows.Forms.TextBox txbTitular;
        private System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txbPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idconsumible;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumible;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciocompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioventa;
    }
}
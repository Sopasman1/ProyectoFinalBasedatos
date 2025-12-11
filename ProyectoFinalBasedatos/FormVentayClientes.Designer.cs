namespace ProyectoFinalBasedatos
{
    partial class FormVentayClientes
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvClientes = new DataGridView();
            panel1 = new Panel();
            Pais = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnEliminarCliente = new Button();
            btnActualizarCliente = new Button();
            btnEditarCliente = new Button();
            btnAgregarCliente = new Button();
            cmbPaisCliente = new ComboBox();
            txtTelefonoCliente = new TextBox();
            txtEmailCliente = new TextBox();
            txtApellidoCliente = new TextBox();
            txtNombreCliente = new TextBox();
            tabPage2 = new TabPage();
            dgvPedidos = new DataGridView();
            panel2 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btnEliminarPedido = new Button();
            btnActualizarPedido = new Button();
            btnEditarPedido = new Button();
            btnAgregarPedido = new Button();
            cmbEstadoPedido = new ComboBox();
            cmbClientePedido = new ComboBox();
            dtpFechaPedido = new DateTimePicker();
            txtTotalPedido = new TextBox();
            tabPage3 = new TabPage();
            dgvFactura = new DataGridView();
            panel3 = new Panel();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            btnEliminarFactura = new Button();
            btnActualizarFactura = new Button();
            btnEditarFactura = new Button();
            btnAgregarFactura = new Button();
            txtImpuestosFactura = new TextBox();
            txtTotalFactura = new TextBox();
            dtpFechaFactura = new DateTimePicker();
            cmbPedidoFactura = new ComboBox();
            tabPage4 = new TabPage();
            dgvPagos = new DataGridView();
            dtp = new Panel();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            btnLimpiarPago = new Button();
            btnEliminarPago = new Button();
            btnAgregarPago = new Button();
            dtpFecha = new DateTimePicker();
            txtMonto = new TextBox();
            cmbMetodoPago = new ComboBox();
            cmbPedido = new ComboBox();
            tabPage5 = new TabPage();
            dgvEnvios = new DataGridView();
            panel4 = new Panel();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            btnEliminarEnvio = new Button();
            btnActualizarEnvio = new Button();
            btnEditarEnvio = new Button();
            btnAgregarEnvio = new Button();
            txtEstadoEnvio = new TextBox();
            dtpFechaEnvio = new DateTimePicker();
            cmbTransportistaEnvio = new ComboBox();
            cmbPedidoEnvio = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            panel2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).BeginInit();
            panel3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPagos).BeginInit();
            dtp.SuspendLayout();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnvios).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvClientes);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cliente";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(209, 0);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(580, 419);
            dgvClientes.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(Pais);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnEliminarCliente);
            panel1.Controls.Add(btnActualizarCliente);
            panel1.Controls.Add(btnEditarCliente);
            panel1.Controls.Add(btnAgregarCliente);
            panel1.Controls.Add(cmbPaisCliente);
            panel1.Controls.Add(txtTelefonoCliente);
            panel1.Controls.Add(txtEmailCliente);
            panel1.Controls.Add(txtApellidoCliente);
            panel1.Controls.Add(txtNombreCliente);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 416);
            panel1.TabIndex = 0;
            // 
            // Pais
            // 
            Pais.AutoSize = true;
            Pais.Location = new Point(5, 255);
            Pais.Name = "Pais";
            Pais.Size = new Size(65, 15);
            Pais.TabIndex = 13;
            Pais.Text = "PaisCliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 190);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 12;
            label4.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 127);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 11;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 67);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 10;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 9;
            label1.Text = "Nombre";
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Location = new Point(122, 371);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(75, 23);
            btnEliminarCliente.TabIndex = 8;
            btnEliminarCliente.Text = "Eliminar";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // btnActualizarCliente
            // 
            btnActualizarCliente.Location = new Point(5, 371);
            btnActualizarCliente.Name = "btnActualizarCliente";
            btnActualizarCliente.Size = new Size(75, 23);
            btnActualizarCliente.TabIndex = 7;
            btnActualizarCliente.Text = "Actualizar";
            btnActualizarCliente.UseVisualStyleBackColor = true;
            btnActualizarCliente.Click += btnActualizarCliente_Click;
            // 
            // btnEditarCliente
            // 
            btnEditarCliente.Location = new Point(122, 317);
            btnEditarCliente.Name = "btnEditarCliente";
            btnEditarCliente.Size = new Size(75, 23);
            btnEditarCliente.TabIndex = 6;
            btnEditarCliente.Text = "Editar";
            btnEditarCliente.UseVisualStyleBackColor = true;
            btnEditarCliente.Click += btnEditarCliente_Click;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.Location = new Point(5, 317);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(75, 23);
            btnAgregarCliente.TabIndex = 5;
            btnAgregarCliente.Text = "Agregar";
            btnAgregarCliente.UseVisualStyleBackColor = true;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // cmbPaisCliente
            // 
            cmbPaisCliente.FormattingEnabled = true;
            cmbPaisCliente.Location = new Point(5, 273);
            cmbPaisCliente.Name = "cmbPaisCliente";
            cmbPaisCliente.Size = new Size(121, 23);
            cmbPaisCliente.TabIndex = 4;
            // 
            // txtTelefonoCliente
            // 
            txtTelefonoCliente.Location = new Point(5, 208);
            txtTelefonoCliente.Name = "txtTelefonoCliente";
            txtTelefonoCliente.Size = new Size(192, 23);
            txtTelefonoCliente.TabIndex = 3;
            // 
            // txtEmailCliente
            // 
            txtEmailCliente.Location = new Point(5, 145);
            txtEmailCliente.Name = "txtEmailCliente";
            txtEmailCliente.Size = new Size(192, 23);
            txtEmailCliente.TabIndex = 2;
            // 
            // txtApellidoCliente
            // 
            txtApellidoCliente.Location = new Point(5, 85);
            txtApellidoCliente.Name = "txtApellidoCliente";
            txtApellidoCliente.Size = new Size(192, 23);
            txtApellidoCliente.TabIndex = 1;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(5, 27);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(192, 23);
            txtNombreCliente.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvPedidos);
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pedidos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvPedidos
            // 
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(209, 0);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.Size = new Size(580, 419);
            dgvPedidos.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnEliminarPedido);
            panel2.Controls.Add(btnActualizarPedido);
            panel2.Controls.Add(btnEditarPedido);
            panel2.Controls.Add(btnAgregarPedido);
            panel2.Controls.Add(cmbEstadoPedido);
            panel2.Controls.Add(cmbClientePedido);
            panel2.Controls.Add(dtpFechaPedido);
            panel2.Controls.Add(txtTotalPedido);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 416);
            panel2.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 193);
            label8.Name = "label8";
            label8.Size = new Size(82, 15);
            label8.TabIndex = 11;
            label8.Text = "Estado Pedido";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 137);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 10;
            label7.Text = "Pedido Cliente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 79);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 9;
            label6.Text = "Fecha Pedido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 16);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 8;
            label5.Text = "Total Pedido";
            // 
            // btnEliminarPedido
            // 
            btnEliminarPedido.Location = new Point(3, 352);
            btnEliminarPedido.Name = "btnEliminarPedido";
            btnEliminarPedido.Size = new Size(79, 25);
            btnEliminarPedido.TabIndex = 7;
            btnEliminarPedido.Text = "Eliminar";
            btnEliminarPedido.UseVisualStyleBackColor = true;
            btnEliminarPedido.Click += btnEliminarPedido_Click;
            // 
            // btnActualizarPedido
            // 
            btnActualizarPedido.Location = new Point(3, 321);
            btnActualizarPedido.Name = "btnActualizarPedido";
            btnActualizarPedido.Size = new Size(79, 25);
            btnActualizarPedido.TabIndex = 6;
            btnActualizarPedido.Text = "Actualizar";
            btnActualizarPedido.UseVisualStyleBackColor = true;
            btnActualizarPedido.Click += btnActualizarPedido_Click;
            // 
            // btnEditarPedido
            // 
            btnEditarPedido.Location = new Point(3, 290);
            btnEditarPedido.Name = "btnEditarPedido";
            btnEditarPedido.Size = new Size(79, 25);
            btnEditarPedido.TabIndex = 5;
            btnEditarPedido.Text = "Editar";
            btnEditarPedido.UseVisualStyleBackColor = true;
            btnEditarPedido.Click += btnEditarPedido_Click;
            // 
            // btnAgregarPedido
            // 
            btnAgregarPedido.Location = new Point(5, 259);
            btnAgregarPedido.Name = "btnAgregarPedido";
            btnAgregarPedido.Size = new Size(79, 25);
            btnAgregarPedido.TabIndex = 4;
            btnAgregarPedido.Text = "Agregar";
            btnAgregarPedido.UseVisualStyleBackColor = true;
            btnAgregarPedido.Click += btnAgregarPedido_Click;
            // 
            // cmbEstadoPedido
            // 
            cmbEstadoPedido.FormattingEnabled = true;
            cmbEstadoPedido.Location = new Point(5, 211);
            cmbEstadoPedido.Name = "cmbEstadoPedido";
            cmbEstadoPedido.Size = new Size(121, 23);
            cmbEstadoPedido.TabIndex = 3;
            // 
            // cmbClientePedido
            // 
            cmbClientePedido.FormattingEnabled = true;
            cmbClientePedido.Location = new Point(5, 155);
            cmbClientePedido.Name = "cmbClientePedido";
            cmbClientePedido.Size = new Size(121, 23);
            cmbClientePedido.TabIndex = 2;
            // 
            // dtpFechaPedido
            // 
            dtpFechaPedido.Location = new Point(3, 97);
            dtpFechaPedido.Name = "dtpFechaPedido";
            dtpFechaPedido.Size = new Size(192, 23);
            dtpFechaPedido.TabIndex = 1;
            // 
            // txtTotalPedido
            // 
            txtTotalPedido.Location = new Point(5, 34);
            txtTotalPedido.Name = "txtTotalPedido";
            txtTotalPedido.Size = new Size(100, 23);
            txtTotalPedido.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvFactura);
            tabPage3.Controls.Add(panel3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(792, 422);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Facturas";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvFactura
            // 
            dgvFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFactura.Location = new Point(209, 3);
            dgvFactura.Name = "dgvFactura";
            dgvFactura.Size = new Size(580, 416);
            dgvFactura.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(btnEliminarFactura);
            panel3.Controls.Add(btnActualizarFactura);
            panel3.Controls.Add(btnEditarFactura);
            panel3.Controls.Add(btnAgregarFactura);
            panel3.Controls.Add(txtImpuestosFactura);
            panel3.Controls.Add(txtTotalFactura);
            panel3.Controls.Add(dtpFechaFactura);
            panel3.Controls.Add(cmbPedidoFactura);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 416);
            panel3.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(4, 205);
            label12.Name = "label12";
            label12.Size = new Size(99, 15);
            label12.TabIndex = 11;
            label12.Text = "Impuesto Factura";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(4, 146);
            label11.Name = "label11";
            label11.Size = new Size(75, 15);
            label11.TabIndex = 10;
            label11.Text = "Total Factura";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(4, 80);
            label10.Name = "label10";
            label10.Size = new Size(80, 15);
            label10.TabIndex = 9;
            label10.Text = "Fecha Factura";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(4, 17);
            label9.Name = "label9";
            label9.Size = new Size(102, 15);
            label9.TabIndex = 8;
            label9.Text = "Factura de Pedido";
            // 
            // btnEliminarFactura
            // 
            btnEliminarFactura.Location = new Point(104, 322);
            btnEliminarFactura.Name = "btnEliminarFactura";
            btnEliminarFactura.Size = new Size(93, 24);
            btnEliminarFactura.TabIndex = 7;
            btnEliminarFactura.Text = "Eliminar";
            btnEliminarFactura.UseVisualStyleBackColor = true;
            btnEliminarFactura.Click += btnEliminarFactura_Click;
            // 
            // btnActualizarFactura
            // 
            btnActualizarFactura.Location = new Point(4, 322);
            btnActualizarFactura.Name = "btnActualizarFactura";
            btnActualizarFactura.Size = new Size(93, 24);
            btnActualizarFactura.TabIndex = 6;
            btnActualizarFactura.Text = "Actualizar";
            btnActualizarFactura.UseVisualStyleBackColor = true;
            btnActualizarFactura.Click += btnActualizarFactura_Click;
            // 
            // btnEditarFactura
            // 
            btnEditarFactura.Location = new Point(104, 278);
            btnEditarFactura.Name = "btnEditarFactura";
            btnEditarFactura.Size = new Size(93, 24);
            btnEditarFactura.TabIndex = 5;
            btnEditarFactura.Text = "Editar";
            btnEditarFactura.UseVisualStyleBackColor = true;
            btnEditarFactura.Click += btnEditarFactura_Click;
            // 
            // btnAgregarFactura
            // 
            btnAgregarFactura.Location = new Point(4, 278);
            btnAgregarFactura.Name = "btnAgregarFactura";
            btnAgregarFactura.Size = new Size(93, 24);
            btnAgregarFactura.TabIndex = 4;
            btnAgregarFactura.Text = "Agregar";
            btnAgregarFactura.UseVisualStyleBackColor = true;
            btnAgregarFactura.Click += btnAgregarFactura_Click;
            // 
            // txtImpuestosFactura
            // 
            txtImpuestosFactura.Location = new Point(4, 223);
            txtImpuestosFactura.Name = "txtImpuestosFactura";
            txtImpuestosFactura.Size = new Size(193, 23);
            txtImpuestosFactura.TabIndex = 3;
            // 
            // txtTotalFactura
            // 
            txtTotalFactura.Location = new Point(4, 164);
            txtTotalFactura.Name = "txtTotalFactura";
            txtTotalFactura.Size = new Size(193, 23);
            txtTotalFactura.TabIndex = 2;
            // 
            // dtpFechaFactura
            // 
            dtpFechaFactura.Location = new Point(4, 98);
            dtpFechaFactura.Name = "dtpFechaFactura";
            dtpFechaFactura.Size = new Size(193, 23);
            dtpFechaFactura.TabIndex = 1;
            // 
            // cmbPedidoFactura
            // 
            cmbPedidoFactura.FormattingEnabled = true;
            cmbPedidoFactura.Location = new Point(4, 35);
            cmbPedidoFactura.Name = "cmbPedidoFactura";
            cmbPedidoFactura.Size = new Size(193, 23);
            cmbPedidoFactura.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dgvPagos);
            tabPage4.Controls.Add(dtp);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(792, 422);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Pagos";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvPagos
            // 
            dgvPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPagos.Location = new Point(209, 3);
            dgvPagos.Name = "dgvPagos";
            dgvPagos.Size = new Size(580, 416);
            dgvPagos.TabIndex = 1;
            // 
            // dtp
            // 
            dtp.Controls.Add(label16);
            dtp.Controls.Add(label15);
            dtp.Controls.Add(label14);
            dtp.Controls.Add(label13);
            dtp.Controls.Add(btnLimpiarPago);
            dtp.Controls.Add(btnEliminarPago);
            dtp.Controls.Add(btnAgregarPago);
            dtp.Controls.Add(dtpFecha);
            dtp.Controls.Add(txtMonto);
            dtp.Controls.Add(cmbMetodoPago);
            dtp.Controls.Add(cmbPedido);
            dtp.Location = new Point(3, 3);
            dtp.Name = "dtp";
            dtp.Size = new Size(200, 416);
            dtp.TabIndex = 0;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(5, 186);
            label16.Name = "label16";
            label16.Size = new Size(84, 15);
            label16.TabIndex = 10;
            label16.Text = "Fecha de pago";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(5, 128);
            label15.Name = "label15";
            label15.Size = new Size(43, 15);
            label15.TabIndex = 9;
            label15.Text = "Monto";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(5, 69);
            label14.Name = "label14";
            label14.Size = new Size(95, 15);
            label14.TabIndex = 8;
            label14.Text = "Metodo de Pago";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(5, 15);
            label13.Name = "label13";
            label13.Size = new Size(44, 15);
            label13.TabIndex = 7;
            label13.Text = "Pedido";
            // 
            // btnLimpiarPago
            // 
            btnLimpiarPago.Location = new Point(5, 306);
            btnLimpiarPago.Name = "btnLimpiarPago";
            btnLimpiarPago.Size = new Size(75, 23);
            btnLimpiarPago.TabIndex = 6;
            btnLimpiarPago.Text = "Limpiar";
            btnLimpiarPago.UseVisualStyleBackColor = true;
            btnLimpiarPago.Click += btnLimpiarPago_Click;
            // 
            // btnEliminarPago
            // 
            btnEliminarPago.Location = new Point(5, 277);
            btnEliminarPago.Name = "btnEliminarPago";
            btnEliminarPago.Size = new Size(75, 23);
            btnEliminarPago.TabIndex = 5;
            btnEliminarPago.Text = "Eliminar";
            btnEliminarPago.UseVisualStyleBackColor = true;
            btnEliminarPago.Click += btnEliminarPago_Click;
            // 
            // btnAgregarPago
            // 
            btnAgregarPago.Location = new Point(5, 248);
            btnAgregarPago.Name = "btnAgregarPago";
            btnAgregarPago.Size = new Size(75, 23);
            btnAgregarPago.TabIndex = 4;
            btnAgregarPago.Text = "Agregar";
            btnAgregarPago.UseVisualStyleBackColor = true;
            btnAgregarPago.Click += btnAgregarPago_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(3, 204);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(192, 23);
            dtpFecha.TabIndex = 3;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(5, 146);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(190, 23);
            txtMonto.TabIndex = 2;
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.FormattingEnabled = true;
            cmbMetodoPago.Location = new Point(3, 87);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(194, 23);
            cmbMetodoPago.TabIndex = 1;
            // 
            // cmbPedido
            // 
            cmbPedido.FormattingEnabled = true;
            cmbPedido.Location = new Point(3, 33);
            cmbPedido.Name = "cmbPedido";
            cmbPedido.Size = new Size(194, 23);
            cmbPedido.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(dgvEnvios);
            tabPage5.Controls.Add(panel4);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(792, 422);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Envios";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // dgvEnvios
            // 
            dgvEnvios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnvios.Location = new Point(209, 3);
            dgvEnvios.Name = "dgvEnvios";
            dgvEnvios.Size = new Size(580, 419);
            dgvEnvios.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(label20);
            panel4.Controls.Add(label19);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(btnEliminarEnvio);
            panel4.Controls.Add(btnActualizarEnvio);
            panel4.Controls.Add(btnEditarEnvio);
            panel4.Controls.Add(btnAgregarEnvio);
            panel4.Controls.Add(txtEstadoEnvio);
            panel4.Controls.Add(dtpFechaEnvio);
            panel4.Controls.Add(cmbTransportistaEnvio);
            panel4.Controls.Add(cmbPedidoEnvio);
            panel4.Location = new Point(3, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 422);
            panel4.TabIndex = 0;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(5, 197);
            label20.Name = "label20";
            label20.Size = new Size(90, 15);
            label20.TabIndex = 11;
            label20.Text = "Estado de Envio";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(5, 134);
            label19.Name = "label19";
            label19.Size = new Size(70, 15);
            label19.TabIndex = 10;
            label19.Text = "Fecha Envio";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(5, 81);
            label18.Name = "label18";
            label18.Size = new Size(73, 15);
            label18.TabIndex = 9;
            label18.Text = "PedidoEnvio";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(5, 25);
            label17.Name = "label17";
            label17.Size = new Size(44, 15);
            label17.TabIndex = 8;
            label17.Text = "Pedido";
            // 
            // btnEliminarEnvio
            // 
            btnEliminarEnvio.Location = new Point(5, 356);
            btnEliminarEnvio.Name = "btnEliminarEnvio";
            btnEliminarEnvio.Size = new Size(75, 23);
            btnEliminarEnvio.TabIndex = 7;
            btnEliminarEnvio.Text = "Eliminar";
            btnEliminarEnvio.UseVisualStyleBackColor = true;
            btnEliminarEnvio.Click += btnEliminarEnvio_Click;
            // 
            // btnActualizarEnvio
            // 
            btnActualizarEnvio.Location = new Point(5, 327);
            btnActualizarEnvio.Name = "btnActualizarEnvio";
            btnActualizarEnvio.Size = new Size(75, 23);
            btnActualizarEnvio.TabIndex = 6;
            btnActualizarEnvio.Text = "Actualizar";
            btnActualizarEnvio.UseVisualStyleBackColor = true;
            btnActualizarEnvio.Click += btnActualizarEnvio_Click;
            // 
            // btnEditarEnvio
            // 
            btnEditarEnvio.Location = new Point(5, 298);
            btnEditarEnvio.Name = "btnEditarEnvio";
            btnEditarEnvio.Size = new Size(75, 23);
            btnEditarEnvio.TabIndex = 5;
            btnEditarEnvio.Text = "Editar";
            btnEditarEnvio.UseVisualStyleBackColor = true;
            btnEditarEnvio.Click += btnEditarEnvio_Click;
            // 
            // btnAgregarEnvio
            // 
            btnAgregarEnvio.Location = new Point(5, 269);
            btnAgregarEnvio.Name = "btnAgregarEnvio";
            btnAgregarEnvio.Size = new Size(75, 23);
            btnAgregarEnvio.TabIndex = 4;
            btnAgregarEnvio.Text = "Agregar";
            btnAgregarEnvio.UseVisualStyleBackColor = true;
            btnAgregarEnvio.Click += btnAgregarEnvio_Click;
            // 
            // txtEstadoEnvio
            // 
            txtEstadoEnvio.Location = new Point(5, 215);
            txtEstadoEnvio.Name = "txtEstadoEnvio";
            txtEstadoEnvio.Size = new Size(192, 23);
            txtEstadoEnvio.TabIndex = 3;
            // 
            // dtpFechaEnvio
            // 
            dtpFechaEnvio.Location = new Point(5, 152);
            dtpFechaEnvio.Name = "dtpFechaEnvio";
            dtpFechaEnvio.Size = new Size(192, 23);
            dtpFechaEnvio.TabIndex = 2;
            // 
            // cmbTransportistaEnvio
            // 
            cmbTransportistaEnvio.FormattingEnabled = true;
            cmbTransportistaEnvio.Location = new Point(5, 99);
            cmbTransportistaEnvio.Name = "cmbTransportistaEnvio";
            cmbTransportistaEnvio.Size = new Size(192, 23);
            cmbTransportistaEnvio.TabIndex = 1;
            // 
            // cmbPedidoEnvio
            // 
            cmbPedidoEnvio.FormattingEnabled = true;
            cmbPedidoEnvio.Location = new Point(5, 43);
            cmbPedidoEnvio.Name = "cmbPedidoEnvio";
            cmbPedidoEnvio.Size = new Size(192, 23);
            cmbPedidoEnvio.TabIndex = 0;
            // 
            // FormVentayClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVentayClientes";
            Text = "FormVentayClientes";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFactura).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPagos).EndInit();
            dtp.ResumeLayout(false);
            dtp.PerformLayout();
            tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEnvios).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvClientes;
        private Panel panel1;
        private ComboBox cmbPaisCliente;
        private TextBox txtTelefonoCliente;
        private TextBox txtEmailCliente;
        private TextBox txtApellidoCliente;
        private TextBox txtNombreCliente;
        private Label Pais;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnEliminarCliente;
        private Button btnActualizarCliente;
        private Button btnEditarCliente;
        private Button btnAgregarCliente;
        private DataGridView dgvPedidos;
        private Panel panel2;
        private ComboBox cmbClientePedido;
        private ComboBox cmbEstadoPedido;
        private DateTimePicker dtpFechaPedido;
        private TextBox txtTotalPedido;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button btnEliminarPedido;
        private Button btnActualizarPedido;
        private Button btnEditarPedido;
        private Button btnAgregarPedido;
        private TabPage tabPage3;
        private DataGridView dgvFactura;
        private Panel panel3;
        private TextBox txtTotalFactura;
        private DateTimePicker dtpFechaFactura;
        private ComboBox cmbPedidoFactura;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button btnEliminarFactura;
        private Button btnActualizarFactura;
        private Button btnEditarFactura;
        private Button btnAgregarFactura;
        private TextBox txtImpuestosFactura;
        private DataGridView dgvPagos;
        private Panel dtp;
        private Label label13;
        private Button btnLimpiarPago;
        private Button btnEliminarPago;
        private Button btnAgregarPago;
        private DateTimePicker dtpFecha;
        private TextBox txtMonto;
        private ComboBox cmbMetodoPago;
        private ComboBox cmbPedido;
        private Label label16;
        private Label label15;
        private Label label14;
        private DataGridView dgvEnvios;
        private Panel panel4;
        private Label label18;
        private Label label17;
        private Button btnEliminarEnvio;
        private Button btnActualizarEnvio;
        private Button btnEditarEnvio;
        private Button btnAgregarEnvio;
        private TextBox txtEstadoEnvio;
        private DateTimePicker dtpFechaEnvio;
        private ComboBox cmbTransportistaEnvio;
        private ComboBox cmbPedidoEnvio;
        private Label label20;
        private Label label19;
    }
}
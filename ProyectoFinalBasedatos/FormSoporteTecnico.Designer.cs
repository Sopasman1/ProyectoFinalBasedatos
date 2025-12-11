namespace ProyectoFinalBasedatos
{
    partial class FormSoporteTecnico
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
            dgvTicketsSoporte = new DataGridView();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnEliminarTicket = new Button();
            btnActualizarTicket = new Button();
            btnEditarTicket = new Button();
            btnAgregarTicket = new Button();
            txtComentario = new TextBox();
            dtpFecha = new DateTimePicker();
            cmbEmpleado = new ComboBox();
            tabPage2 = new TabPage();
            dgvEquipos = new DataGridView();
            panel2 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btnEliminarEquipo = new Button();
            btnActualizarEquipo = new Button();
            btnEditarEquipo = new Button();
            btnAgregarEquipo = new Button();
            dtpFechaCompra = new DateTimePicker();
            cmbEstadoEquipo = new ComboBox();
            txtTipoEquipo = new TextBox();
            txtNombreEquipo = new TextBox();
            Mantenimiento = new TabPage();
            dgvMantenimientos = new DataGridView();
            panel3 = new Panel();
            cmbEqupo2 = new ComboBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            btnEliminarMantenimiento = new Button();
            btnActualizarMantenimiento = new Button();
            btnEditarMantenimiento = new Button();
            btnAgregarMantenimiento = new Button();
            txtCosto = new TextBox();
            txtDescripcion = new TextBox();
            dtpFecha1 = new DateTimePicker();
            tabPage3 = new TabPage();
            dgvContratos = new DataGridView();
            panel4 = new Panel();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            btnEliminarContrato = new Button();
            btnActualizarContrato = new Button();
            btnEditarContrato = new Button();
            btnAgregarContrato = new Button();
            txtMonto = new TextBox();
            dtpFechaFin = new DateTimePicker();
            dtpFechaInicio = new DateTimePicker();
            cmbProveedorserv = new ComboBox();
            cmbEquipo2 = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTicketsSoporte).BeginInit();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).BeginInit();
            panel2.SuspendLayout();
            Mantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMantenimientos).BeginInit();
            panel3.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContratos).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(Mantenimiento);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvTicketsSoporte);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tickets";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvTicketsSoporte
            // 
            dgvTicketsSoporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTicketsSoporte.Location = new Point(209, 3);
            dgvTicketsSoporte.Name = "dgvTicketsSoporte";
            dgvTicketsSoporte.Size = new Size(580, 416);
            dgvTicketsSoporte.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnEliminarTicket);
            panel1.Controls.Add(btnActualizarTicket);
            panel1.Controls.Add(btnEditarTicket);
            panel1.Controls.Add(btnAgregarTicket);
            panel1.Controls.Add(txtComentario);
            panel1.Controls.Add(dtpFecha);
            panel1.Controls.Add(cmbEmpleado);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 416);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 199);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 11;
            label4.Text = "Comentario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 113);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 10;
            label3.Text = "Fecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 23);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 9;
            label2.Text = "Empleado";
            // 
            // btnEliminarTicket
            // 
            btnEliminarTicket.Location = new Point(122, 321);
            btnEliminarTicket.Name = "btnEliminarTicket";
            btnEliminarTicket.Size = new Size(75, 23);
            btnEliminarTicket.TabIndex = 7;
            btnEliminarTicket.Text = "Eliminar";
            btnEliminarTicket.UseVisualStyleBackColor = true;
            btnEliminarTicket.Click += btnEliminarTicket_Click;
            // 
            // btnActualizarTicket
            // 
            btnActualizarTicket.Location = new Point(5, 321);
            btnActualizarTicket.Name = "btnActualizarTicket";
            btnActualizarTicket.Size = new Size(75, 23);
            btnActualizarTicket.TabIndex = 6;
            btnActualizarTicket.Text = "Actualizar";
            btnActualizarTicket.UseVisualStyleBackColor = true;
            btnActualizarTicket.Click += btnActualizarTicket_Click;
            // 
            // btnEditarTicket
            // 
            btnEditarTicket.Location = new Point(122, 269);
            btnEditarTicket.Name = "btnEditarTicket";
            btnEditarTicket.Size = new Size(75, 23);
            btnEditarTicket.TabIndex = 5;
            btnEditarTicket.Text = "Editar";
            btnEditarTicket.UseVisualStyleBackColor = true;
            btnEditarTicket.Click += btnEditarTicket_Click;
            // 
            // btnAgregarTicket
            // 
            btnAgregarTicket.Location = new Point(5, 269);
            btnAgregarTicket.Name = "btnAgregarTicket";
            btnAgregarTicket.Size = new Size(75, 23);
            btnAgregarTicket.TabIndex = 4;
            btnAgregarTicket.Text = "Agregar";
            btnAgregarTicket.UseVisualStyleBackColor = true;
            btnAgregarTicket.Click += btnAgregarTicket_Click;
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(5, 217);
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(192, 23);
            txtComentario.TabIndex = 3;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(5, 131);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(192, 23);
            dtpFecha.TabIndex = 2;
            // 
            // cmbEmpleado
            // 
            cmbEmpleado.FormattingEnabled = true;
            cmbEmpleado.Location = new Point(5, 50);
            cmbEmpleado.Name = "cmbEmpleado";
            cmbEmpleado.Size = new Size(192, 23);
            cmbEmpleado.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvEquipos);
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Equipo";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvEquipos
            // 
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipos.Location = new Point(207, 3);
            dgvEquipos.Name = "dgvEquipos";
            dgvEquipos.Size = new Size(582, 416);
            dgvEquipos.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnEliminarEquipo);
            panel2.Controls.Add(btnActualizarEquipo);
            panel2.Controls.Add(btnEditarEquipo);
            panel2.Controls.Add(btnAgregarEquipo);
            panel2.Controls.Add(dtpFechaCompra);
            panel2.Controls.Add(cmbEstadoEquipo);
            panel2.Controls.Add(txtTipoEquipo);
            panel2.Controls.Add(txtNombreEquipo);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(198, 416);
            panel2.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 213);
            label8.Name = "label8";
            label8.Size = new Size(100, 15);
            label8.TabIndex = 11;
            label8.Text = "Fecha de Compra";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 151);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 10;
            label7.Text = "Estado Equipo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 90);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 9;
            label6.Text = "Tipo Equipo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 24);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 8;
            label5.Text = "Nombre Equipo";
            // 
            // btnEliminarEquipo
            // 
            btnEliminarEquipo.Location = new Point(116, 340);
            btnEliminarEquipo.Name = "btnEliminarEquipo";
            btnEliminarEquipo.Size = new Size(75, 23);
            btnEliminarEquipo.TabIndex = 7;
            btnEliminarEquipo.Text = "Eliminar";
            btnEliminarEquipo.UseVisualStyleBackColor = true;
            btnEliminarEquipo.Click += btnEliminarEquipo_Click;
            // 
            // btnActualizarEquipo
            // 
            btnActualizarEquipo.Location = new Point(5, 340);
            btnActualizarEquipo.Name = "btnActualizarEquipo";
            btnActualizarEquipo.Size = new Size(75, 23);
            btnActualizarEquipo.TabIndex = 6;
            btnActualizarEquipo.Text = "Actualizar";
            btnActualizarEquipo.UseVisualStyleBackColor = true;
            btnActualizarEquipo.Click += btnActualizarEquipo_Click;
            // 
            // btnEditarEquipo
            // 
            btnEditarEquipo.Location = new Point(118, 276);
            btnEditarEquipo.Name = "btnEditarEquipo";
            btnEditarEquipo.Size = new Size(75, 23);
            btnEditarEquipo.TabIndex = 5;
            btnEditarEquipo.Text = "Editar";
            btnEditarEquipo.UseVisualStyleBackColor = true;
            btnEditarEquipo.Click += btnEditarEquipo_Click;
            // 
            // btnAgregarEquipo
            // 
            btnAgregarEquipo.Location = new Point(5, 276);
            btnAgregarEquipo.Name = "btnAgregarEquipo";
            btnAgregarEquipo.Size = new Size(75, 23);
            btnAgregarEquipo.TabIndex = 4;
            btnAgregarEquipo.Text = "Agregar";
            btnAgregarEquipo.UseVisualStyleBackColor = true;
            btnAgregarEquipo.Click += btnAgregarEquipo_Click;
            // 
            // dtpFechaCompra
            // 
            dtpFechaCompra.Location = new Point(3, 231);
            dtpFechaCompra.Name = "dtpFechaCompra";
            dtpFechaCompra.Size = new Size(188, 23);
            dtpFechaCompra.TabIndex = 3;
            // 
            // cmbEstadoEquipo
            // 
            cmbEstadoEquipo.FormattingEnabled = true;
            cmbEstadoEquipo.Location = new Point(3, 169);
            cmbEstadoEquipo.Name = "cmbEstadoEquipo";
            cmbEstadoEquipo.Size = new Size(190, 23);
            cmbEstadoEquipo.TabIndex = 2;
            // 
            // txtTipoEquipo
            // 
            txtTipoEquipo.Location = new Point(3, 108);
            txtTipoEquipo.Name = "txtTipoEquipo";
            txtTipoEquipo.Size = new Size(190, 23);
            txtTipoEquipo.TabIndex = 1;
            // 
            // txtNombreEquipo
            // 
            txtNombreEquipo.Location = new Point(3, 42);
            txtNombreEquipo.Name = "txtNombreEquipo";
            txtNombreEquipo.Size = new Size(190, 23);
            txtNombreEquipo.TabIndex = 0;
            // 
            // Mantenimiento
            // 
            Mantenimiento.Controls.Add(dgvMantenimientos);
            Mantenimiento.Controls.Add(panel3);
            Mantenimiento.Location = new Point(4, 24);
            Mantenimiento.Name = "Mantenimiento";
            Mantenimiento.Size = new Size(792, 422);
            Mantenimiento.TabIndex = 2;
            Mantenimiento.Text = "Mantenimiento";
            Mantenimiento.UseVisualStyleBackColor = true;
            // 
            // dgvMantenimientos
            // 
            dgvMantenimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMantenimientos.Location = new Point(209, 3);
            dgvMantenimientos.Name = "dgvMantenimientos";
            dgvMantenimientos.Size = new Size(580, 416);
            dgvMantenimientos.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(cmbEqupo2);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(btnEliminarMantenimiento);
            panel3.Controls.Add(btnActualizarMantenimiento);
            panel3.Controls.Add(btnEditarMantenimiento);
            panel3.Controls.Add(btnAgregarMantenimiento);
            panel3.Controls.Add(txtCosto);
            panel3.Controls.Add(txtDescripcion);
            panel3.Controls.Add(dtpFecha1);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 416);
            panel3.TabIndex = 0;
            // 
            // cmbEqupo2
            // 
            cmbEqupo2.FormattingEnabled = true;
            cmbEqupo2.Location = new Point(5, 37);
            cmbEqupo2.Name = "cmbEqupo2";
            cmbEqupo2.Size = new Size(186, 23);
            cmbEqupo2.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(5, 230);
            label12.Name = "label12";
            label12.Size = new Size(38, 15);
            label12.TabIndex = 12;
            label12.Text = "Costo";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(5, 161);
            label11.Name = "label11";
            label11.Size = new Size(69, 15);
            label11.TabIndex = 11;
            label11.Text = "Descripcion";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(5, 90);
            label10.Name = "label10";
            label10.Size = new Size(38, 15);
            label10.TabIndex = 10;
            label10.Text = "Fecha";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 19);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 8;
            label9.Text = "Equipo";
            // 
            // btnEliminarMantenimiento
            // 
            btnEliminarMantenimiento.Location = new Point(116, 351);
            btnEliminarMantenimiento.Name = "btnEliminarMantenimiento";
            btnEliminarMantenimiento.Size = new Size(75, 23);
            btnEliminarMantenimiento.TabIndex = 7;
            btnEliminarMantenimiento.Text = "Eliminar";
            btnEliminarMantenimiento.UseVisualStyleBackColor = true;
            btnEliminarMantenimiento.Click += btnEliminarMantenimiento_Click;
            // 
            // btnActualizarMantenimiento
            // 
            btnActualizarMantenimiento.Location = new Point(5, 351);
            btnActualizarMantenimiento.Name = "btnActualizarMantenimiento";
            btnActualizarMantenimiento.Size = new Size(75, 23);
            btnActualizarMantenimiento.TabIndex = 6;
            btnActualizarMantenimiento.Text = "Actualizar";
            btnActualizarMantenimiento.UseVisualStyleBackColor = true;
            btnActualizarMantenimiento.Click += btnActualizarMantenimiento_Click;
            // 
            // btnEditarMantenimiento
            // 
            btnEditarMantenimiento.Location = new Point(116, 295);
            btnEditarMantenimiento.Name = "btnEditarMantenimiento";
            btnEditarMantenimiento.Size = new Size(75, 23);
            btnEditarMantenimiento.TabIndex = 5;
            btnEditarMantenimiento.Text = "Editar";
            btnEditarMantenimiento.UseVisualStyleBackColor = true;
            btnEditarMantenimiento.Click += btnEditarMantenimiento_Click;
            // 
            // btnAgregarMantenimiento
            // 
            btnAgregarMantenimiento.Location = new Point(5, 295);
            btnAgregarMantenimiento.Name = "btnAgregarMantenimiento";
            btnAgregarMantenimiento.Size = new Size(75, 23);
            btnAgregarMantenimiento.TabIndex = 4;
            btnAgregarMantenimiento.Text = "Agregar";
            btnAgregarMantenimiento.UseVisualStyleBackColor = true;
            btnAgregarMantenimiento.Click += btnAgregarMantenimiento_Click;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(3, 248);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(188, 23);
            txtCosto.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(3, 179);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(188, 23);
            txtDescripcion.TabIndex = 2;
            // 
            // dtpFecha1
            // 
            dtpFecha1.Location = new Point(3, 108);
            dtpFecha1.Name = "dtpFecha1";
            dtpFecha1.Size = new Size(190, 23);
            dtpFecha1.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvContratos);
            tabPage3.Controls.Add(panel4);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(792, 422);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "Contratos";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvContratos
            // 
            dgvContratos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContratos.Location = new Point(208, 6);
            dgvContratos.Name = "dgvContratos";
            dgvContratos.Size = new Size(581, 413);
            dgvContratos.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(btnEliminarContrato);
            panel4.Controls.Add(btnActualizarContrato);
            panel4.Controls.Add(btnEditarContrato);
            panel4.Controls.Add(btnAgregarContrato);
            panel4.Controls.Add(txtMonto);
            panel4.Controls.Add(dtpFechaFin);
            panel4.Controls.Add(dtpFechaInicio);
            panel4.Controls.Add(cmbProveedorserv);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(199, 416);
            panel4.TabIndex = 0;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(5, 210);
            label16.Name = "label16";
            label16.Size = new Size(43, 15);
            label16.TabIndex = 11;
            label16.Text = "Monto";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(5, 142);
            label15.Name = "label15";
            label15.Size = new Size(57, 15);
            label15.TabIndex = 10;
            label15.Text = "Fecha Fin";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(5, 84);
            label14.Name = "label14";
            label14.Size = new Size(70, 15);
            label14.TabIndex = 9;
            label14.Text = "Fecha Inicio";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(5, 26);
            label13.Name = "label13";
            label13.Size = new Size(124, 15);
            label13.TabIndex = 8;
            label13.Text = "Proveedor del Servicio";
            // 
            // btnEliminarContrato
            // 
            btnEliminarContrato.Location = new Point(121, 339);
            btnEliminarContrato.Name = "btnEliminarContrato";
            btnEliminarContrato.Size = new Size(75, 23);
            btnEliminarContrato.TabIndex = 7;
            btnEliminarContrato.Text = "Eliminar";
            btnEliminarContrato.UseVisualStyleBackColor = true;
            btnEliminarContrato.Click += btnEliminarContrato_Click;
            // 
            // btnActualizarContrato
            // 
            btnActualizarContrato.Location = new Point(5, 339);
            btnActualizarContrato.Name = "btnActualizarContrato";
            btnActualizarContrato.Size = new Size(75, 23);
            btnActualizarContrato.TabIndex = 6;
            btnActualizarContrato.Text = "Actualizar";
            btnActualizarContrato.UseVisualStyleBackColor = true;
            btnActualizarContrato.Click += btnActualizarContrato_Click;
            // 
            // btnEditarContrato
            // 
            btnEditarContrato.Location = new Point(121, 281);
            btnEditarContrato.Name = "btnEditarContrato";
            btnEditarContrato.Size = new Size(75, 23);
            btnEditarContrato.TabIndex = 5;
            btnEditarContrato.Text = "Editar";
            btnEditarContrato.UseVisualStyleBackColor = true;
            btnEditarContrato.Click += btnEditarContrato_Click;
            // 
            // btnAgregarContrato
            // 
            btnAgregarContrato.Location = new Point(5, 281);
            btnAgregarContrato.Name = "btnAgregarContrato";
            btnAgregarContrato.Size = new Size(75, 23);
            btnAgregarContrato.TabIndex = 4;
            btnAgregarContrato.Text = "Agregar";
            btnAgregarContrato.UseVisualStyleBackColor = true;
            btnAgregarContrato.Click += btnAgregarContrato_Click;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(5, 228);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(191, 23);
            txtMonto.TabIndex = 3;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Location = new Point(5, 160);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(191, 23);
            dtpFechaFin.TabIndex = 2;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(5, 102);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(191, 23);
            dtpFechaInicio.TabIndex = 1;
            // 
            // cmbProveedorserv
            // 
            cmbProveedorserv.FormattingEnabled = true;
            cmbProveedorserv.Location = new Point(5, 44);
            cmbProveedorserv.Name = "cmbProveedorserv";
            cmbProveedorserv.Size = new Size(191, 23);
            cmbProveedorserv.TabIndex = 0;
            // 
            // cmbEquipo2
            // 
            cmbEquipo2.Location = new Point(0, 0);
            cmbEquipo2.Name = "cmbEquipo2";
            cmbEquipo2.Size = new Size(121, 23);
            cmbEquipo2.TabIndex = 0;
            // 
            // FormSoporteTecnico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSoporteTecnico";
            Text = "FormSoporteTecnico";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTicketsSoporte).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            Mantenimiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMantenimientos).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvContratos).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvTicketsSoporte;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnEliminarTicket;
        private Button btnActualizarTicket;
        private Button btnEditarTicket;
        private Button btnAgregarTicket;
        private TextBox txtComentario;
        private DateTimePicker dtpFecha;
        private ComboBox cmbEmpleado;
        private DataGridView dgvEquipos;
        private Panel panel2;
        private Button btnEliminarEquipo;
        private Button btnActualizarEquipo;
        private Button btnEditarEquipo;
        private Button btnAgregarEquipo;
        private DateTimePicker dtpFechaCompra;
        private ComboBox cmbEstadoEquipo;
        private TextBox txtTipoEquipo;
        private TextBox txtNombreEquipo;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TabPage Mantenimiento;
        private DataGridView dgvMantenimientos;
        private Panel panel3;
        private TextBox cmbEquipo;
        private Button btnEliminarMantenimiento;
        private Button btnActualizarMantenimiento;
        private Button btnEditarMantenimiento;
        private Button btnAgregarMantenimiento;
        private TextBox txtCosto;
        private TextBox txtDescripcion;
        private DateTimePicker dtpFecha1;
        private Label label12;
        private Label label11;
        private Label label10;
        private ComboBox cmbEquipo2;
        private Label label9;
        private ComboBox cmbEqupo2;
        private TabPage tabPage3;
        private DataGridView dgvContratos;
        private Panel panel4;
        private Button btnEliminarContrato;
        private Button btnActualizarContrato;
        private Button btnEditarContrato;
        private Button btnAgregarContrato;
        private TextBox txtMonto;
        private DateTimePicker dtpFechaFin;
        private DateTimePicker dtpFechaInicio;
        private ComboBox cmbProveedorserv;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
    }
}
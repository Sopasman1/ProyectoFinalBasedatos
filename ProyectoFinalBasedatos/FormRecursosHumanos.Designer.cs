namespace ProyectoFinalBasedatos
{
    partial class FormRecursosHumanos
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
            dgvEmpleados = new DataGridView();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnEliminarEmpleado = new Button();
            btnActualizarEmpleado = new Button();
            btnEditarEmpleado = new Button();
            btnAgregarEmpleado = new Button();
            cmbAlmacenEmpleado = new ComboBox();
            cmbPuestoEmpleado = new ComboBox();
            txtTelefonoEmpleado = new TextBox();
            txtApellidoEmpleado = new TextBox();
            txtNombreEmpleado = new TextBox();
            tabPage2 = new TabPage();
            dgvPuestos = new DataGridView();
            panel2 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            btnEliminarPuesto = new Button();
            btnActualizarPuesto = new Button();
            btnEditarPuesto = new Button();
            btnAgregarPuesto = new Button();
            txtSalarioBasePuesto = new TextBox();
            txtDescripcionPuesto = new TextBox();
            txtNombrePuesto = new TextBox();
            tabPage3 = new TabPage();
            dgvTurnos = new DataGridView();
            panel3 = new Panel();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            btnEliminarTurno = new Button();
            btnActualizarTurno = new Button();
            btnEditarTurno = new Button();
            btnAgregarTurno = new Button();
            dtpHoraFin = new DateTimePicker();
            dtpHoraInicio = new DateTimePicker();
            txtNombreTurno = new TextBox();
            tabPage4 = new TabPage();
            dgvAsistencias = new DataGridView();
            panel4 = new Panel();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            btnEliminarAsistencia = new Button();
            btnActualizarAsistencia = new Button();
            btnEditarAsistencia = new Button();
            btnAgregarAsistencia = new Button();
            dtpHoraSalida = new DateTimePicker();
            dtpHoraEntrada = new DateTimePicker();
            dtpFecha = new DateTimePicker();
            cmbTurno = new ComboBox();
            cmbEmpleado = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPuestos).BeginInit();
            panel2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).BeginInit();
            panel3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAsistencias).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvEmpleados);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Empleados";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(209, 3);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.Size = new Size(580, 416);
            dgvEmpleados.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnEliminarEmpleado);
            panel1.Controls.Add(btnActualizarEmpleado);
            panel1.Controls.Add(btnEditarEmpleado);
            panel1.Controls.Add(btnAgregarEmpleado);
            panel1.Controls.Add(cmbAlmacenEmpleado);
            panel1.Controls.Add(cmbPuestoEmpleado);
            panel1.Controls.Add(txtTelefonoEmpleado);
            panel1.Controls.Add(txtApellidoEmpleado);
            panel1.Controls.Add(txtNombreEmpleado);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 416);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 253);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 13;
            label5.Text = "Almacen";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 197);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 12;
            label4.Text = "Puesto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 140);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 11;
            label3.Text = "Telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 79);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 10;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 19);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 9;
            label1.Text = "Nombre";
            // 
            // btnEliminarEmpleado
            // 
            btnEliminarEmpleado.Location = new Point(122, 367);
            btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            btnEliminarEmpleado.Size = new Size(75, 23);
            btnEliminarEmpleado.TabIndex = 8;
            btnEliminarEmpleado.Text = "Eliminar";
            btnEliminarEmpleado.UseVisualStyleBackColor = true;
            btnEliminarEmpleado.Click += btnEliminarEmpleado_Click;
            // 
            // btnActualizarEmpleado
            // 
            btnActualizarEmpleado.Location = new Point(5, 367);
            btnActualizarEmpleado.Name = "btnActualizarEmpleado";
            btnActualizarEmpleado.Size = new Size(75, 23);
            btnActualizarEmpleado.TabIndex = 7;
            btnActualizarEmpleado.Text = "Actualizar";
            btnActualizarEmpleado.UseVisualStyleBackColor = true;
            btnActualizarEmpleado.Click += btnActualizarEmpleado_Click;
            // 
            // btnEditarEmpleado
            // 
            btnEditarEmpleado.Location = new Point(122, 309);
            btnEditarEmpleado.Name = "btnEditarEmpleado";
            btnEditarEmpleado.Size = new Size(75, 23);
            btnEditarEmpleado.TabIndex = 6;
            btnEditarEmpleado.Text = "Editar";
            btnEditarEmpleado.UseVisualStyleBackColor = true;
            btnEditarEmpleado.Click += btnEditarEmpleado_Click;
            // 
            // btnAgregarEmpleado
            // 
            btnAgregarEmpleado.Location = new Point(5, 309);
            btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            btnAgregarEmpleado.Size = new Size(75, 23);
            btnAgregarEmpleado.TabIndex = 5;
            btnAgregarEmpleado.Text = "Agregar";
            btnAgregarEmpleado.UseVisualStyleBackColor = true;
            btnAgregarEmpleado.Click += btnAgregarEmpleado_Click;
            // 
            // cmbAlmacenEmpleado
            // 
            cmbAlmacenEmpleado.FormattingEnabled = true;
            cmbAlmacenEmpleado.Location = new Point(5, 271);
            cmbAlmacenEmpleado.Name = "cmbAlmacenEmpleado";
            cmbAlmacenEmpleado.Size = new Size(192, 23);
            cmbAlmacenEmpleado.TabIndex = 4;
            // 
            // cmbPuestoEmpleado
            // 
            cmbPuestoEmpleado.FormattingEnabled = true;
            cmbPuestoEmpleado.Location = new Point(5, 215);
            cmbPuestoEmpleado.Name = "cmbPuestoEmpleado";
            cmbPuestoEmpleado.Size = new Size(192, 23);
            cmbPuestoEmpleado.TabIndex = 3;
            // 
            // txtTelefonoEmpleado
            // 
            txtTelefonoEmpleado.Location = new Point(5, 158);
            txtTelefonoEmpleado.Name = "txtTelefonoEmpleado";
            txtTelefonoEmpleado.Size = new Size(192, 23);
            txtTelefonoEmpleado.TabIndex = 2;
            // 
            // txtApellidoEmpleado
            // 
            txtApellidoEmpleado.Location = new Point(5, 97);
            txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            txtApellidoEmpleado.Size = new Size(192, 23);
            txtApellidoEmpleado.TabIndex = 1;
            // 
            // txtNombreEmpleado
            // 
            txtNombreEmpleado.Location = new Point(5, 37);
            txtNombreEmpleado.Name = "txtNombreEmpleado";
            txtNombreEmpleado.Size = new Size(192, 23);
            txtNombreEmpleado.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvPuestos);
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Puestos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvPuestos
            // 
            dgvPuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPuestos.Location = new Point(212, 0);
            dgvPuestos.Name = "dgvPuestos";
            dgvPuestos.Size = new Size(577, 419);
            dgvPuestos.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btnEliminarPuesto);
            panel2.Controls.Add(btnActualizarPuesto);
            panel2.Controls.Add(btnEditarPuesto);
            panel2.Controls.Add(btnAgregarPuesto);
            panel2.Controls.Add(txtSalarioBasePuesto);
            panel2.Controls.Add(txtDescripcionPuesto);
            panel2.Controls.Add(txtNombrePuesto);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(203, 416);
            panel2.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 172);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 9;
            label8.Text = "Salario Base";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 79);
            label7.Name = "label7";
            label7.Size = new Size(127, 15);
            label7.TabIndex = 8;
            label7.Text = "Descripcion del Puesto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 13);
            label6.Name = "label6";
            label6.Size = new Size(109, 15);
            label6.TabIndex = 7;
            label6.Text = "Nombre del Puesto";
            // 
            // btnEliminarPuesto
            // 
            btnEliminarPuesto.Location = new Point(5, 370);
            btnEliminarPuesto.Name = "btnEliminarPuesto";
            btnEliminarPuesto.Size = new Size(75, 23);
            btnEliminarPuesto.TabIndex = 6;
            btnEliminarPuesto.Text = "Eliminar";
            btnEliminarPuesto.UseVisualStyleBackColor = true;
            btnEliminarPuesto.Click += btnEliminarPuesto_Click;
            // 
            // btnActualizarPuesto
            // 
            btnActualizarPuesto.Location = new Point(5, 323);
            btnActualizarPuesto.Name = "btnActualizarPuesto";
            btnActualizarPuesto.Size = new Size(75, 23);
            btnActualizarPuesto.TabIndex = 5;
            btnActualizarPuesto.Text = "Actualizar";
            btnActualizarPuesto.UseVisualStyleBackColor = true;
            btnActualizarPuesto.Click += btnActualizarPuesto_Click;
            // 
            // btnEditarPuesto
            // 
            btnEditarPuesto.Location = new Point(5, 276);
            btnEditarPuesto.Name = "btnEditarPuesto";
            btnEditarPuesto.Size = new Size(75, 23);
            btnEditarPuesto.TabIndex = 4;
            btnEditarPuesto.Text = "Editar";
            btnEditarPuesto.UseVisualStyleBackColor = true;
            btnEditarPuesto.Click += btnEditarPuesto_Click;
            // 
            // btnAgregarPuesto
            // 
            btnAgregarPuesto.Location = new Point(5, 235);
            btnAgregarPuesto.Name = "btnAgregarPuesto";
            btnAgregarPuesto.Size = new Size(75, 23);
            btnAgregarPuesto.TabIndex = 3;
            btnAgregarPuesto.Text = "Agregar";
            btnAgregarPuesto.UseVisualStyleBackColor = true;
            btnAgregarPuesto.Click += btnAgregarPuesto_Click;
            // 
            // txtSalarioBasePuesto
            // 
            txtSalarioBasePuesto.Location = new Point(5, 190);
            txtSalarioBasePuesto.Name = "txtSalarioBasePuesto";
            txtSalarioBasePuesto.Size = new Size(195, 23);
            txtSalarioBasePuesto.TabIndex = 2;
            // 
            // txtDescripcionPuesto
            // 
            txtDescripcionPuesto.Location = new Point(5, 97);
            txtDescripcionPuesto.Multiline = true;
            txtDescripcionPuesto.Name = "txtDescripcionPuesto";
            txtDescripcionPuesto.Size = new Size(195, 51);
            txtDescripcionPuesto.TabIndex = 1;
            // 
            // txtNombrePuesto
            // 
            txtNombrePuesto.Location = new Point(5, 31);
            txtNombrePuesto.Name = "txtNombrePuesto";
            txtNombrePuesto.Size = new Size(195, 23);
            txtNombrePuesto.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvTurnos);
            tabPage3.Controls.Add(panel3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(792, 422);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Turnos";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvTurnos
            // 
            dgvTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTurnos.Location = new Point(209, 3);
            dgvTurnos.Name = "dgvTurnos";
            dgvTurnos.Size = new Size(580, 416);
            dgvTurnos.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(btnEliminarTurno);
            panel3.Controls.Add(btnActualizarTurno);
            panel3.Controls.Add(btnEditarTurno);
            panel3.Controls.Add(btnAgregarTurno);
            panel3.Controls.Add(dtpHoraFin);
            panel3.Controls.Add(dtpHoraInicio);
            panel3.Controls.Add(txtNombreTurno);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 416);
            panel3.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(5, 147);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 9;
            label11.Text = "Hora Fin";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(5, 87);
            label10.Name = "label10";
            label10.Size = new Size(65, 15);
            label10.TabIndex = 8;
            label10.Text = "Hora inicio";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 21);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 7;
            label9.Text = "Turno";
            // 
            // btnEliminarTurno
            // 
            btnEliminarTurno.Location = new Point(5, 352);
            btnEliminarTurno.Name = "btnEliminarTurno";
            btnEliminarTurno.Size = new Size(75, 23);
            btnEliminarTurno.TabIndex = 6;
            btnEliminarTurno.Text = "Eliminar";
            btnEliminarTurno.UseVisualStyleBackColor = true;
            btnEliminarTurno.Click += btnEliminarTurno_Click;
            // 
            // btnActualizarTurno
            // 
            btnActualizarTurno.Location = new Point(5, 307);
            btnActualizarTurno.Name = "btnActualizarTurno";
            btnActualizarTurno.Size = new Size(75, 23);
            btnActualizarTurno.TabIndex = 5;
            btnActualizarTurno.Text = "Actualizar";
            btnActualizarTurno.UseVisualStyleBackColor = true;
            btnActualizarTurno.Click += btnActualizarTurno_Click;
            // 
            // btnEditarTurno
            // 
            btnEditarTurno.Location = new Point(5, 262);
            btnEditarTurno.Name = "btnEditarTurno";
            btnEditarTurno.Size = new Size(75, 23);
            btnEditarTurno.TabIndex = 4;
            btnEditarTurno.Text = "Editar";
            btnEditarTurno.UseVisualStyleBackColor = true;
            btnEditarTurno.Click += btnEditarTurno_Click;
            // 
            // btnAgregarTurno
            // 
            btnAgregarTurno.Location = new Point(5, 218);
            btnAgregarTurno.Name = "btnAgregarTurno";
            btnAgregarTurno.Size = new Size(75, 23);
            btnAgregarTurno.TabIndex = 3;
            btnAgregarTurno.Text = "Agregar";
            btnAgregarTurno.UseVisualStyleBackColor = true;
            btnAgregarTurno.Click += btnAgregarTurno_Click;
            // 
            // dtpHoraFin
            // 
            dtpHoraFin.Location = new Point(5, 165);
            dtpHoraFin.Name = "dtpHoraFin";
            dtpHoraFin.Size = new Size(192, 23);
            dtpHoraFin.TabIndex = 2;
            // 
            // dtpHoraInicio
            // 
            dtpHoraInicio.Location = new Point(3, 105);
            dtpHoraInicio.Name = "dtpHoraInicio";
            dtpHoraInicio.Size = new Size(192, 23);
            dtpHoraInicio.TabIndex = 1;
            // 
            // txtNombreTurno
            // 
            txtNombreTurno.Location = new Point(5, 39);
            txtNombreTurno.Name = "txtNombreTurno";
            txtNombreTurno.Size = new Size(192, 23);
            txtNombreTurno.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dgvAsistencias);
            tabPage4.Controls.Add(panel4);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(792, 422);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Asistencia";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvAsistencias
            // 
            dgvAsistencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsistencias.Location = new Point(209, 3);
            dgvAsistencias.Name = "dgvAsistencias";
            dgvAsistencias.Size = new Size(580, 416);
            dgvAsistencias.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(btnEliminarAsistencia);
            panel4.Controls.Add(btnActualizarAsistencia);
            panel4.Controls.Add(btnEditarAsistencia);
            panel4.Controls.Add(btnAgregarAsistencia);
            panel4.Controls.Add(dtpHoraSalida);
            panel4.Controls.Add(dtpHoraEntrada);
            panel4.Controls.Add(dtpFecha);
            panel4.Controls.Add(cmbTurno);
            panel4.Controls.Add(cmbEmpleado);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 416);
            panel4.TabIndex = 0;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(5, 247);
            label16.Name = "label16";
            label16.Size = new Size(66, 15);
            label16.TabIndex = 13;
            label16.Text = "Hora salida";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(5, 188);
            label15.Name = "label15";
            label15.Size = new Size(76, 15);
            label15.TabIndex = 12;
            label15.Text = "Hora Entrada";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(5, 127);
            label14.Name = "label14";
            label14.Size = new Size(38, 15);
            label14.TabIndex = 11;
            label14.Text = "Fecha";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(5, 71);
            label13.Name = "label13";
            label13.Size = new Size(39, 15);
            label13.TabIndex = 10;
            label13.Text = "Turno";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(5, 12);
            label12.Name = "label12";
            label12.Size = new Size(60, 15);
            label12.TabIndex = 9;
            label12.Text = "Empleado";
            // 
            // btnEliminarAsistencia
            // 
            btnEliminarAsistencia.Location = new Point(122, 359);
            btnEliminarAsistencia.Name = "btnEliminarAsistencia";
            btnEliminarAsistencia.Size = new Size(75, 23);
            btnEliminarAsistencia.TabIndex = 8;
            btnEliminarAsistencia.Text = "Eliminar";
            btnEliminarAsistencia.UseVisualStyleBackColor = true;
            btnEliminarAsistencia.Click += btnEliminarAsistencia_Click;
            // 
            // btnActualizarAsistencia
            // 
            btnActualizarAsistencia.Location = new Point(5, 359);
            btnActualizarAsistencia.Name = "btnActualizarAsistencia";
            btnActualizarAsistencia.Size = new Size(75, 23);
            btnActualizarAsistencia.TabIndex = 7;
            btnActualizarAsistencia.Text = "Actualizar";
            btnActualizarAsistencia.UseVisualStyleBackColor = true;
            btnActualizarAsistencia.Click += btnActualizarAsistencia_Click;
            // 
            // btnEditarAsistencia
            // 
            btnEditarAsistencia.Location = new Point(122, 312);
            btnEditarAsistencia.Name = "btnEditarAsistencia";
            btnEditarAsistencia.Size = new Size(75, 23);
            btnEditarAsistencia.TabIndex = 6;
            btnEditarAsistencia.Text = "Editar";
            btnEditarAsistencia.UseVisualStyleBackColor = true;
            btnEditarAsistencia.Click += btnEditarAsistencia_Click;
            // 
            // btnAgregarAsistencia
            // 
            btnAgregarAsistencia.Location = new Point(5, 312);
            btnAgregarAsistencia.Name = "btnAgregarAsistencia";
            btnAgregarAsistencia.Size = new Size(75, 23);
            btnAgregarAsistencia.TabIndex = 5;
            btnAgregarAsistencia.Text = "Agregar";
            btnAgregarAsistencia.UseVisualStyleBackColor = true;
            btnAgregarAsistencia.Click += btnAgregarAsistencia_Click;
            // 
            // dtpHoraSalida
            // 
            dtpHoraSalida.Location = new Point(5, 265);
            dtpHoraSalida.Name = "dtpHoraSalida";
            dtpHoraSalida.Size = new Size(192, 23);
            dtpHoraSalida.TabIndex = 4;
            // 
            // dtpHoraEntrada
            // 
            dtpHoraEntrada.Location = new Point(5, 206);
            dtpHoraEntrada.Name = "dtpHoraEntrada";
            dtpHoraEntrada.Size = new Size(192, 23);
            dtpHoraEntrada.TabIndex = 3;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(5, 145);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(192, 23);
            dtpFecha.TabIndex = 2;
            // 
            // cmbTurno
            // 
            cmbTurno.FormattingEnabled = true;
            cmbTurno.Location = new Point(5, 89);
            cmbTurno.Name = "cmbTurno";
            cmbTurno.Size = new Size(192, 23);
            cmbTurno.TabIndex = 1;
            // 
            // cmbEmpleado
            // 
            cmbEmpleado.FormattingEnabled = true;
            cmbEmpleado.Location = new Point(5, 30);
            cmbEmpleado.Name = "cmbEmpleado";
            cmbEmpleado.Size = new Size(192, 23);
            cmbEmpleado.TabIndex = 0;
            // 
            // FormRecursosHumanos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRecursosHumanos";
            Text = "FormRecursosHumanos";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPuestos).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAsistencias).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgvEmpleados;
        private Panel panel1;
        private TabPage tabPage2;
        private TextBox txtTelefonoEmpleado;
        private TextBox txtApellidoEmpleado;
        private TextBox txtNombreEmpleado;
        private Button btnEliminarEmpleado;
        private Button btnActualizarEmpleado;
        private Button btnEditarEmpleado;
        private Button btnAgregarEmpleado;
        private ComboBox cmbAlmacenEmpleado;
        private ComboBox cmbPuestoEmpleado;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvPuestos;
        private Panel panel2;
        private Button btnEliminarPuesto;
        private Button btnActualizarPuesto;
        private Button btnEditarPuesto;
        private Button btnAgregarPuesto;
        private TextBox txtSalarioBasePuesto;
        private TextBox txtDescripcionPuesto;
        private TextBox txtNombrePuesto;
        private Label label8;
        private Label label7;
        private Label label6;
        private TabPage tabPage3;
        private DataGridView dgvTurnos;
        private Panel panel3;
        private DateTimePicker dtpHoraFin;
        private DateTimePicker dtpHoraInicio;
        private TextBox txtNombreTurno;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button btnEliminarTurno;
        private Button btnActualizarTurno;
        private Button btnEditarTurno;
        private Button btnAgregarTurno;
        private TabPage tabPage4;
        private DataGridView dgvAsistencias;
        private Panel panel4;
        private DateTimePicker dtpHoraSalida;
        private DateTimePicker dtpHoraEntrada;
        private DateTimePicker dtpFecha;
        private ComboBox cmbTurno;
        private ComboBox cmbEmpleado;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Button btnEliminarAsistencia;
        private Button btnActualizarAsistencia;
        private Button btnEditarAsistencia;
        private Button btnAgregarAsistencia;
    }
}
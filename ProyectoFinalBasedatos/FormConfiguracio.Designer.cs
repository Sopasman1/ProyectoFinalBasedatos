namespace ProyectoFinalBasedatos
{
    partial class FormConfiguracio
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
            dgvUsuarios = new DataGridView();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnEliminarUsuario = new Button();
            btnActualizarUsuario = new Button();
            btnEditarUsuario = new Button();
            btnAgregarUsuario = new Button();
            cmbEmpleado = new ComboBox();
            cmbRol = new ComboBox();
            txtContrasena = new TextBox();
            txtNombreUsuario = new TextBox();
            tabPage2 = new TabPage();
            dgvRoles = new DataGridView();
            panel2 = new Panel();
            label6 = new Label();
            label5 = new Label();
            btnEliminarRol = new Button();
            btnActualizarRol = new Button();
            btnEditarRol = new Button();
            btnAgregarRol = new Button();
            txtDescripcionRol = new TextBox();
            txtNombreRol = new TextBox();
            tabPage3 = new TabPage();
            dgvSesiones = new DataGridView();
            panel3 = new Panel();
            cmbUsuario2 = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            btnEliminarSesion = new Button();
            btnActualizarSesion = new Button();
            btnEditarSesion = new Button();
            btnAgregarSesion = new Button();
            dtpFechaFin = new DateTimePicker();
            dtpFechaInicio = new DateTimePicker();
            tabPage4 = new TabPage();
            dgvMonedas = new DataGridView();
            panel4 = new Panel();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            btnLimpiarCampos = new Button();
            btnEliminarMoneda = new Button();
            btnActualizarMoneda = new Button();
            btnEditarMoneda = new Button();
            btnAgregarMoneda = new Button();
            txtTipoCambio = new TextBox();
            txtSimboloMoneda = new TextBox();
            txtNombreMoneda = new TextBox();
            tabPage5 = new TabPage();
            dgvCiudades = new DataGridView();
            panel5 = new Panel();
            btnEliminarCiudad = new Button();
            btnActualizarCiudad = new Button();
            btnEditarCiudad = new Button();
            btnAgregarCiudad = new Button();
            label13 = new Label();
            label12 = new Label();
            cmbPais = new ComboBox();
            txtNombreCiudad = new TextBox();
            tabPage6 = new TabPage();
            dgvConfiguraciones = new DataGridView();
            panel6 = new Panel();
            label15 = new Label();
            label14 = new Label();
            btnEliminarConfiguracion = new Button();
            btnActualizarConfiguracion = new Button();
            btnEditarConfiguracion = new Button();
            btnAgregarConfiguracion = new Button();
            txtValor = new TextBox();
            txtClave = new TextBox();
            tabPage7 = new TabPage();
            dgvNotificaciones = new DataGridView();
            panel7 = new Panel();
            label19 = new Label();
            dtpfecha = new DateTimePicker();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            btnEliminarNotificacion = new Button();
            btnActualizarNotificacion = new Button();
            btnEditarNotificacion = new Button();
            btnAgregarNotificacion = new Button();
            cmbUsuario = new ComboBox();
            txtTipo = new TextBox();
            txtMensaje = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).BeginInit();
            panel2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSesiones).BeginInit();
            panel3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMonedas).BeginInit();
            panel4.SuspendLayout();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCiudades).BeginInit();
            panel5.SuspendLayout();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConfiguraciones).BeginInit();
            panel6.SuspendLayout();
            tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNotificaciones).BeginInit();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvUsuarios);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Usuarios";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(207, 3);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(582, 416);
            dgvUsuarios.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnEliminarUsuario);
            panel1.Controls.Add(btnActualizarUsuario);
            panel1.Controls.Add(btnEditarUsuario);
            panel1.Controls.Add(btnAgregarUsuario);
            panel1.Controls.Add(cmbEmpleado);
            panel1.Controls.Add(cmbRol);
            panel1.Controls.Add(txtContrasena);
            panel1.Controls.Add(txtNombreUsuario);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(198, 416);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 196);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 11;
            label4.Text = "Empleado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 134);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 10;
            label3.Text = "Rol";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 72);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 9;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 12);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 8;
            label1.Text = "Nombre Usuario";
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.Location = new Point(120, 320);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(75, 23);
            btnEliminarUsuario.TabIndex = 7;
            btnEliminarUsuario.Text = "Eliminar";
            btnEliminarUsuario.UseVisualStyleBackColor = true;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // btnActualizarUsuario
            // 
            btnActualizarUsuario.Location = new Point(5, 320);
            btnActualizarUsuario.Name = "btnActualizarUsuario";
            btnActualizarUsuario.Size = new Size(75, 23);
            btnActualizarUsuario.TabIndex = 6;
            btnActualizarUsuario.Text = "Actualizar";
            btnActualizarUsuario.UseVisualStyleBackColor = true;
            btnActualizarUsuario.Click += btnActualizarUsuario_Click;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.Location = new Point(120, 262);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Size = new Size(75, 23);
            btnEditarUsuario.TabIndex = 5;
            btnEditarUsuario.Text = "Editar";
            btnEditarUsuario.UseVisualStyleBackColor = true;
            btnEditarUsuario.Click += btnEditarUsuario_Click;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Location = new Point(5, 262);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(75, 23);
            btnAgregarUsuario.TabIndex = 4;
            btnAgregarUsuario.Text = "Agregar";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // cmbEmpleado
            // 
            cmbEmpleado.FormattingEnabled = true;
            cmbEmpleado.Location = new Point(5, 214);
            cmbEmpleado.Name = "cmbEmpleado";
            cmbEmpleado.Size = new Size(190, 23);
            cmbEmpleado.TabIndex = 3;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(5, 152);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(190, 23);
            cmbRol.TabIndex = 2;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(5, 90);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(190, 23);
            txtContrasena.TabIndex = 1;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(5, 30);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(190, 23);
            txtNombreUsuario.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvRoles);
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Roles";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvRoles
            // 
            dgvRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoles.Location = new Point(209, 3);
            dgvRoles.Name = "dgvRoles";
            dgvRoles.Size = new Size(580, 413);
            dgvRoles.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnEliminarRol);
            panel2.Controls.Add(btnActualizarRol);
            panel2.Controls.Add(btnEditarRol);
            panel2.Controls.Add(btnAgregarRol);
            panel2.Controls.Add(txtDescripcionRol);
            panel2.Controls.Add(txtNombreRol);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 416);
            panel2.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 84);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 7;
            label6.Text = "Descripcion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 22);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 6;
            label5.Text = "Nombre Rol";
            // 
            // btnEliminarRol
            // 
            btnEliminarRol.Location = new Point(5, 300);
            btnEliminarRol.Name = "btnEliminarRol";
            btnEliminarRol.Size = new Size(75, 23);
            btnEliminarRol.TabIndex = 5;
            btnEliminarRol.Text = "Eliminar";
            btnEliminarRol.UseVisualStyleBackColor = true;
            btnEliminarRol.Click += btnEliminarRol_Click;
            // 
            // btnActualizarRol
            // 
            btnActualizarRol.Location = new Point(5, 252);
            btnActualizarRol.Name = "btnActualizarRol";
            btnActualizarRol.Size = new Size(75, 23);
            btnActualizarRol.TabIndex = 4;
            btnActualizarRol.Text = "Actualizar";
            btnActualizarRol.UseVisualStyleBackColor = true;
            btnActualizarRol.Click += btnActualizarRol_Click;
            // 
            // btnEditarRol
            // 
            btnEditarRol.Location = new Point(5, 207);
            btnEditarRol.Name = "btnEditarRol";
            btnEditarRol.Size = new Size(75, 23);
            btnEditarRol.TabIndex = 3;
            btnEditarRol.Text = "Editar";
            btnEditarRol.UseVisualStyleBackColor = true;
            btnEditarRol.Click += btnEditarRol_Click;
            // 
            // btnAgregarRol
            // 
            btnAgregarRol.Location = new Point(5, 164);
            btnAgregarRol.Name = "btnAgregarRol";
            btnAgregarRol.Size = new Size(75, 23);
            btnAgregarRol.TabIndex = 2;
            btnAgregarRol.Text = "Agregar";
            btnAgregarRol.UseVisualStyleBackColor = true;
            btnAgregarRol.Click += btnAgregarRol_Click;
            // 
            // txtDescripcionRol
            // 
            txtDescripcionRol.Location = new Point(3, 102);
            txtDescripcionRol.Name = "txtDescripcionRol";
            txtDescripcionRol.Size = new Size(194, 23);
            txtDescripcionRol.TabIndex = 1;
            // 
            // txtNombreRol
            // 
            txtNombreRol.Location = new Point(3, 40);
            txtNombreRol.Name = "txtNombreRol";
            txtNombreRol.Size = new Size(194, 23);
            txtNombreRol.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvSesiones);
            tabPage3.Controls.Add(panel3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(792, 422);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Sesiones";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvSesiones
            // 
            dgvSesiones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSesiones.Location = new Point(209, 3);
            dgvSesiones.Name = "dgvSesiones";
            dgvSesiones.Size = new Size(580, 416);
            dgvSesiones.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(cmbUsuario2);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(btnEliminarSesion);
            panel3.Controls.Add(btnActualizarSesion);
            panel3.Controls.Add(btnEditarSesion);
            panel3.Controls.Add(btnAgregarSesion);
            panel3.Controls.Add(dtpFechaFin);
            panel3.Controls.Add(dtpFechaInicio);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 416);
            panel3.TabIndex = 0;
            // 
            // cmbUsuario2
            // 
            cmbUsuario2.FormattingEnabled = true;
            cmbUsuario2.Location = new Point(3, 168);
            cmbUsuario2.Name = "cmbUsuario2";
            cmbUsuario2.Size = new Size(121, 23);
            cmbUsuario2.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 89);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 7;
            label8.Text = "Fecha fin";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 30);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 6;
            label7.Text = "Fecha Inicio";
            // 
            // btnEliminarSesion
            // 
            btnEliminarSesion.Location = new Point(5, 362);
            btnEliminarSesion.Name = "btnEliminarSesion";
            btnEliminarSesion.Size = new Size(75, 23);
            btnEliminarSesion.TabIndex = 5;
            btnEliminarSesion.Text = "Eliminar";
            btnEliminarSesion.UseVisualStyleBackColor = true;
            btnEliminarSesion.Click += btnEliminarSesion_Click;
            // 
            // btnActualizarSesion
            // 
            btnActualizarSesion.Location = new Point(5, 313);
            btnActualizarSesion.Name = "btnActualizarSesion";
            btnActualizarSesion.Size = new Size(75, 23);
            btnActualizarSesion.TabIndex = 4;
            btnActualizarSesion.Text = "Actualizar";
            btnActualizarSesion.UseVisualStyleBackColor = true;
            btnActualizarSesion.Click += btnActualizarSesion_Click;
            // 
            // btnEditarSesion
            // 
            btnEditarSesion.Location = new Point(5, 259);
            btnEditarSesion.Name = "btnEditarSesion";
            btnEditarSesion.Size = new Size(75, 23);
            btnEditarSesion.TabIndex = 3;
            btnEditarSesion.Text = "Editar";
            btnEditarSesion.UseVisualStyleBackColor = true;
            btnEditarSesion.Click += btnEditarSesion_Click;
            // 
            // btnAgregarSesion
            // 
            btnAgregarSesion.Location = new Point(5, 206);
            btnAgregarSesion.Name = "btnAgregarSesion";
            btnAgregarSesion.Size = new Size(75, 23);
            btnAgregarSesion.TabIndex = 2;
            btnAgregarSesion.Text = "Agregar";
            btnAgregarSesion.UseVisualStyleBackColor = true;
            btnAgregarSesion.Click += btnAgregarSesion_Click;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Location = new Point(3, 107);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(194, 23);
            dtpFechaFin.TabIndex = 1;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(3, 48);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(194, 23);
            dtpFechaInicio.TabIndex = 0;
            dtpFechaInicio.Value = new DateTime(2025, 12, 9, 16, 42, 52, 0);
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dgvMonedas);
            tabPage4.Controls.Add(panel4);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(792, 422);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Moneda";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvMonedas
            // 
            dgvMonedas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMonedas.Location = new Point(209, 3);
            dgvMonedas.Name = "dgvMonedas";
            dgvMonedas.Size = new Size(580, 416);
            dgvMonedas.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(btnLimpiarCampos);
            panel4.Controls.Add(btnEliminarMoneda);
            panel4.Controls.Add(btnActualizarMoneda);
            panel4.Controls.Add(btnEditarMoneda);
            panel4.Controls.Add(btnAgregarMoneda);
            panel4.Controls.Add(txtTipoCambio);
            panel4.Controls.Add(txtSimboloMoneda);
            panel4.Controls.Add(txtNombreMoneda);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 416);
            panel4.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(5, 127);
            label11.Name = "label11";
            label11.Size = new Size(76, 15);
            label11.TabIndex = 10;
            label11.Text = "Tipo Cambio";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(5, 68);
            label10.Name = "label10";
            label10.Size = new Size(98, 15);
            label10.TabIndex = 9;
            label10.Text = "Simbolo Moneda";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 12);
            label9.Name = "label9";
            label9.Size = new Size(98, 15);
            label9.TabIndex = 8;
            label9.Text = "Nombre Moneda";
            // 
            // btnLimpiarCampos
            // 
            btnLimpiarCampos.Location = new Point(5, 376);
            btnLimpiarCampos.Name = "btnLimpiarCampos";
            btnLimpiarCampos.Size = new Size(118, 23);
            btnLimpiarCampos.TabIndex = 7;
            btnLimpiarCampos.Text = "Limpiar campos";
            btnLimpiarCampos.UseVisualStyleBackColor = true;
            btnLimpiarCampos.Click += btnLimpiarCampos_Click;
            // 
            // btnEliminarMoneda
            // 
            btnEliminarMoneda.Location = new Point(5, 333);
            btnEliminarMoneda.Name = "btnEliminarMoneda";
            btnEliminarMoneda.Size = new Size(75, 23);
            btnEliminarMoneda.TabIndex = 6;
            btnEliminarMoneda.Text = "Eliminar";
            btnEliminarMoneda.UseVisualStyleBackColor = true;
            btnEliminarMoneda.Click += btnEliminarMoneda_Click;
            // 
            // btnActualizarMoneda
            // 
            btnActualizarMoneda.Location = new Point(5, 287);
            btnActualizarMoneda.Name = "btnActualizarMoneda";
            btnActualizarMoneda.Size = new Size(75, 23);
            btnActualizarMoneda.TabIndex = 5;
            btnActualizarMoneda.Text = "Actualizar";
            btnActualizarMoneda.UseVisualStyleBackColor = true;
            btnActualizarMoneda.Click += btnActualizarMoneda_Click;
            // 
            // btnEditarMoneda
            // 
            btnEditarMoneda.Location = new Point(5, 243);
            btnEditarMoneda.Name = "btnEditarMoneda";
            btnEditarMoneda.Size = new Size(75, 23);
            btnEditarMoneda.TabIndex = 4;
            btnEditarMoneda.Text = "Editar";
            btnEditarMoneda.UseVisualStyleBackColor = true;
            btnEditarMoneda.Click += btnEditarMoneda_Click;
            // 
            // btnAgregarMoneda
            // 
            btnAgregarMoneda.Location = new Point(5, 200);
            btnAgregarMoneda.Name = "btnAgregarMoneda";
            btnAgregarMoneda.Size = new Size(75, 23);
            btnAgregarMoneda.TabIndex = 3;
            btnAgregarMoneda.Text = "Agregar";
            btnAgregarMoneda.UseVisualStyleBackColor = true;
            btnAgregarMoneda.Click += btnAgregarMoneda_Click;
            // 
            // txtTipoCambio
            // 
            txtTipoCambio.Location = new Point(5, 145);
            txtTipoCambio.Name = "txtTipoCambio";
            txtTipoCambio.Size = new Size(192, 23);
            txtTipoCambio.TabIndex = 2;
            // 
            // txtSimboloMoneda
            // 
            txtSimboloMoneda.Location = new Point(5, 86);
            txtSimboloMoneda.Name = "txtSimboloMoneda";
            txtSimboloMoneda.Size = new Size(192, 23);
            txtSimboloMoneda.TabIndex = 1;
            // 
            // txtNombreMoneda
            // 
            txtNombreMoneda.Location = new Point(5, 30);
            txtNombreMoneda.Name = "txtNombreMoneda";
            txtNombreMoneda.Size = new Size(192, 23);
            txtNombreMoneda.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(dgvCiudades);
            tabPage5.Controls.Add(panel5);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(792, 422);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Pais";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // dgvCiudades
            // 
            dgvCiudades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCiudades.Location = new Point(209, 3);
            dgvCiudades.Name = "dgvCiudades";
            dgvCiudades.Size = new Size(580, 416);
            dgvCiudades.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnEliminarCiudad);
            panel5.Controls.Add(btnActualizarCiudad);
            panel5.Controls.Add(btnEditarCiudad);
            panel5.Controls.Add(btnAgregarCiudad);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(cmbPais);
            panel5.Controls.Add(txtNombreCiudad);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 416);
            panel5.TabIndex = 0;
            // 
            // btnEliminarCiudad
            // 
            btnEliminarCiudad.Location = new Point(5, 313);
            btnEliminarCiudad.Name = "btnEliminarCiudad";
            btnEliminarCiudad.Size = new Size(75, 23);
            btnEliminarCiudad.TabIndex = 7;
            btnEliminarCiudad.Text = "Eliminar";
            btnEliminarCiudad.UseVisualStyleBackColor = true;
            btnEliminarCiudad.Click += btnEliminarCiudad_Click;
            // 
            // btnActualizarCiudad
            // 
            btnActualizarCiudad.Location = new Point(5, 270);
            btnActualizarCiudad.Name = "btnActualizarCiudad";
            btnActualizarCiudad.Size = new Size(75, 23);
            btnActualizarCiudad.TabIndex = 6;
            btnActualizarCiudad.Text = "Actualizar";
            btnActualizarCiudad.UseVisualStyleBackColor = true;
            btnActualizarCiudad.Click += btnActualizarCiudad_Click;
            // 
            // btnEditarCiudad
            // 
            btnEditarCiudad.Location = new Point(5, 225);
            btnEditarCiudad.Name = "btnEditarCiudad";
            btnEditarCiudad.Size = new Size(75, 23);
            btnEditarCiudad.TabIndex = 5;
            btnEditarCiudad.Text = "Editar";
            btnEditarCiudad.UseVisualStyleBackColor = true;
            btnEditarCiudad.Click += btnEditarCiudad_Click;
            // 
            // btnAgregarCiudad
            // 
            btnAgregarCiudad.Location = new Point(5, 181);
            btnAgregarCiudad.Name = "btnAgregarCiudad";
            btnAgregarCiudad.Size = new Size(75, 23);
            btnAgregarCiudad.TabIndex = 4;
            btnAgregarCiudad.Text = "Agregar";
            btnAgregarCiudad.UseVisualStyleBackColor = true;
            btnAgregarCiudad.Click += btnAgregarCiudad_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(5, 97);
            label13.Name = "label13";
            label13.Size = new Size(28, 15);
            label13.TabIndex = 3;
            label13.Text = "Pais";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(5, 24);
            label12.Name = "label12";
            label12.Size = new Size(92, 15);
            label12.TabIndex = 2;
            label12.Text = "Nombre Ciudad";
            // 
            // cmbPais
            // 
            cmbPais.FormattingEnabled = true;
            cmbPais.Location = new Point(5, 115);
            cmbPais.Name = "cmbPais";
            cmbPais.Size = new Size(192, 23);
            cmbPais.TabIndex = 1;
            // 
            // txtNombreCiudad
            // 
            txtNombreCiudad.Location = new Point(5, 42);
            txtNombreCiudad.Name = "txtNombreCiudad";
            txtNombreCiudad.Size = new Size(192, 23);
            txtNombreCiudad.TabIndex = 0;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(dgvConfiguraciones);
            tabPage6.Controls.Add(panel6);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(792, 422);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Configuracion";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // dgvConfiguraciones
            // 
            dgvConfiguraciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConfiguraciones.Location = new Point(209, 3);
            dgvConfiguraciones.Name = "dgvConfiguraciones";
            dgvConfiguraciones.Size = new Size(580, 416);
            dgvConfiguraciones.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(label15);
            panel6.Controls.Add(label14);
            panel6.Controls.Add(btnEliminarConfiguracion);
            panel6.Controls.Add(btnActualizarConfiguracion);
            panel6.Controls.Add(btnEditarConfiguracion);
            panel6.Controls.Add(btnAgregarConfiguracion);
            panel6.Controls.Add(txtValor);
            panel6.Controls.Add(txtClave);
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 416);
            panel6.TabIndex = 0;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(5, 83);
            label15.Name = "label15";
            label15.Size = new Size(33, 15);
            label15.TabIndex = 7;
            label15.Text = "Valor";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(5, 26);
            label14.Name = "label14";
            label14.Size = new Size(36, 15);
            label14.TabIndex = 6;
            label14.Text = "Clave";
            // 
            // btnEliminarConfiguracion
            // 
            btnEliminarConfiguracion.Location = new Point(5, 309);
            btnEliminarConfiguracion.Name = "btnEliminarConfiguracion";
            btnEliminarConfiguracion.Size = new Size(75, 23);
            btnEliminarConfiguracion.TabIndex = 5;
            btnEliminarConfiguracion.Text = "Eliminar";
            btnEliminarConfiguracion.UseVisualStyleBackColor = true;
            btnEliminarConfiguracion.Click += btnEliminarConfiguracion_Click;
            // 
            // btnActualizarConfiguracion
            // 
            btnActualizarConfiguracion.Location = new Point(5, 259);
            btnActualizarConfiguracion.Name = "btnActualizarConfiguracion";
            btnActualizarConfiguracion.Size = new Size(75, 23);
            btnActualizarConfiguracion.TabIndex = 4;
            btnActualizarConfiguracion.Text = "Actualizar";
            btnActualizarConfiguracion.UseVisualStyleBackColor = true;
            btnActualizarConfiguracion.Click += btnActualizarConfiguracion_Click;
            // 
            // btnEditarConfiguracion
            // 
            btnEditarConfiguracion.Location = new Point(5, 210);
            btnEditarConfiguracion.Name = "btnEditarConfiguracion";
            btnEditarConfiguracion.Size = new Size(75, 23);
            btnEditarConfiguracion.TabIndex = 3;
            btnEditarConfiguracion.Text = "Editar";
            btnEditarConfiguracion.UseVisualStyleBackColor = true;
            btnEditarConfiguracion.Click += btnEditarConfiguracion_Click;
            // 
            // btnAgregarConfiguracion
            // 
            btnAgregarConfiguracion.Location = new Point(5, 161);
            btnAgregarConfiguracion.Name = "btnAgregarConfiguracion";
            btnAgregarConfiguracion.Size = new Size(75, 23);
            btnAgregarConfiguracion.TabIndex = 2;
            btnAgregarConfiguracion.Text = "Agregar";
            btnAgregarConfiguracion.UseVisualStyleBackColor = true;
            btnAgregarConfiguracion.Click += btnAgregarConfiguracion_Click;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(5, 101);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(192, 23);
            txtValor.TabIndex = 1;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(5, 44);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(192, 23);
            txtClave.TabIndex = 0;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(dgvNotificaciones);
            tabPage7.Controls.Add(panel7);
            tabPage7.Location = new Point(4, 24);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(792, 422);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Notificacion";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // dgvNotificaciones
            // 
            dgvNotificaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotificaciones.Location = new Point(177, 3);
            dgvNotificaciones.Name = "dgvNotificaciones";
            dgvNotificaciones.Size = new Size(612, 411);
            dgvNotificaciones.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Controls.Add(label19);
            panel7.Controls.Add(dtpfecha);
            panel7.Controls.Add(label18);
            panel7.Controls.Add(label17);
            panel7.Controls.Add(label16);
            panel7.Controls.Add(btnEliminarNotificacion);
            panel7.Controls.Add(btnActualizarNotificacion);
            panel7.Controls.Add(btnEditarNotificacion);
            panel7.Controls.Add(btnAgregarNotificacion);
            panel7.Controls.Add(cmbUsuario);
            panel7.Controls.Add(txtTipo);
            panel7.Controls.Add(txtMensaje);
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(168, 416);
            panel7.TabIndex = 0;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(5, 202);
            label19.Name = "label19";
            label19.Size = new Size(38, 15);
            label19.TabIndex = 11;
            label19.Text = "Fecha";
            // 
            // dtpfecha
            // 
            dtpfecha.Location = new Point(5, 220);
            dtpfecha.Name = "dtpfecha";
            dtpfecha.Size = new Size(160, 23);
            dtpfecha.TabIndex = 10;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(5, 137);
            label18.Name = "label18";
            label18.Size = new Size(47, 15);
            label18.TabIndex = 9;
            label18.Text = "Usuario";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(5, 77);
            label17.Name = "label17";
            label17.Size = new Size(31, 15);
            label17.TabIndex = 8;
            label17.Text = "Tipo";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(5, 16);
            label16.Name = "label16";
            label16.Size = new Size(51, 15);
            label16.TabIndex = 7;
            label16.Text = "Mensaje";
            // 
            // btnEliminarNotificacion
            // 
            btnEliminarNotificacion.Location = new Point(3, 386);
            btnEliminarNotificacion.Name = "btnEliminarNotificacion";
            btnEliminarNotificacion.Size = new Size(75, 23);
            btnEliminarNotificacion.TabIndex = 6;
            btnEliminarNotificacion.Text = "Eliminar";
            btnEliminarNotificacion.UseVisualStyleBackColor = true;
            btnEliminarNotificacion.Click += btnEliminarNotificacion_Click;
            // 
            // btnActualizarNotificacion
            // 
            btnActualizarNotificacion.Location = new Point(3, 340);
            btnActualizarNotificacion.Name = "btnActualizarNotificacion";
            btnActualizarNotificacion.Size = new Size(75, 23);
            btnActualizarNotificacion.TabIndex = 5;
            btnActualizarNotificacion.Text = "Actualizar";
            btnActualizarNotificacion.UseVisualStyleBackColor = true;
            btnActualizarNotificacion.Click += btnActualizarNotificacion_Click;
            // 
            // btnEditarNotificacion
            // 
            btnEditarNotificacion.Location = new Point(3, 293);
            btnEditarNotificacion.Name = "btnEditarNotificacion";
            btnEditarNotificacion.Size = new Size(75, 23);
            btnEditarNotificacion.TabIndex = 4;
            btnEditarNotificacion.Text = "Editar";
            btnEditarNotificacion.UseVisualStyleBackColor = true;
            btnEditarNotificacion.Click += btnEditarNotificacion_Click;
            // 
            // btnAgregarNotificacion
            // 
            btnAgregarNotificacion.Location = new Point(3, 249);
            btnAgregarNotificacion.Name = "btnAgregarNotificacion";
            btnAgregarNotificacion.Size = new Size(75, 23);
            btnAgregarNotificacion.TabIndex = 3;
            btnAgregarNotificacion.Text = "Agregar";
            btnAgregarNotificacion.UseVisualStyleBackColor = true;
            btnAgregarNotificacion.Click += btnAgregarNotificacion_Click;
            // 
            // cmbUsuario
            // 
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(5, 155);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(160, 23);
            cmbUsuario.TabIndex = 2;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(3, 95);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(162, 23);
            txtTipo.TabIndex = 1;
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(3, 34);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(162, 23);
            txtMensaje.TabIndex = 0;
            // 
            // FormConfiguracio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormConfiguracio";
            Text = "FormConfiguracio";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRoles).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSesiones).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMonedas).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCiudades).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvConfiguraciones).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNotificaciones).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvUsuarios;
        private Panel panel1;
        private ComboBox cmbEmpleado;
        private ComboBox cmbRol;
        private TextBox txtContrasena;
        private TextBox txtNombreUsuario;
        private Button btnEliminarUsuario;
        private Button btnActualizarUsuario;
        private Button btnEditarUsuario;
        private Button btnAgregarUsuario;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private DataGridView dgvRoles;
        private Panel panel2;
        private Button btnEliminarRol;
        private Button btnActualizarRol;
        private Button btnEditarRol;
        private Button btnAgregarRol;
        private TextBox txtDescripcionRol;
        private TextBox txtNombreRol;
        private Label label6;
        private Label label5;
        private TabPage tabPage3;
        private DataGridView dgvSesiones;
        private Panel panel3;
        private DateTimePicker dtpFechaFin;
        private DateTimePicker dtpFechaInicio;
        private Label label8;
        private Label label7;
        private Button btnEliminarSesion;
        private Button btnActualizarSesion;
        private Button btnEditarSesion;
        private Button btnAgregarSesion;
        private ComboBox cmbUsuario2;
        private TabPage tabPage4;
        private DataGridView dgvMonedas;
        private Panel panel4;
        private TextBox txtTipoCambio;
        private TextBox txtSimboloMoneda;
        private TextBox txtNombreMoneda;
        private Button btnLimpiarCampos;
        private Button btnEliminarMoneda;
        private Button btnActualizarMoneda;
        private Button btnEditarMoneda;
        private Button btnAgregarMoneda;
        private Label label11;
        private Label label10;
        private Label label9;
        private TabPage tabPage5;
        private DataGridView dgvCiudades;
        private Panel panel5;
        private Button btnAgregarCiudad;
        private Label label13;
        private Label label12;
        private ComboBox cmbPais;
        private TextBox txtNombreCiudad;
        private Button btnEliminarCiudad;
        private Button btnActualizarCiudad;
        private Button btnEditarCiudad;
        private TabPage tabPage6;
        private DataGridView dgvConfiguraciones;
        private Panel panel6;
        private Label label15;
        private Label label14;
        private Button btnEliminarConfiguracion;
        private Button btnActualizarConfiguracion;
        private Button btnEditarConfiguracion;
        private Button btnAgregarConfiguracion;
        private TextBox txtValor;
        private TextBox txtClave;
        private TabPage tabPage7;
        private DataGridView dgvNotificaciones;
        private Panel panel7;
        private ComboBox cmbUsuario;
        private TextBox txtTipo;
        private TextBox txtMensaje;
        private Label label18;
        private Label label17;
        private Label label16;
        private Button btnEliminarNotificacion;
        private Button btnActualizarNotificacion;
        private Button btnEditarNotificacion;
        private Button btnAgregarNotificacion;
        private Label label19;
        private DateTimePicker dtpfecha;
    }
}
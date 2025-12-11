namespace ProyectoFinalBasedatos
{
    partial class Formlogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtContrasena = new TextBox();
            btnIngresar = new Button();
            txtUsuario = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            txtConfirmar = new TextBox();
            txtRUsuario = new TextBox();
            btnRegistrar = new Button();
            label9 = new Label();
            cmbRol = new ComboBox();
            label8 = new Label();
            cmbEmpleado = new ComboBox();
            label7 = new Label();
            txtRContrasena = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.avatar;
            pictureBox1.Location = new Point(3, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(135, 326);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(102, 3);
            label1.Name = "label1";
            label1.Size = new Size(187, 37);
            label1.TabIndex = 2;
            label1.Text = "Iniciar Sesion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(170, 88);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 3;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(155, 177);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            txtContrasena.BorderStyle = BorderStyle.FixedSingle;
            txtContrasena.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContrasena.Location = new Point(88, 200);
            txtContrasena.Multiline = true;
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(218, 27);
            txtContrasena.TabIndex = 6;
            // 
            // btnIngresar
            // 
            btnIngresar.FlatStyle = FlatStyle.System;
            btnIngresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.Location = new Point(158, 267);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 7;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Location = new Point(88, 111);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(218, 29);
            txtUsuario.TabIndex = 8;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(141, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(407, 326);
            tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btnIngresar);
            tabPage1.Controls.Add(txtUsuario);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtContrasena);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(399, 298);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "iniciar sesion";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtConfirmar);
            tabPage2.Controls.Add(txtRUsuario);
            tabPage2.Controls.Add(btnRegistrar);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(cmbRol);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(cmbEmpleado);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(txtRContrasena);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(399, 298);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Crear Usuario";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtConfirmar
            // 
            txtConfirmar.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmar.Location = new Point(3, 191);
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.Size = new Size(193, 23);
            txtConfirmar.TabIndex = 13;
            // 
            // txtRUsuario
            // 
            txtRUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtRUsuario.Location = new Point(6, 77);
            txtRUsuario.Name = "txtRUsuario";
            txtRUsuario.Size = new Size(190, 23);
            txtRUsuario.TabIndex = 12;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(282, 251);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(223, 118);
            label9.Name = "label9";
            label9.Size = new Size(28, 17);
            label9.TabIndex = 10;
            label9.Text = "Rol";
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(223, 136);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(145, 23);
            cmbRol.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(223, 57);
            label8.Name = "label8";
            label8.Size = new Size(69, 17);
            label8.TabIndex = 8;
            label8.Text = "Empleado";
            // 
            // cmbEmpleado
            // 
            cmbEmpleado.FormattingEnabled = true;
            cmbEmpleado.Location = new Point(223, 76);
            cmbEmpleado.Name = "cmbEmpleado";
            cmbEmpleado.Size = new Size(145, 23);
            cmbEmpleado.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 171);
            label7.Name = "label7";
            label7.Size = new Size(143, 17);
            label7.TabIndex = 5;
            label7.Text = "Confirmar Contraseña";
            // 
            // txtRContrasena
            // 
            txtRContrasena.BorderStyle = BorderStyle.FixedSingle;
            txtRContrasena.Location = new Point(6, 136);
            txtRContrasena.Name = "txtRContrasena";
            txtRContrasena.Size = new Size(190, 23);
            txtRContrasena.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 116);
            label6.Name = "label6";
            label6.Size = new Size(77, 17);
            label6.TabIndex = 3;
            label6.Text = "Contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 57);
            label5.Name = "label5";
            label5.Size = new Size(127, 17);
            label5.TabIndex = 1;
            label5.Text = "Nombre de usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(64, 3);
            label4.Name = "label4";
            label4.Size = new Size(273, 37);
            label4.TabIndex = 0;
            label4.Text = "Registro De Usuario";
            // 
            // Formlogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Control;
            ClientSize = new Size(551, 326);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formlogin";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox txtContrasena;
        private Button btnIngresar;
        private TextBox txtUsuario;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private Label label7;
        private TextBox txtRContrasena;
        private Label label6;
        private Button btnRegistrar;
        private Label label9;
        private ComboBox cmbRol;
        private Label label8;
        private ComboBox cmbEmpleado;
        private TextBox txtRUsuario;
        private TextBox txtConfirmar;
    }
}

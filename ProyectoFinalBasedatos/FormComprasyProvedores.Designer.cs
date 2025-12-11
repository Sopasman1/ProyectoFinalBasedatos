namespace ProyectoFinalBasedatos
{
    partial class FormComprasyProvedores
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
            dgvProveedor = new DataGridView();
            panelProveedor = new Panel();
            txtDireccionProveedor = new TextBox();
            txtEmailProveedor = new TextBox();
            txtTelefonoProveedor = new TextBox();
            txtNombreProveedor = new TextBox();
            btnEliminarProveedor = new Button();
            btnActualizarProveedor = new Button();
            btnEditarProveedor = new Button();
            btnAgregarProveedor = new Button();
            label5 = new Label();
            cmbPais = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            dgvOrdenCompra = new DataGridView();
            panelLOC = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            btnAgregarOC = new Button();
            btnEliminarOC = new Button();
            btnActualizarOC = new Button();
            btnEditarOC = new Button();
            numTotalOC = new NumericUpDown();
            cmbProveedorOC = new ComboBox();
            dtpFechaOC = new DateTimePicker();
            tabPage3 = new TabPage();
            dgvDetalleCompra = new DataGridView();
            panel1 = new Panel();
            btnActualizarDetalleCompra = new Button();
            btnEliminarDetalleCompra = new Button();
            btnEditarDetalleCompra = new Button();
            btnAgregarDetalleCompra = new Button();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            numPrecioUnitario = new NumericUpDown();
            numCantidad = new NumericUpDown();
            cmbOrdenCompra = new ComboBox();
            cmbProducto = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).BeginInit();
            panelProveedor.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenCompra).BeginInit();
            panelLOC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTotalOC).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleCompra).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPrecioUnitario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
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
            tabPage1.Controls.Add(dgvProveedor);
            tabPage1.Controls.Add(panelProveedor);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Proveedores";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvProveedor
            // 
            dgvProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedor.Location = new Point(209, 3);
            dgvProveedor.Name = "dgvProveedor";
            dgvProveedor.Size = new Size(580, 413);
            dgvProveedor.TabIndex = 1;
            // 
            // panelProveedor
            // 
            panelProveedor.Controls.Add(txtDireccionProveedor);
            panelProveedor.Controls.Add(txtEmailProveedor);
            panelProveedor.Controls.Add(txtTelefonoProveedor);
            panelProveedor.Controls.Add(txtNombreProveedor);
            panelProveedor.Controls.Add(btnEliminarProveedor);
            panelProveedor.Controls.Add(btnActualizarProveedor);
            panelProveedor.Controls.Add(btnEditarProveedor);
            panelProveedor.Controls.Add(btnAgregarProveedor);
            panelProveedor.Controls.Add(label5);
            panelProveedor.Controls.Add(cmbPais);
            panelProveedor.Controls.Add(label4);
            panelProveedor.Controls.Add(label3);
            panelProveedor.Controls.Add(label2);
            panelProveedor.Controls.Add(label1);
            panelProveedor.Location = new Point(3, 3);
            panelProveedor.Name = "panelProveedor";
            panelProveedor.Size = new Size(200, 416);
            panelProveedor.TabIndex = 0;
            // 
            // txtDireccionProveedor
            // 
            txtDireccionProveedor.Location = new Point(7, 185);
            txtDireccionProveedor.Name = "txtDireccionProveedor";
            txtDireccionProveedor.Size = new Size(190, 23);
            txtDireccionProveedor.TabIndex = 19;
            // 
            // txtEmailProveedor
            // 
            txtEmailProveedor.Location = new Point(5, 133);
            txtEmailProveedor.Name = "txtEmailProveedor";
            txtEmailProveedor.Size = new Size(190, 23);
            txtEmailProveedor.TabIndex = 18;
            // 
            // txtTelefonoProveedor
            // 
            txtTelefonoProveedor.Location = new Point(7, 83);
            txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            txtTelefonoProveedor.Size = new Size(190, 23);
            txtTelefonoProveedor.TabIndex = 17;
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.Location = new Point(5, 30);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(190, 23);
            txtNombreProveedor.TabIndex = 16;
            // 
            // btnEliminarProveedor
            // 
            btnEliminarProveedor.Location = new Point(120, 348);
            btnEliminarProveedor.Name = "btnEliminarProveedor";
            btnEliminarProveedor.Size = new Size(75, 23);
            btnEliminarProveedor.TabIndex = 15;
            btnEliminarProveedor.Text = "Eliminar";
            btnEliminarProveedor.UseVisualStyleBackColor = true;
            btnEliminarProveedor.Click += btnEliminarProveedor_Click;
            // 
            // btnActualizarProveedor
            // 
            btnActualizarProveedor.Location = new Point(7, 348);
            btnActualizarProveedor.Name = "btnActualizarProveedor";
            btnActualizarProveedor.Size = new Size(75, 23);
            btnActualizarProveedor.TabIndex = 14;
            btnActualizarProveedor.Text = "Actualizar";
            btnActualizarProveedor.UseVisualStyleBackColor = true;
            btnActualizarProveedor.Click += btnActualizarProveedor_Click;
            // 
            // btnEditarProveedor
            // 
            btnEditarProveedor.Location = new Point(122, 292);
            btnEditarProveedor.Name = "btnEditarProveedor";
            btnEditarProveedor.Size = new Size(75, 23);
            btnEditarProveedor.TabIndex = 13;
            btnEditarProveedor.Text = "Editar";
            btnEditarProveedor.UseVisualStyleBackColor = true;
            btnEditarProveedor.Click += btnEditarProveedor_Click;
            // 
            // btnAgregarProveedor
            // 
            btnAgregarProveedor.Location = new Point(7, 292);
            btnAgregarProveedor.Name = "btnAgregarProveedor";
            btnAgregarProveedor.Size = new Size(75, 23);
            btnAgregarProveedor.TabIndex = 12;
            btnAgregarProveedor.Text = "Agregar";
            btnAgregarProveedor.UseVisualStyleBackColor = true;
            btnAgregarProveedor.Click += btnAgregarProveedor_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 228);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 11;
            label5.Text = "Pais";
            // 
            // cmbPais
            // 
            cmbPais.FormattingEnabled = true;
            cmbPais.Location = new Point(7, 246);
            cmbPais.Name = "cmbPais";
            cmbPais.Size = new Size(115, 23);
            cmbPais.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 167);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 9;
            label4.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 115);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 8;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 65);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 7;
            label2.Text = "Telefono";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 12);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvOrdenCompra);
            tabPage2.Controls.Add(panelLOC);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Orden de Compra";
            // 
            // dgvOrdenCompra
            // 
            dgvOrdenCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenCompra.Location = new Point(209, 3);
            dgvOrdenCompra.Name = "dgvOrdenCompra";
            dgvOrdenCompra.Size = new Size(580, 419);
            dgvOrdenCompra.TabIndex = 1;
            // 
            // panelLOC
            // 
            panelLOC.Controls.Add(label8);
            panelLOC.Controls.Add(label7);
            panelLOC.Controls.Add(label6);
            panelLOC.Controls.Add(btnAgregarOC);
            panelLOC.Controls.Add(btnEliminarOC);
            panelLOC.Controls.Add(btnActualizarOC);
            panelLOC.Controls.Add(btnEditarOC);
            panelLOC.Controls.Add(numTotalOC);
            panelLOC.Controls.Add(cmbProveedorOC);
            panelLOC.Controls.Add(dtpFechaOC);
            panelLOC.Location = new Point(3, 3);
            panelLOC.Name = "panelLOC";
            panelLOC.Size = new Size(200, 419);
            panelLOC.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 64);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 9;
            label8.Text = "Proveedor";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 125);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 8;
            label7.Text = "Total";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 8);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 7;
            label6.Text = "Fecha";
            // 
            // btnAgregarOC
            // 
            btnAgregarOC.Location = new Point(6, 341);
            btnAgregarOC.Name = "btnAgregarOC";
            btnAgregarOC.Size = new Size(75, 23);
            btnAgregarOC.TabIndex = 6;
            btnAgregarOC.Text = "Agregar";
            btnAgregarOC.UseVisualStyleBackColor = true;
            btnAgregarOC.Click += btnAgregarOC_Click;
            // 
            // btnEliminarOC
            // 
            btnEliminarOC.Location = new Point(6, 297);
            btnEliminarOC.Name = "btnEliminarOC";
            btnEliminarOC.Size = new Size(75, 23);
            btnEliminarOC.TabIndex = 5;
            btnEliminarOC.Text = "Eliminar";
            btnEliminarOC.UseVisualStyleBackColor = true;
            btnEliminarOC.Click += btnEliminarOC_Click;
            // 
            // btnActualizarOC
            // 
            btnActualizarOC.Location = new Point(5, 255);
            btnActualizarOC.Name = "btnActualizarOC";
            btnActualizarOC.Size = new Size(75, 23);
            btnActualizarOC.TabIndex = 4;
            btnActualizarOC.Text = "Actualizar";
            btnActualizarOC.UseVisualStyleBackColor = true;
            btnActualizarOC.Click += btnActualizarOC_Click;
            // 
            // btnEditarOC
            // 
            btnEditarOC.Location = new Point(6, 216);
            btnEditarOC.Name = "btnEditarOC";
            btnEditarOC.Size = new Size(75, 23);
            btnEditarOC.TabIndex = 3;
            btnEditarOC.Text = "Editar";
            btnEditarOC.UseVisualStyleBackColor = true;
            btnEditarOC.Click += btnEditarOC_Click;
            // 
            // numTotalOC
            // 
            numTotalOC.Location = new Point(5, 143);
            numTotalOC.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numTotalOC.Name = "numTotalOC";
            numTotalOC.Size = new Size(102, 23);
            numTotalOC.TabIndex = 2;
            // 
            // cmbProveedorOC
            // 
            cmbProveedorOC.FormattingEnabled = true;
            cmbProveedorOC.Location = new Point(5, 82);
            cmbProveedorOC.Name = "cmbProveedorOC";
            cmbProveedorOC.Size = new Size(121, 23);
            cmbProveedorOC.TabIndex = 1;
            // 
            // dtpFechaOC
            // 
            dtpFechaOC.Location = new Point(6, 26);
            dtpFechaOC.Name = "dtpFechaOC";
            dtpFechaOC.Size = new Size(191, 23);
            dtpFechaOC.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvDetalleCompra);
            tabPage3.Controls.Add(panel1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(792, 422);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Compras";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvDetalleCompra
            // 
            dgvDetalleCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleCompra.Location = new Point(209, 3);
            dgvDetalleCompra.Name = "dgvDetalleCompra";
            dgvDetalleCompra.Size = new Size(580, 416);
            dgvDetalleCompra.TabIndex = 1;
            dgvDetalleCompra.CellClick += dgvDetalleCompra_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnActualizarDetalleCompra);
            panel1.Controls.Add(btnEliminarDetalleCompra);
            panel1.Controls.Add(btnEditarDetalleCompra);
            panel1.Controls.Add(btnAgregarDetalleCompra);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(numPrecioUnitario);
            panel1.Controls.Add(numCantidad);
            panel1.Controls.Add(cmbOrdenCompra);
            panel1.Controls.Add(cmbProducto);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 416);
            panel1.TabIndex = 0;
            // 
            // btnActualizarDetalleCompra
            // 
            btnActualizarDetalleCompra.Location = new Point(5, 355);
            btnActualizarDetalleCompra.Name = "btnActualizarDetalleCompra";
            btnActualizarDetalleCompra.Size = new Size(75, 23);
            btnActualizarDetalleCompra.TabIndex = 11;
            btnActualizarDetalleCompra.Text = "Actualizar";
            btnActualizarDetalleCompra.UseVisualStyleBackColor = true;
            btnActualizarDetalleCompra.Click += btnActualizarDetalleCompra_Click;
            // 
            // btnEliminarDetalleCompra
            // 
            btnEliminarDetalleCompra.Location = new Point(5, 326);
            btnEliminarDetalleCompra.Name = "btnEliminarDetalleCompra";
            btnEliminarDetalleCompra.Size = new Size(75, 23);
            btnEliminarDetalleCompra.TabIndex = 10;
            btnEliminarDetalleCompra.Text = "Eliminar";
            btnEliminarDetalleCompra.UseVisualStyleBackColor = true;
            btnEliminarDetalleCompra.Click += btnEliminarDetalleCompra_Click;
            // 
            // btnEditarDetalleCompra
            // 
            btnEditarDetalleCompra.Location = new Point(5, 297);
            btnEditarDetalleCompra.Name = "btnEditarDetalleCompra";
            btnEditarDetalleCompra.Size = new Size(75, 23);
            btnEditarDetalleCompra.TabIndex = 9;
            btnEditarDetalleCompra.Text = "Editar";
            btnEditarDetalleCompra.UseVisualStyleBackColor = true;
            btnEditarDetalleCompra.Click += btnEditarDetalleCompra_Click;
            // 
            // btnAgregarDetalleCompra
            // 
            btnAgregarDetalleCompra.Location = new Point(6, 268);
            btnAgregarDetalleCompra.Name = "btnAgregarDetalleCompra";
            btnAgregarDetalleCompra.Size = new Size(75, 23);
            btnAgregarDetalleCompra.TabIndex = 8;
            btnAgregarDetalleCompra.Text = "Agregar";
            btnAgregarDetalleCompra.UseVisualStyleBackColor = true;
            btnAgregarDetalleCompra.Click += btnAgregarDetalleCompra_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 195);
            label12.Name = "label12";
            label12.Size = new Size(82, 15);
            label12.TabIndex = 7;
            label12.Text = "PrecioUnitario";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 130);
            label11.Name = "label11";
            label11.Size = new Size(55, 15);
            label11.TabIndex = 6;
            label11.Text = "Cantidad";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 70);
            label10.Name = "label10";
            label10.Size = new Size(83, 15);
            label10.TabIndex = 5;
            label10.Text = "OrdenCompra";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 14);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 4;
            label9.Text = "Producto";
            // 
            // numPrecioUnitario
            // 
            numPrecioUnitario.Location = new Point(6, 213);
            numPrecioUnitario.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numPrecioUnitario.Name = "numPrecioUnitario";
            numPrecioUnitario.Size = new Size(120, 23);
            numPrecioUnitario.TabIndex = 3;
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(6, 148);
            numCantidad.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(120, 23);
            numCantidad.TabIndex = 2;
            // 
            // cmbOrdenCompra
            // 
            cmbOrdenCompra.FormattingEnabled = true;
            cmbOrdenCompra.Location = new Point(5, 88);
            cmbOrdenCompra.Name = "cmbOrdenCompra";
            cmbOrdenCompra.Size = new Size(145, 23);
            cmbOrdenCompra.TabIndex = 1;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(5, 32);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(145, 23);
            cmbProducto.TabIndex = 0;
            // 
            // FormComprasyProvedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormComprasyProvedores";
            Text = "FormComprasyProvedores";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).EndInit();
            panelProveedor.ResumeLayout(false);
            panelProveedor.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrdenCompra).EndInit();
            panelLOC.ResumeLayout(false);
            panelLOC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTotalOC).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetalleCompra).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPrecioUnitario).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvProveedor;
        private Panel panelProveedor;
        private Button btnEliminarProveedor;
        private Button btnActualizarProveedor;
        private Button btnEditarProveedor;
        private Button btnAgregarProveedor;
        private Label label5;
        private ComboBox cmbPais;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDireccionProveedor;
        private TextBox txtEmailProveedor;
        private TextBox txtTelefonoProveedor;
        private TextBox txtNombreProveedor;
        private DataGridView dgvOrdenCompra;
        private Panel panelLOC;
        private NumericUpDown numTotalOC;
        private ComboBox cmbProveedorOC;
        private DateTimePicker dtpFechaOC;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button btnAgregarOC;
        private Button btnEliminarOC;
        private Button btnActualizarOC;
        private Button btnEditarOC;
        private TabPage tabPage3;
        private DataGridView dgvDetalleCompra;
        private Panel panel1;
        private Button btnActualizarDetalleCompra;
        private Button btnEliminarDetalleCompra;
        private Button btnEditarDetalleCompra;
        private Button btnAgregarDetalleCompra;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private NumericUpDown numPrecioUnitario;
        private NumericUpDown numCantidad;
        private ComboBox cmbOrdenCompra;
        private ComboBox cmbProducto;
    }
}
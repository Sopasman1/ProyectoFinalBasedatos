namespace ProyectoFinalBasedatos
{
    partial class FormInventario
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
            dgvProductos = new DataGridView();
            panel1 = new Panel();
            btnActualizarProductos = new Button();
            btnEliminarProducto = new Button();
            button2 = new Button();
            btnAgregarProducto = new Button();
            label6 = new Label();
            cmbSubcategoria = new ComboBox();
            label5 = new Label();
            cmbMarca = new ComboBox();
            label4 = new Label();
            cmbCategoria = new ComboBox();
            numPrecioUnitario = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            txtDescripcionProducto = new TextBox();
            label1 = new Label();
            txtNombreProducto = new TextBox();
            tabPage2 = new TabPage();
            dgvCategorias = new DataGridView();
            panel2 = new Panel();
            btnCategoriaEliminar = new Button();
            label8 = new Label();
            label7 = new Label();
            btnCategoriaActualizar = new Button();
            btnCategoriaAgregar = new Button();
            txtCategoriaDescripcion = new TextBox();
            txtCategoriaNombre = new TextBox();
            tabPage3 = new TabPage();
            dgvSubcategorias = new DataGridView();
            panel3 = new Panel();
            btnSubEliminar = new Button();
            btnSubActualizar = new Button();
            btnSubAgregar = new Button();
            label10 = new Label();
            cmbSubCategoriaPadre = new ComboBox();
            label9 = new Label();
            txtSubNombre = new TextBox();
            tabPage4 = new TabPage();
            dgvMarca = new DataGridView();
            panel4 = new Panel();
            btnEliminarMarca = new Button();
            btnEditarMarca = new Button();
            btnAgregarMarca = new Button();
            label12 = new Label();
            txtPaisOrigen = new TextBox();
            label11 = new Label();
            txtNombreMarca = new TextBox();
            tabPage5 = new TabPage();
            dgvInventario = new DataGridView();
            panel5 = new Panel();
            btnEliminarInventario = new Button();
            btnEditarInventario = new Button();
            btnAgregarInventario = new Button();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            alm = new Label();
            numNivelMinimo = new NumericUpDown();
            numCantidadActual = new NumericUpDown();
            cmbProducto = new ComboBox();
            cmbAlmacen = new ComboBox();
            tabPage6 = new TabPage();
            dgvAuditoria = new DataGridView();
            panel6 = new Panel();
            label17 = new Label();
            label16 = new Label();
            btnActualizarAuditoria = new Button();
            btnEliminarAuditoria = new Button();
            btnEditarAuditoria = new Button();
            btnAgregarAuditoria = new Button();
            dtpFecha = new DateTimePicker();
            cmbEmpleado = new ComboBox();
            txtObservaciones = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPrecioUnitario).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            panel2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSubcategorias).BeginInit();
            panel3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMarca).BeginInit();
            panel4.SuspendLayout();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numNivelMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantidadActual).BeginInit();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuditoria).BeginInit();
            panel6.SuspendLayout();
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
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvProductos);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Producto";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(308, 6);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(478, 408);
            dgvProductos.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnActualizarProductos);
            panel1.Controls.Add(btnEliminarProducto);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnAgregarProducto);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cmbSubcategoria);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cmbMarca);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cmbCategoria);
            panel1.Controls.Add(numPrecioUnitario);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtDescripcionProducto);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtNombreProducto);
            panel1.Location = new Point(3, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 410);
            panel1.TabIndex = 0;
            // 
            // btnActualizarProductos
            // 
            btnActualizarProductos.Location = new Point(5, 358);
            btnActualizarProductos.Name = "btnActualizarProductos";
            btnActualizarProductos.Size = new Size(136, 23);
            btnActualizarProductos.TabIndex = 15;
            btnActualizarProductos.Text = "Actualizar";
            btnActualizarProductos.UseVisualStyleBackColor = true;
            btnActualizarProductos.Click += btnActualizarProductos_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(147, 358);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(136, 23);
            btnEliminarProducto.TabIndex = 14;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // button2
            // 
            button2.Location = new Point(147, 329);
            button2.Name = "button2";
            button2.Size = new Size(136, 23);
            button2.TabIndex = 13;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(147, 300);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(136, 23);
            btnAgregarProducto.TabIndex = 12;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 308);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 11;
            label6.Text = "SubCategoria";
            // 
            // cmbSubcategoria
            // 
            cmbSubcategoria.FormattingEnabled = true;
            cmbSubcategoria.Location = new Point(5, 329);
            cmbSubcategoria.Name = "cmbSubcategoria";
            cmbSubcategoria.Size = new Size(136, 23);
            cmbSubcategoria.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(147, 248);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 9;
            label5.Text = "Marca";
            // 
            // cmbMarca
            // 
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Location = new Point(147, 266);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(136, 23);
            cmbMarca.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 248);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 7;
            label4.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(5, 266);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(136, 23);
            cmbCategoria.TabIndex = 6;
            // 
            // numPrecioUnitario
            // 
            numPrecioUnitario.Location = new Point(5, 218);
            numPrecioUnitario.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPrecioUnitario.Name = "numPrecioUnitario";
            numPrecioUnitario.Size = new Size(120, 23);
            numPrecioUnitario.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 200);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 4;
            label3.Text = "PrecioUnitario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 85);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Descripcion";
            // 
            // txtDescripcionProducto
            // 
            txtDescripcionProducto.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcionProducto.Location = new Point(5, 103);
            txtDescripcionProducto.Multiline = true;
            txtDescripcionProducto.Name = "txtDescripcionProducto";
            txtDescripcionProducto.Size = new Size(192, 82);
            txtDescripcionProducto.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 30);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.BorderStyle = BorderStyle.FixedSingle;
            txtNombreProducto.Location = new Point(5, 48);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(192, 23);
            txtNombreProducto.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvCategorias);
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Categoria";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(206, 3);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.Size = new Size(583, 416);
            dgvCategorias.TabIndex = 1;
            dgvCategorias.CellClick += dgvCategorias_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCategoriaEliminar);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btnCategoriaActualizar);
            panel2.Controls.Add(btnCategoriaAgregar);
            panel2.Controls.Add(txtCategoriaDescripcion);
            panel2.Controls.Add(txtCategoriaNombre);
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 416);
            panel2.TabIndex = 0;
            // 
            // btnCategoriaEliminar
            // 
            btnCategoriaEliminar.Location = new Point(8, 287);
            btnCategoriaEliminar.Name = "btnCategoriaEliminar";
            btnCategoriaEliminar.Size = new Size(75, 23);
            btnCategoriaEliminar.TabIndex = 7;
            btnCategoriaEliminar.Text = "Eliminar";
            btnCategoriaEliminar.UseVisualStyleBackColor = true;
            btnCategoriaEliminar.Click += btnCategoriaEliminar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 75);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 6;
            label8.Text = "Descripcion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 25);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 5;
            label7.Text = "Nombre";
            // 
            // btnCategoriaActualizar
            // 
            btnCategoriaActualizar.Location = new Point(8, 242);
            btnCategoriaActualizar.Name = "btnCategoriaActualizar";
            btnCategoriaActualizar.Size = new Size(75, 23);
            btnCategoriaActualizar.TabIndex = 4;
            btnCategoriaActualizar.Text = "Actualizar";
            btnCategoriaActualizar.UseVisualStyleBackColor = true;
            btnCategoriaActualizar.Click += btnCategoriaActualizar_Click;
            // 
            // btnCategoriaAgregar
            // 
            btnCategoriaAgregar.Location = new Point(8, 200);
            btnCategoriaAgregar.Name = "btnCategoriaAgregar";
            btnCategoriaAgregar.Size = new Size(75, 23);
            btnCategoriaAgregar.TabIndex = 2;
            btnCategoriaAgregar.Text = "Agregar";
            btnCategoriaAgregar.UseVisualStyleBackColor = true;
            btnCategoriaAgregar.Click += btnCategoriaAgregar_Click;
            // 
            // txtCategoriaDescripcion
            // 
            txtCategoriaDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtCategoriaDescripcion.Location = new Point(8, 93);
            txtCategoriaDescripcion.Multiline = true;
            txtCategoriaDescripcion.Name = "txtCategoriaDescripcion";
            txtCategoriaDescripcion.Size = new Size(189, 75);
            txtCategoriaDescripcion.TabIndex = 1;
            // 
            // txtCategoriaNombre
            // 
            txtCategoriaNombre.BorderStyle = BorderStyle.FixedSingle;
            txtCategoriaNombre.Location = new Point(8, 43);
            txtCategoriaNombre.Name = "txtCategoriaNombre";
            txtCategoriaNombre.Size = new Size(189, 23);
            txtCategoriaNombre.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvSubcategorias);
            tabPage3.Controls.Add(panel3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(792, 422);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "SubCategria";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvSubcategorias
            // 
            dgvSubcategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubcategorias.Location = new Point(209, 3);
            dgvSubcategorias.Name = "dgvSubcategorias";
            dgvSubcategorias.Size = new Size(580, 416);
            dgvSubcategorias.TabIndex = 1;
            dgvSubcategorias.CellClick += dgvSubcategorias_CellClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSubEliminar);
            panel3.Controls.Add(btnSubActualizar);
            panel3.Controls.Add(btnSubAgregar);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(cmbSubCategoriaPadre);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(txtSubNombre);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 416);
            panel3.TabIndex = 0;
            // 
            // btnSubEliminar
            // 
            btnSubEliminar.Location = new Point(5, 215);
            btnSubEliminar.Name = "btnSubEliminar";
            btnSubEliminar.Size = new Size(75, 23);
            btnSubEliminar.TabIndex = 6;
            btnSubEliminar.Text = "Eliminar";
            btnSubEliminar.UseVisualStyleBackColor = true;
            btnSubEliminar.Click += btnSubEliminar_Click;
            // 
            // btnSubActualizar
            // 
            btnSubActualizar.Location = new Point(5, 185);
            btnSubActualizar.Name = "btnSubActualizar";
            btnSubActualizar.Size = new Size(75, 24);
            btnSubActualizar.TabIndex = 5;
            btnSubActualizar.Text = "Actualizar";
            btnSubActualizar.UseVisualStyleBackColor = true;
            btnSubActualizar.Click += btnSubActualizar_Click;
            // 
            // btnSubAgregar
            // 
            btnSubAgregar.Location = new Point(5, 156);
            btnSubAgregar.Name = "btnSubAgregar";
            btnSubAgregar.Size = new Size(75, 23);
            btnSubAgregar.TabIndex = 4;
            btnSubAgregar.Text = "Agregar";
            btnSubAgregar.UseVisualStyleBackColor = true;
            btnSubAgregar.Click += btnSubAgregar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(5, 86);
            label10.Name = "label10";
            label10.Size = new Size(157, 15);
            label10.TabIndex = 3;
            label10.Text = "Categoria a la que pertenece";
            // 
            // cmbSubCategoriaPadre
            // 
            cmbSubCategoriaPadre.FormattingEnabled = true;
            cmbSubCategoriaPadre.Location = new Point(5, 104);
            cmbSubCategoriaPadre.Name = "cmbSubCategoriaPadre";
            cmbSubCategoriaPadre.Size = new Size(192, 23);
            cmbSubCategoriaPadre.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 22);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 1;
            label9.Text = "Nombre";
            // 
            // txtSubNombre
            // 
            txtSubNombre.Location = new Point(5, 40);
            txtSubNombre.Name = "txtSubNombre";
            txtSubNombre.Size = new Size(192, 23);
            txtSubNombre.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dgvMarca);
            tabPage4.Controls.Add(panel4);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(792, 422);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Marca";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvMarca
            // 
            dgvMarca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMarca.Location = new Point(209, 3);
            dgvMarca.Name = "dgvMarca";
            dgvMarca.Size = new Size(580, 416);
            dgvMarca.TabIndex = 1;
            dgvMarca.CellClick += dgvMarca_CellClick;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnEliminarMarca);
            panel4.Controls.Add(btnEditarMarca);
            panel4.Controls.Add(btnAgregarMarca);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(txtPaisOrigen);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(txtNombreMarca);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 416);
            panel4.TabIndex = 0;
            // 
            // btnEliminarMarca
            // 
            btnEliminarMarca.Location = new Point(5, 244);
            btnEliminarMarca.Name = "btnEliminarMarca";
            btnEliminarMarca.Size = new Size(84, 25);
            btnEliminarMarca.TabIndex = 6;
            btnEliminarMarca.Text = "Eliminar";
            btnEliminarMarca.UseVisualStyleBackColor = true;
            btnEliminarMarca.Click += btnEliminarMarca_Click;
            // 
            // btnEditarMarca
            // 
            btnEditarMarca.Location = new Point(5, 203);
            btnEditarMarca.Name = "btnEditarMarca";
            btnEditarMarca.Size = new Size(84, 25);
            btnEditarMarca.TabIndex = 5;
            btnEditarMarca.Text = "Editar";
            btnEditarMarca.UseVisualStyleBackColor = true;
            btnEditarMarca.Click += btnEditarMarca_Click;
            // 
            // btnAgregarMarca
            // 
            btnAgregarMarca.Location = new Point(5, 160);
            btnAgregarMarca.Name = "btnAgregarMarca";
            btnAgregarMarca.Size = new Size(84, 25);
            btnAgregarMarca.TabIndex = 4;
            btnAgregarMarca.Text = "Agregar";
            btnAgregarMarca.UseVisualStyleBackColor = true;
            btnAgregarMarca.Click += btnAgregarMarca_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(5, 81);
            label12.Name = "label12";
            label12.Size = new Size(67, 15);
            label12.TabIndex = 3;
            label12.Text = "Pais Origen";
            // 
            // txtPaisOrigen
            // 
            txtPaisOrigen.Location = new Point(5, 99);
            txtPaisOrigen.Name = "txtPaisOrigen";
            txtPaisOrigen.Size = new Size(190, 23);
            txtPaisOrigen.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 17);
            label11.Name = "label11";
            label11.Size = new Size(51, 15);
            label11.TabIndex = 1;
            label11.Text = "Nombre";
            // 
            // txtNombreMarca
            // 
            txtNombreMarca.Location = new Point(3, 35);
            txtNombreMarca.Name = "txtNombreMarca";
            txtNombreMarca.Size = new Size(192, 23);
            txtNombreMarca.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(dgvInventario);
            tabPage5.Controls.Add(panel5);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(792, 422);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Inventario";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // dgvInventario
            // 
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new Point(209, 3);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.Size = new Size(580, 416);
            dgvInventario.TabIndex = 1;
            dgvInventario.CellClick += dgvInventario_CellClick;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnEliminarInventario);
            panel5.Controls.Add(btnEditarInventario);
            panel5.Controls.Add(btnAgregarInventario);
            panel5.Controls.Add(label15);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(alm);
            panel5.Controls.Add(numNivelMinimo);
            panel5.Controls.Add(numCantidadActual);
            panel5.Controls.Add(cmbProducto);
            panel5.Controls.Add(cmbAlmacen);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 416);
            panel5.TabIndex = 0;
            // 
            // btnEliminarInventario
            // 
            btnEliminarInventario.Location = new Point(9, 317);
            btnEliminarInventario.Name = "btnEliminarInventario";
            btnEliminarInventario.Size = new Size(72, 24);
            btnEliminarInventario.TabIndex = 10;
            btnEliminarInventario.Text = "Eliminar";
            btnEliminarInventario.UseVisualStyleBackColor = true;
            btnEliminarInventario.Click += btnEliminarInventario_Click;
            // 
            // btnEditarInventario
            // 
            btnEditarInventario.Location = new Point(6, 288);
            btnEditarInventario.Name = "btnEditarInventario";
            btnEditarInventario.Size = new Size(75, 23);
            btnEditarInventario.TabIndex = 9;
            btnEditarInventario.Text = "Editar";
            btnEditarInventario.UseVisualStyleBackColor = true;
            btnEditarInventario.Click += btnEditarInventario_Click;
            // 
            // btnAgregarInventario
            // 
            btnAgregarInventario.Location = new Point(6, 259);
            btnAgregarInventario.Name = "btnAgregarInventario";
            btnAgregarInventario.Size = new Size(75, 23);
            btnAgregarInventario.TabIndex = 8;
            btnAgregarInventario.Text = "Agregar";
            btnAgregarInventario.UseVisualStyleBackColor = true;
            btnAgregarInventario.Click += btnAgregarInventario_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 194);
            label15.Name = "label15";
            label15.Size = new Size(79, 15);
            label15.TabIndex = 7;
            label15.Text = "Nivel Minimo";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 139);
            label14.Name = "label14";
            label14.Size = new Size(92, 15);
            label14.TabIndex = 6;
            label14.Text = "Cantidad Actual";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 80);
            label13.Name = "label13";
            label13.Size = new Size(56, 15);
            label13.TabIndex = 5;
            label13.Text = "Producto";
            // 
            // alm
            // 
            alm.AutoSize = true;
            alm.Location = new Point(6, 27);
            alm.Name = "alm";
            alm.Size = new Size(54, 15);
            alm.TabIndex = 4;
            alm.Text = "Almacen";
            // 
            // numNivelMinimo
            // 
            numNivelMinimo.Location = new Point(6, 212);
            numNivelMinimo.Name = "numNivelMinimo";
            numNivelMinimo.Size = new Size(120, 23);
            numNivelMinimo.TabIndex = 3;
            // 
            // numCantidadActual
            // 
            numCantidadActual.Location = new Point(6, 157);
            numCantidadActual.Name = "numCantidadActual";
            numCantidadActual.Size = new Size(120, 23);
            numCantidadActual.TabIndex = 2;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(5, 98);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(121, 23);
            cmbProducto.TabIndex = 1;
            // 
            // cmbAlmacen
            // 
            cmbAlmacen.FormattingEnabled = true;
            cmbAlmacen.Location = new Point(5, 45);
            cmbAlmacen.Name = "cmbAlmacen";
            cmbAlmacen.Size = new Size(121, 23);
            cmbAlmacen.TabIndex = 0;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(dgvAuditoria);
            tabPage6.Controls.Add(panel6);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(792, 422);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Auditoria";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // dgvAuditoria
            // 
            dgvAuditoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuditoria.Location = new Point(209, 3);
            dgvAuditoria.Name = "dgvAuditoria";
            dgvAuditoria.Size = new Size(575, 416);
            dgvAuditoria.TabIndex = 1;
            dgvAuditoria.CellClick += dgvAuditoria_CellClick;
            // 
            // panel6
            // 
            panel6.Controls.Add(label17);
            panel6.Controls.Add(label16);
            panel6.Controls.Add(btnActualizarAuditoria);
            panel6.Controls.Add(btnEliminarAuditoria);
            panel6.Controls.Add(btnEditarAuditoria);
            panel6.Controls.Add(btnAgregarAuditoria);
            panel6.Controls.Add(dtpFecha);
            panel6.Controls.Add(cmbEmpleado);
            panel6.Controls.Add(txtObservaciones);
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 416);
            panel6.TabIndex = 0;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(5, 141);
            label17.Name = "label17";
            label17.Size = new Size(60, 15);
            label17.TabIndex = 10;
            label17.Text = "Empleado";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(5, 37);
            label16.Name = "label16";
            label16.Size = new Size(84, 15);
            label16.TabIndex = 9;
            label16.Text = "Observaciones";
            // 
            // btnActualizarAuditoria
            // 
            btnActualizarAuditoria.Location = new Point(5, 345);
            btnActualizarAuditoria.Name = "btnActualizarAuditoria";
            btnActualizarAuditoria.Size = new Size(83, 25);
            btnActualizarAuditoria.TabIndex = 8;
            btnActualizarAuditoria.Text = "Actualizar";
            btnActualizarAuditoria.UseVisualStyleBackColor = true;
            btnActualizarAuditoria.Click += btnActualizarAuditoria_Click;
            // 
            // btnEliminarAuditoria
            // 
            btnEliminarAuditoria.Location = new Point(5, 314);
            btnEliminarAuditoria.Name = "btnEliminarAuditoria";
            btnEliminarAuditoria.Size = new Size(83, 25);
            btnEliminarAuditoria.TabIndex = 7;
            btnEliminarAuditoria.Text = "Eliminar";
            btnEliminarAuditoria.UseVisualStyleBackColor = true;
            btnEliminarAuditoria.Click += btnEliminarAuditoria_Click;
            // 
            // btnEditarAuditoria
            // 
            btnEditarAuditoria.Location = new Point(5, 283);
            btnEditarAuditoria.Name = "btnEditarAuditoria";
            btnEditarAuditoria.Size = new Size(83, 25);
            btnEditarAuditoria.TabIndex = 6;
            btnEditarAuditoria.Text = "Editar";
            btnEditarAuditoria.UseVisualStyleBackColor = true;
            btnEditarAuditoria.Click += btnEditarAuditoria_Click;
            // 
            // btnAgregarAuditoria
            // 
            btnAgregarAuditoria.Location = new Point(5, 252);
            btnAgregarAuditoria.Name = "btnAgregarAuditoria";
            btnAgregarAuditoria.Size = new Size(83, 25);
            btnAgregarAuditoria.TabIndex = 5;
            btnAgregarAuditoria.Text = "Agregar";
            btnAgregarAuditoria.UseVisualStyleBackColor = true;
            btnAgregarAuditoria.Click += btnAgregarAuditoria_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(5, 201);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(192, 23);
            dtpFecha.TabIndex = 4;
            // 
            // cmbEmpleado
            // 
            cmbEmpleado.FormattingEnabled = true;
            cmbEmpleado.Location = new Point(3, 159);
            cmbEmpleado.Name = "cmbEmpleado";
            cmbEmpleado.Size = new Size(192, 23);
            cmbEmpleado.TabIndex = 3;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(5, 55);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(192, 52);
            txtObservaciones.TabIndex = 2;
            // 
            // FormInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormInventario";
            Text = "FormInventario";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPrecioUnitario).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSubcategorias).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMarca).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numNivelMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCantidadActual).EndInit();
            tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAuditoria).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvProductos;
        private Panel panel1;
        private NumericUpDown numPrecioUnitario;
        private Label label3;
        private Label label2;
        private TextBox txtDescripcionProducto;
        private Label label1;
        private TextBox txtNombreProducto;
        private Button button2;
        private Button btnAgregarProducto;
        private Label label6;
        private ComboBox cmbMarca;
        private Label label5;
        private ComboBox cmbSubcategoria;
        private Label label4;
        private ComboBox cmbCategoria;
        private Button btnActualizarProductos;
        private Button btnEliminarProducto;
        private DataGridView dgvCategorias;
        private Panel panel2;
        private Button btnCategoriaActualizar;
        private Button btnCategoriaAgregar;
        private TextBox txtCategoriaDescripcion;
        private TextBox txtCategoriaNombre;
        private Button btnCategoriaEliminar;
        private Label label8;
        private Label label7;
        private TabPage tabPage3;
        private DataGridView dgvSubcategorias;
        private Panel panel3;
        private Label label9;
        private TextBox txtSubNombre;
        private Label label10;
        private ComboBox cmbSubCategoriaPadre;
        private Button btnSubEliminar;
        private Button btnSubActualizar;
        private Button btnSubAgregar;
        private TabPage tabPage4;
        private DataGridView dgvMarca;
        private Panel panel4;
        private Label label11;
        private TextBox txtNombreMarca;
        private Label label12;
        private TextBox txtPaisOrigen;
        private Button btnEliminarMarca;
        private Button btnEditarMarca;
        private Button btnAgregarMarca;
        private TabPage tabPage5;
        private DataGridView dgvInventario;
        private Panel panel5;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label alm;
        private NumericUpDown numNivelMinimo;
        private NumericUpDown numCantidadActual;
        private ComboBox cmbProducto;
        private ComboBox cmbAlmacen;
        private Button btnEliminarInventario;
        private Button btnEditarInventario;
        private Button btnAgregarInventario;
        private TabPage tabPage6;
        private Panel panel6;
        private DataGridView dgvAuditoria;
        private Button btnAgregarAuditoria;
        private DateTimePicker dtpFecha;
        private ComboBox cmbEmpleado;
        private TextBox txtObservaciones;
        private Button btnActualizarAuditoria;
        private Button btnEliminarAuditoria;
        private Button btnEditarAuditoria;
        private Label label17;
        private Label label16;
    }
}
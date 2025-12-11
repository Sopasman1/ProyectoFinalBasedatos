using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace ProyectoFinalBasedatos
{
    public partial class FormInventario : Form
    {
        private int usuarioAccionID;
        public FormInventario(int idUsuarioAccion)
        {
            InitializeComponent();
            CargarProductos();
            CargarCombosProducto();
            CargarCategoriasTabla();
            CargarSubcategoriasTabla();
            CargarCategoriasEnComboSub();
            CargarAlmacenes();
            CargarInventario();
            CargarProductosInventario();
            CargarAuditoria();
            CargarEmpleados();
            CargarMarcas();
            usuarioAccionID = idUsuarioAccion;

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "Productos")
            {
                CargarProductos();
                CargarCombosProducto();
            }
        }

        private void CargarProductos()
        {
            try
            {
                using (var con = DB.GetConnection())
                {
                    con.Open();

                    string query = @"SELECT p.id_producto, p.nombre, p.descripcion, p.preciounitario,
                       c.nombre AS categoria,
                       s.nombre AS subcategoria,
                       m.nombre AS marca,
                       p.usuariocrea, p.usuariomodifica, p.usuarioelimina,
                       p.fechacrea, p.fechamodifica, p.fechaelimina
                FROM producto p
                LEFT JOIN categoria c ON p.id_categoria = c.id_categoria
                LEFT JOIN subcategoria s ON p.id_subcategoria = s.id_subcategoria
                LEFT JOIN marca m ON p.id_marca = m.id_marca
                WHERE p.fechaelimina IS NULL";

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvProductos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void CargarCombosProducto()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();

                // Categoría
                NpgsqlDataAdapter daCat = new NpgsqlDataAdapter(
                    "SELECT id_categoria, nombre FROM categoria", con);
                DataTable dtCat = new DataTable();
                daCat.Fill(dtCat);
                cmbCategoria.DataSource = dtCat;
                cmbCategoria.DisplayMember = "nombre";
                cmbCategoria.ValueMember = "id_categoria";

                // Subcategoría
                NpgsqlDataAdapter daSub = new NpgsqlDataAdapter(
                    "SELECT id_subcategoria, nombre FROM subcategoria", con);
                DataTable dtSub = new DataTable();
                daSub.Fill(dtSub);
                cmbSubcategoria.DataSource = dtSub;
                cmbSubcategoria.DisplayMember = "nombre";
                cmbSubcategoria.ValueMember = "id_subcategoria";

                // Marca
                NpgsqlDataAdapter daMarca = new NpgsqlDataAdapter(
                    "SELECT id_marca, nombre FROM marca", con);
                DataTable dtMarca = new DataTable();
                daMarca.Fill(dtMarca);
                cmbMarca.DataSource = dtMarca;
                cmbMarca.DisplayMember = "nombre";
                cmbMarca.ValueMember = "id_marca";
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                using (var con = DB.GetConnection())
                {
                    con.Open();

                    string query = @"INSERT INTO producto
                (nombre, descripcion, preciounitario, id_categoria, id_subcategoria, id_marca,
                 usuariocrea, fechacrea)
                VALUES
                (@n, @d, @p, @cat, @sub, @mar, @usuario, NOW())";

                    using (var cmd = new NpgsqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@n", txtNombreProducto.Text);
                        cmd.Parameters.AddWithValue("@d", txtDescripcionProducto.Text);
                        cmd.Parameters.AddWithValue("@p", numPrecioUnitario.Value);
                        cmd.Parameters.AddWithValue("@cat", cmbCategoria.SelectedValue);
                        cmd.Parameters.AddWithValue("@sub", cmbSubcategoria.SelectedValue);
                        cmd.Parameters.AddWithValue("@mar", cmbMarca.SelectedValue);
                        cmd.Parameters.AddWithValue("@usuario", usuarioAccionID);

                        cmd.ExecuteNonQuery();
                    }
                }

                CargarProductos();
                LimpiarCamposProducto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un producto.");
                return;
            }

            DataGridViewRow row = dgvProductos.SelectedRows[0];

            txtNombreProducto.Text = row.Cells["nombre"].Value.ToString();
            txtDescripcionProducto.Text = row.Cells["descripcion"].Value.ToString();
            numPrecioUnitario.Value = Convert.ToDecimal(row.Cells["preciounitario"].Value);

            // Importante: usar SelectedValue, NO Text
            cmbCategoria.SelectedValue = ObtenerID("categoria", row.Cells["categoria"].Value.ToString());
            cmbSubcategoria.SelectedValue = ObtenerID("subcategoria", row.Cells["subcategoria"].Value.ToString());
            cmbMarca.SelectedValue = ObtenerID("marca", row.Cells["marca"].Value.ToString());

            txtNombreProducto.Tag = row.Cells["id_producto"].Value;
        }

        private int ObtenerID(string tabla, string nombre)
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                using (var cmd = new NpgsqlCommand($"SELECT id_{tabla} FROM {tabla} WHERE nombre=@n", con))
                {
                    cmd.Parameters.AddWithValue("@n", nombre);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        private void btnActualizarProductos_Click(object sender, EventArgs e)
        {

            if (txtNombreProducto.Tag == null)
            {
                MessageBox.Show("Primero seleccione un producto con Editar.");
                return;
            }

            int id = (int)txtNombreProducto.Tag;

            try
            {
                using (var con = DB.GetConnection())
                {
                    con.Open();

                    string query = @"
                UPDATE producto
                SET nombre=@n, descripcion=@d, preciounitario=@p,
                    id_categoria=@cat, id_subcategoria=@sub, id_marca=@mar,
                    usuariomodifica=@usuario, fechamodifica=NOW()
                WHERE id_producto=@id";

                    using (var cmd = new NpgsqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@n", txtNombreProducto.Text);
                        cmd.Parameters.AddWithValue("@d", txtDescripcionProducto.Text);
                        cmd.Parameters.AddWithValue("@p", numPrecioUnitario.Value);
                        cmd.Parameters.AddWithValue("@cat", cmbCategoria.SelectedValue);
                        cmd.Parameters.AddWithValue("@sub", cmbSubcategoria.SelectedValue);
                        cmd.Parameters.AddWithValue("@mar", cmbMarca.SelectedValue);
                        cmd.Parameters.AddWithValue("@usuario", usuarioAccionID);
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                    }
                }

                CargarProductos();
                LimpiarCamposProducto();
                txtNombreProducto.Tag = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar producto: " + ex.Message);
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un producto.");
                return;
            }

            int id = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells["id_producto"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
            UPDATE producto
            SET usuarioelimina=@usuario, fechaelimina=NOW()
            WHERE id_producto=@id";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuarioAccionID);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            CargarProductos();
        }

        private void LimpiarCamposProducto()
        {
            txtNombreProducto.Text = "";
            txtDescripcionProducto.Text = "";
            numPrecioUnitario.Value = 0;
            cmbCategoria.SelectedIndex = 0;
            cmbSubcategoria.SelectedIndex = 0;
            cmbMarca.SelectedIndex = 0;
            txtNombreProducto.Tag = null;
        }

        private void CargarCategoriasTabla()
        {
            try
            {
                using (var con = DB.GetConnection())
                {
                    con.Open();
                    string query = "SELECT id_categoria, nombre, descripcion FROM categoria ORDER BY id_categoria ASC";

                    using (var da = new NpgsqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvCategorias.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando categorías: " + ex.Message);
            }
        }

        private void btnCategoriaAgregar_Click(object sender, EventArgs e)
        {
            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
        INSERT INTO categoria (nombre, descripcion, usuariocrea, fechacrea)
        VALUES (@n, @d, @uc, NOW())";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@n", txtCategoriaNombre.Text);
                    cmd.Parameters.AddWithValue("@d", txtCategoriaDescripcion.Text);
                    cmd.Parameters.AddWithValue("@uc", usuarioAccionID);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Categoría agregada.");
            CargarCategoriasTabla();
        }



        private void btnCategoriaEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila.");
                return;
            }

            int id = Convert.ToInt32(dgvCategorias.SelectedRows[0].Cells["id_categoria"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
        UPDATE categoria
        SET usuarioelimina=@ue, fechaelimina=NOW()
        WHERE id_categoria=@id";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ue", usuarioAccionID);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Categoría eliminada (borrado lógico).");
            CargarCategoriasTabla();
        }

        private void btnCategoriaActualizar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila.");
                return;
            }

            int id = Convert.ToInt32(dgvCategorias.SelectedRows[0].Cells["id_categoria"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
        UPDATE categoria 
        SET nombre=@n, descripcion=@d, 
            usuariomodifica=@um, fechamodifica=NOW()
        WHERE id_categoria=@id";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@n", txtCategoriaNombre.Text);
                    cmd.Parameters.AddWithValue("@d", txtCategoriaDescripcion.Text);
                    cmd.Parameters.AddWithValue("@um", usuarioAccionID);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Categoría actualizada.");
            CargarCategoriasTabla();
        }

        private void LimpiarCamposCategoria()
        {
            txtCategoriaNombre.Clear();
            txtCategoriaDescripcion.Clear();
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtCategoriaNombre.Text = dgvCategorias.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            txtCategoriaDescripcion.Text = dgvCategorias.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();
        }

        private void CargarSubcategoriasTabla()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
    SELECT 
s.id_subcategoria, 
s.nombre, 
c.nombre AS categoria,
s.usuariocrea, s.usuariomodifica, s.usuarioelimina,
s.fechacrea, s.fechamodifica, s.fechaelimina
FROM subcategoria s
INNER JOIN categoria c ON c.id_categoria = s.id_categoria
ORDER BY s.id_subcategoria";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvSubcategorias.DataSource = dt;
                }
            }
        }

        private void CargarCategoriasEnComboSub()
        {
            try
            {
                using (var con = DB.GetConnection())
                {
                    con.Open();
                    string query = "SELECT id_categoria, nombre FROM categoria ORDER BY nombre";

                    using (var da = new NpgsqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cmbSubCategoriaPadre.DataSource = dt;
                        cmbSubCategoriaPadre.DisplayMember = "nombre";
                        cmbSubCategoriaPadre.ValueMember = "id_categoria";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando categorías en subcategorías: " + ex.Message);
            }
        }


        private int idSubSeleccionada = 0;
        private void dgvSubcategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idSubSeleccionada = Convert.ToInt32(dgvSubcategorias.CurrentRow.Cells["id_subcategoria"].Value);
                txtSubNombre.Text = dgvSubcategorias.CurrentRow.Cells["nombre"].Value.ToString();

                cmbSubCategoriaPadre.Text = dgvSubcategorias.CurrentRow.Cells["categoria"].Value.ToString();
            }
        }

        private void btnSubAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtSubNombre.Text.Trim();
            int idCategoria = (int)cmbSubCategoriaPadre.SelectedValue;

            if (nombre == "")
            {
                MessageBox.Show("El nombre es obligatorio.");
                return;
            }

            try
            {
                using (var con = DB.GetConnection())
                {
                    con.Open();
                    string query = @"
            INSERT INTO subcategoria (nombre, id_categoria, usuariocrea, fechacrea)
            VALUES (@n, @c, @uc, NOW())";

                    using (var cmd = new NpgsqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@n", nombre);
                        cmd.Parameters.AddWithValue("@c", idCategoria);
                        cmd.Parameters.AddWithValue("@uc", usuarioAccionID);
                        cmd.ExecuteNonQuery();
                    }
                }

                CargarSubcategoriasTabla();
                MessageBox.Show("Subcategoría agregada.");
                txtSubNombre.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }

        private void btnSubActualizar_Click(object sender, EventArgs e)
        {
            if (idSubSeleccionada == 0)
            {
                MessageBox.Show("Selecciona una subcategoría.");
                return;
            }

            string nombre = txtSubNombre.Text.Trim();
            int idCat = (int)cmbSubCategoriaPadre.SelectedValue;

            try
            {
                using (var con = DB.GetConnection())
                {
                    con.Open();
                    string query = @"
            UPDATE subcategoria
            SET nombre=@n, id_categoria=@c,
                usuariomodifica=@um, fechamodifica=NOW()
            WHERE id_subcategoria=@id";

                    using (var cmd = new NpgsqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@n", nombre);
                        cmd.Parameters.AddWithValue("@c", idCat);
                        cmd.Parameters.AddWithValue("@um", usuarioAccionID);
                        cmd.Parameters.AddWithValue("@id", idSubSeleccionada);
                        cmd.ExecuteNonQuery();
                    }
                }

                CargarSubcategoriasTabla();
                MessageBox.Show("Subcategoría actualizada.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void btnSubEliminar_Click(object sender, EventArgs e)
        {
            if (idSubSeleccionada == 0)
            {
                MessageBox.Show("Selecciona una subcategoría para eliminar.");
                return;
            }

            try
            {
                using (var con = DB.GetConnection())
                {
                    con.Open();
                    string query = @"
            UPDATE subcategoria
            SET usuarioelimina=@ue, fechaelimina=NOW()
            WHERE id_subcategoria=@id";

                    using (var cmd = new NpgsqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ue", usuarioAccionID);
                        cmd.Parameters.AddWithValue("@id", idSubSeleccionada);
                        cmd.ExecuteNonQuery();
                    }
                }

                CargarSubcategoriasTabla();
                MessageBox.Show("Subcategoría eliminada (borrado lógico).");
                idSubSeleccionada = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }

        }

        private void CargarMarcas()
        {
            try
            {
                using (var con = DB.GetConnection())
                {
                    con.Open();

                    string query = @"
                SELECT 
                    m.id_marca,
                    m.nombre,
                    m.paisorigen,
                    m.usuariocrea,
                    m.usuariomodifica,
                    m.usuarioelimina,
                    m.fechacrea,
                    m.fechamodifica,
                    m.fechaelimina
                FROM marca m
                WHERE m.fechaelimina IS NULL
                ORDER BY m.id_marca";

                    using (var da = new NpgsqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvMarca.AutoGenerateColumns = true;
                        dgvMarca.DataSource = dt;
                    }
                }

                // Ocultar columnas internas si existen
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar marcas: " + ex.Message);
            }
        }

        private void dgvMarca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNombreMarca.Text = dgvMarca.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                txtPaisOrigen.Text = dgvMarca.Rows[e.RowIndex].Cells["paisorigen"].Value.ToString();
            }
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreMarca.Text.Trim();
            string pais = txtPaisOrigen.Text.Trim();

            if (nombre == "" || pais == "")
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
            INSERT INTO marca (nombre, paisorigen, usuariocrea, fechacrea)
            VALUES (@n, @p, @u, NOW())";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@n", nombre);
                    cmd.Parameters.AddWithValue("@p", pais);
                    cmd.Parameters.AddWithValue("@u", usuarioAccionID);
                    cmd.ExecuteNonQuery();
                }
            }

            CargarMarcas();
            LimpiarCamposMarca();
        }

        private void btnEditarMarca_Click(object sender, EventArgs e)
        {
            if (dgvMarca.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una marca para editar.");
                return;
            }

            int id = Convert.ToInt32(dgvMarca.SelectedRows[0].Cells["id_marca"].Value);
            string nombre = txtNombreMarca.Text.Trim();
            string pais = txtPaisOrigen.Text.Trim();

            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
            UPDATE marca
            SET nombre=@n,
                paisorigen=@p,
                usuariomodifica=@u,
                fechamodifica=NOW()
            WHERE id_marca=@id";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@n", nombre);
                    cmd.Parameters.AddWithValue("@p", pais);
                    cmd.Parameters.AddWithValue("@u", usuarioAccionID);
                    cmd.ExecuteNonQuery();
                }
            }

            CargarMarcas();
            LimpiarCamposMarca();

        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            if (dgvMarca.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una marca para eliminar.");
                return;
            }

            int id = Convert.ToInt32(dgvMarca.SelectedRows[0].Cells["id_marca"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
            UPDATE marca 
            SET usuarioelimina=@u,
                fechaelimina=NOW()
            WHERE id_marca=@id";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@u", usuarioAccionID);
                    cmd.ExecuteNonQuery();
                }
            }

            CargarMarcas();
            LimpiarCamposMarca();
        }

        private void LimpiarCamposMarca()
        {
            txtNombreMarca.Clear();
            txtPaisOrigen.Clear();
        }

        private void CargarInventario()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query =
                @"SELECT i.id_inventario, 
                 a.nombre AS almacen,
                 p.nombre AS producto,
                 i.cantidadactual,
                 i.nivelminimo,
                 i.id_almacen,
                 i.id_producto,
                 i.usuariocrea,
                 i.usuariomodifica,
                 i.usuarioelimina,
                 i.fechacrea,
                 i.fechamodifica,
                 i.fechaelimina
          FROM inventario i
          INNER JOIN almacen a ON a.id_almacen = i.id_almacen
          INNER JOIN producto p ON p.id_producto = i.id_producto
          WHERE i.fechaelimina IS NULL
          ORDER BY id_inventario";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvInventario.DataSource = dt;
                }
            }

        }

        private void CargarAlmacenes()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = "SELECT id_almacen, nombre FROM almacen ORDER BY nombre";
                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbAlmacen.DataSource = dt;
                    cmbAlmacen.DisplayMember = "nombre";
                    cmbAlmacen.ValueMember = "id_almacen";
                }
            }
        }

        private void CargarProductosInventario()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = "SELECT id_producto, nombre FROM producto ORDER BY nombre";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbProducto.DataSource = dt;
                    cmbProducto.DisplayMember = "nombre";
                    cmbProducto.ValueMember = "id_producto";
                }
            }
        }

        private void btnAgregarInventario_Click(object sender, EventArgs e)
        {

            int idAlmacen = Convert.ToInt32(cmbAlmacen.SelectedValue);
            int idProducto = Convert.ToInt32(cmbProducto.SelectedValue);
            int cantidad = (int)numCantidadActual.Value;
            int nivelMinimo = (int)numNivelMinimo.Value;

            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"INSERT INTO inventario
                         (id_almacen, id_producto, cantidadactual, nivelminimo,
                          usuariocrea, fechacrea)
                         VALUES (@a, @p, @c, @n, @u, NOW())";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@a", idAlmacen);
                    cmd.Parameters.AddWithValue("@p", idProducto);
                    cmd.Parameters.AddWithValue("@c", cantidad);
                    cmd.Parameters.AddWithValue("@n", nivelMinimo);
                    cmd.Parameters.AddWithValue("@u", usuarioAccionID);
                    cmd.ExecuteNonQuery();
                }
            }

            CargarInventario();
            LimpiarInventario();
        }

        private void btnEditarInventario_Click(object sender, EventArgs e)
        {
            if (dgvInventario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un registro para editar.");
                return;
            }

            int id = Convert.ToInt32(dgvInventario.SelectedRows[0].Cells["id_inventario"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();
                string query =
                @"UPDATE inventario SET
                id_almacen=@a,
                id_producto=@p,
                cantidadactual=@c,
                nivelminimo=@n,
                usuariomodifica=@u,
                fechamodifica=NOW()
          WHERE id_inventario=@id";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@a", Convert.ToInt32(cmbAlmacen.SelectedValue));
                    cmd.Parameters.AddWithValue("@p", Convert.ToInt32(cmbProducto.SelectedValue));
                    cmd.Parameters.AddWithValue("@c", (int)numCantidadActual.Value);
                    cmd.Parameters.AddWithValue("@n", (int)numNivelMinimo.Value);
                    cmd.Parameters.AddWithValue("@u", usuarioAccionID);
                    cmd.ExecuteNonQuery();
                }
            }

            CargarInventario();
            LimpiarInventario();
        }

        private void btnEliminarInventario_Click(object sender, EventArgs e)
        {
            if (dgvInventario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un registro para eliminar.");
                return;
            }

            int id = Convert.ToInt32(dgvInventario.SelectedRows[0].Cells["id_inventario"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();
                string query =
                @"UPDATE inventario SET 
              usuarioelimina=@u,
              fechaelimina=NOW()
          WHERE id_inventario=@id";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@u", usuarioAccionID);
                    cmd.ExecuteNonQuery();
                }
            }

            CargarInventario();
            LimpiarInventario();

        }

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cmbAlmacen.SelectedValue = dgvInventario.Rows[e.RowIndex].Cells["id_almacen"].Value;
                cmbProducto.SelectedValue = dgvInventario.Rows[e.RowIndex].Cells["id_producto"].Value;

                numCantidadActual.Value =
                    Convert.ToInt32(dgvInventario.Rows[e.RowIndex].Cells["cantidadactual"].Value);

                numNivelMinimo.Value =
                    Convert.ToInt32(dgvInventario.Rows[e.RowIndex].Cells["nivelminimo"].Value);
            }
        }

        private void LimpiarInventario()
        {
            numCantidadActual.Value = 0;
            numNivelMinimo.Value = 0;
        }

        private void CargarAuditoria()
        {
            try
            {
                using (var con = DB.GetConnection())
                {
                    con.Open();

                    string query = @"
                SELECT a.id_auditoria, 
                       e.nombre AS empleado,
                       a.fecha, 
                       a.observaciones,
                       a.usuariocrea, a.usuariomodifica, a.usuarioelimina,
                       a.fechacrea, a.fechamodifica, a.fechaelimina
                FROM AuditoriaInventario a
                LEFT JOIN Empleado e ON e.id_empleado = a.id_empleado
                WHERE a.fechaelimina IS NULL";

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvAuditoria.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar auditoría: " + ex.Message);
            }
        }

        private void CargarEmpleados()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = "SELECT id_empleado, nombre || ' ' || apellido AS empleado FROM Empleado ORDER BY nombre";

                using (var cmd = new NpgsqlCommand(query, con))
                using (var reader = cmd.ExecuteReader())
                {
                    List<KeyValuePair<int, string>> empleados = new List<KeyValuePair<int, string>>();

                    while (reader.Read())
                    {
                        empleados.Add(new KeyValuePair<int, string>(
                            reader.GetInt32(0),
                            reader.GetString(1)
                        ));
                    }

                    cmbEmpleado.DataSource = empleados;
                    cmbEmpleado.DisplayMember = "Value";
                    cmbEmpleado.ValueMember = "Key";
                }
            }
        }

        private void btnAgregarAuditoria_Click(object sender, EventArgs e)
        {
            try
            {
                using (var con = DB.GetConnection())
                {
                    con.Open();

                    string query = @"
                INSERT INTO AuditoriaInventario
                (id_empleado, fecha, observaciones, usuariocrea, fechacrea)
                VALUES
                (@empleado, @fecha, @obs, @usuario, NOW())";

                    using (var cmd = new NpgsqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@empleado", (int)cmbEmpleado.SelectedValue);
                        cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value.Date);
                        cmd.Parameters.AddWithValue("@obs", txtObservaciones.Text);
                        cmd.Parameters.AddWithValue("@usuario", usuarioAccionID);

                        cmd.ExecuteNonQuery();
                    }
                }

                CargarAuditoria();
                LimpiarAuditoria();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar auditoría: " + ex.Message);
            }
        }

        private void btnEditarAuditoria_Click(object sender, EventArgs e)
        {
            if (dgvAuditoria.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un registro.");
                return;
            }

            // Verificar si se ha seleccionado un empleado
            if (cmbEmpleado.SelectedValue == null)
            {
                MessageBox.Show("Selecciona un empleado.");
                return;
            }

            int id = Convert.ToInt32(dgvAuditoria.CurrentRow.Cells["id_auditoria"].Value);

            try
            {
                using (var con = DB.GetConnection())
                {
                    con.Open();

                    string query = @"
          UPDATE AuditoriaInventario
          SET id_empleado=@emp, fecha=@fecha, observaciones=@obs,
              usuariomodifica=@usuario, fechamodifica=NOW()
          WHERE id_auditoria=@id";

                    using (var cmd = new NpgsqlCommand(query, con))
                    {
                        // Asegurarse de que cmbEmpleado.SelectedValue no sea null
                        cmd.Parameters.AddWithValue("@emp", (int)cmbEmpleado.SelectedValue);
                        cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value.Date);
                        cmd.Parameters.AddWithValue("@obs", txtObservaciones.Text);
                        cmd.Parameters.AddWithValue("@usuario", usuarioAccionID);
                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                    }
                }

                CargarAuditoria();
                LimpiarAuditoria();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar auditoría: " + ex.Message);
            }
        }

        private void btnEliminarAuditoria_Click(object sender, EventArgs e)
        {
            if (dgvAuditoria.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un registro.");
                return;
            }

            int id = Convert.ToInt32(dgvAuditoria.CurrentRow.Cells["id_auditoria"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
            UPDATE AuditoriaInventario
            SET usuarioelimina=@usuario, fechaelimina=NOW()
            WHERE id_auditoria=@id";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuarioAccionID);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            CargarAuditoria();
            LimpiarAuditoria();
        }

        private void btnActualizarAuditoria_Click(object sender, EventArgs e)
        {
            CargarAuditoria();   // 🔄 Refrescar tabla
            LimpiarAuditoria();  // 🧹 Limpiar campos
        }

        private void dgvAuditoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            cmbEmpleado.Text =
                dgvAuditoria.Rows[e.RowIndex].Cells["empleado"].Value.ToString();


            txtObservaciones.Text =
                dgvAuditoria.Rows[e.RowIndex].Cells["observaciones"].Value.ToString();
        }

        private void LimpiarAuditoria()
        {
            cmbEmpleado.SelectedIndex = -1;
            txtObservaciones.Clear();
            dtpFecha.Value = DateTime.Now;
        }
    }
}

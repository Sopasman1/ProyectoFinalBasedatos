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
    public partial class FormComprasyProvedores : Form
    {
        private int usuarioAccionID;
        public FormComprasyProvedores(int idUsuarioAccion)
        {
            InitializeComponent();
            CargarPaises();
            CargarProveedores();
            CargarProveedoresOC();
            CargarOrdenesCompra();
            CargarDetalleCompra();
            CargarProductos();
            usuarioAccionID = idUsuarioAccion;
        }

        private void CargarPaises()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = "SELECT id_pais, nombre FROM pais ORDER BY nombre";

                using (var cmd = new NpgsqlCommand(query, con))
                using (var dr = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);

                    cmbPais.DataSource = dt;
                    cmbPais.DisplayMember = "nombre";
                    cmbPais.ValueMember = "id_pais";
                    cmbPais.SelectedIndex = -1;
                }
            }
        }

        private void CargarProveedores()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
           SELECT p.id_proveedor,
               p.nombre,
               p.telefono,
               p.email,
               p.direccion,
               pa.nombre AS pais,

               p.usuarioCrea,
               p.usuarioModifica,
               p.usuarioElimina,
               p.fechaCrea,
               p.fechaModifica,
               p.fechaElimina

        FROM proveedor p
        INNER JOIN pais pa ON pa.id_pais = p.id_pais
        ORDER BY p.id_proveedor";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvProveedor.DataSource = dt;
                }
            }
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
            INSERT INTO proveedor 
            (nombre, telefono, email, direccion, id_pais, 
             usuarioCrea, fechaCrea)
            VALUES
            (@n, @t, @e, @d, @p, @u, NOW())";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@n", txtNombreProveedor.Text);
                    cmd.Parameters.AddWithValue("@t", txtTelefonoProveedor.Text);
                    cmd.Parameters.AddWithValue("@e", txtEmailProveedor.Text);
                    cmd.Parameters.AddWithValue("@d", txtDireccionProveedor.Text);
                    cmd.Parameters.AddWithValue("@p", Convert.ToInt32(cmbPais.SelectedValue));
                    cmd.Parameters.AddWithValue("@u", usuarioAccionID);

                    cmd.ExecuteNonQuery();
                }
            }

            LimpiarProveedor();
            CargarProveedores();
        }

        private void btnEditarProveedor_Click(object sender, EventArgs e)
        {
            if (dgvProveedor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un registro.");
                return;
            }

            var row = dgvProveedor.SelectedRows[0];

            txtNombreProveedor.Text = row.Cells["nombre"].Value.ToString();
            txtTelefonoProveedor.Text = row.Cells["telefono"].Value.ToString();
            txtEmailProveedor.Text = row.Cells["email"].Value.ToString();
            txtDireccionProveedor.Text = row.Cells["direccion"].Value.ToString();

            // Selecciona el país correspondiente
            cmbPais.SelectedIndex = cmbPais.FindStringExact(row.Cells["pais"].Value.ToString());

            // Guardamos el ID en tag
            panelProveedor.Tag = row.Cells["id_proveedor"].Value.ToString();
        }

        private void btnActualizarProveedor_Click(object sender, EventArgs e)
        {
            if (panelProveedor.Tag == null)
            {
                MessageBox.Show("Selecciona un proveedor para editar.");
                return;
            }

            int id = Convert.ToInt32(panelProveedor.Tag);

            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
            UPDATE proveedor
            SET nombre=@n, telefono=@t, email=@e, direccion=@d, id_pais=@p,
                usuarioModifica=@u, fechaModifica=NOW()
            WHERE id_proveedor=@id";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@n", txtNombreProveedor.Text);
                    cmd.Parameters.AddWithValue("@t", txtTelefonoProveedor.Text);
                    cmd.Parameters.AddWithValue("@e", txtEmailProveedor.Text);
                    cmd.Parameters.AddWithValue("@d", txtDireccionProveedor.Text);
                    cmd.Parameters.AddWithValue("@p", Convert.ToInt32(cmbPais.SelectedValue));
                    cmd.Parameters.AddWithValue("@u", usuarioAccionID);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }
            }

            LimpiarProveedor();
            CargarProveedores();
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (dgvProveedor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un registro.");
                return;
            }

            int id = Convert.ToInt32(dgvProveedor.SelectedRows[0].Cells["id_proveedor"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
            UPDATE proveedor
            SET nombre = '',
                telefono = '',
                email = '',
                direccion = '',
                id_pais = NULL,
                usuarioelimina = @uAccion,
                fechaelimina = NOW()
            WHERE id_proveedor = @id
        ";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@uAccion", usuarioAccionID);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Proveedor marcado como eliminado.");

            CargarProveedores();
        }

        private void LimpiarProveedor()
        {
            txtNombreProveedor.Clear();
            txtTelefonoProveedor.Clear();
            txtEmailProveedor.Clear();
            txtDireccionProveedor.Clear();
            cmbPais.SelectedIndex = -1;

            panelProveedor.Tag = null;
        }

        private void CargarProveedoresOC()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = "SELECT id_proveedor, nombre FROM proveedor ORDER BY nombre";

                using (var cmd = new NpgsqlCommand(query, con))
                using (var dr = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);

                    cmbProveedorOC.DataSource = dt;
                    cmbProveedorOC.DisplayMember = "nombre";
                    cmbProveedorOC.ValueMember = "id_proveedor";
                    cmbProveedorOC.SelectedIndex = -1;
                }
            }
        }

        private void CargarOrdenesCompra()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
            SELECT 
                oc.id_ordencompra,
                oc.fecha,
                p.nombre AS proveedor,
                oc.total,
                oc.fechaCrea, 
                oc.fechaModifica,
                oc.fechaElimina,
                oc.usuarioCrea,  -- Aquí mostramos los IDs de los usuarios que realizaron las acciones
                oc.usuarioModifica,
                oc.usuarioElimina
            FROM ordencompra oc
            INNER JOIN proveedor p ON p.id_proveedor = oc.id_proveedor
            ORDER BY oc.id_ordencompra";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvOrdenCompra.DataSource = dt;
                }
            }
        }

        private void btnAgregarOC_Click(object sender, EventArgs e)
        {
            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
            INSERT INTO ordencompra 
                (fecha, id_proveedor, total, usuariocrea, fechacrea)
            VALUES
                (@f, @p, @t, @u, NOW())";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@f", dtpFechaOC.Value.Date);
                    cmd.Parameters.AddWithValue("@p", Convert.ToInt32(cmbProveedorOC.SelectedValue));
                    cmd.Parameters.AddWithValue("@t", Convert.ToDecimal(numTotalOC.Value));
                    cmd.Parameters.AddWithValue("@u", usuarioAccionID);   // 👈 Registrar acción

                    cmd.ExecuteNonQuery();
                }
            }

            LimpiarOC();
            CargarOrdenesCompra();
        }

        private void btnEditarOC_Click(object sender, EventArgs e)
        {
            if (dgvOrdenCompra.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una orden.");
                return;
            }

            var row = dgvOrdenCompra.SelectedRows[0];

          
            cmbProveedorOC.SelectedIndex = cmbProveedorOC.FindStringExact(row.Cells["proveedor"].Value.ToString());
            numTotalOC.Value = Convert.ToDecimal(row.Cells["total"].Value);


        }

        private void btnActualizarOC_Click(object sender, EventArgs e)
        {
            if (panelLOC.Tag == null)
            {
                MessageBox.Show("Selecciona una orden para editar.");
                return;
            }

            int id = Convert.ToInt32(panelLOC.Tag);

            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
            UPDATE ordencompra
            SET fecha=@f,
                id_proveedor=@p,
                total=@t,
                usuariomodifica=@u,
                fechamodifica=NOW()
            WHERE id_ordencompra=@id";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@f", dtpFechaOC.Value.Date);
                    cmd.Parameters.AddWithValue("@p", Convert.ToInt32(cmbProveedorOC.SelectedValue));
                    cmd.Parameters.AddWithValue("@t", Convert.ToDecimal(numTotalOC.Value));
                    cmd.Parameters.AddWithValue("@u", usuarioAccionID);  // 👈 Registrar acción
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }
            }

            LimpiarOC();
            CargarOrdenesCompra();
        }

        private void btnEliminarOC_Click(object sender, EventArgs e)
        {
            if (dgvOrdenCompra.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una orden.");
                return;
            }

            int id = Convert.ToInt32(dgvOrdenCompra.SelectedRows[0].Cells["id_ordencompra"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
            UPDATE ordencompra
            SET usuarioelimina=@u,
                fechaelimina=NOW()
            WHERE id_ordencompra=@id";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@u", usuarioAccionID);  // 👈 Registrar acción
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            CargarOrdenesCompra();
        }

        private void LimpiarOC()
        {
            dtpFechaOC.Value = DateTime.Now;
            cmbProveedorOC.SelectedIndex = -1;
            numTotalOC.Value = 0;
            panelLOC.Tag = null;
        }

        private void CargarProductos()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = "SELECT id_producto, nombre FROM producto ORDER BY nombre";
                using (var cmd = new NpgsqlCommand(query, con))
                using (var da = new NpgsqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbProducto.DataSource = dt;
                    cmbProducto.DisplayMember = "nombre";
                    cmbProducto.ValueMember = "id_producto";
                }
            }
        }

        private void CargarDetalleCompra()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
             SELECT d.id_detallecompra, 
               p.nombre AS producto,
               d.id_producto,
               d.id_ordencompra,
               d.cantidad,
               d.preciounitario,
               d.usuariocrea, 
               d.usuariomodifica,
               d.usuarioelimina,
               d.fechacrea,
               d.fechamodifica,
               d.fechaelimina
        FROM detallecompra d
        INNER JOIN producto p ON p.id_producto = d.id_producto
        ORDER BY d.id_detallecompra";

                using (var cmd = new NpgsqlCommand(query, con))
                using (var da = new NpgsqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDetalleCompra.DataSource = dt;
                }
            }
        }

        private int idDetalleSeleccionado = 0;
        private void dgvDetalleCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvDetalleCompra.Rows[e.RowIndex];

            idDetalleSeleccionado = Convert.ToInt32(row.Cells["id_detallecompra"].Value);

            cmbProducto.SelectedValue = Convert.ToInt32(row.Cells["id_producto"].Value);
            cmbOrdenCompra.SelectedValue = Convert.ToInt32(row.Cells["id_ordencompra"].Value);
            numCantidad.Value = Convert.ToInt32(row.Cells["cantidad"].Value);
            numPrecioUnitario.Value = Convert.ToDecimal(row.Cells["preciounitario"].Value);
        }

        private void btnAgregarDetalleCompra_Click(object sender, EventArgs e)
        {
            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
        INSERT INTO detallecompra (id_producto, id_ordencompra, cantidad, preciounitario, usuariocrea, fechacrea)
        VALUES (@prod, @orden, @cant, @precio, @usuario, NOW())";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@prod", (int)cmbProducto.SelectedValue);
                    cmd.Parameters.AddWithValue("@orden", (int)cmbOrdenCompra.SelectedValue);
                    cmd.Parameters.AddWithValue("@cant", (int)numCantidad.Value);
                    cmd.Parameters.AddWithValue("@precio", numPrecioUnitario.Value);
                    cmd.Parameters.AddWithValue("@usuario", usuarioAccionID);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Detalle agregado.");
            CargarDetalleCompra();
        }

        private void btnActualizarDetalleCompra_Click(object sender, EventArgs e)
        {
            if (idDetalleSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un registro.");
                return;
            }

            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
        UPDATE detallecompra
        SET id_producto = @prod,
            id_ordencompra = @orden,
            cantidad = @cant,
            preciounitario = @precio,
            usuariomodifica = @usuario,
            fechamodifica = NOW()
        WHERE id_detallecompra = @id";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@prod", (int)cmbProducto.SelectedValue);
                    cmd.Parameters.AddWithValue("@orden", (int)cmbOrdenCompra.SelectedValue);
                    cmd.Parameters.AddWithValue("@cant", (int)numCantidad.Value);
                    cmd.Parameters.AddWithValue("@precio", numPrecioUnitario.Value);
                    cmd.Parameters.AddWithValue("@usuario", usuarioAccionID);
                    cmd.Parameters.AddWithValue("@id", idDetalleSeleccionado);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Detalle actualizado.");
            CargarDetalleCompra();
        }

        private void btnEliminarDetalleCompra_Click(object sender, EventArgs e)
        {
            if (idDetalleSeleccionado == 0)
            {
                MessageBox.Show("Selecciona un registro.");
                return;
            }

            using (var con = DB.GetConnection())
            {
                con.Open();

                // Modificamos la consulta para hacer un "borrado lógico" con las fechas de eliminación y el usuario
                string query = @"
            UPDATE detallecompra
            SET usuarioelimina = @usuario,
                fechaelimina = NOW()
            WHERE id_detallecompra = @id";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    // Pasamos el usuario que está realizando la acción
                    cmd.Parameters.AddWithValue("@usuario", usuarioAccionID);
                    cmd.Parameters.AddWithValue("@id", idDetalleSeleccionado);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Detalle eliminado (borrado lógico).");
            CargarDetalleCompra();
        }

        private void btnEditarDetalleCompra_Click(object sender, EventArgs e)
        {
            if (dgvDetalleCompra.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una fila primero.");
                return;
            }

            DataGridViewRow row = dgvDetalleCompra.SelectedRows[0];

            // Guardamos el ID del detalle seleccionado para el UPDATE
            idDetalleSeleccionado = Convert.ToInt32(row.Cells["id_detallecompra"].Value);

            // Cargar datos en los controles
            cmbProducto.SelectedValue = Convert.ToInt32(row.Cells["id_producto"].Value);
            cmbOrdenCompra.SelectedValue = Convert.ToInt32(row.Cells["id_ordencompra"].Value);
            numCantidad.Value = Convert.ToInt32(row.Cells["cantidad"].Value);
            numPrecioUnitario.Value = Convert.ToDecimal(row.Cells["preciounitario"].Value);

            MessageBox.Show("Campos cargados. Ahora puedes actualizar.");
        }
    }
}

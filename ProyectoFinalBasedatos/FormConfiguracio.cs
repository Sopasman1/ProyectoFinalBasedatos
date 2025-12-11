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
    public partial class FormConfiguracio : Form
    {
        private int usuarioAccionID;
        public FormConfiguracio(int idUsuarioAccion)
        {
            InitializeComponent();
            CargarUsuarios();
            CargarRoles();
            CargarEmpleados();
            CargarUsuarios2();
            CargarMonedas();
            CargarCiudades();
            CargarPaises();
            CargarConfiguraciones();
            CargarUsuarios3();
            CargarNotificaciones();
            CargarRolesdtg();
            CargarSesiones();
            usuarioAccionID = idUsuarioAccion;
        }

        private void CargarEmpleados()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = "SELECT ID_Empleado, Nombre FROM Empleado";
                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbEmpleado.DisplayMember = "Nombre";
                    cmbEmpleado.ValueMember = "ID_Empleado";
                    cmbEmpleado.DataSource = dt;
                }
            }
        }

        private void CargarRoles()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = "SELECT ID_Rol, Nombre FROM Rol";
                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbRol.DisplayMember = "Nombre";
                    cmbRol.ValueMember = "ID_Rol";
                    cmbRol.DataSource = dt;
                }
            }
        }

        private void CargarUsuarios()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
             SELECT u.ID_Usuario, 
               u.NombreUsuario, 
               r.Nombre AS Rol, 
               e.Nombre AS Empleado, 
               u.fechaCrea, u.fechaModifica, u.fechaElimina,
               u.usuarioCrea,
               u.usuarioModifica,
               u.usuarioElimina
        FROM Usuario u
        JOIN Rol r ON u.ID_Rol = r.ID_Rol
        JOIN Empleado e ON u.ID_Empleado = e.ID_Empleado
        ORDER BY u.ID_Usuario";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvUsuarios.DataSource = dt;
                }
            }
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            string salt = SeguridadPasswort.GenerarSalt();
            string hash = SeguridadPasswort.GenerarHash(txtContrasena.Text, salt);

            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
        INSERT INTO Usuario (NombreUsuario, ContrasenaSalt, ContrasenaHash, ID_Rol, ID_Empleado, usuarioCrea, fechaCrea)
        VALUES (@nombreUsuario, @contrasenaSalt, @contrasenaHash, @idRol, @idEmpleado, @usuarioCrea, NOW())";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nombreUsuario", txtNombreUsuario.Text);
                    cmd.Parameters.AddWithValue("@contrasenaSalt", salt);
                    cmd.Parameters.AddWithValue("@contrasenaHash", hash);
                    cmd.Parameters.AddWithValue("@idRol", (int)cmbRol.SelectedValue);
                    cmd.Parameters.AddWithValue("@idEmpleado", (int)cmbEmpleado.SelectedValue);
                    cmd.Parameters.AddWithValue("@usuarioCrea", usuarioAccionID); // Usuario que crea el usuario

                    cmd.ExecuteNonQuery();
                }
            }

            CargarUsuarios();
            MessageBox.Show("Usuario registrado correctamente.");
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un usuario.");
                return;
            }

            var row = dgvUsuarios.SelectedRows[0];
            int idUsuarioSeleccionado = Convert.ToInt32(row.Cells["ID_Usuario"].Value);

            // Cargar los datos del usuario para edición
            txtNombreUsuario.Text = row.Cells["NombreUsuario"].Value.ToString();
            cmbRol.SelectedValue = row.Cells["Rol"].Value;
            cmbEmpleado.SelectedValue = row.Cells["Empleado"].Value;

            MessageBox.Show("Usuario cargado. Ahora puedes actualizar.");
        }

        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un usuario para actualizar.");
                return;
            }

            int idUsuarioSeleccionado = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["ID_Usuario"].Value);

            string salt = SeguridadPasswort.GenerarSalt();
            string hash = SeguridadPasswort.GenerarHash(txtContrasena.Text, salt);

            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
        UPDATE Usuario
        SET NombreUsuario = @nombreUsuario,
            ContrasenaSalt = @contrasenaSalt,
            ContrasenaHash = @contrasenaHash,
            ID_Rol = @idRol,
            ID_Empleado = @idEmpleado,
            usuarioModifica = @usuarioModifica,
            fechaModifica = NOW()
        WHERE ID_Usuario = @idUsuario";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nombreUsuario", txtNombreUsuario.Text);
                    cmd.Parameters.AddWithValue("@contrasenaSalt", salt);
                    cmd.Parameters.AddWithValue("@contrasenaHash", hash);
                    cmd.Parameters.AddWithValue("@idRol", (int)cmbRol.SelectedValue);
                    cmd.Parameters.AddWithValue("@idEmpleado", (int)cmbEmpleado.SelectedValue);
                    cmd.Parameters.AddWithValue("@usuarioModifica", usuarioAccionID); // Usuario que modifica el usuario
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuarioSeleccionado);

                    cmd.ExecuteNonQuery();
                }
            }

            CargarUsuarios();
            MessageBox.Show("Usuario actualizado correctamente.");
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un usuario para eliminar.");
                return;
            }

            int idUsuario = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["ID_Usuario"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
        UPDATE Usuario
        SET usuarioElimina = @usuarioElimina,
            fechaElimina = NOW()
        WHERE ID_Usuario = @idUsuario";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@usuarioElimina", usuarioAccionID); // Usuario que elimina el usuario
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.ExecuteNonQuery();
                }
            }

            CargarUsuarios();
            MessageBox.Show("Usuario eliminado.");
        }

        private void CargarRolesdtg()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
        SELECT r.ID_Rol, r.Nombre, r.Descripcion, 
               r.fechaCrea, r.fechaModifica, r.fechaElimina,
              r.usuarioCrea,
              r.usuarioModifica,
              r.usuarioElimina
        FROM Rol r
        ORDER BY r.ID_Rol";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvRoles.DataSource = dt;
                }
            }
        }

        private void btnAgregarRol_Click(object sender, EventArgs e)
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
        INSERT INTO Rol (Nombre, Descripcion, usuarioCrea, fechaCrea)
        VALUES (@nombre, @descripcion, @usuarioCrea, NOW())";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", txtNombreRol.Text);
                    cmd.Parameters.AddWithValue("@descripcion", txtDescripcionRol.Text);
                    cmd.Parameters.AddWithValue("@usuarioCrea", usuarioAccionID);  // El ID del usuario que crea el rol

                    cmd.ExecuteNonQuery();
                }
            }

            CargarRolesdtg();
            MessageBox.Show("Rol agregado correctamente.");
        }

        private void btnEditarRol_Click(object sender, EventArgs e)
        {
            if (dgvRoles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un rol.");
                return;
            }

            var row = dgvRoles.SelectedRows[0];
            int idRolSeleccionado = Convert.ToInt32(row.Cells["ID_Rol"].Value);

            // Cargar los datos del rol para edición
            txtNombreRol.Text = row.Cells["Nombre"].Value.ToString();
            txtDescripcionRol.Text = row.Cells["Descripcion"].Value.ToString();

            MessageBox.Show("Rol cargado. Ahora puedes actualizar.");
        }

        private void btnActualizarRol_Click(object sender, EventArgs e)
        {
            if (dgvRoles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un rol para actualizar.");
                return;
            }

            int idRolSeleccionado = Convert.ToInt32(dgvRoles.SelectedRows[0].Cells["ID_Rol"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
        UPDATE Rol
        SET Nombre = @nombre,
            Descripcion = @descripcion,
            usuarioModifica = @usuarioModifica,
            fechaModifica = NOW()
        WHERE ID_Rol = @idRol";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", txtNombreRol.Text);
                    cmd.Parameters.AddWithValue("@descripcion", txtDescripcionRol.Text);
                    cmd.Parameters.AddWithValue("@usuarioModifica", usuarioAccionID);  // El ID del usuario que modifica el rol
                    cmd.Parameters.AddWithValue("@idRol", idRolSeleccionado);

                    cmd.ExecuteNonQuery();
                }
            }

            CargarRolesdtg();
            MessageBox.Show("Rol actualizado correctamente.");
        }

        private void btnEliminarRol_Click(object sender, EventArgs e)
        {
            if (dgvRoles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un rol para eliminar.");
                return;
            }

            int idRol = Convert.ToInt32(dgvRoles.SelectedRows[0].Cells["ID_Rol"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
        UPDATE Rol
        SET usuarioElimina = @usuarioElimina,
            fechaElimina = NOW()
        WHERE ID_Rol = @idRol";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@usuarioElimina", usuarioAccionID);  // El ID del usuario que elimina el rol
                    cmd.Parameters.AddWithValue("@idRol", idRol);
                    cmd.ExecuteNonQuery();
                }
            }

            CargarRolesdtg();
            MessageBox.Show("Rol eliminado.");
        }

        private void CargarSesiones()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
            SELECT s.ID_Sesion, u.NombreUsuario, s.FechaInicio, s.FechaFin,
               s.fechaCrea, s.fechaModifica, s.fechaElimina,
               s.usuarioCrea,
               s.usuarioModifica,
               s.usuarioElimina
        FROM Sesion s
        INNER JOIN Usuario u ON u.ID_Usuario = s.ID_Usuario
        ORDER BY s.FechaInicio DESC";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvSesiones.DataSource = dt;
                }
            }
        }

        private void btnAgregarSesion_Click(object sender, EventArgs e)
        {
            if (cmbUsuario2.SelectedValue == null)
            {
                MessageBox.Show("Selecciona un usuario.");
                return;
            }

            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
        INSERT INTO Sesion (ID_Usuario, FechaInicio, FechaFin, usuarioCrea, fechaCrea)
        VALUES (@usuario, @fechaInicio, @fechaFin, @usuarioCrea, NOW())";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@usuario", Convert.ToInt32(cmbUsuario2.SelectedValue));
                    cmd.Parameters.AddWithValue("@fechaInicio", DateTime.Now);
                    cmd.Parameters.AddWithValue("@fechaFin", DBNull.Value);  // Dejar en NULL hasta que termine la sesión
                    cmd.Parameters.AddWithValue("@usuarioCrea", usuarioAccionID);  // El ID del usuario que crea la sesión

                    cmd.ExecuteNonQuery();
                }
            }

            CargarSesiones();
            MessageBox.Show("Sesión iniciada correctamente.");
        }

        private void btnEditarSesion_Click(object sender, EventArgs e)
        {
            if (dgvSesiones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una sesión.");
                return;
            }

            var row = dgvSesiones.SelectedRows[0];
            int idSesionSeleccionada = Convert.ToInt32(row.Cells["ID_Sesion"].Value);

           

            MessageBox.Show("Sesión cargada. Ahora puedes actualizar.");
        }

        private void btnActualizarSesion_Click(object sender, EventArgs e)
        {
            if (dgvSesiones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una sesión para actualizar.");
                return;
            }

            var row = dgvSesiones.SelectedRows[0];
            int idSesionSeleccionada = Convert.ToInt32(row.Cells["ID_Sesion"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
        UPDATE Sesion
        SET FechaFin = @fechaFin,
            usuarioModifica = @usuarioModifica,
            fechaModifica = NOW()
        WHERE ID_Sesion = @idSesion";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@fechaFin", DateTime.Now);  // Marca el momento de cierre de la sesión
                    cmd.Parameters.AddWithValue("@usuarioModifica", usuarioAccionID);  // El ID del usuario que modifica la sesión
                    cmd.Parameters.AddWithValue("@idSesion", idSesionSeleccionada);

                    cmd.ExecuteNonQuery();
                }
            }

            CargarSesiones();
            MessageBox.Show("Sesión finalizada correctamente.");
        }

        private void btnEliminarSesion_Click(object sender, EventArgs e)
        {
            if (dgvSesiones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una sesión para eliminar.");
                return;
            }

            int idSesion = Convert.ToInt32(dgvSesiones.SelectedRows[0].Cells["ID_Sesion"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
        UPDATE Sesion
        SET usuarioElimina = @usuarioElimina,
            fechaElimina = NOW()
        WHERE ID_Sesion = @idSesion";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@usuarioElimina", usuarioAccionID);  // El ID del usuario que elimina la sesión
                    cmd.Parameters.AddWithValue("@idSesion", idSesion);
                    cmd.ExecuteNonQuery();
                }
            }

            CargarSesiones();
            MessageBox.Show("Sesión eliminada.");
        }

        private void CargarUsuarios2()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = "SELECT ID_Usuario, NombreUsuario FROM Usuario ORDER BY NombreUsuario";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbUsuario2.DataSource = dt;
                    cmbUsuario2.DisplayMember = "NombreUsuario";
                    cmbUsuario2.ValueMember = "ID_Usuario";
                }
            }
        }

        private void CargarMonedas()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
            SELECT m.ID_Moneda, m.Nombre, m.Simbolo, m.TipoCambio,
               m.fechaCrea, m.fechaModifica, m.fechaElimina,
               m.usuarioCrea,
               m.usuarioModifica,
               m.usuarioElimina
        FROM Moneda m
        ORDER BY m.Nombre";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvMonedas.DataSource = dt;
                }
            }
        }

        private void btnAgregarMoneda_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreMoneda.Text) || string.IsNullOrEmpty(txtSimboloMoneda.Text) || string.IsNullOrEmpty(txtTipoCambio.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
        INSERT INTO Moneda (Nombre, Simbolo, TipoCambio, usuarioCrea, fechaCrea)
        VALUES (@nombre, @simbolo, @tipoCambio, @usuarioCrea, NOW())";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", txtNombreMoneda.Text);
                    cmd.Parameters.AddWithValue("@simbolo", txtSimboloMoneda.Text);
                    cmd.Parameters.AddWithValue("@tipoCambio", Convert.ToDecimal(txtTipoCambio.Text));
                    cmd.Parameters.AddWithValue("@usuarioCrea", usuarioAccionID);  // El ID del usuario que crea la moneda

                    cmd.ExecuteNonQuery();
                }
            }

            CargarMonedas();
            MessageBox.Show("Moneda agregada correctamente.");
        }

        private void btnEditarMoneda_Click(object sender, EventArgs e)
        {
            if (dgvMonedas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una moneda.");
                return;
            }

            var row = dgvMonedas.SelectedRows[0];
            int idMonedaSeleccionada = Convert.ToInt32(row.Cells["ID_Moneda"].Value);

            // Cargar los valores en los campos de texto para editar
            txtNombreMoneda.Text = row.Cells["Nombre"].Value.ToString();
            txtSimboloMoneda.Text = row.Cells["Simbolo"].Value.ToString();
            txtTipoCambio.Text = row.Cells["TipoCambio"].Value.ToString();

            MessageBox.Show("Moneda cargada. Ahora puedes actualizar.");
        }

        private void btnActualizarMoneda_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreMoneda.Text) || string.IsNullOrEmpty(txtSimboloMoneda.Text) || string.IsNullOrEmpty(txtTipoCambio.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (dgvMonedas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una moneda para actualizar.");
                return;
            }

            var row = dgvMonedas.SelectedRows[0];
            int idMonedaSeleccionada = Convert.ToInt32(row.Cells["ID_Moneda"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
        UPDATE Moneda
        SET Nombre = @nombre,
            Simbolo = @simbolo,
            TipoCambio = @tipoCambio,
            usuarioModifica = @usuarioModifica,
            fechaModifica = NOW()
        WHERE ID_Moneda = @idMoneda";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", txtNombreMoneda.Text);
                    cmd.Parameters.AddWithValue("@simbolo", txtSimboloMoneda.Text);
                    cmd.Parameters.AddWithValue("@tipoCambio", Convert.ToDecimal(txtTipoCambio.Text));
                    cmd.Parameters.AddWithValue("@usuarioModifica", usuarioAccionID);  // El ID del usuario que modifica la moneda
                    cmd.Parameters.AddWithValue("@idMoneda", idMonedaSeleccionada);

                    cmd.ExecuteNonQuery();
                }
            }

            CargarMonedas();
            MessageBox.Show("Moneda actualizada correctamente.");
        }

        private void btnEliminarMoneda_Click(object sender, EventArgs e)
        {
            if (dgvMonedas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una moneda para eliminar.");
                return;
            }

            int idMoneda = Convert.ToInt32(dgvMonedas.SelectedRows[0].Cells["ID_Moneda"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
        UPDATE Moneda
        SET usuarioElimina = @usuarioElimina,
            fechaElimina = NOW()
        WHERE ID_Moneda = @idMoneda";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@usuarioElimina", usuarioAccionID);  // El ID del usuario que elimina la moneda
                    cmd.Parameters.AddWithValue("@idMoneda", idMoneda);
                    cmd.ExecuteNonQuery();
                }
            }

            CargarMonedas();
            MessageBox.Show("Moneda eliminada.");
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtNombreMoneda.Clear();
            txtSimboloMoneda.Clear();
            txtTipoCambio.Clear();
        }

        private void CargarCiudades()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
             SELECT c.ID_Ciudad, c.Nombre, p.Nombre AS Pais, 
               c.fechaCrea, c.fechaModifica, c.fechaElimina,
               c.usuarioCrea,
               c.usuarioModifica,
               c.usuarioElimina
        FROM Ciudad c
        INNER JOIN Pais p ON p.ID_Pais = c.ID_Pais
        ORDER BY c.Nombre";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvCiudades.DataSource = dt;
                }
            }
        }

        private void CargarPaises()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = "SELECT ID_Pais, Nombre FROM Pais ORDER BY Nombre";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbPais.DataSource = dt;
                    cmbPais.DisplayMember = "Nombre";
                    cmbPais.ValueMember = "ID_Pais";
                }
            }
        }

        private void btnAgregarCiudad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreCiudad.Text) || cmbPais.SelectedValue == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
        INSERT INTO Ciudad (Nombre, ID_Pais, usuarioCrea, fechaCrea)
        VALUES (@nombre, @idPais, @usuarioCrea, NOW())";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", txtNombreCiudad.Text);
                    cmd.Parameters.AddWithValue("@idPais", Convert.ToInt32(cmbPais.SelectedValue));
                    cmd.Parameters.AddWithValue("@usuarioCrea", usuarioAccionID);  // Registrar el usuario que crea la ciudad

                    cmd.ExecuteNonQuery();
                }
            }

            CargarCiudades();
            MessageBox.Show("Ciudad agregada correctamente.");

            // Limpiar campos después de agregar
            txtNombreCiudad.Clear();
            cmbPais.SelectedIndex = -1; // Limpiar ComboBox
        }

        private void btnEditarCiudad_Click(object sender, EventArgs e)
        {

            if (dgvCiudades.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una ciudad.");
                return;
            }

            var row = dgvCiudades.SelectedRows[0];
            int idCiudadSeleccionada = Convert.ToInt32(row.Cells["ID_Ciudad"].Value);

            // Cargar los valores de la ciudad para editar
            txtNombreCiudad.Text = row.Cells["Nombre"].Value.ToString();
            cmbPais.SelectedValue = row.Cells["ID_Pais"].Value;

            MessageBox.Show("Ciudad cargada. Ahora puedes actualizar.");
        }

        private void btnActualizarCiudad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreCiudad.Text) || cmbPais.SelectedValue == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (dgvCiudades.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una ciudad para actualizar.");
                return;
            }

            var row = dgvCiudades.SelectedRows[0];
            int idCiudadSeleccionada = Convert.ToInt32(row.Cells["ID_Ciudad"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
        UPDATE Ciudad
        SET Nombre = @nombre, 
            ID_Pais = @idPais,
            usuarioModifica = @usuarioModifica,
            fechaModifica = NOW()
        WHERE ID_Ciudad = @idCiudad";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", txtNombreCiudad.Text);
                    cmd.Parameters.AddWithValue("@idPais", Convert.ToInt32(cmbPais.SelectedValue));
                    cmd.Parameters.AddWithValue("@usuarioModifica", usuarioAccionID);  // Registrar el usuario que modifica la ciudad
                    cmd.Parameters.AddWithValue("@idCiudad", idCiudadSeleccionada);

                    cmd.ExecuteNonQuery();
                }
            }

            CargarCiudades();
            MessageBox.Show("Ciudad actualizada correctamente.");

            // Limpiar campos después de actualizar
            txtNombreCiudad.Clear();
            cmbPais.SelectedIndex = -1; // Limpiar ComboBox
        }

        private void btnEliminarCiudad_Click(object sender, EventArgs e)
        {
            if (dgvCiudades.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una ciudad para eliminar.");
                return;
            }

            int idCiudad = Convert.ToInt32(dgvCiudades.SelectedRows[0].Cells["ID_Ciudad"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
        UPDATE Ciudad
        SET usuarioElimina = @usuarioElimina,
            fechaElimina = NOW()
        WHERE ID_Ciudad = @idCiudad";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@usuarioElimina", usuarioAccionID);  // Registrar el usuario que elimina la ciudad
                    cmd.Parameters.AddWithValue("@idCiudad", idCiudad);
                    cmd.ExecuteNonQuery();
                }
            }

            CargarCiudades();
            MessageBox.Show("Ciudad eliminada.");

            // Limpiar campos después de eliminar
            txtNombreCiudad.Clear();
            cmbPais.SelectedIndex = -1; // Limpiar ComboBox
        }

        private void CargarConfiguraciones()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
        SELECT c.ID_Config, c.Clave, c.Valor,
               c.fechaCrea, c.fechaModifica, c.fechaElimina,
               c.usuarioCrea,
               c.usuarioModifica,
               c.usuarioElimina
        FROM Configuracion c
        ORDER BY c.Clave";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvConfiguraciones.DataSource = dt;
                }
            }
        }

        private void btnAgregarConfiguracion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClave.Text) || string.IsNullOrEmpty(txtValor.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
        INSERT INTO Configuracion (Clave, Valor, usuarioCrea, fechaCrea)
        VALUES (@clave, @valor, @usuarioCrea, NOW())";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@clave", txtClave.Text);
                    cmd.Parameters.AddWithValue("@valor", txtValor.Text);
                    cmd.Parameters.AddWithValue("@usuarioCrea", usuarioAccionID);  // Registrar el usuario que crea la configuración

                    cmd.ExecuteNonQuery();
                }
            }

            CargarConfiguraciones();
            MessageBox.Show("Configuración agregada correctamente.");

            // Limpiar los campos después de agregar
            txtClave.Clear();
            txtValor.Clear();
        }

        private void btnEditarConfiguracion_Click(object sender, EventArgs e)
        {
            if (dgvConfiguraciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una configuración.");
                return;
            }

            var row = dgvConfiguraciones.SelectedRows[0];
            int idConfigSeleccionada = Convert.ToInt32(row.Cells["ID_Config"].Value);

            // Cargar los valores para editar
            txtClave.Text = row.Cells["Clave"].Value.ToString();
            txtValor.Text = row.Cells["Valor"].Value.ToString();

            MessageBox.Show("Configuración cargada. Ahora puedes actualizar.");
        }

        private void btnActualizarConfiguracion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClave.Text) || string.IsNullOrEmpty(txtValor.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (dgvConfiguraciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una configuración para actualizar.");
                return;
            }

            var row = dgvConfiguraciones.SelectedRows[0];
            int idConfigSeleccionada = Convert.ToInt32(row.Cells["ID_Config"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
        UPDATE Configuracion
        SET Clave = @clave, 
            Valor = @valor,
            usuarioModifica = @usuarioModifica,
            fechaModifica = NOW()
        WHERE ID_Config = @idConfig";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@clave", txtClave.Text);
                    cmd.Parameters.AddWithValue("@valor", txtValor.Text);
                    cmd.Parameters.AddWithValue("@usuarioModifica", usuarioAccionID);  // Registrar el usuario que modifica la configuración
                    cmd.Parameters.AddWithValue("@idConfig", idConfigSeleccionada);

                    cmd.ExecuteNonQuery();
                }
            }

            CargarConfiguraciones();
            MessageBox.Show("Configuración actualizada correctamente.");

            // Limpiar campos después de actualizar
            txtClave.Clear();
            txtValor.Clear();
        }

        private void btnEliminarConfiguracion_Click(object sender, EventArgs e)
        {
            if (dgvConfiguraciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una configuración para eliminar.");
                return;
            }

            int idConfig = Convert.ToInt32(dgvConfiguraciones.SelectedRows[0].Cells["ID_Config"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
        UPDATE Configuracion
        SET usuarioElimina = @usuarioElimina,
            fechaElimina = NOW()
        WHERE ID_Config = @idConfig";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@usuarioElimina", usuarioAccionID);  // Registrar el usuario que elimina la configuración
                    cmd.Parameters.AddWithValue("@idConfig", idConfig);
                    cmd.ExecuteNonQuery();
                }
            }

            CargarConfiguraciones();
            MessageBox.Show("Configuración eliminada.");

            // Limpiar campos después de eliminar
            txtClave.Clear();
            txtValor.Clear();
        }

        private void CargarNotificaciones()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
        SELECT n.ID_Notificacion, n.Mensaje, n.Fecha, n.Tipo, u.NombreUsuario AS Usuario,
               n.fechaCrea, n.fechaModifica, n.fechaElimina,
               n.usuarioCrea, 
               n.usuarioModifica, 
               n.usuarioElimina
        FROM Notificacion n
        LEFT JOIN Usuario u ON u.ID_Usuario = n.ID_Usuario
        ORDER BY n.ID_Notificacion";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvNotificaciones.DataSource = dt;
                }
            }
        }

        private void btnAgregarNotificacion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMensaje.Text) || string.IsNullOrEmpty(txtTipo.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
        INSERT INTO Notificacion (ID_Usuario, Mensaje, Fecha, Tipo, usuarioCrea, fechaCrea)
        VALUES (@usuario, @mensaje, @fecha, @tipo, @usuarioCrea, NOW())";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@usuario", Convert.ToInt32(cmbUsuario.SelectedValue));
                    cmd.Parameters.AddWithValue("@mensaje", txtMensaje.Text);
                    cmd.Parameters.AddWithValue("@fecha", dtpfecha.Value);
                    cmd.Parameters.AddWithValue("@tipo", txtTipo.Text);
                    cmd.Parameters.AddWithValue("@usuarioCrea", usuarioAccionID);  // Registrar el usuario que crea la notificación

                    cmd.ExecuteNonQuery();
                }
            }

            CargarNotificaciones();
            MessageBox.Show("Notificación agregada correctamente.");

            // Limpiar los campos después de agregar
            txtMensaje.Clear();
            txtTipo.Clear();
            cmbUsuario.SelectedIndex = 0;
        }

        private void btnEditarNotificacion_Click(object sender, EventArgs e)
        {
            if (dgvNotificaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una notificación.");
                return;
            }

            var row = dgvNotificaciones.SelectedRows[0];
            int idNotificacionSeleccionada = Convert.ToInt32(row.Cells["ID_Notificacion"].Value);

            // Cargar los valores para editar
            txtMensaje.Text = row.Cells["Mensaje"].Value.ToString();
            txtTipo.Text = row.Cells["Tipo"].Value.ToString();
            dtpfecha.Value = Convert.ToDateTime(row.Cells["Fecha"].Value);
            cmbUsuario.SelectedValue = Convert.ToInt32(row.Cells["ID_Usuario"].Value);

            MessageBox.Show("Notificación cargada. Ahora puedes actualizar.");
        }

        private void btnActualizarNotificacion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMensaje.Text) || string.IsNullOrEmpty(txtTipo.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (dgvNotificaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una notificación para actualizar.");
                return;
            }

            var row = dgvNotificaciones.SelectedRows[0];
            int idNotificacionSeleccionada = Convert.ToInt32(row.Cells["ID_Notificacion"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
        UPDATE Notificacion
        SET Mensaje = @mensaje, 
            Fecha = @fecha, 
            Tipo = @tipo,
            ID_Usuario = @usuario,
            usuarioModifica = @usuarioModifica,
            fechaModifica = NOW()
        WHERE ID_Notificacion = @idNotificacion";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@mensaje", txtMensaje.Text);
                    cmd.Parameters.AddWithValue("@fecha", dtpfecha.Value);
                    cmd.Parameters.AddWithValue("@tipo", txtTipo.Text);
                    cmd.Parameters.AddWithValue("@usuario", Convert.ToInt32(cmbUsuario.SelectedValue));
                    cmd.Parameters.AddWithValue("@usuarioModifica", usuarioAccionID);  // Registrar el usuario que modifica la notificación
                    cmd.Parameters.AddWithValue("@idNotificacion", idNotificacionSeleccionada);

                    cmd.ExecuteNonQuery();
                }
            }

            CargarNotificaciones();
            MessageBox.Show("Notificación actualizada correctamente.");

            // Limpiar campos después de actualizar
            txtMensaje.Clear();
            txtTipo.Clear();
            cmbUsuario.SelectedIndex = 0;
        }

        private void btnEliminarNotificacion_Click(object sender, EventArgs e)
        {
            if (dgvNotificaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una notificación para eliminar.");
                return;
            }

            int idNotificacion = Convert.ToInt32(dgvNotificaciones.SelectedRows[0].Cells["ID_Notificacion"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
        UPDATE Notificacion
        SET usuarioElimina = @usuarioElimina,
            fechaElimina = NOW()
        WHERE ID_Notificacion = @idNotificacion";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@usuarioElimina", usuarioAccionID);  // Registrar el usuario que elimina la notificación
                    cmd.Parameters.AddWithValue("@idNotificacion", idNotificacion);
                    cmd.ExecuteNonQuery();
                }
            }

            CargarNotificaciones();
            MessageBox.Show("Notificación eliminada.");

            // Limpiar campos después de eliminar
            txtMensaje.Clear();
            txtTipo.Clear();
            cmbUsuario.SelectedIndex = 0;
        }

        private void CargarUsuarios3()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = "SELECT ID_Usuario, NombreUsuario FROM Usuario ORDER BY NombreUsuario";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbUsuario.DataSource = dt;
                    cmbUsuario.DisplayMember = "NombreUsuario";
                    cmbUsuario.ValueMember = "ID_Usuario";
                }
            }
        }

    }
}

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
    public partial class FormRecursosHumanos : Form
    {
        private int usuarioAccionID;
        public FormRecursosHumanos(int idUsuarioAccion)
        {
            InitializeComponent();
            CargarEmpleados();
            CargarPuestosEmpleado();
            CargarAlmacenesEmpleado();
            CargarPuestos();
            CargarTurnos();
            CargarAsistencias();
            Cargarturnoscmb();
            carasistenciaempleado();
            usuarioAccionID = idUsuarioAccion;
        }

        private void CargarPuestosEmpleado()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = "SELECT id_puesto, nombre FROM puesto ORDER BY nombre";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbPuestoEmpleado.DataSource = dt;
                    cmbPuestoEmpleado.DisplayMember = "nombre";
                    cmbPuestoEmpleado.ValueMember = "id_puesto";
                }
            }
        }

        private void carasistenciaempleado()
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
        private void Cargarturnoscmb()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = "SELECT ID_Turno, Nombre FROM turno ORDER BY Nombre";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Cargar los datos en el ComboBox
                    cmbTurno.DataSource = dt;
                    cmbTurno.DisplayMember = "Nombre";  // Mostrar el nombre del turno
                    cmbTurno.ValueMember = "ID_Turno"; // Usar el ID del turno como valor
                }
            }
        }
        private void CargarAlmacenesEmpleado()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = "SELECT id_almacen, nombre FROM almacen ORDER BY nombre";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbAlmacenEmpleado.DataSource = dt;
                    cmbAlmacenEmpleado.DisplayMember = "nombre";
                    cmbAlmacenEmpleado.ValueMember = "id_almacen";
                }
            }
        }

        private void CargarEmpleados()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"SELECT e.ID_Empleado, e.Nombre, e.Apellido, e.Telefono, 
               e.ID_Puesto, p.Nombre AS Puesto, e.ID_Almacen, a.Nombre AS Almacen,
               e.fechaCrea, e.fechaModifica, e.fechaElimina,
               e.UsuarioCrea, e.UsuarioModifica, e.UsuarioElimina
        FROM empleado e
        INNER JOIN puesto p ON p.id_puesto = e.ID_Puesto
        INNER JOIN almacen a ON a.id_almacen = e.ID_Almacen
        ORDER BY e.ID_Empleado";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvEmpleados.DataSource = dt;
                }
            }
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
        INSERT INTO empleado (Nombre, Apellido, Telefono, ID_Puesto, ID_Almacen, usuarioCrea, fechaCrea) 
        VALUES (@nombre, @apellido, @telefono, @puesto, @almacen, @usuario, NOW())";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", txtNombreEmpleado.Text);
                    cmd.Parameters.AddWithValue("@apellido", txtApellidoEmpleado.Text);
                    cmd.Parameters.AddWithValue("@telefono", txtTelefonoEmpleado.Text);
                    cmd.Parameters.AddWithValue("@puesto", Convert.ToInt32(cmbPuestoEmpleado.SelectedValue));
                    cmd.Parameters.AddWithValue("@almacen", Convert.ToInt32(cmbAlmacenEmpleado.SelectedValue));
                    cmd.Parameters.AddWithValue("@usuario", usuarioAccionID);  // Registrar acción

                    cmd.ExecuteNonQuery();
                }
            }

            CargarEmpleados();
            MessageBox.Show("Empleado agregado correctamente.");
        }

        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un empleado.");
                return;
            }

            var row = dgvEmpleados.SelectedRows[0];
            int idEmpleadoSeleccionado = Convert.ToInt32(row.Cells["ID_Empleado"].Value);

            // Cargar datos para editar
            txtNombreEmpleado.Text = row.Cells["Nombre"].Value.ToString();
            txtApellidoEmpleado.Text = row.Cells["Apellido"].Value.ToString();
            txtTelefonoEmpleado.Text = row.Cells["Telefono"].Value.ToString();

            // Asignar el ID_Puesto correctamente
            if (row.Cells["ID_Puesto"].Value != DBNull.Value)
            {
                int idPuesto = Convert.ToInt32(row.Cells["ID_Puesto"].Value);
                cmbPuestoEmpleado.SelectedValue = idPuesto;
            }

            // Asignar el ID_Almacen correctamente
            if (row.Cells["ID_Almacen"].Value != DBNull.Value)
            {
                int idAlmacen = Convert.ToInt32(row.Cells["ID_Almacen"].Value);
                cmbAlmacenEmpleado.SelectedValue = idAlmacen;
            }

            MessageBox.Show("Empleado cargado. Ahora puedes actualizar.");
        }

        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un empleado para actualizar.");
                return;
            }

            int idEmpleadoSeleccionado = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["ID_Empleado"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
        UPDATE empleado
        SET Nombre = @nombre,
            Apellido = @apellido,
            Telefono = @telefono,
            ID_Puesto = @puesto,
            ID_Almacen = @almacen,
            usuarioModifica = @usuario,
            fechaModifica = NOW()
        WHERE ID_Empleado = @idEmpleado";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", txtNombreEmpleado.Text);
                    cmd.Parameters.AddWithValue("@apellido", txtApellidoEmpleado.Text);
                    cmd.Parameters.AddWithValue("@telefono", txtTelefonoEmpleado.Text);
                    cmd.Parameters.AddWithValue("@puesto", Convert.ToInt32(cmbPuestoEmpleado.SelectedValue));
                    cmd.Parameters.AddWithValue("@almacen", Convert.ToInt32(cmbAlmacenEmpleado.SelectedValue));
                    cmd.Parameters.AddWithValue("@usuario", usuarioAccionID);  // Registrar acción del usuario
                    cmd.Parameters.AddWithValue("@idEmpleado", idEmpleadoSeleccionado);

                    cmd.ExecuteNonQuery();
                }
            }

            CargarEmpleados();
            MessageBox.Show("Empleado actualizado correctamente.");
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un empleado para eliminar.");
                return;
            }

            int idEmpleado = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["ID_Empleado"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
        UPDATE empleado
        SET usuarioElimina = @usuario,
            fechaElimina = NOW()
        WHERE ID_Empleado = @idEmpleado";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuarioAccionID);  // Registrar acción del usuario
                    cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                    cmd.ExecuteNonQuery();
                }
            }

            CargarEmpleados();
            MessageBox.Show("Empleado marcado como eliminado.");
        }

        private void CargarPuestos()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
             SELECT p.ID_Puesto, p.Nombre, p.Descripcion, p.SalarioBase,
               p.fechaCrea, p.fechaModifica, p.fechaElimina,
               p.UsuarioCrea, p.UsuarioModifica, p.UsuarioElimina
        FROM puesto p
        ORDER BY p.ID_Puesto";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPuestos.DataSource = dt;
                }
            }
        }

        private void btnAgregarPuesto_Click(object sender, EventArgs e)
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
        INSERT INTO puesto (Nombre, Descripcion, SalarioBase, usuarioCrea, fechaCrea)
        VALUES (@nombre, @descripcion, @salarioBase, @usuario, NOW())";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", txtNombrePuesto.Text);
                    cmd.Parameters.AddWithValue("@descripcion", txtDescripcionPuesto.Text);
                    cmd.Parameters.AddWithValue("@salarioBase", Convert.ToDecimal(txtSalarioBasePuesto.Text));
                    cmd.Parameters.AddWithValue("@usuario", usuarioAccionID);  // Registrar acción

                    cmd.ExecuteNonQuery();
                }
            }

            CargarPuestos();
            MessageBox.Show("Puesto agregado correctamente.");
        }

        private void btnEditarPuesto_Click(object sender, EventArgs e)
        {
            if (dgvPuestos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un puesto.");
                return;
            }

            var row = dgvPuestos.SelectedRows[0];
            int idPuestoSeleccionado = Convert.ToInt32(row.Cells["ID_Puesto"].Value);

            // Cargar los datos del puesto para edición
            txtNombrePuesto.Text = row.Cells["Nombre"].Value.ToString();
            txtDescripcionPuesto.Text = row.Cells["Descripcion"].Value.ToString();
            txtSalarioBasePuesto.Text = row.Cells["SalarioBase"].Value.ToString();

            MessageBox.Show("Puesto cargado. Ahora puedes actualizar.");
        }

        private void btnActualizarPuesto_Click(object sender, EventArgs e)
        {
            if (dgvPuestos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un puesto para actualizar.");
                return;
            }

            int idPuestoSeleccionado = Convert.ToInt32(dgvPuestos.SelectedRows[0].Cells["ID_Puesto"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
        UPDATE puesto
        SET Nombre = @nombre,
            Descripcion = @descripcion,
            SalarioBase = @salarioBase,
            usuarioModifica = @usuario,
            fechaModifica = NOW()
        WHERE ID_Puesto = @idPuesto";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", txtNombrePuesto.Text);
                    cmd.Parameters.AddWithValue("@descripcion", txtDescripcionPuesto.Text);
                    cmd.Parameters.AddWithValue("@salarioBase", Convert.ToDecimal(txtSalarioBasePuesto.Text));
                    cmd.Parameters.AddWithValue("@usuario", usuarioAccionID);  // Registrar acción
                    cmd.Parameters.AddWithValue("@idPuesto", idPuestoSeleccionado);

                    cmd.ExecuteNonQuery();
                }
            }

            CargarPuestos();
            MessageBox.Show("Puesto actualizado correctamente.");
        }

        private void btnEliminarPuesto_Click(object sender, EventArgs e)
        {
            if (dgvPuestos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un puesto para eliminar.");
                return;
            }

            int idPuesto = Convert.ToInt32(dgvPuestos.SelectedRows[0].Cells["ID_Puesto"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
        UPDATE puesto
        SET usuarioElimina = @usuario,
            fechaElimina = NOW()
        WHERE ID_Puesto = @idPuesto";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuarioAccionID);  // Registrar acción
                    cmd.Parameters.AddWithValue("@idPuesto", idPuesto);
                    cmd.ExecuteNonQuery();
                }
            }

            CargarPuestos();
            MessageBox.Show("Puesto marcado como eliminado.");
        }

        private void CargarTurnos()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
            SELECT t.ID_Turno, t.Nombre, t.HoraInicio, t.HoraFin, 
               t.fechaCrea, t.fechaModifica, t.fechaElimina,
               t.UsuarioCrea, t.UsuarioModifica, t.UsuarioElimina
        FROM turno t
        ORDER BY t.ID_Turno";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvTurnos.DataSource = dt;
                }
            }
        }

        private void btnAgregarTurno_Click(object sender, EventArgs e)
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
        INSERT INTO turno (Nombre, HoraInicio, HoraFin, usuarioCrea, fechaCrea)
        VALUES (@nombre, @horaInicio, @horaFin, @usuario, NOW())";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", txtNombreTurno.Text);
                    cmd.Parameters.AddWithValue("@horaInicio", dtpHoraInicio.Value.TimeOfDay);
                    cmd.Parameters.AddWithValue("@horaFin", dtpHoraFin.Value.TimeOfDay);
                    cmd.Parameters.AddWithValue("@usuario", usuarioAccionID);  // Registrar acción

                    cmd.ExecuteNonQuery();
                }
            }

            CargarTurnos();
            MessageBox.Show("Turno agregado correctamente.");
        }

        private void btnEditarTurno_Click(object sender, EventArgs e)
        {
            if (dgvTurnos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un turno.");
                return;
            }

            var row = dgvTurnos.SelectedRows[0];
            int idTurnoSeleccionado = Convert.ToInt32(row.Cells["ID_Turno"].Value);

            // Cargar los datos del turno para edición
            txtNombreTurno.Text = row.Cells["Nombre"].Value.ToString();
            
        

            MessageBox.Show("Turno cargado. Ahora puedes actualizar.");
        }

        private void btnActualizarTurno_Click(object sender, EventArgs e)
        {
            if (dgvTurnos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un turno para actualizar.");
                return;
            }

            int idTurnoSeleccionado = Convert.ToInt32(dgvTurnos.SelectedRows[0].Cells["ID_Turno"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
        UPDATE turno
        SET Nombre = @nombre,
            HoraInicio = @horaInicio,
            HoraFin = @horaFin,
            usuarioModifica = @usuario,
            fechaModifica = NOW()
        WHERE ID_Turno = @idTurno";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", txtNombreTurno.Text);
                    cmd.Parameters.AddWithValue("@horaInicio", dtpHoraInicio.Value.TimeOfDay);
                    cmd.Parameters.AddWithValue("@horaFin", dtpHoraFin.Value.TimeOfDay);
                    cmd.Parameters.AddWithValue("@usuario", usuarioAccionID);  // Registrar acción
                    cmd.Parameters.AddWithValue("@idTurno", idTurnoSeleccionado);

                    cmd.ExecuteNonQuery();
                }
            }

            CargarTurnos();
            MessageBox.Show("Turno actualizado correctamente.");
        }

        private void btnEliminarTurno_Click(object sender, EventArgs e)
        {
            if (dgvTurnos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un turno para eliminar.");
                return;
            }

            int idTurno = Convert.ToInt32(dgvTurnos.SelectedRows[0].Cells["ID_Turno"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
        UPDATE turno
        SET usuarioElimina = @usuario,
            fechaElimina = NOW()
        WHERE ID_Turno = @idTurno";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuarioAccionID);  // Registrar acción
                    cmd.Parameters.AddWithValue("@idTurno", idTurno);
                    cmd.ExecuteNonQuery();
                }
            }

            CargarTurnos();
            MessageBox.Show("Turno marcado como eliminado.");
        }

        private void CargarAsistencias()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
           SELECT a.ID_Asistencia, e.Nombre || ' ' || e.Apellido AS Empleado, t.Nombre AS Turno, 
               a.Fecha, a.HoraEntrada, a.HoraSalida, 
               a.fechaCrea, a.fechaModifica, a.fechaElimina,
               a.UsuarioCrea, a.UsuarioModifica, a.UsuarioElimina
        FROM Asistencia a
        JOIN Empleado e ON a.ID_Empleado = e.ID_Empleado
        JOIN Turno t ON a.ID_Turno = t.ID_Turno
        ORDER BY a.ID_Asistencia";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvAsistencias.DataSource = dt;
                }
            }
        }

        private void btnAgregarAsistencia_Click(object sender, EventArgs e)
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
        INSERT INTO Asistencia (ID_Empleado, Fecha, ID_Turno, HoraEntrada, HoraSalida, usuarioCrea, fechaCrea)
        VALUES (@idEmpleado, @fecha, @idTurno, @horaEntrada, @horaSalida, @usuario, NOW())";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@idEmpleado", (int)cmbEmpleado.SelectedValue);
                    cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value.Date);
                    cmd.Parameters.AddWithValue("@idTurno", (int)cmbTurno.SelectedValue);
                    cmd.Parameters.AddWithValue("@horaEntrada", dtpHoraEntrada.Value.TimeOfDay);
                    cmd.Parameters.AddWithValue("@horaSalida", dtpHoraSalida.Value.TimeOfDay);
                    cmd.Parameters.AddWithValue("@usuario", usuarioAccionID);  // Registrar acción

                    cmd.ExecuteNonQuery();
                }
            }

            CargarAsistencias();
            MessageBox.Show("Asistencia registrada correctamente.");
        }

        private void btnEditarAsistencia_Click(object sender, EventArgs e)
        {
            if (dgvAsistencias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una asistencia.");
                return;
            }

            var row = dgvAsistencias.SelectedRows[0];
            int idAsistenciaSeleccionada = Convert.ToInt32(row.Cells["ID_Asistencia"].Value);

            // Cargar el nombre del empleado y obtener el ID_Empleado
            string nombreEmpleado = row.Cells["Empleado"].Value.ToString();  // Obtener el nombre completo del empleado

            using (var con = DB.GetConnection())
            {
                con.Open();

                // Obtener el ID_Empleado a partir del nombre completo
                string queryEmpleado = "SELECT ID_Empleado FROM Empleado WHERE Nombre || ' ' || Apellido = @nombreEmpleado";
                using (var cmdEmpleado = new NpgsqlCommand(queryEmpleado, con))
                {
                    cmdEmpleado.Parameters.AddWithValue("@nombreEmpleado", nombreEmpleado);

                    var resultEmpleado = cmdEmpleado.ExecuteScalar();
                    if (resultEmpleado != null)
                    {
                        cmbEmpleado.SelectedValue = Convert.ToInt32(resultEmpleado);  // Asignamos el ID_Empleado al ComboBox
                    }
                    else
                    {
                        MessageBox.Show("Empleado no encontrado.");
                    }
                }
            }

            // Cargar el ID_Turno (turno) para el ComboBox
            string turnoNombre = row.Cells["Turno"].Value.ToString();  // Obtener el nombre del turno (por ejemplo, "Noche")

            using (var con = DB.GetConnection())
            {
                con.Open();

                // Obtener el ID_Turno a partir del nombre del turno
                string queryTurno = "SELECT ID_Turno FROM turno WHERE Nombre = @nombre";
                using (var cmdTurno = new NpgsqlCommand(queryTurno, con))
                {
                    cmdTurno.Parameters.AddWithValue("@nombre", turnoNombre);
                    var resultTurno = cmdTurno.ExecuteScalar();

                    if (resultTurno != null)
                    {
                        cmbTurno.SelectedValue = Convert.ToInt32(resultTurno);  // Establecemos el ID_Turno en el ComboBox
                    }
                    else
                    {
                        MessageBox.Show("Turno no encontrado.");
                    }
                }
            }

           

            MessageBox.Show("Asistencia cargada. Ahora puedes actualizar.");
        }

        private void btnActualizarAsistencia_Click(object sender, EventArgs e)
        {
            if (dgvAsistencias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una asistencia para actualizar.");
                return;
            }

            int idAsistenciaSeleccionada = Convert.ToInt32(dgvAsistencias.SelectedRows[0].Cells["ID_Asistencia"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
        UPDATE Asistencia
        SET ID_Empleado = @idEmpleado,
            Fecha = @fecha,
            ID_Turno = @idTurno,
            HoraEntrada = @horaEntrada,
            HoraSalida = @horaSalida,
            usuarioModifica = @usuario,
            fechaModifica = NOW()
        WHERE ID_Asistencia = @idAsistencia";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@idEmpleado", (int)cmbEmpleado.SelectedValue);
                    cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value.Date);
                    cmd.Parameters.AddWithValue("@idTurno", (int)cmbTurno.SelectedValue);
                    cmd.Parameters.AddWithValue("@horaEntrada", dtpHoraEntrada.Value.TimeOfDay);
                    cmd.Parameters.AddWithValue("@horaSalida", dtpHoraSalida.Value.TimeOfDay);
                    cmd.Parameters.AddWithValue("@usuario", usuarioAccionID);  // Registrar acción
                    cmd.Parameters.AddWithValue("@idAsistencia", idAsistenciaSeleccionada);

                    cmd.ExecuteNonQuery();
                }
            }

            CargarAsistencias();
            MessageBox.Show("Asistencia actualizada correctamente.");
        }

        private void btnEliminarAsistencia_Click(object sender, EventArgs e)
        {
            if (dgvAsistencias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una asistencia para eliminar.");
                return;
            }

            int idAsistencia = Convert.ToInt32(dgvAsistencias.SelectedRows[0].Cells["ID_Asistencia"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
        UPDATE Asistencia
        SET usuarioElimina = @usuario,
            fechaElimina = NOW()
        WHERE ID_Asistencia = @idAsistencia";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuarioAccionID);  // Registrar acción
                    cmd.Parameters.AddWithValue("@idAsistencia", idAsistencia);
                    cmd.ExecuteNonQuery();
                }
            }

            CargarAsistencias();
            MessageBox.Show("Asistencia marcada como eliminada.");
        }
    }
}

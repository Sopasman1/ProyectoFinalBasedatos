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
    
    public partial class FormSoporteTecnico : Form
    {
        private int usuarioAccionID;
        public FormSoporteTecnico(int idUsuarioAccion)
        {
            InitializeComponent();
            CargarTicketsSoporte();
            CargarEmpleados();
            CargarEquipos();
            CargarContratos();
            CargarProveedores();
            CargarMantenimientos();
            usuarioAccionID = idUsuarioAccion;
        }

        private void CargarEmpleados()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = "SELECT ID_Empleado, Nombre || ' ' || Apellido AS NombreCompleto FROM Empleado";
                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbEmpleado.DisplayMember = "NombreCompleto";
                    cmbEmpleado.ValueMember = "ID_Empleado";
                    cmbEmpleado.DataSource = dt;
                }
            }
        }

        private void CargarTicketsSoporte()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
            SELECT t.ID_Ticket,
           e.Nombre || ' ' || e.Apellido AS Empleado,
           t.Fecha,
           t.Comentario,
           t.fechaCrea, t.fechaModifica, t.fechaElimina,
           t.usuarioCrea, t.usuarioModifica, t.usuarioElimina
    FROM TicketSoporte t
    JOIN Empleado e ON t.ID_Empleado = e.ID_Empleado
    ORDER BY t.ID_Ticket";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvTicketsSoporte.DataSource = dt;
                }
            }
        }

        private void btnAgregarTicket_Click(object sender, EventArgs e)
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
    INSERT INTO TicketSoporte (Fecha, Comentario, ID_Empleado, usuarioCrea, fechaCrea)
    VALUES (@fecha, @comentario, @idEmpleado, @usuarioCrea, NOW())";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value.Date);
                    cmd.Parameters.AddWithValue("@comentario", txtComentario.Text);
                    cmd.Parameters.AddWithValue("@idEmpleado", (int)cmbEmpleado.SelectedValue);
                    cmd.Parameters.AddWithValue("@usuarioCrea", usuarioAccionID);  // Registra el usuario que crea el ticket

                    cmd.ExecuteNonQuery();
                }
            }

            CargarTicketsSoporte();
            MessageBox.Show("Ticket de soporte registrado correctamente.");
        }

        private void btnEditarTicket_Click(object sender, EventArgs e)
        {
            if (dgvTicketsSoporte.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un ticket de soporte.");
                return;
            }

            var row = dgvTicketsSoporte.SelectedRows[0];

            txtComentario.Text = row.Cells["Comentario"].Value.ToString();

            // Seleccionar empleado en ComboBox
            cmbEmpleado.Text = row.Cells["Empleado"].Value.ToString();

            MessageBox.Show("Ticket cargado. Ahora puedes actualizar.");
        }

        private void btnActualizarTicket_Click(object sender, EventArgs e)
        {
            if (dgvTicketsSoporte.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un ticket para actualizar.");
                return;
            }

            int idTicketSeleccionado = Convert.ToInt32(dgvTicketsSoporte.SelectedRows[0].Cells["ID_Ticket"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
    UPDATE TicketSoporte
    SET Fecha = @fecha,
        Comentario = @comentario,
        ID_Empleado = @idEmpleado,
        usuarioModifica = @usuarioModifica,
        fechaModifica = NOW()
    WHERE ID_Ticket = @idTicket";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value.Date);
                    cmd.Parameters.AddWithValue("@comentario", txtComentario.Text);
                    cmd.Parameters.AddWithValue("@idEmpleado", (int)cmbEmpleado.SelectedValue);
                    cmd.Parameters.AddWithValue("@usuarioModifica", usuarioAccionID);  // Registra el usuario que modifica el ticket
                    cmd.Parameters.AddWithValue("@idTicket", idTicketSeleccionado);

                    cmd.ExecuteNonQuery();
                }
            }

            CargarTicketsSoporte();
            MessageBox.Show("Ticket de soporte actualizado correctamente.");
        }

        private void btnEliminarTicket_Click(object sender, EventArgs e)
        {
            if (dgvTicketsSoporte.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un ticket para eliminar.");
                return;
            }

            int idTicket = Convert.ToInt32(
                dgvTicketsSoporte.SelectedRows[0].Cells["ID_Ticket"].Value
            );

            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
UPDATE TicketSoporte
SET estado_a = 0,
    usuarioElimina = @usuarioElimina,
    fechaElimina = NOW()
WHERE ID_Ticket = @idTicket";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@usuarioElimina", usuarioAccionID);
                    cmd.Parameters.AddWithValue("@idTicket", idTicket);
                    cmd.ExecuteNonQuery();
                }
            }

            CargarTicketsSoporte();
            MessageBox.Show("Ticket de soporte eliminado (borrado lógico).");
        }

        private void CargarEquipos()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
           SELECT e.ID_Equipo,
           e.Nombre,
           e.Tipo,
           e.Estado,
           e.FechaCompra,
           e.fechaCrea, e.fechaModifica, e.fechaElimina,
          e.usuarioCrea,
          e.usuarioModifica,
          e.usuarioElimina
    FROM Equipo e
    ORDER BY e.ID_Equipo";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvEquipos.DataSource = dt;
                }
            }
        }

        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
    INSERT INTO Equipo (Nombre, Tipo, Estado, FechaCompra, usuarioCrea, fechaCrea)
    VALUES (@nombre, @tipo, @estado, @fechaCompra, @usuarioCrea, NOW())";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", txtNombreEquipo.Text);
                    cmd.Parameters.AddWithValue("@tipo", txtTipoEquipo.Text);
                    cmd.Parameters.AddWithValue("@estado", cmbEstadoEquipo.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@fechaCompra", dtpFechaCompra.Value.Date);
                    cmd.Parameters.AddWithValue("@usuarioCrea", usuarioAccionID);  // Agregar el ID del usuario que crea el equipo

                    cmd.ExecuteNonQuery();
                }
            }

            CargarEquipos();
            MessageBox.Show("Equipo registrado correctamente.");
        }

        private void btnEditarEquipo_Click(object sender, EventArgs e)
        {
            if (dgvEquipos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un equipo.");
                return;
            }

            var row = dgvEquipos.SelectedRows[0];
            int idEquipoSeleccionado = Convert.ToInt32(row.Cells["ID_Equipo"].Value);

            // Cargar los datos del equipo para edición
            txtNombreEquipo.Text = row.Cells["Nombre"].Value.ToString();
            txtTipoEquipo.Text = row.Cells["Tipo"].Value.ToString();
            cmbEstadoEquipo.SelectedItem = row.Cells["Estado"].Value.ToString();
            dtpFechaCompra.Value = Convert.ToDateTime(row.Cells["FechaCompra"].Value);

            MessageBox.Show("Equipo cargado. Ahora puedes actualizar.");
        }

        private void btnActualizarEquipo_Click(object sender, EventArgs e)
        {
            if (dgvEquipos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un equipo para actualizar.");
                return;
            }

            int idEquipoSeleccionado = Convert.ToInt32(dgvEquipos.SelectedRows[0].Cells["ID_Equipo"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
    UPDATE Equipo
    SET Nombre = @nombre,
        Tipo = @tipo,
        Estado = @estado,
        FechaCompra = @fechaCompra,
        usuarioModifica = @usuarioModifica,
        fechaModifica = NOW()
    WHERE ID_Equipo = @idEquipo";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", txtNombreEquipo.Text);
                    cmd.Parameters.AddWithValue("@tipo", txtTipoEquipo.Text);
                    cmd.Parameters.AddWithValue("@estado", cmbEstadoEquipo.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@fechaCompra", dtpFechaCompra.Value.Date);
                    cmd.Parameters.AddWithValue("@usuarioModifica", usuarioAccionID);  // Agregar el ID del usuario que modifica el equipo
                    cmd.Parameters.AddWithValue("@idEquipo", idEquipoSeleccionado);

                    cmd.ExecuteNonQuery();
                }
            }

            CargarEquipos();
            MessageBox.Show("Equipo actualizado correctamente.");
        }

        private void btnEliminarEquipo_Click(object sender, EventArgs e)
        {
            if (dgvEquipos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un equipo para eliminar.");
                return;
            }

            int idEquipo = Convert.ToInt32(
                dgvEquipos.SelectedRows[0].Cells["ID_Equipo"].Value
            );

            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
UPDATE Equipo
SET estado = 0,
    usuarioElimina = @usuario,
    fechaElimina = NOW()
WHERE ID_Equipo = @idEquipo";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuarioAccionID);
                    cmd.Parameters.AddWithValue("@idEquipo", idEquipo);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Equipo eliminado (borrado lógico).");
            CargarEquipos();
        }

        private void CargarMantenimientos()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
            SELECT m.ID_Mantenimiento,
           e.Nombre AS Equipo,
           m.Fecha,
           m.Descripcion,
           m.Costo,
           m.fechaCrea, m.fechaModifica, m.fechaElimina,
           m.usuarioCrea,
           m.usuarioModifica,
           m.usuarioElimina
    FROM Mantenimiento m
    JOIN Equipo e ON m.ID_Equipo = e.ID_Equipo
    ORDER BY m.ID_Mantenimiento";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvMantenimientos.DataSource = dt;
                }
            }
        }

        private void btnAgregarMantenimiento_Click(object sender, EventArgs e)
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
    INSERT INTO Mantenimiento (ID_Equipo, Fecha, Descripcion, Costo, usuarioCrea, fechaCrea)
    VALUES (@idEquipo, @fecha, @descripcion, @costo, @usuarioCrea, NOW())";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@idEquipo", (int)cmbEquipo2.SelectedValue);
                    cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value.Date);
                    cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                    cmd.Parameters.AddWithValue("@costo", Convert.ToDecimal(txtCosto.Text));
                    cmd.Parameters.AddWithValue("@usuarioCrea", usuarioAccionID); // Agregar el ID del usuario que crea el mantenimiento

                    cmd.ExecuteNonQuery();
                }
            }

            CargarMantenimientos();
            MessageBox.Show("Mantenimiento registrado correctamente.");
        }

        private void btnEditarMantenimiento_Click(object sender, EventArgs e)
        {

            if (dgvMantenimientos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un mantenimiento.");
                return;
            }

            var row = dgvMantenimientos.SelectedRows[0];
            int idMantenimientoSeleccionado = Convert.ToInt32(row.Cells["ID_Mantenimiento"].Value);

            // Cargar los datos del mantenimiento para edición
            cmbEquipo2.SelectedValue = row.Cells["Equipo"].Value;
            dtpFecha1.Value = Convert.ToDateTime(row.Cells["Fecha"].Value);
            txtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
            txtCosto.Text = row.Cells["Costo"].Value.ToString();

            MessageBox.Show("Mantenimiento cargado. Ahora puedes actualizar.");
        }

        private void btnActualizarMantenimiento_Click(object sender, EventArgs e)
        {
            if (dgvMantenimientos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un mantenimiento para actualizar.");
                return;
            }

            int idMantenimientoSeleccionado = Convert.ToInt32(dgvMantenimientos.SelectedRows[0].Cells["ID_Mantenimiento"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
    UPDATE Mantenimiento
    SET ID_Equipo = @idEquipo,
        Fecha = @fecha,
        Descripcion = @descripcion,
        Costo = @costo,
        usuarioModifica = @usuarioModifica,
        fechaModifica = NOW()
    WHERE ID_Mantenimiento = @idMantenimiento";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@idEquipo", (int)cmbEquipo2.SelectedValue);
                    cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value.Date);
                    cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                    cmd.Parameters.AddWithValue("@costo", Convert.ToDecimal(txtCosto.Text));
                    cmd.Parameters.AddWithValue("@usuarioModifica", usuarioAccionID); // Agregar el ID del usuario que modifica el mantenimiento
                    cmd.Parameters.AddWithValue("@idMantenimiento", idMantenimientoSeleccionado);

                    cmd.ExecuteNonQuery();
                }
            }

            CargarMantenimientos();
            MessageBox.Show("Mantenimiento actualizado correctamente.");
        }

        private void btnEliminarMantenimiento_Click(object sender, EventArgs e)
        {
            if (dgvMantenimientos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un mantenimiento para eliminar.");
                return;
            }

            int idMantenimiento = Convert.ToInt32(
                dgvMantenimientos.SelectedRows[0].Cells["ID_Mantenimiento"].Value
            );

            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
UPDATE mantenimiento
SET estado = 0,
    usuarioelimina = @usuario,
    fechaelimina = NOW()
WHERE id_mantenimiento = @id
  AND estado = 1";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuarioAccionID);
                    cmd.Parameters.AddWithValue("@id", idMantenimiento);
                    cmd.ExecuteNonQuery();
                }
            }

            CargarMantenimientos();
            MessageBox.Show("Mantenimiento eliminado (borrado lógico).");
        }

        private void CargarContratos()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
           SELECT c.ID_Contrato, 
               p.Nombre AS Proveedor, 
               c.FechaInicio, 
               c.FechaFin, 
               c.Monto,
               c.fechaCrea, c.fechaModifica, c.fechaElimina,
               c.usuarioCrea,
               c.usuarioModifica,
               c.usuarioElimina
        FROM ContratoServicio c
        JOIN ProveedorServicio p ON c.ID_ProveedorServ = p.ID_ProveedorServ
        ORDER BY c.ID_Contrato";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvContratos.DataSource = dt;
                }
            }
        }

        private void CargarProveedores()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = "SELECT ID_ProveedorServ, Nombre FROM ProveedorServicio";
                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbProveedorserv.DisplayMember = "Nombre";
                    cmbProveedorserv.ValueMember = "ID_ProveedorServ";
                    cmbProveedorserv.DataSource = dt;
                }
            }
        }

        private void btnAgregarContrato_Click(object sender, EventArgs e)
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
        INSERT INTO ContratoServicio (ID_ProveedorServ, FechaInicio, FechaFin, Monto, usuarioCrea, fechaCrea)
        VALUES (@idProveedor, @fechaInicio, @fechaFin, @monto, @usuarioCrea, NOW())";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@idProveedor", (int)cmbProveedorserv.SelectedValue);
                    cmd.Parameters.AddWithValue("@fechaInicio", dtpFechaInicio.Value.Date);
                    cmd.Parameters.AddWithValue("@fechaFin", dtpFechaFin.Value.Date);
                    cmd.Parameters.AddWithValue("@monto", Convert.ToDecimal(txtMonto.Text));
                    cmd.Parameters.AddWithValue("@usuarioCrea", usuarioAccionID); // Usuario que crea el contrato

                    cmd.ExecuteNonQuery();
                }
            }

            CargarContratos();
            MessageBox.Show("Contrato de servicio registrado correctamente.");
        }

        private void btnEditarContrato_Click(object sender, EventArgs e)
        {
            if (dgvContratos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un contrato.");
                return;
            }

            var row = dgvContratos.SelectedRows[0];
            int idContratoSeleccionado = Convert.ToInt32(row.Cells["ID_Contrato"].Value);

            // Cargar los datos del contrato para edición
            cmbProveedorserv.SelectedValue = row.Cells["Proveedor"].Value;
            dtpFechaInicio.Value = Convert.ToDateTime(row.Cells["FechaInicio"].Value);
            dtpFechaFin.Value = Convert.ToDateTime(row.Cells["FechaFin"].Value);
            txtMonto.Text = row.Cells["Monto"].Value.ToString();

            MessageBox.Show("Contrato cargado. Ahora puedes actualizar.");
        }

        private void btnActualizarContrato_Click(object sender, EventArgs e)
        {
            if (dgvContratos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un contrato para actualizar.");
                return;
            }

            int idContratoSeleccionado = Convert.ToInt32(dgvContratos.SelectedRows[0].Cells["ID_Contrato"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
        UPDATE ContratoServicio
        SET ID_ProveedorServ = @idProveedor,
            FechaInicio = @fechaInicio,
            FechaFin = @fechaFin,
            Monto = @monto,
            usuarioModifica = @usuarioModifica,
            fechaModifica = NOW()
        WHERE ID_Contrato = @idContrato";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@idProveedor", (int)cmbProveedorserv.SelectedValue);
                    cmd.Parameters.AddWithValue("@fechaInicio", dtpFechaInicio.Value.Date);
                    cmd.Parameters.AddWithValue("@fechaFin", dtpFechaFin.Value.Date);
                    cmd.Parameters.AddWithValue("@monto", Convert.ToDecimal(txtMonto.Text));
                    cmd.Parameters.AddWithValue("@usuarioModifica", usuarioAccionID); // Usuario que modifica el contrato
                    cmd.Parameters.AddWithValue("@idContrato", idContratoSeleccionado);

                    cmd.ExecuteNonQuery();
                }
            }

            CargarContratos();
            MessageBox.Show("Contrato actualizado correctamente.");
        }

        private void btnEliminarContrato_Click(object sender, EventArgs e)
        {
            if (dgvContratos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un contrato para eliminar.");
                return;
            }

            int idContrato = Convert.ToInt32(
                dgvContratos.SelectedRows[0].Cells["ID_Contrato"].Value
            );

            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
UPDATE ContratoServicio
SET estado = 0,
    usuarioElimina = @usuarioElimina,
    fechaElimina = NOW()
WHERE ID_Contrato = @idContrato";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@usuarioElimina", usuarioAccionID);
                    cmd.Parameters.AddWithValue("@idContrato", idContrato);
                    cmd.ExecuteNonQuery();
                }
            }

            CargarContratos();
            MessageBox.Show("Contrato eliminado (borrado lógico).");
        }
    }
}

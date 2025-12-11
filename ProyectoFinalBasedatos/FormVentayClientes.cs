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
    public partial class FormVentayClientes : Form
    {
        private int usuarioAccionID;
        public FormVentayClientes(int idUsuarioAccion)
        {
            InitializeComponent();
            CargarPaisesCliente();
            CargarClientes();
            CargarClientesPedido();
            CargarEstadosPedido();
            CargarPedidos();
            CargarPedidosFactura();
            CargarFacturas();
            CargarMetodosPago();
            CargarPagos();
            CargarEnvios();
            CargarTransportistasEnvio();
            CargarPedidosEnvio();
            CargarPedidop();
            usuarioAccionID = idUsuarioAccion;
        }

        int idFacturaSeleccionada = -1;

        int idPedidoSeleccionado = -1;

        int idClienteSeleccionado = -1;

        private void CargarClientes()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
             SELECT c.id_cliente, c.nombre, c.apellido, c.email, 
                   c.telefono, p.nombre AS pais, c.id_pais,
                   c.fechaCrea, c.fechaModifica, c.fechaElimina,
                   c.usuarioCrea, c.usuarioModifica, c.usuarioElimina
            FROM cliente c
            INNER JOIN pais p ON p.id_pais = c.id_pais
            ORDER BY c.id_cliente";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvClientes.DataSource = dt;
                }
            }

            // Ocultar columnas no necesarias
            dgvClientes.Columns["id_pais"].Visible = false;
        }

        private void CargarPaisesCliente()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = "SELECT id_pais, nombre FROM pais ORDER BY nombre";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbPaisCliente.DataSource = dt;
                    cmbPaisCliente.DisplayMember = "nombre";
                    cmbPaisCliente.ValueMember = "id_pais";
                }
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
            INSERT INTO cliente(nombre, apellido, email, telefono, id_pais, usuarioCrea, fechaCrea)
            VALUES (@nombre, @apellido, @email, @telefono, @pais, @usuarioCrea, NOW())";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", txtNombreCliente.Text);
                    cmd.Parameters.AddWithValue("@apellido", txtApellidoCliente.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmailCliente.Text);
                    cmd.Parameters.AddWithValue("@telefono", txtTelefonoCliente.Text);
                    cmd.Parameters.AddWithValue("@pais", Convert.ToInt32(cmbPaisCliente.SelectedValue));
                    cmd.Parameters.AddWithValue("@usuarioCrea", usuarioAccionID);  // Registrar usuario que crea

                    cmd.ExecuteNonQuery();
                }
            }

            CargarClientes();
            MessageBox.Show("Cliente agregado correctamente.");
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un cliente.");
                return;
            }

            var row = dgvClientes.SelectedRows[0];

            idClienteSeleccionado = Convert.ToInt32(row.Cells["id_cliente"].Value);

            txtNombreCliente.Text = row.Cells["nombre"].Value.ToString();
            txtApellidoCliente.Text = row.Cells["apellido"].Value.ToString();
            txtEmailCliente.Text = row.Cells["email"].Value.ToString();
            txtTelefonoCliente.Text = row.Cells["telefono"].Value.ToString();
            cmbPaisCliente.SelectedValue = Convert.ToInt32(row.Cells["id_pais"].Value);

            MessageBox.Show("Cliente cargado. Ahora puedes actualizar.");
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            if (idClienteSeleccionado == -1)
            {
                MessageBox.Show("Primero selecciona un cliente con Editar.");
                return;
            }

            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
            UPDATE cliente
            SET nombre = @nombre,
                apellido = @apellido,
                email = @email,
                telefono = @telefono,
                id_pais = @pais,
                usuarioModifica = @usuarioModifica,
                fechaModifica = NOW()
            WHERE id_cliente = @id";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", txtNombreCliente.Text);
                    cmd.Parameters.AddWithValue("@apellido", txtApellidoCliente.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmailCliente.Text);
                    cmd.Parameters.AddWithValue("@telefono", txtTelefonoCliente.Text);
                    cmd.Parameters.AddWithValue("@pais", Convert.ToInt32(cmbPaisCliente.SelectedValue));
                    cmd.Parameters.AddWithValue("@usuarioModifica", usuarioAccionID);  // Registrar el usuario que modifica
                    cmd.Parameters.AddWithValue("@id", idClienteSeleccionado);

                    cmd.ExecuteNonQuery();
                }
            }

            CargarClientes();
            MessageBox.Show("Cliente actualizado correctamente.");
            idClienteSeleccionado = -1;
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un cliente.");
                return;
            }

            int id = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["id_cliente"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
            UPDATE cliente
            SET nombre = '',
                apellido = '',
                email = '',
                telefono = '',
                id_pais = NULL,
                usuarioElimina = @usuarioElimina,
                fechaElimina = NOW()
            WHERE id_cliente = @id";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@usuarioElimina", usuarioAccionID);  // Registrar el usuario que elimina
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            CargarClientes();
            MessageBox.Show("Cliente marcado como eliminado.");
        }

        private void CargarPedidos()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
           SELECT p.id_pedido, p.fecha, 
                   p.id_cliente, c.nombre || ' ' || c.apellido AS cliente,
                   p.total, p.estado,
                   p.usuarioCrea, p.usuarioModifica, p.usuarioElimina,
                   p.fechaCrea, p.fechaModifica, p.fechaElimina
            FROM pedido p
            INNER JOIN cliente c ON c.id_cliente = p.id_cliente
            ORDER BY p.id_pedido";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvPedidos.DataSource = dt;
                }
            }

            dgvPedidos.Columns["id_cliente"].Visible = false;
        }

        private void CargarClientesPedido()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = "SELECT id_cliente, nombre || ' ' || apellido AS cliente FROM cliente ORDER BY nombre";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbClientePedido.DataSource = dt;
                    cmbClientePedido.DisplayMember = "cliente";
                    cmbClientePedido.ValueMember = "id_cliente";
                }
            }
        }

        private void CargarEstadosPedido()
        {
            cmbEstadoPedido.Items.Clear();
            cmbEstadoPedido.Items.Add("Pendiente");
            cmbEstadoPedido.Items.Add("Procesado");
            cmbEstadoPedido.Items.Add("Enviado");
            cmbEstadoPedido.Items.Add("Entregado");
            cmbEstadoPedido.Items.Add("Cancelado");

            cmbEstadoPedido.SelectedIndex = 0;
        }

        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
            INSERT INTO pedido(fecha, id_cliente, total, estado, usuarioCrea, fechaCrea)
            VALUES (@fecha, @cliente, @total, @estado, @usuarioCrea, NOW())";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@fecha", dtpFechaPedido.Value);
                    cmd.Parameters.AddWithValue("@cliente", Convert.ToInt32(cmbClientePedido.SelectedValue));
                    cmd.Parameters.AddWithValue("@total", Convert.ToDecimal(txtTotalPedido.Text));
                    cmd.Parameters.AddWithValue("@estado", cmbEstadoPedido.Text);
                    cmd.Parameters.AddWithValue("@usuarioCrea", usuarioAccionID);  // Registrar quien crea el pedido

                    cmd.ExecuteNonQuery();
                }
            }

            CargarPedidos();
            MessageBox.Show("Pedido agregado.");
        }

        private void btnEditarPedido_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un pedido.");
                return;
            }

            var row = dgvPedidos.SelectedRows[0];

            idPedidoSeleccionado = Convert.ToInt32(row.Cells["id_pedido"].Value);

            dtpFechaPedido.Value = Convert.ToDateTime(row.Cells["fecha"].Value);
            cmbClientePedido.SelectedValue = Convert.ToInt32(row.Cells["id_cliente"].Value);
            txtTotalPedido.Text = row.Cells["total"].Value.ToString();
            cmbEstadoPedido.Text = row.Cells["estado"].Value.ToString();

            MessageBox.Show("Pedido cargado para edición.");
        }

        private void btnActualizarPedido_Click(object sender, EventArgs e)
        {
            if (idPedidoSeleccionado == -1)
            {
                MessageBox.Show("Primero selecciona un pedido con Editar.");
                return;
            }

            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
            UPDATE pedido
            SET fecha=@fecha,
                id_cliente=@cliente,
                total=@total,
                estado=@estado,
                usuarioModifica=@usuarioModifica,
                fechaModifica=NOW()
            WHERE id_pedido=@id";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@fecha", dtpFechaPedido.Value);
                    cmd.Parameters.AddWithValue("@cliente", Convert.ToInt32(cmbClientePedido.SelectedValue));
                    cmd.Parameters.AddWithValue("@total", Convert.ToDecimal(txtTotalPedido.Text));
                    cmd.Parameters.AddWithValue("@estado", cmbEstadoPedido.Text);
                    cmd.Parameters.AddWithValue("@usuarioModifica", usuarioAccionID);  // Registrar quien modifica el pedido
                    cmd.Parameters.AddWithValue("@id", idPedidoSeleccionado);

                    cmd.ExecuteNonQuery();
                }
            }

            CargarPedidos();
            MessageBox.Show("Pedido actualizado.");
            idPedidoSeleccionado = -1;
        }

        private void btnEliminarPedido_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un pedido.");
                return;
            }

            int id = Convert.ToInt32(dgvPedidos.SelectedRows[0].Cells["id_pedido"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
            UPDATE pedido
            SET estado = 'Eliminado','Eliminado'
                        usuarioElimina = @usuarioElimina,
                fechaElimina = NOW()
                    WHERE id_pedido = @id";
        
        using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@usuarioElimina", usuarioAccionID);  // Registrar quien elimina el pedido
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            CargarPedidos();
            MessageBox.Show("Pedido marcado como eliminado.");
        }

        private void CargarFacturas()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
            SELECT f.id_factura, f.id_pedido,
                   p.fecha AS fecha_pedido,
                   f.fecha AS fecha_factura,
                   f.total, f.impuestos,
                   f.fechaCrea, f.fechaModifica, f.fechaElimina,
                   f.usuariocrea AS usuarioCrea,
                   f.usuariomodifica AS usuarioModifica,
                   f.usuarioelimina AS usuarioElimina
            FROM factura f
            INNER JOIN pedido p ON p.id_pedido = f.id_pedido
            ORDER BY f.id_factura";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvFactura.DataSource = dt;
                }
            }

            // Ocultar columnas internas
            dgvFactura.Columns["id_pedido"].Visible = false;
        }

        private void CargarPedidosFactura()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
            SELECT id_pedido, 
                   'Pedido #' || id_pedido || ' - ' || fecha AS pedido
            FROM pedido
            ORDER BY id_pedido";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbPedidoFactura.DataSource = dt;
                    cmbPedidoFactura.DisplayMember = "pedido";
                    cmbPedidoFactura.ValueMember = "id_pedido";
                }
            }
        }

        private void btnAgregarFactura_Click(object sender, EventArgs e)
        {
            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
            INSERT INTO factura(id_pedido, fecha, total, impuestos, usuarioCrea, fechaCrea)
            VALUES (@pedido, @fecha, @total, @impuestos, @usuarioCrea, NOW())";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@pedido", Convert.ToInt32(cmbPedidoFactura.SelectedValue));
                    cmd.Parameters.AddWithValue("@fecha", dtpFechaFactura.Value);
                    cmd.Parameters.AddWithValue("@total", Convert.ToDecimal(txtTotalFactura.Text));
                    cmd.Parameters.AddWithValue("@impuestos", Convert.ToDecimal(txtImpuestosFactura.Text));
                    cmd.Parameters.AddWithValue("@usuarioCrea", usuarioAccionID);  // Registrar quien crea la factura

                    cmd.ExecuteNonQuery();
                }
            }

            CargarFacturas();
            MessageBox.Show("Factura agregada.");
        }

        private void btnEditarFactura_Click(object sender, EventArgs e)
        {
            if (dgvFactura.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una factura para editar.");
                return;
            }

            // Obtener fila seleccionada
            var row = dgvFactura.SelectedRows[0];

            // Guardar ID de la factura
            idFacturaSeleccionada = Convert.ToInt32(row.Cells["id_factura"].Value);

            // Cargar datos en los controles
            cmbPedidoFactura.SelectedValue = Convert.ToInt32(row.Cells["id_pedido"].Value);
            txtTotalFactura.Text = row.Cells["total"].Value.ToString();
            txtImpuestosFactura.Text = row.Cells["impuestos"].Value.ToString();

            MessageBox.Show("Factura cargada. Ahora puedes actualizar.");
        }

        private void btnActualizarFactura_Click(object sender, EventArgs e)
        {
            if (idFacturaSeleccionada == -1)
            {
                MessageBox.Show("Primero selecciona una factura con Editar.");
                return;
            }

            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
            UPDATE factura
            SET id_pedido=@pedido,
                fecha=@fecha,
                total=@total,
                impuestos=@impuestos,
                usuarioModifica=@usuarioModifica,
                fechaModifica=NOW()
            WHERE id_factura=@id";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@pedido", Convert.ToInt32(cmbPedidoFactura.SelectedValue));
                    cmd.Parameters.AddWithValue("@fecha", dtpFechaFactura.Value);
                    cmd.Parameters.AddWithValue("@total", Convert.ToDecimal(txtTotalFactura.Text));
                    cmd.Parameters.AddWithValue("@impuestos", Convert.ToDecimal(txtImpuestosFactura.Text));
                    cmd.Parameters.AddWithValue("@usuarioModifica", usuarioAccionID);  // Registrar quien modifica la factura
                    cmd.Parameters.AddWithValue("@id", idFacturaSeleccionada);

                    cmd.ExecuteNonQuery();
                }
            }

            CargarFacturas();
            MessageBox.Show("Factura actualizada.");
            idFacturaSeleccionada = -1;
        }

        private void btnEliminarFactura_Click(object sender, EventArgs e)
        {
            if (dgvFactura.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una factura.");
                return;
            }

            int id = Convert.ToInt32(dgvFactura.SelectedRows[0].Cells["id_factura"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = @"
            UPDATE factura
            SET usuarioElimina=@usuarioElimina,
                fechaElimina=NOW()
            WHERE id_factura=@id";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@usuarioElimina", usuarioAccionID);  // Registrar quien elimina la factura
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            CargarFacturas();
            MessageBox.Show("Factura eliminada.");
        }

        private void CargarMetodosPago()
        {
            string query = "SELECT id_metodopago, nombre FROM metodopago ORDER BY id_metodopago";

            using (var con = DB.GetConnection())
            {
                con.Open();
                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbMetodoPago.DataSource = dt;
                    cmbMetodoPago.DisplayMember = "nombre";
                    cmbMetodoPago.ValueMember = "id_metodopago";
                }
            }
        }

        private void CargarPagos()
        {
            string query = @"SELECT p.id_pago, 
           ped.fecha AS pedido,
           mp.nombre AS metodo_pago,
           p.monto,
           p.fecha,
           p.fechaCrea, p.fechaModifica, p.fechaElimina,
           p.UsuarioCrea AS usuarioCrea,
           p.UsuarioModifica AS usuarioModifica,
           p.UsuarioElimina AS usuarioElimina
    FROM pago p
    INNER JOIN pedido ped ON ped.id_pedido = p.id_pedido
    INNER JOIN metodopago mp ON mp.id_metodopago = p.id_metodopago
    ORDER BY p.id_pago";

            using (var con = DB.GetConnection())
            {
                con.Open();
                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPagos.DataSource = dt;
                }
            }
        }

        private void btnAgregarPago_Click(object sender, EventArgs e)
        {
            string query = @"
    INSERT INTO pago (id_pedido, id_metodopago, monto, fecha, usuarioCrea, fechaCrea)
    VALUES (@pedido, @metodo, @monto, @fecha, @usuario, NOW())";

            using (var con = DB.GetConnection())
            {
                con.Open();
                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@pedido", (int)cmbPedido.SelectedValue);
                    cmd.Parameters.AddWithValue("@metodo", (int)cmbMetodoPago.SelectedValue);
                    cmd.Parameters.AddWithValue("@monto", Convert.ToDecimal(txtMonto.Text));
                    cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value.Date);
                    cmd.Parameters.AddWithValue("@usuario", usuarioAccionID); // Registrar acción del usuario

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Pago registrado correctamente");
            CargarPagos();
        }

        private void btnEliminarPago_Click(object sender, EventArgs e)
        {
            if (dgvPagos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un pago para eliminar.");
                return;
            }

            int idPago = Convert.ToInt32(dgvPagos.SelectedRows[0].Cells["id_pago"].Value);

            string query = @"
    UPDATE pago 
    SET usuarioElimina = @usuario, 
        fechaElimina = NOW() 
    WHERE id_pago = @id";

            using (var con = DB.GetConnection())
            {
                con.Open();
                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuarioAccionID);  // Registrar acción del usuario
                    cmd.Parameters.AddWithValue("@id", idPago);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Pago marcado como eliminado.");
            CargarPagos();
        }

        private void btnLimpiarPago_Click(object sender, EventArgs e)
        {
            cmbPedido.SelectedIndex = 0;
            cmbMetodoPago.SelectedIndex = 0;
            txtMonto.Clear();
            dtpFecha.Value = DateTime.Now;
        }

        private void CargarPedidop()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = "SELECT id_pedido, 'Pedido #' || id_pedido || ' - ' || fecha AS pedido FROM pedido ORDER BY id_pedido";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbPedido.DataSource = dt;
                    cmbPedido.DisplayMember = "pedido";
                    cmbPedido.ValueMember = "id_pedido";
                }
            }
        }
        

        private void CargarPedidosEnvio()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = "SELECT id_pedido, 'Pedido #' || id_pedido || ' - ' || fecha AS pedido FROM pedido ORDER BY id_pedido";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbPedidoEnvio.DataSource = dt;
                    cmbPedidoEnvio.DisplayMember = "pedido";
                    cmbPedidoEnvio.ValueMember = "id_pedido";
                }
            }
        }

        private void CargarTransportistasEnvio()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = "SELECT id_transportista, nombre FROM transportista ORDER BY nombre";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbTransportistaEnvio.DataSource = dt;
                    cmbTransportistaEnvio.DisplayMember = "nombre";
                    cmbTransportistaEnvio.ValueMember = "id_transportista";
                }
            }
        }

        private void CargarEnvios()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
             SELECT 
        e.ID_Envio, 
        e.FechaEnvio, 
        e.Estado, 
        e.ID_Transportista,       -- 🔹 AQUI LO AGREGAS
        p.id_pedido, 
        t.nombre AS Transportista,
        e.fechaCrea, e.fechaModifica, e.fechaElimina,
        e.UsuarioCrea AS usuarioCrea, 
        e.UsuarioModifica AS usuarioModifica, 
        e.UsuarioElimina AS usuarioElimina
    FROM Envio e
    INNER JOIN Pedido p ON p.id_pedido = e.ID_Pedido
    INNER JOIN Transportista t ON t.id_transportista = e.ID_Transportista
    ORDER BY e.ID_Envio";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvEnvios.DataSource = dt;
                }
            }
        }

        private void btnAgregarEnvio_Click(object sender, EventArgs e)
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
        INSERT INTO Envio (ID_Pedido, FechaEnvio, ID_Transportista, Estado, usuarioCrea, fechaCrea)
        VALUES (@pedido, @fecha, @transportista, @estado, @usuario, NOW())";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@pedido", Convert.ToInt32(cmbPedidoEnvio.SelectedValue));
                    cmd.Parameters.AddWithValue("@fecha", dtpFechaEnvio.Value.Date);
                    cmd.Parameters.AddWithValue("@transportista", Convert.ToInt32(cmbTransportistaEnvio.SelectedValue));
                    cmd.Parameters.AddWithValue("@estado", txtEstadoEnvio.Text);
                    cmd.Parameters.AddWithValue("@usuario", usuarioAccionID);  // Registrar acción del usuario

                    cmd.ExecuteNonQuery();
                }
            }

            CargarEnvios();
            MessageBox.Show("Envío registrado correctamente.");
        }

        private void btnEditarEnvio_Click(object sender, EventArgs e)
        {
            if (dgvEnvios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un envío.");
                return;
            }

            var row = dgvEnvios.SelectedRows[0];
            int idEnvioSeleccionado = Convert.ToInt32(row.Cells["ID_Envio"].Value);

            // Cargar datos para editar
            cmbPedidoEnvio.SelectedValue = Convert.ToInt32(row.Cells["id_pedido"].Value);
            cmbTransportistaEnvio.SelectedValue = Convert.ToInt32(row.Cells["ID_Transportista"].Value);
            txtEstadoEnvio.Text = row.Cells["Estado"].Value.ToString();

            MessageBox.Show("Envío cargado. Ahora puedes actualizar.");
        }

        private void btnActualizarEnvio_Click(object sender, EventArgs e)
        {
            if (dgvEnvios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un envío para actualizar.");
                return;
            }

            int idEnvioSeleccionado = Convert.ToInt32(dgvEnvios.SelectedRows[0].Cells["ID_Envio"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
        UPDATE Envio
        SET ID_Pedido = @pedido,
            FechaEnvio = @fecha,
            ID_Transportista = @transportista,
            Estado = @estado,
            usuarioModifica = @usuario,
            fechaModifica = NOW()
        WHERE ID_Envio = @idEnvio";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@pedido", Convert.ToInt32(cmbPedidoEnvio.SelectedValue));
                    cmd.Parameters.AddWithValue("@fecha", dtpFechaEnvio.Value.Date);
                    cmd.Parameters.AddWithValue("@transportista", Convert.ToInt32(cmbTransportistaEnvio.SelectedValue));
                    cmd.Parameters.AddWithValue("@estado", txtEstadoEnvio.Text);
                    cmd.Parameters.AddWithValue("@usuario", usuarioAccionID);  // Registrar acción del usuario
                    cmd.Parameters.AddWithValue("@idEnvio", idEnvioSeleccionado);

                    cmd.ExecuteNonQuery();
                }
            }

            CargarEnvios();
            MessageBox.Show("Envío actualizado correctamente.");
        }

        private void btnEliminarEnvio_Click(object sender, EventArgs e)
        {
            if (dgvEnvios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un envío para eliminar.");
                return;
            }

            int idEnvio = Convert.ToInt32(dgvEnvios.SelectedRows[0].Cells["ID_Envio"].Value);

            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = @"
        UPDATE Envio
        SET usuarioElimina = @usuario,
            fechaElimina = NOW()
        WHERE ID_Envio = @idEnvio";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuarioAccionID);  // Registrar acción del usuario
                    cmd.Parameters.AddWithValue("@idEnvio", idEnvio);
                    cmd.ExecuteNonQuery();
                }
            }

            CargarEnvios();
            MessageBox.Show("Envío marcado como eliminado.");
        }
    }
}

using Npgsql;
using System.Data;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
namespace ProyectoFinalBasedatos
{
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
            CargarRoles();
            CargarEmpleados();
            cmbRol.Enabled = false;
        }

        private int ValidarUsuario(string usuario, string clave)
        {
            try
            {
                using (var con = DB.GetConnection())
                {
                    con.Open();

                    string sql = @"
                SELECT ID_Usuario, ContrasenaHash, ContrasenaSalt
                FROM Usuario
                WHERE NombreUsuario = @u
            ";

                    using (var cmd = new NpgsqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@u", usuario);

                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                string hashBD = dr.GetString(dr.GetOrdinal("ContrasenaHash"));
                                string saltBD = dr.GetString(dr.GetOrdinal("ContrasenaSalt"));

                                // Generar hash con la contraseña ingresada y el salt de BD
                                string hashIngresado =
                                    SeguridadPasswort.GenerarHash(clave, saltBD);

                                // Comparar hashes
                                if (hashBD == hashIngresado)
                                {
                                    return dr.GetInt32(dr.GetOrdinal("ID_Usuario"));
                                }
                                else
                                {
                                    return 0; // Contraseña incorrecta
                                }
                            }
                            else
                            {
                                return 0; // Usuario no existe
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en ValidarUsuario: " + ex.Message);
                return 0;
            }
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            if (usuario == "" || contrasena == "")
            {
                MessageBox.Show("Ingresa usuario y contraseña.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idUsuario = ValidarUsuario(usuario, contrasena);

            if (idUsuario > 0)
            {
                // 1. OBTENER ROL REAL DEL USUARIO
                int idRol = ObtenerRolUsuario(idUsuario);

                // 2. REGISTRAR AUDITORÍA
                int idUsuarioAccion = RegistrarUsuarioAccion(idUsuario, idRol);

                // 3. GUARDAR DATOS EN SESIÓN
                SesionUsuario.ID_Usuario = idUsuario;
                SesionUsuario.ID_Rol = idRol;
                SesionUsuario.ID_UsuarioAccion = idUsuarioAccion;

                // 4. REGISTRAR INICIO DE SESIÓN
                int idSesion = RegistrarInicioSesion(idUsuario);

                MessageBox.Show("Inicio de sesión exitoso.", "Bienvenido");

                // 5. ABRIR PRINCIPAL
                FormPrincipal principal = new FormPrincipal(idUsuario, idSesion,idUsuarioAccion);
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private int ObtenerRolUsuario(int idUsuario)
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string sql = "SELECT ID_Rol FROM Usuario WHERE ID_Usuario=@u";

                using (var cmd = new NpgsqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@u", idUsuario);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        private int RegistrarUsuarioAccion(int idUsuario, int idRol)
        {
            using (var con = DB.GetConnection())
            {
                con.Open();

                string sql = @"
                    INSERT INTO UsuarioAccion (ID_Usuario, ID_Rol)
                    VALUES (@usuario, @rol)
                    RETURNING ID_UsuarioAccion
                ";

                using (var cmd = new NpgsqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@usuario", idUsuario);
                    cmd.Parameters.AddWithValue("@rol", idRol);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        private int RegistrarInicioSesion(int idUsuario)
        {
            using (var con = DB.GetConnection())
            {
                con.Open();

                string sql = @"
            INSERT INTO Sesion (ID_Usuario, FechaInicio)
            VALUES (@u, NOW())
            RETURNING ID_Sesion;
        ";

                using (var cmd = new NpgsqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@u", idUsuario);

                    int idSesion = (int)cmd.ExecuteScalar();
                    return idSesion;
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string usuario = txtRUsuario.Text.Trim();
            string pass1 = txtRContrasena.Text.Trim();
            string pass2 = txtConfirmar.Text.Trim();

            int idRol = Convert.ToInt32(cmbRol.SelectedValue);
            int idEmpleado = Convert.ToInt32(cmbEmpleado.SelectedValue);

            if (usuario == "" || pass1 == "")
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            if (pass1 != pass2)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            if (UsuarioExiste(usuario))
            {
                MessageBox.Show("El usuario ya existe.");
                return;
            }

            // Crear HASH y SALT
            string salt = SeguridadPasswort.GenerarSalt();
            string hash = SeguridadPasswort.GenerarHash(pass1, salt);

            using (var con = DB.GetConnection())
            {
                con.Open();

                string sql = @"
                    INSERT INTO Usuario 
                    (NombreUsuario, ContrasenaHash, ContrasenaSalt, id_rol, id_empleado)
                    VALUES (@u, @h, @s, @r, @e)
                ";

                using (var cmd = new NpgsqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@u", usuario);
                    cmd.Parameters.AddWithValue("@h", hash);
                    cmd.Parameters.AddWithValue("@s", salt);
                    cmd.Parameters.AddWithValue("@r", idRol);
                    cmd.Parameters.AddWithValue("@e", idEmpleado);
                    cmd.ExecuteNonQuery();
                }
            }

            // SI HAY SESIÓN, REGISTRAR ACCIÓN
            if (SesionUsuario.ID_Usuario > 0)
            {
                RegistrarUsuarioAccion(
                    SesionUsuario.ID_Usuario,
                    SesionUsuario.ID_Rol
                );
            }

            MessageBox.Show("Usuario registrado correctamente.");
            LimpiarCampos();
        }

        private bool UsuarioExiste(string usuario)
        {
            using (var con = DB.GetConnection())
            {
                con.Open();

                string sql = "SELECT COUNT(*) FROM usuario WHERE NombreUsuario=@u";

                using (var cmd = new NpgsqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@u", usuario);

                    long count = (long)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }


        private void CargarRoles()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = "SELECT id_rol, nombre FROM rol";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbRol.DataSource = dt;
                    cmbRol.DisplayMember = "nombre";
                    cmbRol.ValueMember = "id_rol";
                }
            }
        }


        private void CargarEmpleados()
        {
            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = "SELECT id_empleado, nombre || ' ' || Apellido AS NombreCompleto FROM empleado";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbEmpleado.DataSource = dt;
                    cmbEmpleado.DisplayMember = "NombreCompleto";
                    cmbEmpleado.ValueMember = "id_empleado";
                }
            }
        }

        private int ObtenerRolPorPuesto(int idPuesto)
        {
            // Valores reales de tu tabla Rol
            int rolAdmin = 1;        // admin_master
            int rolAuditor = 2;      // auditor_sistema
            int rolOperador = 3;     // operador_general

            switch (idPuesto)
            {
                case 1:  // Gerente General
                case 10: // Gerente de Sistemas
                case 11: // Administrador de Base de Datos
                    return rolAdmin;

                default:
                    return rolOperador;
            }
        }

        private void cmbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmpleado.SelectedValue == null)
                return;

            int idEmpleado = Convert.ToInt32(cmbEmpleado.SelectedValue);

            using (var con = DB.GetConnection())
            {
                con.Open();

                string query = "SELECT id_puesto FROM empleado WHERE id_empleado = @id";

                using (var cmd = new NpgsqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", idEmpleado);

                    int idPuesto = Convert.ToInt32(cmd.ExecuteScalar());

                    int idRol = ObtenerRolPorPuesto(idPuesto);

                    // Seleccionar el rol automáticamente
                    cmbRol.SelectedValue = idRol;
                }
            }
        }


        private void LimpiarCampos()
        {
            txtRUsuario.Clear();
            txtRContrasena.Clear();
            txtConfirmar.Clear();
            cmbRol.SelectedIndex = 0;
            cmbEmpleado.SelectedIndex = 0;
        }




    }

}

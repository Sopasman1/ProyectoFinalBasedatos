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
    public partial class FormPrincipal : Form
    {
        private int usuarioActual;
        private int sesionActual;
        private int usuarioAccionID;
        public FormPrincipal(int idUsuario, int idSesion,int idUsuarioAccion)
        {
            InitializeComponent();
            usuarioActual = idUsuario;
            sesionActual = idSesion;
            usuarioAccionID = idUsuarioAccion;


        }


        private void RegistrarFinSesion(int idSesion)
        {
            using (var con = DB.GetConnection())
            {
                con.Open();

                string sql = "UPDATE Sesion SET FechaFin = NOW() WHERE ID_Sesion = @id";

                using (var cmd = new NpgsqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", idSesion);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            RegistrarFinSesion(sesionActual);
        }

        // Función para cambiar el color del label y marcar el formulario activo
        private void CambiarColorLabel(Label labelSeleccionado)
        {
            // Restaurar el color de todos los labels
            label2.BackColor = Color.AntiqueWhite;
            label3.BackColor = Color.AntiqueWhite;
            label4.BackColor = Color.AntiqueWhite;
            label5.BackColor = Color.AntiqueWhite;
            label6.BackColor = Color.AntiqueWhite;
            label7.BackColor = Color.AntiqueWhite;
            label8.BackColor = Color.AntiqueWhite;

            // Cambiar color del label seleccionado
            labelSeleccionado.BackColor = Color.LightBlue; // O el color que prefieras
        }
        private void AbrirFormulario(Form formHijo)
        {
            // Limpia lo que estaba cargado
            if (panelContenedor.Controls.Count > 0)
                panelContenedor.Controls.RemoveAt(0);

            // Ajustar configuración del formulario hijo
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            // Agregar al panel
            panelContenedor.Controls.Add(formHijo);
            panelContenedor.Tag = formHijo;
            formHijo.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            CambiarColorLabel(label2);
            AbrirFormulario(new FormInventario(usuarioAccionID));
        }

        private void label3_Click(object sender, EventArgs e)
        {
            CambiarColorLabel(label3);
            AbrirFormulario(new FormComprasyProvedores(usuarioAccionID));
        }

        private void label4_Click(object sender, EventArgs e)
        {
            CambiarColorLabel(label4);
            AbrirFormulario(new FormVentayClientes(usuarioAccionID));
        }

        private void label5_Click(object sender, EventArgs e)
        {
            CambiarColorLabel(label5);
            AbrirFormulario(new FormRecursosHumanos(usuarioAccionID));
        }

        private void label6_Click(object sender, EventArgs e)
        {
            CambiarColorLabel(label6);
            AbrirFormulario(new FormSoporteTecnico(usuarioAccionID));
        }

        private void label7_Click(object sender, EventArgs e)
        {
            CambiarColorLabel(label7);
            AbrirFormulario(new FormConfiguracio(usuarioAccionID));
        }

        private void label8_Click(object sender, EventArgs e)
        {
            CambiarColorLabel(label8);
            AbrirFormulario(new FormReportes());
        }
    }
}

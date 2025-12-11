using ClosedXML.Excel;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace ProyectoFinalBasedatos
{
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbReportes.SelectedIndex == -1)
                return;

            string vista = cmbReportes.SelectedItem.ToString();

            using (var con = DB.GetConnection())
            {
                con.Open();
                string query = $"SELECT * FROM {vista}";

                using (var da = new NpgsqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtvReportes.DataSource = dt;
                }
            }
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            // Añade aquí tus vistas de PostgreSQL
            cmbReportes.Items.Add("reporte_clientes_pais");
            cmbReportes.Items.Add("reporte_empleados_puesto");
            cmbReportes.Items.Add("reporte_inventario_actual");
            cmbReportes.Items.Add("reporte_mantenimientos_realizados");
            cmbReportes.Items.Add("reporte_pagos_realizados");
            cmbReportes.Items.Add("reporte_productos_categoria");
            cmbReportes.Items.Add("reporte_tickets_soporte_abiertos");
            cmbReportes.Items.Add("reporte_ventas_cliente");
            cmbReportes.Items.Add("vw_proveedores_top");
            cmbReportes.Items.Add("vw_resumen_inventario");
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel (*.xlsx)|*.xlsx";
            sfd.FileName = "Reporte.xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (XLWorkbook wb = new XLWorkbook())
                {
                    // Convertir DataGridView → DataTable
                    DataTable dt = (DataTable)dtvReportes.DataSource;

                    wb.Worksheets.Add(dt, "Reporte");
                    wb.SaveAs(sfd.FileName);
                }

                MessageBox.Show("Archivo Excel exportado correctamente.");
            }
        }

        private void btnJson_Click(object sender, EventArgs e)
        {
            if (dtvReportes.DataSource == null)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivo JSON|*.json";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var dt = (DataTable)dtvReportes.DataSource;
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(dt, Newtonsoft.Json.Formatting.Indented);

                File.WriteAllText(sfd.FileName, json);
                MessageBox.Show("JSON generado correctamente");
            }
        }

        private void btnCsv_Click(object sender, EventArgs e)
        {
            if (dtvReportes.DataSource == null)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivo CSV|*.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var dt = (DataTable)dtvReportes.DataSource;
                StringBuilder sb = new StringBuilder();

                // Encabezados
                foreach (DataColumn col in dt.Columns)
                    sb.Append(col.ColumnName + ",");

                sb.AppendLine();

                // Filas
                foreach (DataRow row in dt.Rows)
                {
                    foreach (var item in row.ItemArray)
                        sb.Append(item.ToString().Replace(",", " ") + ",");

                    sb.AppendLine();
                }

                File.WriteAllText(sfd.FileName, sb.ToString());
                MessageBox.Show("CSV generado correctamente");
            }
        }
    }
}

namespace ProyectoFinalBasedatos
{
    partial class FormReportes
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
            cmbReportes = new ComboBox();
            dtvReportes = new DataGridView();
            btnCsv = new Button();
            btnExcel = new Button();
            btnJson = new Button();
            ((System.ComponentModel.ISupportInitialize)dtvReportes).BeginInit();
            SuspendLayout();
            // 
            // cmbReportes
            // 
            cmbReportes.FormattingEnabled = true;
            cmbReportes.Location = new Point(12, 48);
            cmbReportes.Name = "cmbReportes";
            cmbReportes.Size = new Size(362, 23);
            cmbReportes.TabIndex = 0;
            cmbReportes.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dtvReportes
            // 
            dtvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvReportes.Location = new Point(3, 107);
            dtvReportes.Name = "dtvReportes";
            dtvReportes.Size = new Size(793, 341);
            dtvReportes.TabIndex = 1;
            // 
            // btnCsv
            // 
            btnCsv.Location = new Point(417, 48);
            btnCsv.Name = "btnCsv";
            btnCsv.Size = new Size(75, 23);
            btnCsv.TabIndex = 2;
            btnCsv.Text = "CSV";
            btnCsv.UseVisualStyleBackColor = true;
            btnCsv.Click += btnCsv_Click;
            // 
            // btnExcel
            // 
            btnExcel.Location = new Point(524, 48);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(75, 23);
            btnExcel.TabIndex = 3;
            btnExcel.Text = "Excel";
            btnExcel.UseVisualStyleBackColor = true;
            btnExcel.Click += btnExcel_Click;
            // 
            // btnJson
            // 
            btnJson.Location = new Point(642, 48);
            btnJson.Name = "btnJson";
            btnJson.Size = new Size(75, 23);
            btnJson.TabIndex = 4;
            btnJson.Text = "Json";
            btnJson.UseVisualStyleBackColor = true;
            btnJson.Click += btnJson_Click;
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(btnJson);
            Controls.Add(btnExcel);
            Controls.Add(btnCsv);
            Controls.Add(dtvReportes);
            Controls.Add(cmbReportes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormReportes";
            Text = "FormReportes";
            Load += FormReportes_Load;
            ((System.ComponentModel.ISupportInitialize)dtvReportes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbReportes;
        private DataGridView dtvReportes;
        private Button btnCsv;
        private Button btnExcel;
        private Button btnJson;
    }
}
namespace PIA_Finanzas
{
    partial class FrmCalculos
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
            dataGridView1 = new DataGridView();
            BtnABC = new Button();
            BtnEOQ = new Button();
            BtnPR = new Button();
            label1 = new Label();
            CbFormatoExportacion = new ComboBox();
            label2 = new Label();
            BtnExportar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(192, 192, 255);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(775, 300);
            dataGridView1.TabIndex = 1;
            // 
            // BtnABC
            // 
            BtnABC.BackColor = Color.FromArgb(128, 128, 255);
            BtnABC.FlatStyle = FlatStyle.Flat;
            BtnABC.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            BtnABC.ForeColor = Color.Black;
            BtnABC.Location = new Point(11, 10);
            BtnABC.Name = "BtnABC";
            BtnABC.Size = new Size(154, 25);
            BtnABC.TabIndex = 2;
            BtnABC.Text = "ABC";
            BtnABC.UseVisualStyleBackColor = false;
            BtnABC.Click += BtnABC_Click;
            // 
            // BtnEOQ
            // 
            BtnEOQ.BackColor = Color.FromArgb(128, 128, 255);
            BtnEOQ.FlatStyle = FlatStyle.Flat;
            BtnEOQ.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            BtnEOQ.ForeColor = Color.Black;
            BtnEOQ.Location = new Point(184, 10);
            BtnEOQ.Name = "BtnEOQ";
            BtnEOQ.Size = new Size(154, 25);
            BtnEOQ.TabIndex = 3;
            BtnEOQ.Text = "EOQ";
            BtnEOQ.UseVisualStyleBackColor = false;
            BtnEOQ.Click += BtnEOQ_Click;
            // 
            // BtnPR
            // 
            BtnPR.BackColor = Color.FromArgb(128, 128, 255);
            BtnPR.FlatStyle = FlatStyle.Flat;
            BtnPR.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            BtnPR.ForeColor = Color.Black;
            BtnPR.Location = new Point(345, 10);
            BtnPR.Name = "BtnPR";
            BtnPR.Size = new Size(154, 25);
            BtnPR.TabIndex = 4;
            BtnPR.Text = "Punto de reorden";
            BtnPR.UseVisualStyleBackColor = false;
            BtnPR.Click += BtnPR_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            label1.Location = new Point(491, 17);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 6;
            // 
            // CbFormatoExportacion
            // 
            CbFormatoExportacion.FormattingEnabled = true;
            CbFormatoExportacion.Location = new Point(345, 41);
            CbFormatoExportacion.Name = "CbFormatoExportacion";
            CbFormatoExportacion.Size = new Size(197, 25);
            CbFormatoExportacion.TabIndex = 8;
            CbFormatoExportacion.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(327, 15);
            label2.TabIndex = 7;
            label2.Text = "¿En que formato desea exportar el reporte?";
            // 
            // BtnExportar
            // 
            BtnExportar.BackColor = Color.FromArgb(128, 128, 255);
            BtnExportar.FlatStyle = FlatStyle.Flat;
            BtnExportar.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            BtnExportar.ForeColor = Color.Black;
            BtnExportar.Location = new Point(548, 41);
            BtnExportar.Name = "BtnExportar";
            BtnExportar.Size = new Size(180, 25);
            BtnExportar.TabIndex = 9;
            BtnExportar.Text = "Exportar";
            BtnExportar.UseVisualStyleBackColor = false;
            BtnExportar.Click += BtnExportar_Click;
            // 
            // FrmCalculos
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 382);
            Controls.Add(BtnExportar);
            Controls.Add(CbFormatoExportacion);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnPR);
            Controls.Add(BtnEOQ);
            Controls.Add(BtnABC);
            Controls.Add(dataGridView1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            Name = "FrmCalculos";
            Text = "Calculos";
            Load += FrmCalculos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button BtnABC;
        private Button BtnEOQ;
        private Button BtnPR;
        private Label label1;
        private ComboBox CbFormatoExportacion;
        private Label label2;
        private Button BtnExportar;
    }
}
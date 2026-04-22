namespace PIA_Finanzas
{
    partial class FrmReportes
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
            DGVProductos = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            BtnOrdCat = new Button();
            BtnOrdP = new Button();
            CbCategoria = new ComboBox();
            CbProveedores = new ComboBox();
            CbFormatoExportacion = new ComboBox();
            label9 = new Label();
            BtnExportar = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVProductos).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // DGVProductos
            // 
            DGVProductos.BackgroundColor = Color.FromArgb(192, 192, 255);
            DGVProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVProductos.Location = new Point(12, 102);
            DGVProductos.Name = "DGVProductos";
            DGVProductos.RowHeadersWidth = 51;
            DGVProductos.Size = new Size(776, 336);
            DGVProductos.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.9898148F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.0101852F));
            tableLayoutPanel1.Controls.Add(BtnOrdCat, 0, 1);
            tableLayoutPanel1.Controls.Add(BtnOrdP, 0, 0);
            tableLayoutPanel1.Controls.Add(CbCategoria, 1, 1);
            tableLayoutPanel1.Controls.Add(CbProveedores, 1, 0);
            tableLayoutPanel1.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(476, 72);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // BtnOrdCat
            // 
            BtnOrdCat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            BtnOrdCat.Location = new Point(43, 39);
            BtnOrdCat.Name = "BtnOrdCat";
            BtnOrdCat.Size = new Size(210, 30);
            BtnOrdCat.TabIndex = 5;
            BtnOrdCat.Text = "Ordenar por categoría";
            BtnOrdCat.UseVisualStyleBackColor = true;
            BtnOrdCat.Click += BtnOrdCat_Click;
            // 
            // BtnOrdP
            // 
            BtnOrdP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            BtnOrdP.Location = new Point(43, 3);
            BtnOrdP.Name = "BtnOrdP";
            BtnOrdP.Size = new Size(210, 30);
            BtnOrdP.TabIndex = 3;
            BtnOrdP.Text = "Ordenar por proveedores";
            BtnOrdP.UseVisualStyleBackColor = true;
            BtnOrdP.Click += BtnOrdP_Click;
            // 
            // CbCategoria
            // 
            CbCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CbCategoria.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            CbCategoria.FormattingEnabled = true;
            CbCategoria.Items.AddRange(new object[] { "Pan", "Bollería", "Pan Dulce", "Pastelitos", "Galletas", "Pan Tostado", "English Muffins", "Bagels", "Tortillas y flatbread", "Botanas Saladas" });
            CbCategoria.Location = new Point(259, 39);
            CbCategoria.Name = "CbCategoria";
            CbCategoria.Size = new Size(214, 23);
            CbCategoria.TabIndex = 4;
            // 
            // CbProveedores
            // 
            CbProveedores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CbProveedores.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            CbProveedores.FormattingEnabled = true;
            CbProveedores.Items.AddRange(new object[] { "Proveedor Shelly", "Proveedores FAPS", "Proveedor QUO", "Distribuidora Central", "Comercializadora Norte" });
            CbProveedores.Location = new Point(259, 3);
            CbProveedores.Name = "CbProveedores";
            CbProveedores.Size = new Size(214, 23);
            CbProveedores.TabIndex = 3;
            // 
            // CbFormatoExportacion
            // 
            CbFormatoExportacion.FormattingEnabled = true;
            CbFormatoExportacion.Location = new Point(491, 48);
            CbFormatoExportacion.Name = "CbFormatoExportacion";
            CbFormatoExportacion.Size = new Size(159, 28);
            CbFormatoExportacion.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            label9.Location = new Point(538, 8);
            label9.Name = "label9";
            label9.Size = new Size(180, 30);
            label9.TabIndex = 13;
            label9.Text = "¿En que formato desea \r\nexportar el reporte?";
            label9.Click += label9_Click;
            // 
            // BtnExportar
            // 
            BtnExportar.Location = new Point(656, 48);
            BtnExportar.Name = "BtnExportar";
            BtnExportar.Size = new Size(132, 29);
            BtnExportar.TabIndex = 15;
            BtnExportar.Text = "Exportar";
            BtnExportar.UseVisualStyleBackColor = true;
            BtnExportar.Click += BtnExportar_Click;
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(BtnExportar);
            Controls.Add(CbFormatoExportacion);
            Controls.Add(label9);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(DGVProductos);
            Name = "FrmReportes";
            Text = "Reportes";
            Load += FrmReportes_Load;
            ((System.ComponentModel.ISupportInitialize)DGVProductos).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGVProductos;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox CbCategoria;
        private ComboBox CbProveedores;
        private Button BtnOrdCat;
        private Button BtnOrdP;
        private ComboBox CbFormatoExportacion;
        private Label label9;
        private Button BtnExportar;
    }
}
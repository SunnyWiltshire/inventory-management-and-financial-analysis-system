namespace PIA_Finanzas
{
    partial class FormProductos
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
            BtnAgregarP = new Button();
            BtnEliminarP = new Button();
            BtnModP = new Button();
            TxtNombreP = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label10 = new Label();
            label11 = new Label();
            label6 = new Label();
            label7 = new Label();
            label12 = new Label();
            TxtCostoPed = new TextBox();
            TxtDemandaAn = new TextBox();
            TxtCantidadDisp = new TextBox();
            TxtPm3 = new TextBox();
            CBProveedor = new ComboBox();
            TxtPm2 = new TextBox();
            TxtCostoMtto = new TextBox();
            TxtPm1 = new TextBox();
            BtnLimpiar = new Button();
            BtnExportar = new Button();
            CbExport = new ComboBox();
            label9 = new Label();
            CBCategoria = new ComboBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(192, 192, 255);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(667, 188);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BtnAgregarP
            // 
            BtnAgregarP.BackColor = Color.FromArgb(128, 128, 255);
            BtnAgregarP.FlatStyle = FlatStyle.Flat;
            BtnAgregarP.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            BtnAgregarP.ForeColor = Color.Black;
            BtnAgregarP.Location = new Point(21, 228);
            BtnAgregarP.Name = "BtnAgregarP";
            BtnAgregarP.Size = new Size(180, 29);
            BtnAgregarP.TabIndex = 1;
            BtnAgregarP.Text = "Agregar producto";
            BtnAgregarP.UseVisualStyleBackColor = false;
            BtnAgregarP.Click += BtnAgregarP_Click;
            // 
            // BtnEliminarP
            // 
            BtnEliminarP.BackColor = Color.FromArgb(128, 128, 255);
            BtnEliminarP.FlatStyle = FlatStyle.Flat;
            BtnEliminarP.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            BtnEliminarP.ForeColor = Color.Black;
            BtnEliminarP.Location = new Point(21, 263);
            BtnEliminarP.Name = "BtnEliminarP";
            BtnEliminarP.Size = new Size(180, 29);
            BtnEliminarP.TabIndex = 2;
            BtnEliminarP.Text = "Eliminar producto";
            BtnEliminarP.UseVisualStyleBackColor = false;
            BtnEliminarP.Click += BtnEliminarP_Click;
            // 
            // BtnModP
            // 
            BtnModP.BackColor = Color.FromArgb(128, 128, 255);
            BtnModP.FlatStyle = FlatStyle.Flat;
            BtnModP.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            BtnModP.ForeColor = Color.Black;
            BtnModP.Location = new Point(21, 298);
            BtnModP.Name = "BtnModP";
            BtnModP.Size = new Size(180, 29);
            BtnModP.TabIndex = 3;
            BtnModP.Text = "Modificar producto";
            BtnModP.UseVisualStyleBackColor = false;
            BtnModP.Click += BtnModP_Click;
            // 
            // TxtNombreP
            // 
            TxtNombreP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtNombreP.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            TxtNombreP.Location = new Point(256, 3);
            TxtNombreP.Name = "TxtNombreP";
            TxtNombreP.Size = new Size(204, 22);
            TxtNombreP.TabIndex = 4;
            TxtNombreP.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            label1.Location = new Point(91, 0);
            label1.Name = "label1";
            label1.Size = new Size(159, 32);
            label1.TabIndex = 5;
            label1.Text = "Nombre del Producto";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            label2.Location = new Point(119, 281);
            label2.Name = "label2";
            label2.Size = new Size(131, 30);
            label2.TabIndex = 6;
            label2.Text = "Costo por pedido";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            label3.Location = new Point(171, 32);
            label3.Name = "label3";
            label3.Size = new Size(79, 40);
            label3.TabIndex = 7;
            label3.Text = "Categoría";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            label4.Location = new Point(168, 72);
            label4.Name = "label4";
            label4.Size = new Size(82, 38);
            label4.TabIndex = 15;
            label4.Text = "Proveedor";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            label5.Location = new Point(150, 110);
            label5.Name = "label5";
            label5.Size = new Size(100, 32);
            label5.TabIndex = 16;
            label5.Text = "Precio mes 1";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            label10.Location = new Point(150, 142);
            label10.Name = "label10";
            label10.Size = new Size(100, 39);
            label10.TabIndex = 20;
            label10.Text = "Precio mes 2";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            label11.Location = new Point(150, 181);
            label11.Name = "label11";
            label11.Size = new Size(100, 31);
            label11.TabIndex = 21;
            label11.Text = "Precio mes 3";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            label6.Location = new Point(99, 212);
            label6.Name = "label6";
            label6.Size = new Size(151, 34);
            label6.TabIndex = 17;
            label6.Text = "Cantidad disponible";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            label7.Location = new Point(60, 246);
            label7.Name = "label7";
            label7.Size = new Size(190, 35);
            label7.TabIndex = 18;
            label7.Text = "Demanda promedio anual";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            label12.Location = new Point(23, 311);
            label12.Name = "label12";
            label12.Size = new Size(227, 92);
            label12.TabIndex = 23;
            label12.Text = "Costo de mantenimiento anual por unidad";
            label12.TextAlign = ContentAlignment.TopRight;
            // 
            // TxtCostoPed
            // 
            TxtCostoPed.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtCostoPed.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            TxtCostoPed.Location = new Point(256, 284);
            TxtCostoPed.Name = "TxtCostoPed";
            TxtCostoPed.Size = new Size(204, 22);
            TxtCostoPed.TabIndex = 14;
            // 
            // TxtDemandaAn
            // 
            TxtDemandaAn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtDemandaAn.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            TxtDemandaAn.Location = new Point(256, 249);
            TxtDemandaAn.Name = "TxtDemandaAn";
            TxtDemandaAn.Size = new Size(204, 22);
            TxtDemandaAn.TabIndex = 13;
            // 
            // TxtCantidadDisp
            // 
            TxtCantidadDisp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtCantidadDisp.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            TxtCantidadDisp.Location = new Point(256, 215);
            TxtCantidadDisp.Name = "TxtCantidadDisp";
            TxtCantidadDisp.Size = new Size(204, 22);
            TxtCantidadDisp.TabIndex = 12;
            // 
            // TxtPm3
            // 
            TxtPm3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtPm3.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            TxtPm3.Location = new Point(256, 184);
            TxtPm3.Name = "TxtPm3";
            TxtPm3.Size = new Size(204, 22);
            TxtPm3.TabIndex = 11;
            // 
            // CBProveedor
            // 
            CBProveedor.FormattingEnabled = true;
            CBProveedor.Items.AddRange(new object[] { "Proveedor Shelly", "Proveedores FAPS", "Proveedor QUO", "Distribuidora Central", "Comercializadora Norte" });
            CBProveedor.Location = new Point(256, 75);
            CBProveedor.Name = "CBProveedor";
            CBProveedor.Size = new Size(204, 28);
            CBProveedor.TabIndex = 24;
            // 
            // TxtPm2
            // 
            TxtPm2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtPm2.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            TxtPm2.Location = new Point(256, 145);
            TxtPm2.Name = "TxtPm2";
            TxtPm2.Size = new Size(204, 22);
            TxtPm2.TabIndex = 9;
            // 
            // TxtCostoMtto
            // 
            TxtCostoMtto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtCostoMtto.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            TxtCostoMtto.Location = new Point(256, 314);
            TxtCostoMtto.Name = "TxtCostoMtto";
            TxtCostoMtto.Size = new Size(204, 22);
            TxtCostoMtto.TabIndex = 22;
            // 
            // TxtPm1
            // 
            TxtPm1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtPm1.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            TxtPm1.Location = new Point(256, 113);
            TxtPm1.Name = "TxtPm1";
            TxtPm1.Size = new Size(204, 22);
            TxtPm1.TabIndex = 10;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.BackColor = Color.FromArgb(128, 128, 255);
            BtnLimpiar.FlatStyle = FlatStyle.Flat;
            BtnLimpiar.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            BtnLimpiar.ForeColor = Color.Black;
            BtnLimpiar.Location = new Point(21, 333);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(180, 29);
            BtnLimpiar.TabIndex = 9;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = false;
            BtnLimpiar.Click += button1_Click;
            // 
            // BtnExportar
            // 
            BtnExportar.BackColor = Color.FromArgb(128, 128, 255);
            BtnExportar.FlatStyle = FlatStyle.Flat;
            BtnExportar.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            BtnExportar.ForeColor = Color.Black;
            BtnExportar.Location = new Point(20, 447);
            BtnExportar.Name = "BtnExportar";
            BtnExportar.Size = new Size(180, 29);
            BtnExportar.TabIndex = 10;
            BtnExportar.Text = "Exportar";
            BtnExportar.UseVisualStyleBackColor = false;
            BtnExportar.Click += BtnExportar_Click;
            // 
            // CbExport
            // 
            CbExport.FormattingEnabled = true;
            CbExport.Location = new Point(20, 413);
            CbExport.Name = "CbExport";
            CbExport.Size = new Size(181, 28);
            CbExport.TabIndex = 12;
            CbExport.SelectedIndexChanged += CbExport_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            label9.Location = new Point(21, 372);
            label9.Name = "label9";
            label9.Size = new Size(180, 30);
            label9.TabIndex = 11;
            label9.Text = "¿En que formato desea \r\nexportar el reporte?";
            // 
            // CBCategoria
            // 
            CBCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CBCategoria.FormattingEnabled = true;
            CBCategoria.Items.AddRange(new object[] { "Pan", "Bollería", "Pan Dulce", "Pastelitos", "Galletas", "Pan Tostado", "English Muffins", "Bagels", "Tortillas y flatbread", "Botanas Saladas" });
            CBCategoria.Location = new Point(256, 35);
            CBCategoria.Name = "CBCategoria";
            CBCategoria.Size = new Size(204, 28);
            CBCategoria.TabIndex = 13;
            CBCategoria.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.6436272F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.3563728F));
            tableLayoutPanel2.Controls.Add(TxtCostoMtto, 1, 9);
            tableLayoutPanel2.Controls.Add(TxtCostoPed, 1, 8);
            tableLayoutPanel2.Controls.Add(label12, 0, 9);
            tableLayoutPanel2.Controls.Add(TxtDemandaAn, 1, 7);
            tableLayoutPanel2.Controls.Add(label2, 0, 8);
            tableLayoutPanel2.Controls.Add(TxtCantidadDisp, 1, 6);
            tableLayoutPanel2.Controls.Add(label10, 0, 4);
            tableLayoutPanel2.Controls.Add(TxtPm3, 1, 5);
            tableLayoutPanel2.Controls.Add(label6, 0, 6);
            tableLayoutPanel2.Controls.Add(label11, 0, 5);
            tableLayoutPanel2.Controls.Add(label5, 0, 3);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(CBCategoria, 1, 1);
            tableLayoutPanel2.Controls.Add(TxtPm2, 1, 4);
            tableLayoutPanel2.Controls.Add(TxtNombreP, 1, 0);
            tableLayoutPanel2.Controls.Add(CBProveedor, 1, 2);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(TxtPm1, 1, 3);
            tableLayoutPanel2.Controls.Add(label4, 0, 2);
            tableLayoutPanel2.Controls.Add(label7, 0, 7);
            tableLayoutPanel2.Location = new Point(216, 206);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 10;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 44.1558456F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 55.8441544F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 91F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(463, 403);
            tableLayoutPanel2.TabIndex = 14;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(689, 564);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(CbExport);
            Controls.Add(label9);
            Controls.Add(BtnExportar);
            Controls.Add(BtnLimpiar);
            Controls.Add(BtnModP);
            Controls.Add(BtnEliminarP);
            Controls.Add(BtnAgregarP);
            Controls.Add(dataGridView1);
            Name = "FormProductos";
            Text = "Productos";
            Load += FormProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button BtnAgregarP;
        private Button BtnEliminarP;
        private Button BtnModP;
        private TextBox TxtNombreP;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtPm2;
        private TextBox TxtPm1;
        private TextBox TxtPm3;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox TxtCantidadDisp;
        private TextBox TxtDemandaAn;
        private TextBox TxtCostoPed;
        private Label label4;
        private Button BtnLimpiar;
        private Button BtnExportar;
        private ComboBox CbExport;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox TxtCostoMtto;
        private ComboBox CBProveedor;
        private ComboBox CBCategoria;
        private TableLayoutPanel tableLayoutPanel2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}
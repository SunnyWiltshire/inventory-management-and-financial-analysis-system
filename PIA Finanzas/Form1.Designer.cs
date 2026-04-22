namespace PIA_Finanzas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            BtnProductos = new Button();
            BtnReportes = new Button();
            BtnCalculos = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UD Digi Kyokasho NK-R", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(52, 25);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(365, 15);
            label1.TabIndex = 0;
            label1.Text = "GRUPO BIMBO, S.A.B. DE C.V. Y SUBSIDIARIAS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            label2.Location = new Point(197, 75);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(76, 15);
            label2.TabIndex = 1;
            label2.Text = "Buen día!";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // BtnProductos
            // 
            BtnProductos.BackColor = Color.FromArgb(128, 128, 255);
            BtnProductos.FlatAppearance.BorderColor = Color.Black;
            BtnProductos.FlatAppearance.CheckedBackColor = Color.Cyan;
            BtnProductos.FlatStyle = FlatStyle.Flat;
            BtnProductos.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            BtnProductos.ForeColor = Color.Black;
            BtnProductos.Location = new Point(26, 163);
            BtnProductos.Name = "BtnProductos";
            BtnProductos.Size = new Size(119, 29);
            BtnProductos.TabIndex = 2;
            BtnProductos.Text = "Productos";
            BtnProductos.UseVisualStyleBackColor = false;
            BtnProductos.Click += BtnProductos_Click;
            // 
            // BtnReportes
            // 
            BtnReportes.BackColor = Color.FromArgb(128, 128, 255);
            BtnReportes.FlatAppearance.BorderColor = Color.Black;
            BtnReportes.FlatAppearance.CheckedBackColor = Color.Cyan;
            BtnReportes.FlatStyle = FlatStyle.Flat;
            BtnReportes.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            BtnReportes.ForeColor = Color.Black;
            BtnReportes.Location = new Point(256, 163);
            BtnReportes.Name = "BtnReportes";
            BtnReportes.Size = new Size(119, 29);
            BtnReportes.TabIndex = 3;
            BtnReportes.Text = "Reportes";
            BtnReportes.UseVisualStyleBackColor = false;
            BtnReportes.Click += BtnReportes_Click;
            // 
            // BtnCalculos
            // 
            BtnCalculos.BackColor = Color.FromArgb(128, 128, 255);
            BtnCalculos.FlatAppearance.BorderColor = Color.Black;
            BtnCalculos.FlatAppearance.CheckedBackColor = Color.Cyan;
            BtnCalculos.FlatStyle = FlatStyle.Flat;
            BtnCalculos.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            BtnCalculos.ForeColor = Color.Black;
            BtnCalculos.Location = new Point(466, 163);
            BtnCalculos.Name = "BtnCalculos";
            BtnCalculos.Size = new Size(119, 29);
            BtnCalculos.TabIndex = 4;
            BtnCalculos.Text = "Calculos";
            BtnCalculos.UseVisualStyleBackColor = false;
            BtnCalculos.Click += BtnCalculos_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("UD Digi Kyokasho NK-R", 9F);
            label3.Location = new Point(26, 40);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 6;
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(452, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(192, 192, 255);
            richTextBox1.Font = new Font("UD Digi Kyokasho NK-R", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            richTextBox1.Location = new Point(12, 235);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(611, 144);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(635, 405);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(BtnCalculos);
            Controls.Add(BtnReportes);
            Controls.Add(BtnProductos);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Menú";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button BtnProductos;
        private Button BtnReportes;
        private Button BtnCalculos;
        private Label label3;
        private PictureBox pictureBox1;
        private RichTextBox richTextBox1;
    }
}

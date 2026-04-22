namespace PIA_Finanzas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            FormProductos ventanaProductos = new FormProductos();
            ventanaProductos.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            FrmReportes ventanaReportes = new FrmReportes();
            ventanaReportes.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalculos_Click(object sender, EventArgs e)
        {
            FrmCalculos ventanaCalculo = new FrmCalculos();
            ventanaCalculo.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;



namespace PIA_Finanzas
{
    public partial class FrmCalculos : Form
    {
        public FrmCalculos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnABC_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=LISSET\\SQLEXPRESS;Database=BIMBO;Trusted_Connection=True;TrustServerCertificate=True;Connect Timeout=5;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("ReporteClasificacionABC", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Mostrar en un nuevo DataGridView o el mismo
                dataGridView1.DataSource = dt;
            }
        }
        private void CargarProductos()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection("Server=LISSET\\SQLEXPRESS;Database=BIMBO;Trusted_Connection=True;TrustServerCertificate=True;Connect Timeout=5;"))
                {
                    string consulta = "SELECT * FROM Productos";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message);
            }
        }
        private void FrmCalculos_Load(object sender, EventArgs e)
        {
            CbFormatoExportacion.Items.Add("PDF");
            CbFormatoExportacion.Items.Add("PNG");
            CargarProductos();
        }

        private void BtnEOQ_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=LISSET\\SQLEXPRESS;Database=BIMBO;Trusted_Connection=True;TrustServerCertificate=True;Connect Timeout=5;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand("CalcularEOQ", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener EOQ: " + ex.Message);
                }
            }
        }

        private void BtnPR_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=LISSET\\SQLEXPRESS;Database=BIMBO;Trusted_Connection=True;TrustServerCertificate=True;Connect Timeout=5;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand("CalcularPuntoReorden", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener EOQ: " + ex.Message);
                }
            }
        }

        private void ExportarAPdf(DataGridView dgv)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Archivo PDF|*.pdf";
                sfd.FileName = "Calculo.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document(PageSize.A4.Rotate());
                    PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                    doc.Open();

                    PdfPTable table = new PdfPTable(dgv.Columns.Count);
                    foreach (DataGridViewColumn col in dgv.Columns)
                    {
                        table.AddCell(new Phrase(col.HeaderText));
                    }

                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                table.AddCell(cell.Value?.ToString() ?? "");
                            }
                        }
                    }

                    doc.Add(table);
                    doc.Close();
                    MessageBox.Show("Exportado como PDF:\n" + sfd.FileName);
                }
            }
        }

        private void ExportarAPng(DataGridView dgv)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Imagen PNG|*.png";
                sfd.FileName = "Calculo.png";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (Bitmap bmp = new Bitmap(dgv.Width, dgv.Height))
                    {
                        dgv.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, dgv.Width, dgv.Height));
                        bmp.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        MessageBox.Show("Exportado como imagen PNG:\n" + sfd.FileName);
                    }
                }
            }
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            if (CbFormatoExportacion.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un formato de exportación.");
                return;
            }

            string formato = CbFormatoExportacion.SelectedItem.ToString();

            if (formato == "PDF")
            {
                ExportarAPdf(dataGridView1);
            }
            else if (formato == "PNG")
            {
                ExportarAPng(dataGridView1);
            }
            else
            {
                MessageBox.Show("Formato no válido.");
            }
        }
    }
}

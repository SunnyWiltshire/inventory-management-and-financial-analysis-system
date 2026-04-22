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
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
                    DGVProductos.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message);
            }
        }

        private void CargarCategorias()
        {
            using (SqlConnection connection = new SqlConnection("Server=LISSET\\SQLEXPRESS;Database=BIMBO;Trusted_Connection=True;TrustServerCertificate=True;Connect Timeout=5;"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT IdCategoria, NombreCategoria FROM Categorias", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                CbCategoria.DataSource = dt;
                CbCategoria.DisplayMember = "NombreCategoria";
                CbCategoria.ValueMember = "IdCategoria";
            }
        }

        private void CargarProveedores()
        {
            using (SqlConnection connection = new SqlConnection("Server=LISSET\\SQLEXPRESS;Database=BIMBO;Trusted_Connection=True;TrustServerCertificate=True;Connect Timeout=5;"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT IdProveedor, NombreProveedor FROM Proveedores", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                CbProveedores.DataSource = dt;
                CbProveedores.DisplayMember = "NombreProveedor";
                CbProveedores.ValueMember = "IdProveedor";
            }
        }
        private void FrmReportes_Load(object sender, EventArgs e)
        {
            CbFormatoExportacion.Items.Add("PDF");
            CbFormatoExportacion.Items.Add("PNG");
            CbFormatoExportacion.SelectedIndex = 0; // Valor por defecto
            CargarProductos();
            CargarCategorias();
            CargarProveedores();
        }

        private void BtnOrdP_Click(object sender, EventArgs e)
        {
            try
            {
                int idProveedor = Convert.ToInt32(CbProveedores.SelectedValue);

                string connectionString = "Server=LISSET\\SQLEXPRESS;Database=BIMBO;Trusted_Connection=True;TrustServerCertificate=True;Connect Timeout=5;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Productos WHERE IdProveedor = @IdProveedor";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IdProveedor", idProveedor);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);
                    DGVProductos.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar por proveedor: " + ex.Message);
            }
        }

        private void BtnOrdCat_Click(object sender, EventArgs e)
        {
            try
            {
                int idCategoria = Convert.ToInt32(CbCategoria.SelectedValue);

                string connectionString = "Server=LISSET\\SQLEXPRESS;Database=BIMBO;Trusted_Connection=True;TrustServerCertificate=True;Connect Timeout=5;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Productos WHERE IdCategoria = @IdCategoria";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IdCategoria", idCategoria);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);
                    DGVProductos.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar por categoría: " + ex.Message);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void ExportarAPng(DataGridView dgv)
        {
            using (Bitmap bmp = new Bitmap(dgv.Width, dgv.Height))
            {
                dgv.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, dgv.Width, dgv.Height));
                bmp.Save("DGVProductos.png", System.Drawing.Imaging.ImageFormat.Png);
                MessageBox.Show("Exportado como imagen PNG.");
            }
        }

        private void ExportarAPDF(DataGridView dgv)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                Title = "Guardar como PDF",
                FileName = "Productos.pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4.Rotate(), 10f, 10f, 20f, 20f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        PdfPTable pdfTable = new PdfPTable(dgv.Columns.Count);
                        pdfTable.WidthPercentage = 100;

                        // Encabezados
                        foreach (DataGridViewColumn column in dgv.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                            cell.BackgroundColor = new BaseColor(240, 240, 240);
                            pdfTable.AddCell(cell);
                        }

                        // Datos
                        foreach (DataGridViewRow row in dgv.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value?.ToString());
                                }
                            }
                        }

                        pdfDoc.Add(pdfTable);
                        pdfDoc.Close();
                        stream.Close();

                        MessageBox.Show("Exportado correctamente a PDF.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar PDF: " + ex.Message);
                }
            }
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            string formato = CbFormatoExportacion.SelectedItem.ToString();

            switch (formato)
            {
                case "PDF":
                    ExportarAPDF(DGVProductos); // Requiere iTextSharp
                    break;
                case "PNG":
                    ExportarAPng(DGVProductos);
                    break;
                default:
                    MessageBox.Show("Formato no válido.");
                    break;
            }
        }
    }
}

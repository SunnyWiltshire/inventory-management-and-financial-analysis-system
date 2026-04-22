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
using Microsoft.VisualBasic;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace PIA_Finanzas
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtNombreP.Text = " ";
            CBCategoria.SelectedIndex = -1;
            CBProveedor.SelectedIndex = -1;
            TxtPm1.Text = " ";
            TxtPm2.Text = " ";
            TxtPm3.Text = " ";
            TxtCantidadDisp.Text = " ";
            TxtDemandaAn.Text = " ";
            TxtCostoPed.Text = " ";
            TxtCostoMtto.Text = " ";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAgregarP_Click(object sender, EventArgs e)
        {

            try
            {
                // Capturar datos desde los controles
                string NombreProducto = TxtNombreP.Text;
                decimal PrecioMes1 = Convert.ToDecimal(TxtPm1.Text);
                decimal PrecioMes2 = Convert.ToDecimal(TxtPm2.Text);
                decimal PrecioMes3 = Convert.ToDecimal(TxtPm3.Text);
                int StockActual = Convert.ToInt32(TxtCantidadDisp.Text);
                decimal DemandaAnual = Convert.ToDecimal(TxtDemandaAn.Text);
                decimal CostoPedido = Convert.ToDecimal(TxtCostoPed.Text);
                decimal CostoMantenimiento = Convert.ToDecimal(TxtCostoMtto.Text);
                int IdCategoria = Convert.ToInt32(CBCategoria.SelectedValue);
                int IdProveedor = Convert.ToInt32(CBProveedor.SelectedValue);

                // Calcular stock mínimo (15% de la demanda anual)
                int StockMinimo = (int)Math.Ceiling(DemandaAnual * 0.15m);

                string connectionString = "Server=LISSET\\SQLEXPRESS;Database=BIMBO;Trusted_Connection=True;TrustServerCertificate=True;Connect Timeout=5;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
                INSERT INTO Productos 
                (NombreProducto, PrecioMes1, PrecioMes2, PrecioMes3, StockActual, 
                DemandaAnual, CostoPedido, CostoMantenimiento, IdCategoria, IdProveedor, StockMinimo)
                VALUES 
                (@NombreProducto, @PrecioMes1, @PrecioMes2, @PrecioMes3, @StockActual, @DemandaAnual, @CostoPedido, 
                @CostoMantenimiento, @IdCategoria, @IdProveedor, @StockMinimo)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NombreProducto", NombreProducto);
                    command.Parameters.AddWithValue("@PrecioMes1", PrecioMes1);
                    command.Parameters.AddWithValue("@PrecioMes2", PrecioMes2);
                    command.Parameters.AddWithValue("@PrecioMes3", PrecioMes3);
                    command.Parameters.AddWithValue("@StockActual", StockActual);
                    command.Parameters.AddWithValue("@DemandaAnual", DemandaAnual);
                    command.Parameters.AddWithValue("@CostoPedido", CostoPedido);
                    command.Parameters.AddWithValue("@CostoMantenimiento", CostoMantenimiento);
                    command.Parameters.AddWithValue("@IdCategoria", IdCategoria);
                    command.Parameters.AddWithValue("@IdProveedor", IdProveedor);
                    command.Parameters.AddWithValue("@StockMinimo", StockMinimo);

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Producto agregado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el producto.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message);
            }
            CargarProductos();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    dataGridView1.DataSource = tabla;
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

                CBCategoria.DataSource = dt;
                CBCategoria.DisplayMember = "NombreCategoria";
                CBCategoria.ValueMember = "IdCategoria";
            }
        }

        private void CargarProveedores()
        {
            using (SqlConnection connection = new SqlConnection("Server=LISSET\\SQLEXPRESS;Database=BIMBO;Trusted_Connection=True;TrustServerCertificate=True;Connect Timeout=5;"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT IdProveedor, NombreProveedor FROM Proveedores", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                CBProveedor.DataSource = dt;
                CBProveedor.DisplayMember = "NombreProveedor";
                CBProveedor.ValueMember = "IdProveedor";
            }
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            CbExport.Items.Add("PDF");
            CbExport.Items.Add("PNG");
            CargarProductos();
            CargarCategorias();
            CargarProveedores();
        }

        private void BtnEliminarP_Click(object sender, EventArgs e)
        {
            try
            {
                string input = Interaction.InputBox("Ingresa el ID del producto a eliminar:", "Eliminar producto", "");

                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("No se ingresó ningún ID.");
                    return;
                }

                int idProducto = Convert.ToInt32(input);

                string connectionString = "Server=LISSET\\SQLEXPRESS;Database=BIMBO;Trusted_Connection=True;TrustServerCertificate=True;Connect Timeout=5;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Productos WHERE IdProducto = @IdProducto";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IdProducto", idProducto);

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Producto eliminado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un producto con ese ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar producto: " + ex.Message);
            }
            CargarProductos();

        }

        private void BtnModP_Click(object sender, EventArgs e)
        {
            try
            {
                // Pedir ID del producto a modificar
                string input = Microsoft.VisualBasic.Interaction.InputBox("Ingresa el ID del producto a modificar:", "Modificar Producto", "");
                if (!int.TryParse(input, out int idProducto))
                {
                    MessageBox.Show("ID inválido.");
                    return;
                }

                // Capturar los nuevos datos desde los controles
                string NombreProducto = TxtNombreP.Text;
                decimal PrecioMes1 = Convert.ToDecimal(TxtPm1.Text);
                decimal PrecioMes2 = Convert.ToDecimal(TxtPm2.Text);
                decimal PrecioMes3 = Convert.ToDecimal(TxtPm3.Text);
                int StockActual = Convert.ToInt32(TxtCantidadDisp.Text);
                decimal DemandaAnual = Convert.ToDecimal(TxtDemandaAn.Text);
                decimal CostoPedido = Convert.ToDecimal(TxtCostoPed.Text);
                decimal CostoMantenimiento = Convert.ToDecimal(TxtCostoMtto.Text);
                int IdCategoria = Convert.ToInt32(CBCategoria.SelectedValue);
                int IdProveedor = Convert.ToInt32(CBProveedor.SelectedValue);

                // Calcular el nuevo stock mínimo
                int StockMinimo = (int)Math.Ceiling(DemandaAnual * 0.15m);

                string connectionString = "Server=LISSET\\SQLEXPRESS;Database=BIMBO;Trusted_Connection=True;TrustServerCertificate=True;Connect Timeout=5;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"
            UPDATE Productos SET
                NombreProducto = @NombreProducto,
                PrecioMes1 = @PrecioMes1,
                PrecioMes2 = @PrecioMes2,
                PrecioMes3 = @PrecioMes3,
                StockActual = @StockActual,
                DemandaAnual = @DemandaAnual,
                CostoPedido = @CostoPedido,
                CostoMantenimiento = @CostoMantenimiento,
                IdCategoria = @IdCategoria,
                IdProveedor = @IdProveedor,
                StockMinimo = @StockMinimo
            WHERE IdProducto = @IdProducto";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NombreProducto", NombreProducto);
                    command.Parameters.AddWithValue("@PrecioMes1", PrecioMes1);
                    command.Parameters.AddWithValue("@PrecioMes2", PrecioMes2);
                    command.Parameters.AddWithValue("@PrecioMes3", PrecioMes3);
                    command.Parameters.AddWithValue("@StockActual", StockActual);
                    command.Parameters.AddWithValue("@DemandaAnual", DemandaAnual);
                    command.Parameters.AddWithValue("@CostoPedido", CostoPedido);
                    command.Parameters.AddWithValue("@CostoMantenimiento", CostoMantenimiento);
                    command.Parameters.AddWithValue("@IdCategoria", IdCategoria);
                    command.Parameters.AddWithValue("@IdProveedor", IdProveedor);
                    command.Parameters.AddWithValue("@StockMinimo", StockMinimo);
                    command.Parameters.AddWithValue("@IdProducto", idProducto);

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Producto modificado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un producto con ese ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar producto: " + ex.Message);
            }
            CargarProductos();

        }

        private void ExportarAPdf(DataGridView dgv)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Archivo PDF|*.pdf";
                sfd.FileName = "Productos.pdf";

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
                sfd.FileName = "Productos.png";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (Bitmap bmp = new Bitmap(dgv.Width, dgv.Height))
                    {
                        dgv.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, dgv.Width, dgv.Height));
                        bmp.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        MessageBox.Show("Exportado como imagen PNG en:\n" + sfd.FileName);
                    }
                }
            }
        }


        private void BtnExportar_Click(object sender, EventArgs e)
        {
            if (CbExport.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un formato de exportación.");
                return;
            }

            string formato = CbExport.SelectedItem.ToString();

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

        private void CbExport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

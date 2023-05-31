using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using PdfiumViewer;


namespace Sistema_de_R.Humanos
{
    public partial class Nuevo_expediente : Form
    {
        public Nuevo_expediente()
        {
            InitializeComponent();
        }

        private void btnSeleccionaPdf_Click(object sender, EventArgs e)
        {
            // Abrir el diálogo de selección de archivos
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Crear el documento final
                Document document = new Document();
                // Crear el escritor de PDF
                PdfCopy writer = new PdfCopy(document, new FileStream(@"C:\UDocumentos\Nuevos expedientes\NuevoExpediente.pdf", FileMode.Create));
                
                try
                {
                    // Abrir el documento
                    document.Open();

                    // Recorrer los archivos seleccionados
                    foreach (string file in openFileDialog.FileNames)
                    {
                        // Leer cada archivo PDF
                        PdfReader reader = new PdfReader(file);

                        // Recorrer cada página del PDF
                        for (int i = 1; i <= reader.NumberOfPages; i++)
                        {
                            // Obtener la página actual
                            PdfImportedPage page = writer.GetImportedPage(reader, i);

                            // Agregar la página al documento final
                            writer.AddPage(page);
                        }

                        // Cerrar el lector actual
                        reader.Close();
                    }

                    // Cerrar el escritor de PDF y el documento
                    writer.Close();
                    document.Close();

                    MessageBox.Show("La fusión de PDF se ha completado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }   
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al fusionar los PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}

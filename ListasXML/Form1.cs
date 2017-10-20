using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasXML
{
    public partial class Form1 : Form
    {
        List<Estudiante> estudiantes;

        public Form1()
        {
            InitializeComponent();
            estudiantes = new List<Estudiante>();
        }

        private void AbrirButton_Click(object sender, EventArgs e)
        {
            Stream stream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((stream = openFileDialog1.OpenFile()) != null)
                    {
                        using (stream)
                        {                            
                            var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                            estudiantes = (List<Estudiante>)bformatter.Deserialize(stream);
                            ActualizarGrid();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image  
            // assigned to Button2.  
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Guardar Archivo";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.  
            if (saveFileDialog1.FileName != "")
            { 
                System.IO.FileStream fs =
                   (System.IO.FileStream)saveFileDialog1.OpenFile();

                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                bformatter.Serialize(fs, estudiantes);

                fs.Close();
            }
        }

        private void ActualizarButton_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante
            {
                Carne = CarneTextBox.Text,
                Nombre = NombreTextBox.Text
            };

            estudiantes.Add(estudiante);
            ActualizarGrid();
        }

        /// <summary>
        /// Actualiza el DataGridView
        /// </summary>
        private void ActualizarGrid()
        {
            EstudiantesGridView.DataSource = null;
            EstudiantesGridView.DataSource = estudiantes;
            EstudiantesGridView.Refresh();
        }
    }
}

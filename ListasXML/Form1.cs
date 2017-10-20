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
using System.Xml.Serialization;

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
            // Inicializamos el dialog para abrir un archivo
            Stream stream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            // Si la respuesta del dialogo es correcta intentamos deserializarlo
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((stream = openFileDialog1.OpenFile()) != null)
                    {
                        using (stream)
                        {
                            // Deserializamos en base a la opcion marcada
                            if (BinarioRadioButton.Checked)
                            {
                                var binarySerializer = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                                estudiantes = (List<Estudiante>)binarySerializer.Deserialize(stream);
                            }
                            else if (XmlRadioButton.Checked)
                            {
                                var xmlSerializer = new XmlSerializer(typeof(List<Estudiante>));
                                estudiantes = (List<Estudiante>)xmlSerializer.Deserialize(stream);
                            }

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

        /// <summary>
        /// Guarda la lista de estudiantes en un archivo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            // Inicializamos el dialogo para guardar el archivo
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Guardar Archivo"
            };

            saveFileDialog1.ShowDialog();

            // Si el nombre del archivo no esta vacio procedemos a guardarlo.
            if (saveFileDialog1.FileName != "")
            { 
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();

                // Serializamos en base a la opcion seleccionada.
                if (BinarioRadioButton.Checked)
                {
                    var binarySerializer = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    binarySerializer.Serialize(fs, estudiantes);
                }
                else if (XmlRadioButton.Checked)
                {
                    var xmlSerializer = new XmlSerializer(typeof(List<Estudiante>));
                    xmlSerializer.Serialize(fs, estudiantes);
                }                               

                fs.Close();
            }
        }

        /// <summary>
        /// Agrega un usuario a la lista de usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

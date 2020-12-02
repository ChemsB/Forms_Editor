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

namespace pt2b_ChemsBezetout
{

    /**
     * En caso de darle a nuevo crear fichero con guardar como
     */

    public partial class MainForm : Form
    {
        int length=0;
        bool openFile = false;
        String filePath;
        String selectedPath;
        public MainForm()
        {
            InitializeComponent();
            Options.Enabled = false;
        }


        private void PracticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SobrePractica form = new SobrePractica();
            form.ShowDialog();
        }



        /// <summary>
        /// Abre una ventana para seleccionar los archivos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowFiles_Click(object sender, EventArgs e)
        {
           

            OpenFiles.InitialDirectory = "c:\\"; 
            OpenFiles.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|rtf files (*.rtf)|*.rtf";
            OpenFiles.FilterIndex = 2;
            OpenFiles.RestoreDirectory = true;

            if (OpenFiles.ShowDialog() == DialogResult.OK)
            {
                filePath = OpenFiles.FileName;
                rutas.Items.Add(filePath);

            }


        }




        /// <summary>
        /// Introducie el contenido del fichero seleccionado en el editor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Rutas_DoubleClick(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            selectedPath = rutas.SelectedItem.ToString();

           if (selectedPath.EndsWith(".txt"))
            {
                richTextBox1.LoadFile(selectedPath, RichTextBoxStreamType.PlainText);

            }
            else if (selectedPath.EndsWith(".rtf"))
            {
                richTextBox1.LoadFile(selectedPath, RichTextBoxStreamType.RichText);
            }

            openFile = true;


        }


        /// <summary>
        /// Si no se ha seleccionado ningun fichero y se ha escrito en el editor, se le pide al ususario que guarde el fichero
        /// Si se ha abierto un fichero se le pregunta si quiere guardar el contenido o borrarlo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            length = richTextBox1.Text.Length;

            if (!openFile && length != 0)
            {
                
                saveFileDialog1.InitialDirectory = "c:\\"; //Primer directorio
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|rtf files (*.rtf)|*.rtf";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                saveFileDialog1.ShowDialog();

                StreamWriter writer = new StreamWriter(saveFileDialog1.OpenFile());
                writer.WriteLine(richTextBox1.Text);
                filePath = saveFileDialog1.FileName;
                rutas.Items.Add(filePath);
                selectedPath = filePath;
                writer.Flush();
                writer.Close();
            }
            else if(openFile)
            {

                DialogResult dialogo = MessageBox.Show("¿Quieres Guardar el contenido del fichero o Borrar para escribir de nuevo?", "Borra", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.Yes)
                {

                    using (StreamWriter writer = new StreamWriter(selectedPath))
                    {

                        foreach(object line in richTextBox1.Lines)
                        {
                           
                            writer.WriteLine(line);
                        }

                    }

                }
                else
                {
                    richTextBox1.Clear();
                }

            }


        }



        /// <summary>
        /// Muestra un menu que se habilita y dehabilita dependiendo si se ha activado el checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowMenu_CheckedChanged(object sender, EventArgs e)
        {
            

            if (ShowMenu.Checked)
            {
                Options.Enabled = true;
            }
            else
            {
                Options.Enabled = false;
            }
            
        }



        /// <summary>
        /// Permite cambiar la fuente de un texto seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }




        /// <summary>
        /// Permite cambiar el color de un texto seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }




        /// <summary>
        /// Permite copiar un texto seleccionacdo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Copy_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }




        /// <summary>
        /// Permite cortar un texto seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cut_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }




        /// <summary>
        /// Permite pegar un texto copiado o cortado previamente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Paste_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }




        /// <summary>
        /// Permite abrir un nuevo texto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Open_Click(object sender, EventArgs e)
        {

            OpenFiles.InitialDirectory = "c:\\";
            OpenFiles.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|rtf files (*.rtf)|*.rtf"; //Filtra ficheros de texto y rtf
            OpenFiles.FilterIndex = 2;
            OpenFiles.RestoreDirectory = true;

            if (OpenFiles.ShowDialog() == DialogResult.OK)
            {
                
                filePath = OpenFiles.FileName;
                rutas.Items.Add(filePath);

            }


            richTextBox1.Clear();

            if (Path.GetExtension(OpenFiles.FileName)==".txt")
            {
                richTextBox1.LoadFile(OpenFiles.FileName, RichTextBoxStreamType.PlainText);

            }
            else if (Path.GetExtension(OpenFiles.FileName) == ".rtf")
            {
                richTextBox1.LoadFile(OpenFiles.FileName, RichTextBoxStreamType.RichText);
            }

            openFile = true;


        }



        /// <summary>
        /// Guarda el contenido del texto en el fichero de texto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (StreamWriter writer = new StreamWriter(selectedPath))
            {

                foreach (object line in richTextBox1.Lines)
                {

                    writer.WriteLine(line);
                }

            }

            MessageBox.Show("Texto guardado con exito");

        }



        /// <summary>
        /// Permite seleccionar todo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }



        /// <summary>
        /// Preguntar antes de cerrar aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Are you sure to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;


        }



        /// <summary>
        /// Cerrar aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }





}

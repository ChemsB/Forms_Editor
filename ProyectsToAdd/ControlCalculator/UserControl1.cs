using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCalculator
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }


        bool clickComa = true, moreLess = false;
        int moreLessCont = 0;

        public Boolean flag = false;


        /// <summary>
        /// Muestra el numero del boron correspondiente
        /// </summary>
        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Text;
        }


        /// <summary>
        /// Elimina el ultimo numero
        /// </summary>
        private void EFlecha_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }

        }

        /// <summary>
        /// Elimina todo el texto
        /// </summary>

        private void Button18_Click(object sender, EventArgs e)
        {

            textBox1.Clear();

        }


        /// <summary>
        /// Muestra texto de los operadores
        /// </summary>
        private void operationBottons_Click(object sender, EventArgs e)
        {

            Button b = (Button)sender;

            if (!textBox1.Text.EndsWith(b.Text))
            {
                textBox1.Text += b.Text;
            }


        }


        /// <summary>
        /// Muestra una coma
        /// </summary>
        private void comaButton(object sender, EventArgs e)
        {

            Button b = (Button)sender;

            if (!textBox1.Text.Contains("."))
            {
                clickComa = true;
            }

            if (clickComa)
            {
                textBox1.Text += ".";
                clickComa = false;
            }


        }


        /// <summary>
        /// Calcula el resultado y lo muestra
        /// </summary>
        private void resultButton(object sender, EventArgs e)
        {

            DataTable opera = new DataTable();

            float total = float.Parse(opera.Compute(textBox1.Text, string.Empty).ToString());
            MessageBox.Show($"{total}");


        }


        /// <summary>
        /// Muestra o suma o resta dependiendo que se ha apretado antes
        /// </summary>

        private void moreLess_Click(object sender, EventArgs e)
        {

            if (moreLess == false)
            {
                moreLess = true;
                moreLessCont++;
                moreLess = false;

            }

            if (moreLessCont == 0)
            {
                textBox1.Text += "";
            }
            else if (moreLessCont == 1)
            {
                textBox1.Text += "+";
            }
            else if (moreLessCont == 2)
            {
                textBox1.Text += "-";
                moreLessCont = 0;
            }


        }



    }
}

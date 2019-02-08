using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U18OKT25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addition_Click(object sender, EventArgs e)
        {
            double tal1 = Convert.ToDouble(textBox1.Text);
            double tal2 = Convert.ToDouble(textBox2.Text);

            double svar = tal1 + tal2;
            listBox1.Items.Add(tal1 + " + " + tal2 + " = " + svar);

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox1.Focus();
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            double tal1 = Convert.ToDouble(textBox1.Text);
            double tal2 = Convert.ToDouble(textBox2.Text);

            double svar = tal1 - tal2;
            listBox1.Items.Add(tal1 + " - " + tal2 + " = " + svar);

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox1.Focus();
        }

        private void Divi_Click(object sender, EventArgs e)
        {

            double tal1 = Convert.ToDouble(textBox1.Text);
            double tal2 = Convert.ToDouble(textBox2.Text);

            double svar = tal1 / tal2;

            if (tal2 == 0)
            {
                listBox1.Items.Add(tal1 + " / " + tal2 + " = undefined");
            }
            else
            {
                listBox1.Items.Add(tal1 + " / " + tal2 + " = " + svar);
            }

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox1.Focus();
        }

        private void multi_Click(object sender, EventArgs e)
        {
            double tal1 = Convert.ToDouble(textBox1.Text);
            double tal2 = Convert.ToDouble(textBox2.Text);

            double svar = tal1 * tal2;
            listBox1.Items.Add(tal1 + " * " + tal2 + " = " + svar);

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox1.Focus();
        }
    }
}

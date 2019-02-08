using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2018OKT25_2
{
    public partial class Form1 : Form
    {
        //Constructor, kod som körs automatiskt vid NEW
        public Form1()
        {
            InitializeComponent();

            //Hur man sätter en eventhandler till ne knapp manuellt
            //INTE DUBBELKLICK
            button2.Click += new EventHandler(DoSomething);

            button2.Text = "Try Me";
            button2.Text = "Add";

        }

        private void DoSomething(object sender, EventArgs e)
        {
            MessageBox.Show("tested");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Du skrev: " + textBox1.Text;

            listBox1.Items.Add(DateTime.Now.ToShortTimeString() + ": " + textBox1.Text);

            textBox1.Text = string.Empty; //Detta är att föredra framför ""
            textBox1.Focus();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U18OKT25_2
{
    public partial class Form1 : Form
    {
        private ICalculator calc; //Abstract

        public Form1()
        {
            InitializeComponent();

            calc = new Calculate(); //Konkret, kan bytas till exempel SuperCalculator!!

            Addition.Text = "+";
            Subtraktion.Text = "-";
            Multiplikation.Text = "*";
            Division.Text = "/";

            Addition.Click += new EventHandler(DoCalculation);
            Subtraktion.Click += new EventHandler(DoCalculation);
            Multiplikation.Click += new EventHandler(DoCalculation);
            Division.Click += new EventHandler(DoCalculation);

        }

        private void DoCalculation(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            decimal n1 = decimal.Parse(textBox1.Text);
            decimal n2 = decimal.Parse(textBox2.Text);
            decimal result = 0;

            switch (b.Text)
            {
                case "+":
                    result = calc.Add(n1, n2);
                    break;

                case "-":
                    result = calc.Sub(n1, n2);
                    break;

                case "*":
                    result = calc.Mul(n1, n2);
                    break;

                case "/":
                    result = calc.Div(n1, n2);
                    break;
            }
            //Läs av siffrorna
            //Anropa Add metoden
            //Visa resultat

            listBox1.Items.Add(string.Format("{0} {3} {1} = {2}", n1, n2, result, b.Text));
        }
       
    }
}

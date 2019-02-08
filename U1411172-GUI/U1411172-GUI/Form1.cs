using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace U1411172_GUI
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {       
            InitializeComponent();

            using (SqlConnection c = new SqlConnection())
            {
                c.ConnectionString = @"Data source=(localdb)\mssqllocaldb;Initial Catalog=1411708;Integrated Security=True;";   
                c.Open();

                MessageBox.Show("ok, Open!");

                listBox1.DataSource = new object 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

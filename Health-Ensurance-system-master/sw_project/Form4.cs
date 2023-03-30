using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sw_project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                Form5 f5 = new Form5();
                f5.Show();
                Dispose();
            }
            else
            {
                MessageBox.Show("Incorrect Username or password");
                textBox1.Text = "";  
                textBox2.Text = "";
            }
        }
    }
}

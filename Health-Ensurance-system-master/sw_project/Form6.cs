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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "client" && textBox2.Text == "client")
            {
                Form7 f5 = new Form7();
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

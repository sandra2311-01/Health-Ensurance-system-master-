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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void createPackageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 f8= new Form8();
            f8.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            view_edit_package v = new view_edit_package();
            v.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_View v = new Admin_View();
            v.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form10 f = new Form10();
            f.Show();
        }
    }
}

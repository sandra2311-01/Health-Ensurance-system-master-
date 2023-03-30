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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f5 = new Form4();
            f5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 f5 = new Form6();
            f5.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aDMINToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void cLIENTToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Form4 f5 = new Form4();
            f5.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form6 f5 = new Form6();
            f5.Show();

        }
    }
}

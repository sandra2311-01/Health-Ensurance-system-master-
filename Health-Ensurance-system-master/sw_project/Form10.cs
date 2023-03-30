using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace sw_project
{
    public partial class Form10 : Form
    {
        CrystalReport1 cr;
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
                cr.SetParameterValue(0, radioButton1.Text);
            else
                cr.SetParameterValue(0, radioButton2.Text);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}

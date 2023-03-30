using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace sw_project
{
    public partial class Form8 : Form
    {
        OracleConnection con;
        string ordb = "data source = orcl; user id =scott; password=tiger;";

        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into CLASS_TYPE values (:class,:price,:type,:age)";
            cmd.Parameters.Add("class", textBox1.Text);
            cmd.Parameters.Add("price", Convert.ToInt32(numericUpDown2.Value));
            cmd.Parameters.Add("type", comboBox1.SelectedItem.ToString());
            cmd.Parameters.Add("age", Convert.ToInt32(numericUpDown1.Value));   
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("New Package is added");
            }
            textBox1.Text = "";
            comboBox1.SelectedIndex = 0;
            numericUpDown2.Value = 0;
            numericUpDown1.Value = 0;
        }
    }
}

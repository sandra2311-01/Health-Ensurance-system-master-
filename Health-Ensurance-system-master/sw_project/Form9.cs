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
    public partial class Form9 : Form
    {
        string ordb = "Data Source=orcl ; User ID=scott ; Password=tiger;";
        OracleConnection conn;
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select CLASS from CLASS_TYPE";
            c.CommandType = CommandType.Text;
            OracleDataReader dr = c.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[0]);
            }
            dr.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.CommandText = "select AGE_LIMIT from CLASS_TYPE WHERE CLASS=:class";
            cmd1.Parameters.Add("class", comboBox2.SelectedItem.ToString());
            OracleDataReader dr1 = cmd1.ExecuteReader();
            int package_minimun_age=0;
            while (dr1.Read())
            {
                package_minimun_age = Convert.ToInt32( dr1[0].ToString());
            }
            if (package_minimun_age<=numericUpDown1.Value)
            {
                MessageBox.Show("Can't subscribe in this package (age limit)");
            }
            else{
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Insert into CLIENTS values (:name,:id,:age,:gender,:inherited_disease,:class,:Exp_date)";
                cmd.Parameters.Add("name", textBox1.Text);
                cmd.Parameters.Add("id", numericUpDown2.Value);
                cmd.Parameters.Add("age", numericUpDown1.Value);
                if (radioButton1.Checked)
                {
                    cmd.Parameters.Add("gender", radioButton1.Text);

                }
                else if (radioButton2.Checked)
                {
                    cmd.Parameters.Add("gender", radioButton2.Text);

                }
                cmd.Parameters.Add("inherited_disease", textBox3.Text);

                cmd.Parameters.Add("class", comboBox2.SelectedItem.ToString());

                cmd.Parameters.Add("Exp_date", DateTime.Now.AddYears(2).ToString());

                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("New Client is added");
                    textBox1.Text = "";
                    textBox3.Text = "";
                    numericUpDown2.Value = 0;
                    comboBox2.SelectedIndex = 0;
                    numericUpDown1.Value = 0;
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                }
            }
            conn.Dispose();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            view_packages v = new view_packages();
            v.Show();
        }
    }
}

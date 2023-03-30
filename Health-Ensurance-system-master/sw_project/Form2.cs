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
    public partial class Form2 : Form
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Exp_date from Clients where ID=:id";
            cmd.Parameters.Add("id", textBox1.Text);
            OracleDataReader dr = cmd.ExecuteReader();
            DateTime d=new DateTime();
            while (dr.Read())
            {
                d = Convert.ToDateTime(dr[0].ToString());
            }
            if (d.CompareTo(DateTime.UtcNow) > 0)
            {
                textBox2.Text = "Your package is not expiered yet";
            }
            else if(d.CompareTo(DateTime.UtcNow) <= 0)
            {
                textBox2.Text = "Your package is expiered please Renew";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "Your package is not expiered yet")
            {
                MessageBox.Show("Your package is not expiered yet");
            }
            else
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE CLIENTS SET EXP_DATE=:EXP where id=:id";
                cmd.Parameters.Add("EXP", DateTime.Now.AddYears(2).ToString());
                cmd.Parameters.Add("id", textBox1.Text);
                int r= cmd.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("Package renwed Succssefully");
                }

            }
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}

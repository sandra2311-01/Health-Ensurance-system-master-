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
    public partial class View : Form
    {
        string ordb = "Data Source=orcl ; User ID=scott ; Password=tiger;";
        OracleConnection conn;
        public View()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void View_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);

            conn.Open();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            OracleCommand cmd2 = new OracleCommand();
            OracleParameter p_status = new OracleParameter();
            OracleParameter p_status1 = new OracleParameter();
            OracleParameter p_status2 = new OracleParameter();
            OracleParameter p_status3 = new OracleParameter();
            OracleParameter p_status4 = new OracleParameter();
            cmd2.Connection = conn;
            cmd2.CommandText = "VIEW_DATA";
            cmd2.CommandType = CommandType.StoredProcedure;
            p_status.ParameterName = "client_name";
            p_status.OracleDbType = OracleDbType.Varchar2;
            p_status.Direction = ParameterDirection.Output;
            p_status.Size = 10000;
            p_status1.ParameterName = "client_gender";
            p_status1.OracleDbType = OracleDbType.Varchar2;
            p_status1.Direction = ParameterDirection.Output;
            p_status1.Size = 10000;
            p_status2.ParameterName = "client_disease";
            p_status2.OracleDbType = OracleDbType.Varchar2;
            p_status2.Direction = ParameterDirection.Output;
            p_status2.Size = 10000;
            p_status3.ParameterName = "client_class";
            p_status3.OracleDbType = OracleDbType.Varchar2;
            p_status3.Direction = ParameterDirection.Output;
            p_status3.Size = 10000;
            p_status4.ParameterName = "client_date";
            p_status4.OracleDbType = OracleDbType.Varchar2;
            p_status4.Direction = ParameterDirection.Output;
            p_status4.Size = 10000;
            cmd2.Parameters.Add("client_id", numericUpDown1.Value.ToString());
            cmd2.Parameters.Add(p_status);
            cmd2.Parameters.Add(p_status1);
            cmd2.Parameters.Add("client_age", OracleDbType.Int32, ParameterDirection.Output);
            cmd2.Parameters.Add(p_status2);
            cmd2.Parameters.Add(p_status3);
            cmd2.Parameters.Add(p_status4);
            cmd2.ExecuteNonQuery();
            try
            {
                textBox1.Text = cmd2.Parameters["client_name"].Value.ToString();
                textBox2.Text = cmd2.Parameters["client_gender"].Value.ToString();
                textBox5.Text = cmd2.Parameters["client_age"].Value.ToString();
                textBox6.Text = cmd2.Parameters["client_disease"].Value.ToString();
                textBox4.Text = cmd2.Parameters["client_class"].Value.ToString();
                textBox7.Text = cmd2.Parameters["client_date"].Value.ToString();
            }
            catch { MessageBox.Show("done"); }
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

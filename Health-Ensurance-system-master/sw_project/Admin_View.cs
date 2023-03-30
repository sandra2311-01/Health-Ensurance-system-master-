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
    public partial class Admin_View : Form
    {
        string ordb = "Data Source=orcl ; User ID=scott ; Password=tiger;";
        OracleConnection conn;
        DataTable d = new DataTable();
        public Admin_View()
        {
            InitializeComponent();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Admin_View_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);

            conn.Open();
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "VIEWINFO";
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.Add("Act_name", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataAdapter da = new OracleDataAdapter(cmd2);
            da.Fill(d);
            dataGridView1.DataSource = d;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "NAME")
            {
                DataView dv = new DataView(d);
                dv.RowFilter = string.Format("name LIKE '%{0}%'", textBox1.Text);
                dataGridView1.DataSource = dv;
            }
            else if(comboBox1.Text == "CLASS")
            {
                DataView dv = new DataView(d);
                dv.RowFilter = string.Format("class LIKE '%{0}%'", textBox1.Text);
                dataGridView1.DataSource = dv;
            }
            

        }
    }
}

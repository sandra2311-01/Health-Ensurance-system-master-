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
    public partial class view_packages : Form
    {

        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public view_packages()
        {
            InitializeComponent();
        }

        private void view_packages_Load(object sender, EventArgs e)
        {
            string Constr = "Data Source=orcl; User Id=scott;Password=tiger;";
            string c = "Select * from Class_type";
            adapter = new OracleDataAdapter(c, Constr);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}

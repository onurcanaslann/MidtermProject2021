using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _201735018EMS
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        SqlConnection connn = new SqlConnection("Data Source=.;Initial Catalog=DBems;Integrated Security=True");
        private void btnlog_Click(object sender, EventArgs e)
        {
            try
            {
                connn.Open();
                string sql = "Select * From table_sec where username=@username AND password=@password";
                SqlParameter prmu = new SqlParameter("username", txtusername.Text);
                SqlParameter prmp = new SqlParameter("password", txtpassword.Text);
                SqlCommand cmdl = new SqlCommand(sql, connn);
                cmdl.Parameters.Add(prmu);
                cmdl.Parameters.Add(prmp);
                DataTable dtt = new DataTable();
                SqlDataAdapter daa = new SqlDataAdapter(cmdl);
                daa.Fill(dtt);
                if(dtt.Rows.Count>0)
                {
                    Form1 fr1 = new Form1();
                    fr1.Show();
                    this.Hide();
                }
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}

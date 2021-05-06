using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _201735018EMS
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btn_ex_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            this.Hide();
        }

        private void btn_sall_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
            this.Hide();
        }

        private void btn_rep_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.Show();
            this.Hide();
        }
        SqlConnection cond = new SqlConnection("Data Source=.;Initial Catalog=DBems;Integrated Security=True");
        private void Form4_Load(object sender, EventArgs e)
        {
            cond.Open();
            SqlCommand comud = new SqlCommand("Select name,monthpay From table_sal",cond);
            SqlDataReader readd = comud.ExecuteReader();
            while (readd.Read())
            {
                chart1.Series["monthpay"].Points.AddXY(readd[0].ToString(), readd[1]);
            }
            cond.Close();
        }
    }
}

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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        void cleaningg()
        {
            txtid.Clear();
            txtname.Clear();
            txtsurname.Clear();
            txtmonthp.Clear();
            pd.Value = DateTime.Now;
            txtiban.Clear();
            
        }
        void refff()
        {
            dataGridView1.DataSource = aducs.List("Select * from table_sal");
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            refff();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = aducs.List("Select * from table_sal Where name like'%" + txtsearch.Text + "%'");
        }
        SqlCommand cmdd;

        private void btnadd_Click(object sender, EventArgs e)
        {
            string sql = "insert into table_sal(name,surname,monthpay,bonuspay,paydate,iban) values('" + txtname.Text + "','" + txtsurname.Text + "','" + txtmonthp.Text + "','" + txtbonusp.Text + "',@paydate,'" +txtiban.Text + "')";
            cmdd = new SqlCommand();
            cmdd.Parameters.Add("@paydate", SqlDbType.Date).Value = pd.Value;
            aducs.ADUC(sql, cmdd);
            refff();
            cleaningg();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsurname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtmonthp.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtbonusp.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            pd.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtiban.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string sql = "Update table_sal Set name='" + txtname.Text + "',surname='" + txtsurname.Text + "',monthpay='" + txtmonthp.Text + "',bonuspay='" + txtbonusp.Text + "',paydate=@paydate,iban='" + txtiban.Text + "' Where id='" + txtid.Text + "'";
            cmdd = new SqlCommand();
            cmdd.Parameters.Add("@paydate", SqlDbType.Date).Value = pd.Value;
            aducs.ADUC(sql, cmdd);
            refff();
            cleaningg();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Delete the record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                string sql = "Delete from table_sal Where id='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
                cmdd = new SqlCommand();
                aducs.ADUC(sql, cmdd);
                refff();
                cleaningg();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            cleaningg();
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

        private void btn_ex_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_rep_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.Show();
            this.Hide();
        }
    }
}

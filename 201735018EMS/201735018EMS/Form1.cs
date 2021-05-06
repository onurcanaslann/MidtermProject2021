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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void cleaning()
        {
            txtid.Clear();
            txtname.Clear();
            txtsurname.Clear();
            txtdep.Clear();
            dob.Value = DateTime.Now;
            dos.Value = DateTime.Now;
            txtpn.Clear();
            txtaddr.Clear();
            txtemail.Clear();
        }
        void reff()
        {
            dataGridView1.DataSource = aducs.List("Select * from table_info");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reff();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = aducs.List("Select * from table_info Where name like'%"+txtsearch.Text+"%'");
        }
        SqlCommand cmd;
        private void btnadd_Click(object sender, EventArgs e)
        {
            string sql = "insert into table_info(name,surname,department,dateob,dateos,pnumber,address,email) values('"+txtname.Text+"','" + txtsurname.Text+"','" + txtdep.Text+"',@dateob,@dateos,'" + txtpn.Text+"','" + txtaddr.Text+"','" + txtemail.Text+"')";
            cmd = new SqlCommand();
            cmd.Parameters.Add("@dateob",SqlDbType.Date).Value=dob.Value;
            cmd.Parameters.Add("@dateos", SqlDbType.Date).Value = dos.Value;
            aducs.ADUC(sql,cmd);
            reff();
            cleaning();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsurname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtdep.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dob.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dos.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtpn.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtaddr.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtemail.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string sql = "Update table_info Set name='"+txtname.Text+ "',surname='" + txtsurname.Text + "',department='" + txtdep.Text + "',dateob=@dateob,dateos=@dateos,pnumber='" + txtpn.Text + "',address='" + txtaddr.Text + "',email='" + txtemail.Text + "' Where id='"+txtid.Text+"'";
            cmd = new SqlCommand();
            cmd.Parameters.Add("@dateob", SqlDbType.Date).Value = dob.Value;
            cmd.Parameters.Add("@dateos", SqlDbType.Date).Value = dos.Value;
            aducs.ADUC(sql, cmd);
            reff();
            cleaning();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Delete the record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialog==DialogResult.Yes)
            {
                string sql = "Delete from table_info Where id='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
                cmd = new SqlCommand();
                aducs.ADUC(sql, cmd);
                reff();
                cleaning();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            cleaning();
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

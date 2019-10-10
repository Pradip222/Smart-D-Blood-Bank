using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Smart_D_Blood_Bank
{
    public partial class hospitel : Form
    {
        public hospitel()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cmbgroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbgroup.SelectedIndex){
                case 0:
                    dataGridView1.Rows.Clear();
                    break;
                case 1:
                    showall("apos");
                    //a+
                    MessageBox.Show("a+", "ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    showall("bpos");
                    //b+
                    break;
                case 3:
                    showall("abpos");
                    //ab+
                    break;
                case 4:
                    showall("opos");
                    //o+
                    break;
                case 5:
                    showall("aneg");
                    //a-
                    break;
                case 6:
                    showall("bneg");
                    //b-
                    break;
                case 7:
                    showall("abneg");
                    //Ab-
                    break;
                case 8:
                    showall("oneg");
                    //o-
                    break;


            } 
        }
        private void showall(string a)
        {
            string constring = @"Data Source=.\sqlexpress;Initial Catalog=Bank;Integrated Security=True;Pooling=False";
            SqlConnection conn1 = new SqlConnection(constring);
            conn1.Open();
            string command;
            SqlDataReader rdr = null, rdr1 = null;
            string commandget = "select id,bnkaddress,name,pin,"+a+"  from Bank where apos>=1;";
            SqlCommand getmaxD = new SqlCommand(commandget, conn1);
            rdr = getmaxD.ExecuteReader();
            while (rdr.Read())
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetInt32(3), rdr.GetInt32(4));
            }
        }
        private void Hospitel_Load(object sender, EventArgs e)
        {
            cmbgroup.SelectedIndex = 0;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

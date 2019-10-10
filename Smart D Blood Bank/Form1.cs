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
    public partial class Form1 : Form
    {
        public int bnkid;
        public Form1()//update here when joining to other form and send bbank id
        {
            InitializeComponent();
            bnkid = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblBank_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }

        private void TextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void Paneltake_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSubmitP_Click(object sender, EventArgs e)
        {
            int maxid=0;
            DBconnection conn = new DBconnection();
            string constring =  @"Data Source=.\sqlexpress;Initial Catalog=Bank;Integrated Security=True;Pooling=False";
            SqlConnection conn1 = new SqlConnection(constring);
            conn1.Open();
            string command;
            SqlDataReader rdr = null ,rdr1= null;
            string commandget = "select max(Pid) from patient;";
            
            SqlCommand querygetid = new SqlCommand(commandget, conn1);
            rdr = querygetid.ExecuteReader();
            if(rdr.Read())
                maxid = Int32.Parse(rdr[0].ToString());
            rdr.Close();
            maxid += 1;
            
            string pbldgrp = bldgrp(txtPblood.Text.ToString());
            int bloodcount = 0;
            rdr = null;
            string getblood= "select max(" + pbldgrp.ToString() + ") from bank where id = " +bnkid.ToString()+ ";";
            bloodcount = Int32.Parse(txtPquan.Text.ToString());
            MessageBox.Show(bloodcount.ToString());
            SqlCommand getbldcount = new SqlCommand(getblood,conn1);
            rdr1 = getbldcount.ExecuteReader();
            if (rdr1.Read())
            {
                int bloodcount1 = rdr1.GetInt32(0);
                rdr1.Close();
               if(bloodcount<=bloodcount1)
                {
                    bloodcount1 -= bloodcount;
                    
                    string updatecommand = "update bank set " + pbldgrp.ToString() + " = '" + bloodcount1+ "' where id= '" + bnkid+ "';";
                    SqlCommand update = new SqlCommand(updatecommand, conn1);
                    update.ExecuteNonQuery();
                    conn1.Close();
                    conn1.Open();
                    MessageBox.Show("ok" + maxid.ToString(), "ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    command = "insert into patient (Pid,Pname,Paddress,Pincode,Bldgrp) values" + "(" + maxid.ToString() + ",'" + txtPname.Text.ToString() + "','" + txtPaddress.Text.ToString() + "','" + txtPin.Text.ToString() + "','" + txtPblood.Text.ToString() + "');";
                    SqlCommand insert = new SqlCommand(command, conn1);
                    insert.ExecuteNonQuery();
                    conn1.Close();
                    txtPaddress.Text = null;
                    txtPname.Text = null;
                    txtPblood.Text = null;
                    txtPin.Text = null;
                    txtPquan.Text = null;

                }
                else
                {
                    MessageBox.Show("Not available", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //exit condition
                    
                }
                rdr1.Close();
            }
            

        }
        private string bldgrp(string bld )
        {
            switch (bld)
            {
                case "a+":
                case "A+":
                    return "apos";


                    break;
                case "a-":
                case "A-":
                    return "aneg";

                    break;
                case "b+":
                case "B+":
                    return "bpos";
                    break;
                case "b-":
                case "B-":
                    return "bneg";

                    break;
                case "ab+":
                case "AB+":

                    break;
                case "ab-":
                case "AB-":
                    return "abneg";
                    break;
                case "o+":
                case "O+":
                    return "opos";
                    break;
                case "o-":
                case "O-":
                    return "oneg";
                    break;




            }

            return null;
        }
        private void LblExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnSubmitD_Click(object sender, EventArgs e)
        {
            int maxid = 0;
            string constring = @"Data Source=.\sqlexpress;Initial Catalog=Bank;Integrated Security=True;Pooling=False";
            SqlConnection conn1 = new SqlConnection(constring);
            conn1.Open();
            string command;
            SqlDataReader rdr = null, rdr1 = null;
            string commandget = "select max(Did) from Donar;";
            SqlCommand getmaxD = new SqlCommand(commandget, conn1);

            rdr = getmaxD.ExecuteReader();
            if (rdr.Read())
            {
                maxid = rdr.GetInt32(0);
                rdr.Close();
                maxid += 1;
                string pbldgrp = bldgrp(txtDBgrp.Text.ToString());
                int bloodcount = 0;
                rdr = null;
                string getblood = "select max(" + pbldgrp.ToString() + ") from bank where id = " + bnkid.ToString() + ";";
                
                SqlCommand getbldcount = new SqlCommand(getblood, conn1);
                rdr1 = getbldcount.ExecuteReader();
                if (rdr1.Read())
                {
                    int bloodcount1 = rdr1.GetInt32(0);
                    rdr1.Close();
                    
                        bloodcount1 +=1;

                        string updatecommand1= "update bank set " + pbldgrp.ToString() + " = '" + bloodcount1 + "' where id= '" + bnkid + "';";
                        SqlCommand update1 = new SqlCommand(updatecommand1, conn1);
                        update1.ExecuteNonQuery();
                        conn1.Close();
                    conn1.Open();
                    string commandInsert = "insert into Donar (Did,Dname,Address,Age,Weight,Hb,Email,Mobile,DDate,Bgroup,Status) values(" + maxid + ",'" + txtDname.Text.ToString() + "','" + txtDaddress.Text.ToString() + "','" + txtAge.Text.ToString() + "','" + txtDweight.Text.ToString() + "','" + txtDHB.Text.ToString() + "','" + txtDemail.Text.ToString() + "','" + txtDmobile.Text.ToString() + "','" + DateTime.Now.ToString() + "','" + txtDBgrp.Text.ToString() + "','" + txtDstatus.Text.ToString() + "');";
                    SqlCommand put = new SqlCommand(commandInsert, conn1);
                    put.ExecuteNonQuery();

                    conn1.Close();
                    MessageBox.Show("Record added successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAge.Clear();
                    txtDaddress.Clear();
                    txtDBgrp.Clear();
                    txtDemail.Clear();
                    txtDHB.Clear();
                    txtDmobile.Clear();
                    txtDname.Clear();
                    txtDstatus.Clear();
                    txtDweight.Clear();
                    
                }

                    


            }
            
        }

        private void TxtPblood_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

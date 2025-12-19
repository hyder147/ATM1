using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATM1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\123\OneDrive\Documents\ATM1DB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True ");
        public static string accountNum;
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtnTb_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AccountTb1 where AccNum='" + AccNumTb.Text + "' and PIN = " + PinTb.Text + "", con);
            DataTable  dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            { 
                accountNum = AccNumTb.Text;
                Home home = new Home();
                home.Show();
                this.Hide();
                con.Close();
            }
            else
            {
                MessageBox.Show("Wrong Account Number OR PIN Code");
            } 
                con.Close();
        }
    }
}

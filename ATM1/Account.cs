using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;



namespace ATM1
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\123\OneDrive\Documents\ATM1DB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True ");
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            int bal = 0;
            if (AccNumTb.Text == "" || AccNameTb.Text == "" || AccFnameTb.Text == "" || AddressTb.Text == "" || PinTb.Text == "" || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into AccountTb1('" + AccNumTb.Text + "','" + AccNameTb.Text + "','" + AccFnameTb.Text + "','" + PhoneTb.Text + "','" + AddressTb.Text + "','" + PinTb.Text + ",'" + bal + ")";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully");
                    LoginForm log = new LoginForm();
                    //log.show();
                    this.Hide();
                    con.Close();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            // log.show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AccNumTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

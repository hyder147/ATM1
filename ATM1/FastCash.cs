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
    public partial class FastCash : Form
    {
        public FastCash()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\123\OneDrive\Documents\ATM1DB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True ");
        string Acc = LoginForm.accountNum;
        int balance, newBalance,amount=0;
        public void GetBalance()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTb1 where AccNum='" + Acc + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BalanceLbl.Text = "Balance $: " + dt.Rows[0][0].ToString();
            balance = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();
        }
        public void AddTranscation()
        {
            string transcationType = "Withdraw";
            try
            {
                con.Open();
                //(AccountTb1 change hoga transcation table se)
                string query = "insert into AccountTb1('" + Acc + "','" + transcationType + "'," + amount + ",'" + DateTime.Today.ToString() + "')";

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
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void FastCash_Load(object sender, EventArgs e)
        {
            GetBalance();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (balance < 10)
            {
                MessageBox.Show("Balance can't be negative");
            }
            else
            {
                amount = 10;
                newBalance = balance - 10;
                try
                {
                    con.Open();
                    string query = "Update AccountTb1 set Balance " + newBalance + "where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Successfully Withdrawal");
                    con.Close();
                    AddTranscation();
                    LoginForm log = new LoginForm();
                    log.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (balance < 50)
            {
                MessageBox.Show("Balance can't be negative");
            }
            else
            {
                amount = 50;
                newBalance = balance - 50;
                try
                {
                    con.Open();
                    string query = "Update AccountTb1 set Balance " + newBalance + "where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Successfully Withdrawal");
                    con.Close();
                    AddTranscation();
                    LoginForm log = new LoginForm();
                    log.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (balance < 100)
            {
                MessageBox.Show("Balance can't be negative");
            }
            else
            {
                amount = 100;
                newBalance = balance - 100;
                try
                {
                    con.Open();
                    string query = "Update AccountTb1 set Balance " + newBalance + "where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Successfully Withdrawal");
                    con.Close();
                    AddTranscation();
                    LoginForm log = new LoginForm();
                    log.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (balance < 1000)
            {
                MessageBox.Show("Balance can't be negative");
            }
            else
            {
                amount = 1000;
                newBalance = balance - 1000;
                try
                {
                    con.Open();
                    string query = "Update AccountTb1 set Balance " + newBalance + "where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Successfully Withdrawal");
                    con.Close();
                    AddTranscation();
                    LoginForm log = new LoginForm();
                    log.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}


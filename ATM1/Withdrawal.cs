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
    public partial class Withdrawal : Form
    {
        public Withdrawal()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\123\OneDrive\Documents\ATM1DB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True ");
        string Acc = LoginForm.accountNum;
        int balance;
        int newBalance;

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
                string query = "insert into AccountTb1('" + Acc + "','" + transcationType + "'," + WithdrawalTb.Text + ",'" + DateTime.Today.ToString() + "')";

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
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Withdrawal_Load(object sender, EventArgs e)
        {
            GetBalance();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (WithdrawalTb.Text == "")
            {
                MessageBox.Show("Missing Amount");
            }
            else if (Convert.ToInt32(WithdrawalTb.Text) <= 0)
            {
                MessageBox.Show("Please Enter a valid Amount");
            }
            else if (Convert.ToInt32(WithdrawalTb.Text) > balance)
            {
                MessageBox.Show("Balance can't be negative");
            }
            else
            {

                newBalance = balance - Convert.ToInt32(WithdrawalTb.Text);
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

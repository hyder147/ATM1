using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace ATM1
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\123\OneDrive\Documents\ATM1DB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True ");

        private void button1_Click(object sender, EventArgs e)
        {
            if (DepositAmtLbl.Text == "" || Convert.ToInt32(DepositAmtLbl.Text) <= 0)
            {
                MessageBox.Show("Enter Amount To Deposit");
            }
            else
            {
                
                newBalance= oldBalance+Convert.ToInt32(DepositAmtLbl.Text);
                try
                {
                    con.Open();
                    string query = "Update AccountTb1 set Balance " + newBalance + "where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Successfully Deposited");
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
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int oldBalance,newBalance;
        string Acc = LoginForm.accountNum;
        public void GetBalance()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTb1 where AccNum='" +Acc+ "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            oldBalance = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();
        }
        public void AddTranscation()
        {
            string transcationType = "Deposit";
            try
            {
                con.Open();
                //(AccountTb1 change hoga transcation table se)
                string query = "insert into AccountTb1('" + Acc+ "','" + transcationType + "'," +DepositAmtLbl.Text+ ",'" +DateTime.Today.ToString()+"')";

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
            con.Close() ;
        }
        private void Deposit_Load(object sender, EventArgs e)
        {
            GetBalance();
        }
    }
}

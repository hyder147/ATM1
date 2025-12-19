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
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\123\OneDrive\Documents\ATM1DB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True ");
        public void GetBalance()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTb1 where AccNum='" + AccNumLbl.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BalanceLbl.Text = dt.Rows[0][0].ToString();
            con.Close();    
        }
        private void Balance_Load(object sender, EventArgs e)
        {
            AccNumLbl.Text = LoginForm.accountNum;
            GetBalance();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

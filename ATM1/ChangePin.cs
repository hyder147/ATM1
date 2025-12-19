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
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home =new Home();
            home.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\123\OneDrive\Documents\ATM1DB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True ");
        string Acc = LoginForm.accountNum;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Pin1Tb.Text == "" || Pin2Tb.Text == "")
            {
                MessageBox.Show("Enter New and Confirm Pin Number");
            }
            else if (Pin2Tb.Text != Pin2Tb.Text)
            {
                MessageBox.Show("New Pin and Confirm Pin are Different");
            }
            else
            {

                // newBalance = oldBalance + Convert.ToInt32(DepositAmtLbl.Text);
                try
                {
                    con.Open();
                    string query = "Update AccountTb1 set Balance " + Pin1Tb.Text + "where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pin Changed Successfully");
                    con.Close();
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

        private void Pin2Tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

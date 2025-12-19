using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ATM1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            //  AccNumLb.Text = "Account Number : " + LoginForm.accountNum;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            //log.show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Balance bal = new Balance();
            bal.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MiniStatements stat = new MiniStatements();
            stat.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Deposit dop = new Deposit();
            dop.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ChangePin cPin = new ChangePin();
            cPin.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Withdrawal wd = new Withdrawal();
            wd.Show(); 
            this.Hide(); 
        }
    }
}

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
    public partial class MiniStatements : Form
    {
        public MiniStatements()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\123\OneDrive\Documents\ATM1DB.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True ");
        string Acc = LoginForm.accountNum;
        private void Populate()
        {
            con.Open();
            string query = "select * from TranscationTb1 where AccNum = '" + Acc + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            MiniStatementDGV.DataSource=ds.Tables[0];
            con.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MiniStatements_Load(object sender, EventArgs e)
        {
            Populate();
        }
    }
}

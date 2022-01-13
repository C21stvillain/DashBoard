using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Plan_Maker
{
    
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlCommand command;
        SqlDataAdapter DA;
        void listGetir()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Plan Maker_V1.1\Plan Maker\Database1.mdf;Integrated Security=True");
            con.Open();
            DA = new SqlDataAdapter("SELECT yapilcaklist FROM yaplist", con);
            DataTable table = new DataTable();
            DA.Fill(table);
            dataGridView1.DataSource = table;
            con.Close();

        }
        void earningsGetir()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Plan Maker_V1.1\Plan Maker\Database1.mdf;Integrated Security=True");
            con.Open();
            DA = new SqlDataAdapter("SELECT earning FROM earningss", con);
            DataTable table = new DataTable();
            DA.Fill(table);
            dataGridView2.DataSource = table;
            con.Close();
        }

        void totalGetir()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Plan Maker_V1.1\Plan Maker\Database1.mdf;Integrated Security=True");
            con.Open();
            DA = new SqlDataAdapter("SELECT total FROM earningss", con);
            DataTable table = new DataTable();
            DA.Fill(table);
            dataGridView3.DataSource = table;
            con.Close();
        }
        void WorkGetir()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Plan Maker_V1.1\Plan Maker\Database1.mdf;Integrated Security=True");
            con.Open();
            DA = new SqlDataAdapter("SELECT workk FROM Weeklyy", con);
            DataTable table = new DataTable();
            DA.Fill(table);
            dataGridViewwork.DataSource = table;
            con.Close();
        }
        void BookGetir()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Plan Maker_V1.1\Plan Maker\Database1.mdf;Integrated Security=True");
            con.Open();
            DA = new SqlDataAdapter("SELECT bookk FROM Weeklyy", con);
            DataTable table = new DataTable();
            DA.Fill(table);
            dataGridViewbook.DataSource = table;
            con.Close();
        }
        void GymGetir()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Plan Maker_V1.1\Plan Maker\Database1.mdf;Integrated Security=True");
            con.Open();
            DA = new SqlDataAdapter("SELECT gymm FROM Weeklyy", con);
            DataTable table = new DataTable();
            DA.Fill(table);
            dataGridViewgym.DataSource = table;
            con.Close();
        }
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listGetir();
            earningsGetir();
            totalGetir();
            BookGetir();
            WorkGetir();
            GymGetir();
        }

       
    }
}

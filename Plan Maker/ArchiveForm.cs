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
    public partial class ArchiveForm : Form
    {
        SqlConnection con;
        SqlDataAdapter DA;
        SqlCommand command;

        public ArchiveForm()
        {
            InitializeComponent();
        }

        void kazanim()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Plan Maker_V1.1\Plan Maker\Database1.mdf;Integrated Security=True");
            con.Open();
            DA = new SqlDataAdapter("SELECT *FROM Kazanimm", con);
            DataTable table = new DataTable();
            DA.Fill(table);
            dataGridView2.DataSource = table;
            con.Close();
        }

        void agenda()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Plan Maker_V1.1\Plan Maker\Database1.mdf;Integrated Security=True");
            con.Open();
            DA = new SqlDataAdapter("SELECT *FROM Agenda", con);
            DataTable table = new DataTable();
            DA.Fill(table);
            dataGridView1.DataSource = table;
            con.Close();
        }
        private void ArchiveForm_Load(object sender, EventArgs e)
        {
            kazanim();
            agenda();
        }
    }
}

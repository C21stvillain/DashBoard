using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Plan_Maker
{
    public partial class SettingsForm : Form
    {
        SqlConnection con;
        SqlCommand command;
        SqlDataAdapter DA;
        
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Plan Maker_V1.1\Plan Maker\Database1.mdf;Integrated Security=True");
            string workk = "UPDATE Weeklyy SET workk = 0";
            command = new SqlCommand(workk, con);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();

            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Plan Maker_V1.1\Plan Maker\Database1.mdf;Integrated Security=True");
            string bookk = "UPDATE Weeklyy SET bookk = 0";
            command = new SqlCommand(bookk, con);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();

            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Plan Maker_V1.1\Plan Maker\Database1.mdf;Integrated Security=True");
            string gymm = "UPDATE Weeklyy SET gymm = 0";
            command = new SqlCommand(gymm, con);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Work")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Plan Maker_V1.1\Plan Maker\Database1.mdf;Integrated Security=True");
                string workk = "UPDATE Weeklyy SET workk += @work";
                command = new SqlCommand(workk, con);
                command.Parameters.AddWithValue("@work", Convert.ToInt32(textBox2.Text));
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                textBox2.Clear();
            }

            if (comboBox1.Text == "Book")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Plan Maker_V1.1\Plan Maker\Database1.mdf;Integrated Security=True");
                string bookk = "UPDATE Weeklyy SET bookk += @book";
                command = new SqlCommand(bookk, con);
                command.Parameters.AddWithValue("@book", Convert.ToInt32(textBox2.Text));
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                textBox2.Clear();
            }

            if (comboBox1.Text == "Gym")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Plan Maker_V1.1\Plan Maker\Database1.mdf;Integrated Security=True");
                string gymm = "UPDATE Weeklyy SET gymm += @gymm";
                command = new SqlCommand(gymm, con);
                command.Parameters.AddWithValue("@gymm", Convert.ToInt32(textBox2.Text));
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                textBox2.Clear();
            }

        }
    }
}

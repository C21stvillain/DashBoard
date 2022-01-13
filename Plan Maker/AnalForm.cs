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
    public partial class AnalForm : Form
    {
        SqlConnection con;
        SqlCommand command;
        SqlDataAdapter DA;
        public AnalForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Plan Maker_V1.1\Plan Maker\Database1.mdf;Integrated Security=True");
            string sil = "DELETE FROM yaplist";
            command = new SqlCommand(sil, con);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
        }

      

        private void AnalForm_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Plan Maker_V1.1\Plan Maker\Database1.mdf;Integrated Security=True");
            string sorgu = "insert into yaplist(yapilcaklist) VALUES (@yapilcaklist);";
            command = new SqlCommand(sorgu, con);
            command.Parameters.AddWithValue("@yapilcaklist", richTextBox1.Text);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            richTextBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Plan Maker_V1.1\Plan Maker\Database1.mdf;Integrated Security=True");
            string educ = "insert into Kazanimm(kazanimlar) VALUES (@kazanimlar);";
            command = new SqlCommand(educ, con);
            command.Parameters.AddWithValue("@kazanimlar", textBox2.Text);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Plan Maker_V1.1\Plan Maker\Database1.mdf;Integrated Security=True");
            string earning = "UPDATE earningss SET earning = @earning";
            command = new SqlCommand(earning, con);
            command.Parameters.AddWithValue("@earning", Convert.ToInt32(textBox1.Text));
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            string total = "UPDATE earningss SET total +=@earning";
            command = new SqlCommand(total, con);
            command.Parameters.AddWithValue("@earning", Convert.ToInt32(textBox1.Text));
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            textBox1.Clear();
        }
    }
}

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
    public partial class CalenderForm : Form
    {
        SqlConnection con;
        SqlCommand command;
        SqlDataAdapter da;
        public CalenderForm()
        {
            InitializeComponent();
        }

        private void CalenderForm_Load(object sender, EventArgs e)
        {
            //string[] liste = { "Ed. Attainment", "To-Do-List", "Agenda" };
            //comboBox2
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Plan Maker_V1.1\Plan Maker\Database1.mdf;Integrated Security=True");
            string sorgu = "insert into Agenda(dtarih,yapilacaklar) VALUES (@dtarih,@yapilacaklar)";
            command = new SqlCommand(sorgu, con);
            command.Parameters.AddWithValue("@dtarih", dateTimePicker1.Value);
            command.Parameters.AddWithValue("@yapilacaklar", textBox1.Text);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Agenda")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Plan Maker_V1.1\Plan Maker\Database1.mdf;Integrated Security=True");
                string sil = "DELETE FROM Agenda WHERE mno=@mno";
                command = new SqlCommand(sil, con);
                command.Parameters.AddWithValue("@mno", Convert.ToInt32(textBox2.Text));
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
            }

            if (comboBox1.Text == "To-Do-List")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Plan Maker_V1.1\Plan Maker\Database1.mdf;Integrated Security=True");
                string sil = "DELETE FROM yaplist WHERE mno=@mno";
                command = new SqlCommand(sil, con);
                command.Parameters.AddWithValue("@mno", Convert.ToInt32(textBox2.Text));
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
            }

            if (comboBox1.Text == "Kazanimlar")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Plan Maker_V1.1\Plan Maker\Database1.mdf;Integrated Security=True");
                string sil = "DELETE FROM Kazanimm WHERE mno=@mno";
                command = new SqlCommand(sil, con);
                command.Parameters.AddWithValue("@mno", Convert.ToInt32(textBox2.Text));
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
            }
            
        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Agenda")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Plan Maker_V1.1\Plan Maker\Database1.mdf;Integrated Security=True");
                string sil = "DELETE FROM Agenda";
                command = new SqlCommand(sil, con);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
            }

            if(comboBox2.Text == "To-Do-List")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Plan Maker_V1.1\Plan Maker\Database1.mdf;Integrated Security=True");
                string sil = "DELETE FROM yaplist";
                command = new SqlCommand(sil, con);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
            }

            if(comboBox2.Text == "Kazanimlar")
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exorcist\source\repos\Plan Maker_V1.1\Plan Maker\Database1.mdf;Integrated Security=True");
                string sil = "DELETE FROM Kazanimm";
                command = new SqlCommand(sil, con);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
            }
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Plan_Maker
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
                 int nHeightEllipse

          );


        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            Dash.BackColor = Color.Aquamarine;
            Dash.ForeColor = Color.FromArgb(24, 40, 54);

            lblTitle.Text = "DashBoard";
            this.pnlForms.Controls.Clear();
            Form2 form2_Vrb = new Form2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            form2_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlForms.Controls.Add(form2_Vrb);
            form2_Vrb.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Dash_Click(object sender, EventArgs e)
        {
            Dash.BackColor = Color.Aquamarine;
            Dash.ForeColor = Color.FromArgb(24, 40, 54);
            Anal.BackColor = Color.FromArgb(24, 40, 54);
            Anal.ForeColor = Color.Aquamarine;
            cal.BackColor = Color.FromArgb(24, 40, 54);
            cal.ForeColor = Color.Aquamarine;
            Emp.BackColor = Color.FromArgb(24, 40, 54);
            Emp.ForeColor = Color.Aquamarine;
            sett.BackColor = Color.FromArgb(24, 40, 54);
            sett.ForeColor = Color.Aquamarine;
            lblTitle.Text = "DashBoard";
            this.pnlForms.Controls.Clear();
            Form2 form2_Vrb = new Form2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            form2_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlForms.Controls.Add(form2_Vrb);
            form2_Vrb.Show();
        }

        private void Anal_Click(object sender, EventArgs e)
        {
            Anal.BackColor = Color.Aquamarine;
            Anal.ForeColor = Color.FromArgb(24, 40, 54);
            cal.BackColor = Color.FromArgb(24, 40, 54);
            cal.ForeColor = Color.Aquamarine;
            Emp.BackColor = Color.FromArgb(24, 40, 54);
            Emp.ForeColor = Color.Aquamarine;
            sett.BackColor = Color.FromArgb(24, 40, 54);
            sett.ForeColor = Color.Aquamarine;
            Dash.BackColor = Color.FromArgb(24, 40, 54);
            Dash.ForeColor = Color.Aquamarine;

            lblTitle.Text = "Analytics";
            this.pnlForms.Controls.Clear();
            AnalForm analForm_Vrb = new AnalForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            analForm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlForms.Controls.Add(analForm_Vrb);
            analForm_Vrb.Show();
        }

        private void cal_Click(object sender, EventArgs e)
        {
            cal.BackColor = Color.Aquamarine;
            cal.ForeColor = Color.FromArgb(24, 40, 54);
            Emp.BackColor = Color.FromArgb(24, 40, 54);
            Emp.ForeColor = Color.Aquamarine;
            sett.BackColor = Color.FromArgb(24, 40, 54);
            sett.ForeColor = Color.Aquamarine;
            Dash.BackColor = Color.FromArgb(24, 40, 54);
            Dash.ForeColor = Color.Aquamarine;
            Anal.BackColor = Color.FromArgb(24, 40, 54);
            Anal.ForeColor = Color.Aquamarine;

            lblTitle.Text = "Calendar";
            this.pnlForms.Controls.Clear();
            CalenderForm calenderForm_Vrb = new CalenderForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            calenderForm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlForms.Controls.Add(calenderForm_Vrb);
            calenderForm_Vrb.Show();

        }

        private void sett_Click(object sender, EventArgs e)
        {
            sett.BackColor = Color.Aquamarine;
            sett.ForeColor = Color.FromArgb(24, 40, 54);
            Dash.BackColor = Color.FromArgb(24, 40, 54);
            Dash.ForeColor = Color.Aquamarine;
            Anal.BackColor = Color.FromArgb(24, 40, 54);
            Anal.ForeColor = Color.Aquamarine;
            Emp.BackColor = Color.FromArgb(24, 40, 54);
            Emp.ForeColor = Color.Aquamarine;
            cal.BackColor = Color.FromArgb(24, 40, 54);
            cal.ForeColor = Color.Aquamarine;

            lblTitle.Text = "Settings";
            this.pnlForms.Controls.Clear();
            SettingsForm settingsForm_Vrb = new SettingsForm() { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
            settingsForm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlForms.Controls.Add(settingsForm_Vrb);
            settingsForm_Vrb.Show();



        }


        private void Emp_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Upcoming";
            Emp.BackColor = Color.Aquamarine;
            Emp.ForeColor = Color.FromArgb(24, 40, 54);
            Dash.BackColor = Color.FromArgb(24, 40, 54);
            Dash.ForeColor = Color.Aquamarine;
            Anal.BackColor = Color.FromArgb(24, 40, 54);
            Anal.ForeColor = Color.Aquamarine;
            cal.BackColor = Color.FromArgb(24, 40, 54);
            cal.ForeColor = Color.Aquamarine;
            sett.BackColor = Color.FromArgb(24, 40, 54);
            sett.ForeColor = Color.Aquamarine;
            this.pnlForms.Controls.Clear();
            ArchiveForm archiveForm_Vrb = new ArchiveForm() { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
            archiveForm_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlForms.Controls.Add(archiveForm_Vrb);
            archiveForm_Vrb.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

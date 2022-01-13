
namespace Plan_Maker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.sett = new System.Windows.Forms.Button();
            this.Emp = new System.Windows.Forms.Button();
            this.cal = new System.Windows.Forms.Button();
            this.Anal = new System.Windows.Forms.Button();
            this.Dash = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlForms = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.sett);
            this.panel1.Controls.Add(this.Emp);
            this.panel1.Controls.Add(this.cal);
            this.panel1.Controls.Add(this.Anal);
            this.panel1.Controls.Add(this.Dash);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Aquamarine;
            this.panel3.Location = new System.Drawing.Point(185, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 583);
            this.panel3.TabIndex = 7;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.Aquamarine;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(1, 577);
            this.pnlNav.TabIndex = 2;
            // 
            // sett
            // 
            this.sett.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sett.FlatAppearance.BorderSize = 0;
            this.sett.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sett.Font = new System.Drawing.Font("SWRomnt", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sett.ForeColor = System.Drawing.Color.Aquamarine;
            this.sett.Location = new System.Drawing.Point(0, 532);
            this.sett.Name = "sett";
            this.sett.Size = new System.Drawing.Size(186, 45);
            this.sett.TabIndex = 6;
            this.sett.Text = "Settings";
            this.sett.UseVisualStyleBackColor = true;
            this.sett.Click += new System.EventHandler(this.sett_Click);
            // 
            // Emp
            // 
            this.Emp.Dock = System.Windows.Forms.DockStyle.Top;
            this.Emp.FlatAppearance.BorderSize = 0;
            this.Emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Emp.Font = new System.Drawing.Font("SWRomnt", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Emp.ForeColor = System.Drawing.Color.Aquamarine;
            this.Emp.Location = new System.Drawing.Point(0, 279);
            this.Emp.Name = "Emp";
            this.Emp.Size = new System.Drawing.Size(186, 45);
            this.Emp.TabIndex = 5;
            this.Emp.Text = "Upcoming";
            this.Emp.UseVisualStyleBackColor = true;
            this.Emp.Click += new System.EventHandler(this.Emp_Click);
            // 
            // cal
            // 
            this.cal.Dock = System.Windows.Forms.DockStyle.Top;
            this.cal.FlatAppearance.BorderSize = 0;
            this.cal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cal.Font = new System.Drawing.Font("SWRomnt", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cal.ForeColor = System.Drawing.Color.Aquamarine;
            this.cal.Location = new System.Drawing.Point(0, 234);
            this.cal.Name = "cal";
            this.cal.Size = new System.Drawing.Size(186, 45);
            this.cal.TabIndex = 4;
            this.cal.Text = "Calendar";
            this.cal.UseVisualStyleBackColor = true;
            this.cal.Click += new System.EventHandler(this.cal_Click);
            // 
            // Anal
            // 
            this.Anal.Dock = System.Windows.Forms.DockStyle.Top;
            this.Anal.FlatAppearance.BorderSize = 0;
            this.Anal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Anal.Font = new System.Drawing.Font("SWRomnt", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Anal.ForeColor = System.Drawing.Color.Aquamarine;
            this.Anal.Location = new System.Drawing.Point(0, 189);
            this.Anal.Name = "Anal";
            this.Anal.Size = new System.Drawing.Size(186, 45);
            this.Anal.TabIndex = 3;
            this.Anal.Text = "Analytics";
            this.Anal.UseVisualStyleBackColor = true;
            this.Anal.Click += new System.EventHandler(this.Anal_Click);
            // 
            // Dash
            // 
            this.Dash.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dash.FlatAppearance.BorderSize = 0;
            this.Dash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dash.Font = new System.Drawing.Font("SWRomnt", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dash.ForeColor = System.Drawing.Color.Aquamarine;
            this.Dash.Location = new System.Drawing.Point(0, 144);
            this.Dash.Name = "Dash";
            this.Dash.Size = new System.Drawing.Size(186, 45);
            this.Dash.TabIndex = 2;
            this.Dash.Text = "DashBoard";
            this.Dash.UseVisualStyleBackColor = true;
            this.Dash.Click += new System.EventHandler(this.Dash_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SWRomnt", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(48, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "N8RAID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("SWRomnt", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(214, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(229, 39);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "DASHBOARD";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Aquamarine;
            this.button1.Location = new System.Drawing.Point(895, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlForms
            // 
            this.pnlForms.Location = new System.Drawing.Point(192, 88);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Size = new System.Drawing.Size(733, 477);
            this.pnlForms.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(933, 577);
            this.Controls.Add(this.pnlForms);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button sett;
        private System.Windows.Forms.Button Emp;
        private System.Windows.Forms.Button cal;
        private System.Windows.Forms.Button Anal;
        private System.Windows.Forms.Button Dash;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlForms;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlNav;
    }
}


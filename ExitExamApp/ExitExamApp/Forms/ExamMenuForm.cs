using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExitExamApp
{
    public partial class ExamMenuForm : Form
    {
        private int exitCode;

        User user = new User();
        public ExamMenuForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            welcomeLabel.Text = "Welcome, " + user.FirstName + " " + user.LastName + ".";
        }

        private void exitExamButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(exitCode);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUserForm xmform = new AddUserForm();
            xmform.Show();
            this.Close();
        }
    }
}

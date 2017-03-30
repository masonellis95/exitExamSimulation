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
    public partial class DeleteUserForm : Form
    {
        DatabaseManager thisOne;
        User deleteMe;

        public DeleteUserForm()
        {
            InitializeComponent();
            verifyBox.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // instantiate a database manager
            thisOne = new DatabaseManager();
            deleteMe = thisOne.GetUser(Int32.Parse(mNumberBox.Text));
            firstNameBox.Text = deleteMe.FirstName;
            lastNameBox.Text = deleteMe.LastName;
            verifyBox.Show();
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            thisOne.DeleteUser(deleteMe.UserID);
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            deleteMe = null;
            mNumberBox.Text = "";
            firstNameBox.Text = "";
            lastNameBox.Text = "";
            verifyBox.Hide();
        }
    }
}

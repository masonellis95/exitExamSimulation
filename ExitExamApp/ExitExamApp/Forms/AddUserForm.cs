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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        /******************************************************************************
         * private void addButton_Click(object sender, EventArgs e)
         * 
         * @ instantiates new User based on data submitted in AddUserForm text boxes
         * @ params: object sender, EventArgs e
         * @ returns: NA
         * 
        ******************************************************************************/
        

        private void addButton_Click_1(object sender, EventArgs e)
        {
            
            // instantiate new User
            User theNewUser = new User();

            // specify user attributes
            try
            { theNewUser.UserID = Int32.Parse(this.mNumberBox.Text); }
            catch (Exception ex)
            { MessageBox.Show("Please enter ony integers for the M number."); }

            theNewUser.FirstName = firstNameBox.Text;
            theNewUser.LastName = lastNameBox.Text;
            theNewUser.UserName = userNameBox.Text;
            theNewUser.PassWord = passwordBox.Text;
            theNewUser.UserType = userTypeTextBox.Text[0];

            DatabaseManager thisOne = new DatabaseManager();

            // send User object to Database Manager- so indicate if no joy
            bool success = thisOne.InsertUser(theNewUser);
            if (success) MessageBox.Show(theNewUser.FirstName + " " + 
                theNewUser.LastName + " added to database.");
            else MessageBox.Show("User not added.");

            this.Hide();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

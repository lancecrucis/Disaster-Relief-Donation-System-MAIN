using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disaster_Relief_Donation_System_Functions
{
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
        }

        private void forgotPassword_Click(object sender, EventArgs e)
        {
            Forgot_Password forgotPasswordPage = new Forgot_Password();
            forgotPasswordPage.Show();
            this.Hide();
            
        }

        private void register_Click(object sender, EventArgs e)
        {
            Sign_Up_Page signUpPage = new Sign_Up_Page();
            signUpPage.Show();
            this.Hide();
            
        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernametxt.Text;
            string password = passwordtxt.Text;

            string user = "lance";
            string pass = "admin";

            if (username == user && password == pass) {
                MessageBox.Show("Login Successfull");
            }
            else {
                MessageBox.Show("Login failed");
            }
        }
    }
}

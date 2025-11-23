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
    public partial class Forgot_Password : Form
    {
        public Forgot_Password()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backToLogin_Click(object sender, EventArgs e)
        {
            loginPage loginPage = new loginPage();
            loginPage.Show();
            this.Close();
        }

        private void sendCodeBtn_Click(object sender, EventArgs e)
        {
            string email = emailAddresstxt.Text;

            verifyCode verifyCodePage = new verifyCode(email);
            verifyCodePage.Show();
            this.Close();

            
        }
    }
}

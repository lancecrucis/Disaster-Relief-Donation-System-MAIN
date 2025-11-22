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
            this.Close();
        }
    }
}

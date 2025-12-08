using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Disaster_Relief_Donation_System_Functions
{
    
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            SwitchControl(new Dashboard());

        }
        public void SwitchControl(UserControl newControl)
        {
            panel4.Controls.Clear();
            newControl.Dock = DockStyle.Fill;
            panel4.Controls.Add(newControl);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SwitchControl(new Dashboard());
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SwitchControl(new Request());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SwitchControl(new Donations());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            donateButton donate = new donateButton();
            donate.Show();
        }
    }
}

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
    public partial class Request : UserControl
    {
        public Request()
        {
            InitializeComponent();
        }
        int cardCount = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            using (requestButtonInfo popUpForm = new requestButtonInfo(this as Request))
            {
                popUpForm.ShowDialog();
            }
        }
        public void AddCardToPanel(Panel card)
        {
            card.Location = new Point(10, cardCount * 140 + 10);
            panel1.Controls.Add(card);
            cardCount++;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Disaster_Relief_Donation_System_Functions
{
    public partial class requestButtonInfo : Form
    {
        private Request _parentForm;
        public requestButtonInfo(Request parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Panel card = new Panel();
            card.Size = new Size(_parentForm.panel1.Width - 20, 130);

            card.BackColor = Color.White;
            card.BorderStyle = BorderStyle.None;

            // ----- TEMPLATE DATA -----
            string name = "lance";
            string location = "Zone 4 Silang, Cavite";
            string date = "Nov. 5, 2025";
            string status = "Pending";
            string note = "Urgent need for clean drinking water and water purification tablets for 200 families";

            // Name label
            Label lblName = new Label();
            lblName.Text = name;
            lblName.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblName.Location = new Point(15, 10);
            lblName.AutoSize = true;

            // Location label
            Label lblLocation = new Label();
            lblLocation.Text = location;
            lblLocation.Font = new Font("Segoe UI", 8);
            lblLocation.Location = new Point(15, 35);
            lblLocation.AutoSize = true;

            // Date (right side)
            Label lblDate = new Label();
            lblDate.Text = date;
            lblDate.Font = new Font("Segoe UI", 9);
            lblDate.AutoSize = true;
            lblDate.Location = new Point(card.Width - lblDate.Width - 70, 10);

            // Status badge
            Label statusBadge = new Label();
            statusBadge.Text = status;
            statusBadge.AutoSize = false;
            statusBadge.TextAlign = ContentAlignment.MiddleCenter;
            statusBadge.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            statusBadge.Size = new Size(60, 23);
            statusBadge.Location = new Point(card.Width - 75, 7);
            statusBadge.BackColor = Color.Goldenrod;
            statusBadge.ForeColor = Color.White;

            // Note text
            Label lblNote = new Label();
            lblNote.Text = "Note: " + note;
            lblNote.Font = new Font("Segoe UI", 9);
            lblNote.AutoSize = false;
            lblNote.Size = new Size(card.Width - 30, 60);
            lblNote.Location = new Point(15, 60);

            // Add controls to card
            card.Controls.Add(lblName);
            card.Controls.Add(lblLocation);
            card.Controls.Add(lblDate);
            card.Controls.Add(statusBadge);
            card.Controls.Add(lblNote);

            // Add card to panel
            _parentForm.AddCardToPanel(card);

            this.DialogResult = DialogResult.OK;
            this.Close();

    }
    }
}

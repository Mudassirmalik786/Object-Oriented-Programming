using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainManagementSystemGUI.DL;

namespace TrainManagementSystemGUI.UI
{
    public partial class AnnouncementForm : Form
    {
        public AnnouncementForm()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSaveAnnouncement_Click(object sender, EventArgs e)
        {
            string announcement = textBoxMessage.Text;
            if (string.IsNullOrEmpty(announcement))
            {
                MessageBox.Show("You have not entered any text!!");
                return;
            }
            AdminDL.storeAnnouncementIntoFile(announcement, "announcement.txt");
            MessageBox.Show("Announcement has been saved");
            ClearInputField();
        }
        private void ClearInputField()
        {
            textBoxMessage.Text = "";
        }

        private void textBoxMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                // Ignore numeric characters
                // Also ignoring special characters
            }
        }
    }
}

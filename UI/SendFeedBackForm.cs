using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainManagementSystemGUI.BL;
using TrainManagementSystemGUI.DL;

namespace TrainManagementSystemGUI.UI
{
    public partial class SendFeedBackForm : Form
    {
        public SendFeedBackForm()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSendFeedback_Click(object sender, EventArgs e)
        {
            string feedBack = textBoxFeedback.Text;
            if (string.IsNullOrEmpty(feedBack))
            {
                MessageBox.Show("You have entered nothing!!");
                return;
            }
            Customer customer = new Customer();
            customer.setFeedBack(feedBack);
            CustomerDL.addIntoList(customer);
            CustomerDL.storeFeedIntoFile(customer, "feedBack.txt");
            MessageBox.Show("The FeedBack has been sent to Admin");
            ClearInputFields();
        }
        private void ClearInputFields()
        {
            textBoxFeedback.Text = "";
        }

        private void textBoxFeedback_KeyPress(object sender, KeyPressEventArgs e)
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

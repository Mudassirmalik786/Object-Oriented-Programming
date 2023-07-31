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
    public partial class DelateTicketForm : Form
    {
        public DelateTicketForm()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string personName = textBox1.Text;
            Ticket ticket = null;
            Ticket ticketToDelete = TicketDL.checkPresenceofTicket(ticket, personName);
            if (ticketToDelete != null)
            {
                TicketDL.deleteTicketFromList(ticketToDelete, "ticket.txt");
                MessageBox.Show("Ticket has been deleted");
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Ticket with the specified name does not exist.");
            }
        }
        private void ClearInputFields()
        {
            textBox1.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

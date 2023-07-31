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
    public partial class BookedTicketsForm : Form
    {
        List<Ticket> ticketList;
        public BookedTicketsForm()
        {
            InitializeComponent();
            ticketList = TicketDL.getListForTicket();
            ticketList.Clear();
            TicketDL.readTicketFromFile("ticket.txt");
            dataGridViewBookedTickets.DataSource = ticketList;
            dataGridViewBookedTickets.Refresh();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

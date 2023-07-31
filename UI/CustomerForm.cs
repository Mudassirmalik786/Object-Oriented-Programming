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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void buttonViewTrainSchedule_Click(object sender, EventArgs e)
        {
            TrainScheduleForm trainScheduleForm = new TrainScheduleForm();
            trainScheduleForm.ShowDialog();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBuyTicket_Click(object sender, EventArgs e)
        {
            BuyTicketForm buyTicketForm = new BuyTicketForm();
            buyTicketForm.ShowDialog();
        }

        private void buttonViewTickets_Click(object sender, EventArgs e)
        {
            BookedTicketsForm bookedTicketsForm = new BookedTicketsForm();
            bookedTicketsForm.ShowDialog();
        }

        private void buttonSendFeedBack_Click(object sender, EventArgs e) // Almost Done
        {
            SendFeedBackForm sendFeedBackForm = new SendFeedBackForm();
            sendFeedBackForm.ShowDialog();
        }

        private void buttonViewAnnouncement_Click(object sender, EventArgs e)
        {
            ViewAnnouncementForm viewAnnouncementForm = new ViewAnnouncementForm();
            viewAnnouncementForm.ShowDialog();
        }

        private void buttonDeleteTicket_Click(object sender, EventArgs e)
        {
            DelateTicketForm delateTicketForm = new DelateTicketForm();
            delateTicketForm.ShowDialog();
        }

        private void buttonViewTrainSchedule_MouseHover(object sender, EventArgs e)
        {
            buttonViewTrainSchedule.BackColor = Color.MidnightBlue;
            buttonViewTrainSchedule.Anchor = AnchorStyles.Top;
            buttonViewTrainSchedule.ForeColor = Color.Aquamarine;
        }

        private void buttonViewTrainSchedule_MouseLeave(object sender, EventArgs e)
        {
            buttonViewTrainSchedule.BackColor = Color.Lime;
            buttonViewTrainSchedule.ForeColor = Color.Black;
        }

        private void buttonBuyTicket_MouseHover(object sender, EventArgs e)
        {
            buttonBuyTicket.BackColor = Color.MidnightBlue;
            buttonBuyTicket.Anchor = AnchorStyles.Top;
            buttonBuyTicket.ForeColor = Color.Aquamarine;
        }

        private void buttonBuyTicket_MouseLeave(object sender, EventArgs e)
        {
            buttonBuyTicket.BackColor = Color.Lime;
            buttonBuyTicket.ForeColor = Color.Black;
        }

        private void buttonViewTickets_MouseHover(object sender, EventArgs e)
        {
            buttonViewTickets.BackColor = Color.MidnightBlue;
            buttonViewTickets.Anchor = AnchorStyles.Top;
            buttonViewTickets.ForeColor = Color.Aquamarine;
        }

        private void buttonViewTickets_MouseLeave(object sender, EventArgs e)
        {
            buttonViewTickets.BackColor = Color.Lime;
            buttonViewTickets.ForeColor = Color.Black;
        }

        private void buttonSendFeedBack_MouseHover(object sender, EventArgs e)
        {
            buttonSendFeedBack.BackColor = Color.MidnightBlue;
            buttonSendFeedBack.Anchor = AnchorStyles.Top;
            buttonSendFeedBack.ForeColor = Color.Aquamarine;
        }

        private void buttonSendFeedBack_MouseLeave(object sender, EventArgs e)
        {
            buttonSendFeedBack.BackColor = Color.Lime;
            buttonSendFeedBack.ForeColor = Color.Black;
        }

        private void buttonViewAnnouncement_MouseHover(object sender, EventArgs e)
        {
            buttonViewAnnouncement.BackColor = Color.MidnightBlue;
            buttonViewAnnouncement.Anchor = AnchorStyles.Top;
            buttonViewAnnouncement.ForeColor = Color.Aquamarine;
        }

        private void buttonViewAnnouncement_MouseLeave(object sender, EventArgs e)
        {
            buttonViewAnnouncement.BackColor = Color.Lime;
            buttonViewAnnouncement.ForeColor = Color.Black;
        }

        private void buttonDeleteTicket_MouseHover(object sender, EventArgs e)
        {
            buttonDeleteTicket.BackColor = Color.MidnightBlue;
            buttonDeleteTicket.Anchor = AnchorStyles.Top;
            buttonDeleteTicket.ForeColor = Color.Aquamarine;
        }

        private void buttonDeleteTicket_MouseLeave(object sender, EventArgs e)
        {
            buttonDeleteTicket.BackColor = Color.Lime;
            buttonDeleteTicket.ForeColor = Color.Black;
        }

        private void buttonClose_MouseHover(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.MidnightBlue;
            buttonClose.Anchor = AnchorStyles.Top;
            buttonClose.ForeColor = Color.Aquamarine;
        }

        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.BackColor = Color.Lime;
            buttonClose.ForeColor = Color.Black;
        }
    }
}

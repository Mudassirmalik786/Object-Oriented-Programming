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
    public partial class BuyTicketForm : Form
    {
        List<Train> trains = TrainDL.getList();
        public BuyTicketForm()
        {
            InitializeComponent();
            List<string> origin = new List<string>{ "Karachi", "Lahore", "Islamabad", "Peshawar" };
            comboBoxOrigin.DataSource = origin;
            List<string> destination = new List<string> { "Sialkot", "Pindi", "Quetta", "Mianwali" };
            comboBoxDestination.DataSource = destination;
            List<string> category = new List<string> { "Business", "Economy" };
            comboBoxTicketCategory.DataSource = category;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            List<Ticket> tickets = TicketDL.getListForTicket();
            TrainDL.readTrainFromFile("train.txt");
            int ticketNumber = TicketDL.GetNextTicketNumber("ticket.txt");
            string personName = textBoxPersonName.Text;
            string origin = comboBoxOrigin.Text;
            string destination = comboBoxDestination.Text;
            string category = comboBoxTicketCategory.Text;
            double fare = 0;
            string departure = "";
            for(int x = 0; x< trains.Count; x++)
            {
                if(origin == trains[x].getOrigin() && destination == trains[x].getDestination())
                {
                    fare = trains[x].getFare();
                    departure = trains[x].getDeparture();
                }
            }
            if (string.IsNullOrEmpty(personName) ||  string.IsNullOrEmpty(origin) || string.IsNullOrEmpty(destination) || string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Please enter all the above fields");
                return;
            }
            Ticket ticket = new Ticket(ticketNumber, personName, origin, destination, category, fare, departure);
            TicketDL.StoreTicket(ticket, "ticket.txt");
            MessageBox.Show("Ticket has been Booked");
            ClearInputFields();
        }
        private void ClearInputFields()
        {
            textBoxPersonName.Text = "";
            comboBoxOrigin.Text = "";
            comboBoxDestination.Text = "";
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Aqua;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void textBoxPersonName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                // Ignore numeric characters
                // Also ignoring special characters
            }
        }

        private void comboBoxOrigin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
                // Ignore numeric characters
                // Also ignoring special characters
                // Ignore non-numeric characters
            }
        }

        private void comboBoxDestination_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
                // Ignore numeric characters
                // Also ignoring special characters
                // Ignore non-numeric characters
            }
        }

        private void comboBoxTicketCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
                // Ignore numeric characters
                // Also ignoring special characters
                // Ignore non-numeric characters
            }
        }
    }
}

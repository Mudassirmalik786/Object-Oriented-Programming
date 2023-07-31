using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainManagementSystemGUI.BL
{
    class Ticket : Management
    {
        private int ticketNumber;
        private string personName;
        private int quantity;

        public string PersonName { get => personName; set => personName = value; }
        public int TicketNumber { get => ticketNumber; set => ticketNumber = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public Ticket()
        {
        }
        public Ticket(int ticketNumber, string personName, string origin, string destination, string category, double fare, string departure) : base(origin, destination, category, fare, departure)
        {
            this.ticketNumber = ticketNumber;
            this.personName = personName;
        }

        public void setTicketNumber(int ticketNumber)
        {
            this.ticketNumber = ticketNumber;
        }
        public int getTicketNumber()
        {
            return ticketNumber;
        }
        public void setPersonName(string personName)
        {
            this.personName = personName;
        }
        public string getPersonName()
        {
            return personName;
        }
        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }
        public int getQuantity()
        {
            return quantity;
        }
    }
}

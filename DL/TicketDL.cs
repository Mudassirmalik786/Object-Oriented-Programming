using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainManagementSystemGUI.BL;

namespace TrainManagementSystemGUI.DL
{
    class TicketDL : TrainDL
    {
        private static List<Ticket> ticketList = new List<Ticket>();
        internal static List<Ticket> TicketList { get => ticketList; set => ticketList = value; }

        public static void addTicketIntoList(Ticket ticket)
        {
            TicketList.Add(ticket);
        }
        public static bool readTicketFromFile(string path)
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    int ticketNumber = int.Parse(MUserDL.parseData(record, 1));
                    string personName = MUserDL.parseData(record, 2);
                    string origin = MUserDL.parseData(record, 3);
                    string destination = MUserDL.parseData(record, 4);
                    string category = MUserDL.parseData(record, 5);
                    double fare = double.TryParse(MUserDL.parseData(record, 6), out double parsedValue) ? parsedValue : 0.0;
                    string departure = MUserDL.parseData(record, 7);
                    Ticket ticket = new Ticket();
                    ticket.setTicketNumber(ticketNumber);
                    ticket.setPersonName(personName);
                    ticket.setOrigin(origin);
                    ticket.setDestination(destination);
                    ticket.setCategory(category);
                    ticket.setFare(fare);
                    ticket.setDeparture(departure);
                    //Train train = new Train(trainNumber, trainName, trainOrigin, trainDestination, trainFare, trainDeparture);
                    addTicketIntoList(ticket);
                }
                fileVariable.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static List<Ticket> getListForTicket()
        {
            return ticketList;
        }
        public static void storeTicketIntoFile(Ticket ticket, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(ticket.getTicketNumber() + "," + ticket.getPersonName() + "," + ticket.getOrigin() + "," + ticket.getDestination() + "," + ticket.getCategory() + "," + ticket.getFare() + "," + ticket.getDeparture());
            file.Flush();
            file.Close();
        }
        public static void StoreTicket(Ticket ticket, string path)
        {
            addTicketIntoList(ticket);
            storeTicketIntoFile(ticket, path);
        }
        public static int GetNextTicketNumber(string path)
        {
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                if (lines.Length > 0)
                {
                    string lastLine = lines[lines.Length - 1];
                    string[] fields = lastLine.Split(',');
                    if (fields.Length > 0)
                    {
                        string lastTicketNumber = fields[0];
                        if (int.TryParse(lastTicketNumber, out int lastTicketNum))
                        {
                            return lastTicketNum + 1;
                        }
                    }
                }
            }
            return 1;
        }
        public static Ticket checkPresenceofTicket(Ticket ticketToDelete, string personName)
        {
            foreach (Ticket ticket in ticketList)
            {
                if (ticket.getPersonName() == personName)
                {
                    ticketToDelete = ticket;
                    return ticket;
                }
            }
            return null;
        }
        public static void deleteTicketFromList(Ticket ticket, string path) 
        {
            for (int index = 0; index < ticketList.Count; index++)
            {
                if (ticketList[index].getTicketNumber() == ticket.getTicketNumber() && ticketList[index].getPersonName() == ticket.getPersonName())
                {
                    ticketList.RemoveAt(index);
                }
            }
            StoreTicketListintoFile(ticketList, path); 
        }
        public static void StoreTicketListintoFile(List<Ticket> ticketList, string path) 
        {
            
            using (StreamWriter file = new StreamWriter(path, false))
            {
                foreach (Ticket ticket in ticketList)
                {
                    file.WriteLine(ticket.getTicketNumber() + "," + ticket.getPersonName() + "," + ticket.getOrigin() + "," + ticket.getDestination() + "," + ticket.getCategory() + "," + ticket.getFare() + "," + ticket.getDeparture());
                    file.Close();
                }
            }
        }
    }
}

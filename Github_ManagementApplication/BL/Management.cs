using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainManagementSystemGUI.BL
{
    class Management
    {
        protected string origin;
        protected string destination;
        protected double fare;
        protected string departure;
        protected string category;

        public string Origin { get => origin; set => origin = value; }
        public string Destination { get => destination; set => destination = value; }
        public double Fare { get => fare; set => fare = value; }
        public string Departure { get => departure; set => departure = value; }
        public string Category { get => category; set => category = value; }

        public Management(string origin, string destination, string category, double fare, string departure)
        {
            this.origin = origin;
            this.destination = destination;
            this.fare = fare;
            this.departure = departure;
            this.category = category;
        }
        public Management()
        {
        }
        public void setOrigin(string origin)
        {
            this.origin = origin;
        }
        public string getOrigin()
        {
            return origin;
        }
        public void setDestination(string destination)
        {
            this.destination = destination;
        }
        public string getDestination()
        {
            return destination;
        }
        public void setFare(double fare)
        {
            this.fare = fare;
        }
        public double getFare()
        {
            return fare;
        }
        public void setDeparture(string departure)
        {
            this.departure = departure;
        }
        public string getDeparture()
        {
            return departure;
        }
        public void setCategory(string category)
        {
            this.category = category;
        }
        public string getCategory()
        {
            return category;
        }
    }
}

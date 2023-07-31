using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainManagementSystemGUI.BL
{
    class Train : Management
    {
        private string trainNumber;
        private string trainName;

        public string TrainNumber { get => trainNumber; set => trainNumber = value; }
        public string TrainName { get => trainName; set => trainName = value; }

        public Train() : base()
        {
        }
        public Train(string trainNumber, string trainName, string trainOrigin, string trainDestination, string trainCategory, double trainFare, string trainDeparture) : base(trainOrigin, trainDestination, trainCategory, trainFare, trainDeparture)
        {
            this.trainNumber = trainNumber;
            this.trainName = trainName;
        }
        public void setTrainNumber(string trainNumber)
        {
            this.trainNumber = trainNumber;
        }
        public string getTrainNumber()
        {
            return trainNumber;
        }
        public void setTrainName(string trainName)
        {
            this.trainName = trainName;
        }
        public string getTrainName()
        {
            return trainName;
        }
        public string toString()
        {
            string pass = trainNumber + " " + trainNumber + " " + getOrigin() + " " + getDestination() + " " + getCategory() + " " + getFare() + " " + getDeparture();
            return pass;
        }
    }
}

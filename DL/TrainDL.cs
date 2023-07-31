using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainManagementSystemGUI.BL;

namespace TrainManagementSystemGUI.DL
{
    class TrainDL
    {
        private static List<Train> trainList = new List<Train>();
        internal static List<Train> TrainList { get => trainList; set => trainList = value; }

        public static void addTrainIntoList(Train train)
        {
            TrainList.Add(train);
        }
        public static bool readTrainFromFile(string path)
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string trainNumber = MUserDL.parseData(record, 1);
                    string trainName = MUserDL.parseData(record, 2);
                    string trainOrigin = MUserDL.parseData(record, 3);
                    string trainDestination = MUserDL.parseData(record, 4);
                    string trainCategory = MUserDL.parseData(record, 5);
                    double trainFare = double.TryParse(MUserDL.parseData(record, 6), out double parsedValue) ? parsedValue : 0.0;
                    string trainDeparture = MUserDL.parseData(record, 7);
                    Train train = new Train(trainNumber, trainName, trainOrigin, trainDestination, trainCategory, trainFare, trainDeparture);
                    addTrainIntoList(train);
                }
                fileVariable.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void storeTrainIntoFile(Train train, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(train.getTrainNumber() + "," + train.getTrainName() + "," + train.getOrigin() + "," + train.getDestination() + "," + train.getCategory() + "," + train.getFare() + "," + train.getDeparture());
            file.Flush();
            file.Close();
        }
        public static List<Train> getList()
        {
            return trainList;
        }
        public static void StoreTrain(Train train, string path)
        {
            addTrainIntoList(train);
            storeTrainIntoFile(train, path);
        }
        public static Train checkPresenceofTrain(Train trainToDelete, string trainNumber, string trainName)
        {
            foreach (Train train in trainList)
            {
                if (train.getTrainNumber() == trainNumber && train.getTrainName() == trainName)
                {
                    trainToDelete = train;
                    return train;
                }
            }
            return null;
        }
        public static void deleteTrainFromList(Train train, string path)
        {
            for (int index = 0; index < trainList.Count; index++)
            {
                if (trainList[index].getTrainNumber() == train.getTrainNumber() && trainList[index].getTrainName() == train.getTrainName())
                {
                    trainList.RemoveAt(index);
                }
            }
            StoreTrainListintoFile(trainList, path); 
        }

        public static void StoreTrainListintoFile(List<Train> trainList, string path)
        {
            
            using (StreamWriter file = new StreamWriter(path, false))
            {
                foreach (Train train in trainList)
                {
                    file.WriteLine(train.getTrainNumber() + "," + train.getTrainName() + "," + train.getOrigin() + "," + train.getDestination() + "," + train.getCategory() + "," + train.getFare() + "," + train.getDeparture());
                }
            }
        }
    }
}

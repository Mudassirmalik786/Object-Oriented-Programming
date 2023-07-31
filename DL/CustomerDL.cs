using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainManagementSystemGUI.BL;

namespace TrainManagementSystemGUI.DL
{
    class CustomerDL
    {
        public static List<Customer> customers = new List<Customer>();
        public static void addIntoList(Customer customer)
        {
            customers.Add(customer);
        }
        public static void storeFeedIntoFile(Customer customer, string feedBackpath)
        {
            StreamWriter file = new StreamWriter(feedBackpath, true);
            file.WriteLine(customer.getFeedBack());
            file.Flush();
            file.Close();
        }

        public static bool readFeedBackFromFile(string feedbackPath)
        {
            try
            {
                // Open the file using a stream reader
                using (StreamReader sr = new StreamReader(feedbackPath))
                {
                    string fileContents = sr.ReadToEnd();
                    Customer customer = new Customer();
                    customer.setFeedBack(fileContents);
                    addIntoList(customer);
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static List<Customer> getList()
        {
            return customers;
        }
    }
}

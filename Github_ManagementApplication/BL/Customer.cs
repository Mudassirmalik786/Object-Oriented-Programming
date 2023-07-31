using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainManagementSystemGUI.BL
{
    class Customer
    {
        private string feedBack;
        public Customer()
        {
        }
        public void setFeedBack(string feedBack)
        {
            this.feedBack = feedBack;
        }
        public string getFeedBack()
        {
            return feedBack;
        }
    }
}

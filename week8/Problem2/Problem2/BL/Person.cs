using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.BL
{
    class Person
    {
        protected string name;
        protected string address;
        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public string getName()
        {
            return name;
        }
        public string getAddress()
        {
            return address;
        }
        public void setAddress(string address)
        {
            this.address = address;
        }
        public virtual string toString()
        {
            string pass;
            pass = "Person[name = " + name + "address = " + address + "]";
            return pass;
        }
    }
}

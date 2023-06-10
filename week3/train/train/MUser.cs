using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace train
{
    class MUser
    {
        public string name;
        public string password;
        public string role;
        public MUser(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
        public MUser(string name, string password, string role)
        {
            this.name = name;
            this.password = password;
            this.role = role;
        }
        public bool isAdmin()
        {
            if (role == "Admin")
            {
                return true;
            }
            return false;
        }
    }
    class Train
    {
        public string tname;
        public string tschedule;
        public string time;
        public Train(string tname,string tschedule,string time)
        {
            this.tname = tname;
            this.tschedule = tschedule;
            this.time = time;
        }
        public Train()
        {

        }
    }
}

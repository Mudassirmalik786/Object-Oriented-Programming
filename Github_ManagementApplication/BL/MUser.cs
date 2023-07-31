using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainManagementSystemGUI.BL
{
    public class MUser
    {
        private string userName;
        private string userPassword;
        private string userRole;

        public string UserName { get => userName; set => userName = value; }
        public string UserPassword { get => userPassword; set => userPassword = value; }
        public string UserRole { get => userRole; set => userRole = value; }

        public MUser(string userName, string userPassword)
        {
            this.userName = userName;
            this.userPassword = userPassword;

        }
        public MUser()
        {
        }
        public MUser(string userName, string userPassword, string userRole) : this(userName, userPassword)
        {
            this.userRole = userRole;
        }
        public void setuserName(string userName)
        {
            this.userName = userName;
        }
        public string getuserName()
        {
            return userName;
        }
        public void setuserPassword(string userPassword)
        {
            this.userPassword = userPassword;
        }
        public string getuserPassword()
        {
            return userPassword;
        }
        public void setuserRole(string userRole)
        {
            this.userRole = userRole;
        }
        public string getUserRole()
        {
            return userRole;
        }

        public bool isAdmin()
        {
            if (userRole == "Admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string toString()
        {
            string pass = userName + "," + userPassword + "," + userRole;
            return pass;
        }
    }
}

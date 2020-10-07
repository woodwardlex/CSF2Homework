using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Login
    {
        //FIELDS
        private string _username;
        private string _password;

        //PROPERTIES
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }//end Username
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }//end Password

        //CONSTRUCTOR
        public Login(string username, string password)
        {
            Username = username;
            Password = password;
        }
        //default constructor
        public Login() { }

        //METHODS
        public override string ToString()
        {
            return string.Format("Your username is: {0}\n" +
                "Your password is: {1}", Username, Password);
        }//end override ToString()

    }//end class
}//end namespace

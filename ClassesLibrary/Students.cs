using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Students
    {
        //field
        private string _firstName;
        private string _lastName;
        private string _id;
        private float _gpa;

        //properties
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }//end FirstName
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }//end LastName
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }//end Id
        public float Gpa
        {
            get { return _gpa; }
            set { _gpa = value; }
        }//end Gpa

        

        //constructor
        public Students(string firstName, string lastName, string id, float gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Gpa = gpa;
        }//end constructors

        //default CTOR
        public Students() { }

        //methods
        public override string ToString()
        {
            return string.Format("{0} {1}\n\nID: {2}\nGPA: {3:n2}\n", FirstName, LastName, Id, Gpa);
        }
    }
}

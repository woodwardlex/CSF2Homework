using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Customer
    {
        //fields
        
        

        //props
        public string CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<ContactInfo> ContactInformation { get; set; }

        //CTOR
        public Customer(string customerId, string firstName, string lastName, List<ContactInfo> contactInformation)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            ContactInformation = contactInformation;
        }

        public Customer() { }

        //methods
        public override string ToString()
        {
            string contact = "";
            foreach (ContactInfo i in ContactInformation)
            {
                contact += i + "\n";
            }
            return string.Format("{0} {1}\n" +
                "ID: {2}\n" +
                "Contact Information: {3}", FirstName, LastName, CustomerId, ContactInformation);
        }

    }
}

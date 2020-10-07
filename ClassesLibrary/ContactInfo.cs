using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class ContactInfo
    {
        //fields

        //props
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        //CTOR
        public ContactInfo(string streetAddress, string city, string state, string zip, string phone, string email)
        {
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
            Phone = phone;
            Email = email;
        }

        public ContactInfo() { }

        //methods
        public override string ToString()
        {
            return string.Format("\n{0} {1}, {2}\t{3}\n" +
                "Phone: {4}\n" +
                "E-mail: {5}",
                StreetAddress, City, State, Zip, Phone, Email); 
        }

    }
}

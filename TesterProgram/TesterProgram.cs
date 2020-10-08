using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Reference the ClassesLibrary
using ClassesLibrary;

namespace TesterProgram
{
    class TesterProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CSF2 Homework\n\n");

            #region Students
            Console.WriteLine("Students\n");

            Students s1 = new Students();
            s1.FirstName = "Allison";
            s1.LastName = "Jackson";
            s1.Id = "7784565";
            s1.Gpa = 3.67f;

            Console.WriteLine(s1);
            Console.WriteLine();

            Students s2 = new Students("Rodger", "Williamson", "8895655", 2.89f);

            Console.WriteLine(s2);
            Console.WriteLine();
            #endregion

            #region Vehicles
            Console.WriteLine("Vehicles\n");

            Vehicles v1 = new Vehicles();
            v1.Make = "Jeep";
            v1.Model = "Rubicon";
            v1.Year = 2011;
            v1.Weight = 14002.3f;

            Console.WriteLine(v1);

            Vehicles v2 = new Vehicles("Toyota", "Camry", 2009, 12654.46f);

            Console.WriteLine(v2);

            Console.WriteLine();
            #endregion
            
            #region Login
            Console.WriteLine("Login\n");

            Login l1 = new Login();
            l1.Username = "awoodward";
            l1.Password = "ilovepineapples12";

            Console.WriteLine(l1);
            Console.WriteLine();

            Login l2 = new Login("tjmaxx", "shoesshoesshoes");

            Console.WriteLine(l2);
            Console.WriteLine();
            #endregion

            #region Contact Info
            Console.WriteLine("Contact Information\n");

            ContactInfo p1 = new ContactInfo();
            p1.StreetAddress = "32326 Burberry Lane";
            p1.City = "Los Angeles";
            p1.State = "California";
            p1.Zip = "90016";
            p1.Phone = "(901)465-5562";
            p1.Email = "karatekid12@hotmail.com";

            Console.WriteLine(p1);

            ContactInfo p2 = new ContactInfo("99900 Runaway Blvd", "Transylvania", "Pennsylvania", "66600", "(636)222-6660", "itsspookyseason@aol.com");

            Console.WriteLine(p2);
            #endregion

            #region List of Contact Info
            List<ContactInfo> contact = new List<ContactInfo>();
            contact.Add(p1);
            contact.Add(p2);
            #endregion

            #region Customer
            Console.WriteLine("Customer\n");

            Customer c1 = new Customer();
            c1.FirstName = "Analise";
            c1.LastName = "Misuko";
            c1.CustomerId = "445689";
            c1.ContactInformation = contact;

            Customer c2 = new Customer("465645", "Allison", "Lebinski", contact);

            Console.WriteLine(c1);
            Console.WriteLine(c2);

            #endregion

            #region Customer List
            List<Customer> customers = new List<Customer>();
            customers.Add(c1);
            customers.Add(c2);
            #endregion

            #region Credit Card Account
            Console.WriteLine("Credit Card Accounts\n");

            //CreditCardAccount a1 = new CreditCardAccount();
            //a1.AccountNumber = 484895;
            //a1.ContactInfo = customers;
            //a1.Balance = 17899.56m;
            //a1.IsPastDue = true;
            //a1.AnnualInterestRate = .06m;

            CreditCardAccount a2 = new CreditCardAccount(26564, customers, 1656.23m, false, .64m);

            //Console.WriteLine(a1);
            Console.WriteLine(a2);
            #endregion



        }//end main
    }//end class
}//end namespace

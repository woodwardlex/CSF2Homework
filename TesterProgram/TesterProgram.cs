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
            Console.WriteLine("Students\n");

            Students s1 = new Students();
            s1.FirstName = "Allison";
            s1.LastName = "Jackson";
            s1.Id = "7784565";
            s1.Gpa = 3.67f;

            Console.WriteLine(s1);

            Students s2 = new Students("Rodger", "Williamson", "8895655", 2.89f);

            Console.WriteLine(s2);

            Console.WriteLine();

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

            Console.WriteLine("Login\n");

            Login l1 = new Login();
            l1.Username = "awoodward";
            l1.Password = "ilovepineapples12";

            Console.WriteLine(l1);
            Console.WriteLine();

            Login l2 = new Login("tjmaxx", "shoesshoesshoes");

            Console.WriteLine(l2);

            Console.WriteLine();

            Console.WriteLine("Contact Info\n");
            #region MyRegion
            ContactInfo c1 = new ContactInfo();
            c1.StreetAddress = "32321 Balmain St.";
            c1.City = "Los Angeles";
            c1.State = "California";
            c1.Zip = "90101";
            c1.Phone = "(901)667-3726";
            c1.Email = "ktheis@fakeemail.com";

            Console.WriteLine(c1);
            Console.WriteLine();

            ContactInfo c2 = new ContactInfo("2341 Runaway St.", "Transylvania", "Pensylvania", "66600", "(666)555-2346", "lackindracin@spooky.com");

            Console.WriteLine(c2);
            Console.WriteLine();
            #endregion
            

            Console.WriteLine("Customer\n");
            #region Customer

            #endregion


        }//end main
    }//end class
}//end namespace

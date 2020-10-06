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
        }//end main
    }//end class
}//end namespace

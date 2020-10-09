using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class MotorHome : Vehicles
    {
        //fields
        //props
        public int NumberOfBeds { get; set; }

        //ctors
        public MotorHome(string make, string model, int year, float weight, int numberOfBeds) :base(make, model, year, weight)
        {
            NumberOfBeds = numberOfBeds;
        }
        public MotorHome() { }

        //methods
        public override string ToString()
        {
            return base.ToString() + "\nNumber of Beds: " + NumberOfBeds;
        }
    }
}

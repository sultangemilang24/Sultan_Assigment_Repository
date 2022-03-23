using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxiapp
{
    class Taxi
    {
        //Properties
        public string DriverName {get; set;}
        public bool OnDuty {get; set;}
        public int NumPassenger {get; set;}

        //Method
        public void TaxiInfo()
        {
            Console.WriteLine("Nama Driver\t : {0}", DriverName);
            Console.WriteLine("On Duty\t\t : {0}", OnDuty);
            Console.WriteLine("Total Passenger\t : {0}", NumPassenger);
        }
        
        public void PickUpPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang\n", DriverName);
        }
    }
}


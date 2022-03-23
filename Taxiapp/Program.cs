using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxiapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi_1 = new Taxi();
            Taxi taxi_2 = new Taxi();

            taxi_1.DriverName = "Liaw";
            taxi_1.OnDuty = true;
            taxi_1.NumPassenger = 4;

            taxi_2.DriverName = "Anbul";
            taxi_2.OnDuty = false;
            taxi_2.NumPassenger = 0;

            taxi_1.TaxiInfo();
            taxi_1.PickUpPassenger();
            taxi_1.DropOffPassenger();

            taxi_2.TaxiInfo();

            Console.ReadKey();
        }
    }
}

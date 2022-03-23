using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAXI_CLASS
{
    class Program
    {
        static void Main(string[] args)
        {
            //objek taxi
            Taxi member = new Taxi();

            //setting nilai object clas 
            member.DriverName = "jhonitay";
            member.OnDuty = true;
            member.NumPassenger = 10;

            //output informasi
            member.TaxiInfo();
            member.PickupPassenger();
            member.DropOffPassenger();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HGS.Models;

namespace HGS
{
    class Program
    {
        static void Main(string[] args)
        {
            Booth booth = new Booth();

            Car car1 = new Car();
            car1.HGSno = 213564896;
            car1.FullName= "Car example";
            car1.Time = new DateTime(2022, 09, 5);
            car1.Balance = 100;

            booth.Payment(car1);

            Minibus minibus1 = new Minibus();
            minibus1.HGSno = 213555325;
            minibus1.FullName = "Minibus example";
            minibus1.Time = new DateTime(2022, 09, 4);
            minibus1.Balance = 100;

            booth.Payment(minibus1);

            Bus bus1 = new Bus();
            bus1.HGSno = 231567896;
            bus1.FullName = "Bus example";
            bus1.Time = new DateTime(2022, 09, 5);
            bus1.Balance = 100;

            booth.Payment(bus1);


            Management management = new Management(booth);

            string passVehicleList = management.GetPassVehicles();

            decimal totalVallet = management.GetTotalVallet();

            string dailyTotalVallet = management.GetDailyTotalVallet();

            Console.WriteLine("Gişeden Geçen Araç HSG Nolar: {0}", passVehicleList);
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Gişenin toplam kazancı: {0}", totalVallet);
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Gişenin gün bazlı toplam kazancı:\n{0}", dailyTotalVallet);
            Console.ReadLine();
        }
    }
}

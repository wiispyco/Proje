using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGS.Models
{
    public class Booth
    {
        public decimal Vallet { get; set; }

        public List<long> PassVehicles { get; set; }

        public List<DailyVallet> DailyVallets { get; set; }

        public Booth()
        {
            PassVehicles = new List<long>();

            DailyVallets = new List<DailyVallet>();
        }

        public void Payment(Vehicle vehicle)
        {
           
            if (vehicle.ClassOfVehicle == ClassOfVehicle.class1)
            {
                vehicle.Balance -= 50;
                Vallet += 50;

                DailyVallets.Add(new DailyVallet()
                {
                    Time = vehicle.Time,
                    Vallet = 50,
                });
            }
            else if (vehicle.ClassOfVehicle == ClassOfVehicle.class2)
            {
                vehicle.Balance -= 70;
                Vallet += 70;

                DailyVallets.Add(new DailyVallet()
                {
                    Time = vehicle.Time,
                    Vallet = 70,
                });
            }
            else
            {
                vehicle.Balance -= 100;
                Vallet += 100;

                DailyVallets.Add(new DailyVallet()
                {
                    Time = vehicle.Time,
                    Vallet = 100,
                });
            }

            PassVehicles.Add(vehicle.HGSno);
        }
    }
}

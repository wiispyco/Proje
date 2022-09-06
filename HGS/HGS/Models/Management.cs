using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGS.Models
{
    public class Management
    {
        private Booth booth;

        public Management(Booth _booth)
        {
            booth = _booth;
        }

        public string GetPassVehicles()
        {
            string passVehicles = string.Join(",", booth.PassVehicles);

            return passVehicles;
        }

        public decimal GetTotalVallet()
        {
            return booth.Vallet;
        }

        public string GetDailyTotalVallet()
        {
            var result = booth.DailyVallets.GroupBy(x => x.Time).Select(x => x.Key.ToString("dd.MM.yyyy") + " tarihinde " + x.Sum(y => y.Vallet) + " kazanılmıştır.");

            return string.Join("\n", result);
        }
    }
}

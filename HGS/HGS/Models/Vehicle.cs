using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGS.Models
{
    public  class Vehicle
    {
        [Key]
        public int Id { get; set; }
        public long HGSno { get; set; }
        public string FullName { get; set; }
        public string ClassOfVehicle { get; set; }
        public DateTime Time { get; set; }
        public decimal Balance { get; set; }
    }
}

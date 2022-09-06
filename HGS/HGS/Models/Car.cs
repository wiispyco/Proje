using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGS.Models
{
    public class Car : Vehicle
    {
        public Car()
        {
            ClassOfVehicle = "1. Class";
        }
    }
}

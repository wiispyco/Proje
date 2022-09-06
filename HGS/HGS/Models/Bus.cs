using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGS.Models
{
    public class Bus : Vehicle
    {
        public Bus()
        {
            ClassOfVehicle = "3. Class";
        }
    }
}

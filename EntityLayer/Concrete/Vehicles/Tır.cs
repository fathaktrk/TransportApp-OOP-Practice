using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Vehicles
{
    public class Tır : IVehicle
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}

using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Vehicles
{
    public class Vehicle : IVehicle
    {
        public int ID { get; set; }
        public string Name { get; set; }


        public enum Types
        {
            TIR=1, Truck=3, Tanker=2, Train=4
        }
    }
}

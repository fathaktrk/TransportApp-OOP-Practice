using DataLayer;
using EntityLayer.Concrete.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Abstract
{
    public class Operation
    {
        public IVehicle Vhc { get; set; }

        public IOrder Order { get; set; }

        public ICargo Cargo { get; set; }

        public IPerson Person { get; set; } 

        public void LoadOnWay(Vehicle.Types type, int StartingPoint, int EndingPoint)
        {
            var value = DistanceCities.KmList[(StartingPoint, EndingPoint)]; 

            Console.WriteLine("Yük Yola Çıktı. \nAraç Markası: " + Vhc.Name + "\nAraç Tipi: " + type + "\nKM başına yakıt: " + (int)type + "\nYol Ücreti: " + value + "\nTotal Masraf: " + (int)type * value +  "\nÖdemesi Yapıldı mı?: " + 
                Order.IsPayment.ToString() + "\nYükü: " + Cargo.Name + "\nŞoför adı: " + Person.Name + " \nMaaşı: " + Person.Salary.ToString());
        }

        public void LoadIsArrived()
        {
            Console.WriteLine("Yük yerine ulaştı.");
        }

    }
}

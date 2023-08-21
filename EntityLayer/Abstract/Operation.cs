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

            Console.WriteLine("Yük Yola Çıktı. \n Araç Markası: " + Vhc.Name + "\n Araç Tipi: " + type + "\n KM başına yakıt: " + (int)type + "\n Yol Ücreti: " + value + "\n Total Masraf: " + (int)type * value +  "\n Ödemesi Yapıldı mı?: " + 
                Order.IsPayment.ToString() + "\n Yükü: " + Cargo.Name + "\n Şoför adı: " + Person.Name + " Maaşı: " + Person.Salary.ToString());
        }

        public void LoadIsArrived()
        {
            Console.WriteLine("Yük yerine ulaştı.");

        }

    }
}

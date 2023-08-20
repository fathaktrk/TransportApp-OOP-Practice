using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Abstract
{
    public class Operation
    {
        public IVehicle Vehicle { get; set; }

        public IOrder Order { get; set; }

        public ICargo Cargo { get; set; }

        public IPerson Person { get; set; } 

        public void loadOnWay()
        {
            Console.WriteLine("Yük Yola Çıktı. \n Araç Markası: " + Vehicle.Name + "\n Ödemesi Yapıldı mı?: " + 
                Order.IsPayment.ToString() + "\n Yükü: " + Cargo.Name + "\n Şoför adı: " + Person.Name + " Maaşı: " + Person.Salary.ToString());
        }

        public void loadIsArrived()
        {
            Console.WriteLine("Yük yerine ulaştı.");

        }

    }
}

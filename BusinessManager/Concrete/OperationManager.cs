using BusinessManager.Abstract;
using DataLayer;
using EntityLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Concrete.Cargos;
using EntityLayer.Concrete.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager.Concrete
{
    public class OperationManager : IOperationManager
    {
        IOperation _operation;
        public OperationManager(IOperation operation)
        {
            _operation = operation;
        }


        public void LoadOnWay(Vehicle.Types type, Cargo.Types cargoType, int StartingPoint, int EndingPoint)
        {
            int value = DistanceCities.KmList[(StartingPoint, EndingPoint)];

            Console.WriteLine("Yük Yola Çıktı. \nAraç Markası: " + _operation.Vhc.Name + "\nAraç Tipi: " + type + "\nKM başına yakıt: " + (int)type + "\nYol Ücreti: " + value + "\nTotal Masraf: " + (int)type * value + "\nÖdemesi Yapıldı mı?: " +
                _operation.Order.IsPayment.ToString() + "\nYükü: " + _operation.Cargo.Name + "\nYük Tipi: " + cargoType + "\nŞoför adı: " + _operation.Person.Name + " \nMaaşı: " + _operation.Person.Salary.ToString());
        }

        public void LoadIsArrived()
        {
            Console.WriteLine("Yük yerine ulaştı.");
        }

    }
}

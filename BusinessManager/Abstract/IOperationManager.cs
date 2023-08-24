using DataLayer;
using EntityLayer.Concrete.Cargos;
using EntityLayer.Concrete.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager.Abstract
{
    public interface IOperationManager
    {
        public void LoadOnWay(Vehicle.Types type, Cargo.Types cargoType, int StartingPoint, int EndingPoint);
        public void LoadIsArrived();
    }
}

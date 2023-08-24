using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Abstract
{
    public interface IOperation
    {
        public IVehicle Vhc { get; set; }

        public IOrder Order { get; set; }

        public ICargo Cargo { get; set; }

        public IPerson Person { get; set; }
    }
}

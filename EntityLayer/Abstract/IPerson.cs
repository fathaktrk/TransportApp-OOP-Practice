using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Abstract
{
    public interface IPerson
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }
}

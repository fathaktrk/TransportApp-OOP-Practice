using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Persons
{
    public class Driver : IPerson
    {
        public Driver()
        {
            Salary = 250 * 30; //günlük yevmiye 250
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

    }
}

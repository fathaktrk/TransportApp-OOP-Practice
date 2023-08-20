using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Persons
{
    public class Manager : IPerson
    {
        public Manager()
        {
            Salary = 400 * 30; //günlük yevmiye 400 
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

    }
}

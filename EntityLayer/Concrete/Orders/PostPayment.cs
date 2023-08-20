using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Orders
{
    public class PostPayment : IOrder
    {
        public bool IsPayment { get; set; }

        public void applyPayment()
        {
            IsPayment = true;
            Console.WriteLine("Ödeme Tamamlandı.");
        }
    }
}

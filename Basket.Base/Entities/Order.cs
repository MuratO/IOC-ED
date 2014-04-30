using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketBase
{
    public class Order
    {
        public int orderId { get; set; }
        public List<Product> product { get; set; }
    }
}

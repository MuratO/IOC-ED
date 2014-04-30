using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasketBase.Events
{ 
    public class OrderSubmitEvent
    {
        public readonly int orderId;
        public OrderSubmitEvent(int OrderId)
        {
            this.orderId = OrderId;
        }
    } 
}

using BasketBase.Events;
using BasketBase.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketBase.Consumers
{
    public class SendCargoInformation : IConsumer<OrderSubmitEvent>
    {
        public void Handle(OrderSubmitEvent eventMessage)
        {
            Core.Logger.Info("---------------");
            Core.Logger.Info("Send cargo info");
            Core.Logger.Info(String.Format("Order Id : {0} ", eventMessage.orderId.ToString()));
            Core.Logger.Info("---------------");
        }
    }
}

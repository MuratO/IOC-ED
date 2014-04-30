using BasketBase.Consumers;
using BasketBase.Events;
using BasketBase.Interfaces;
using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketBase.Managers
{
    public class EventSubscriptions : ISubscriptionService
    {
       public static void Register()
        {
           Container.RegisterFacility(new ArrayFacility());
           Container.RegisterFromAssembly(typeof(IConsumer<OrderSubmitEvent>), typeof(IConsumerArray<OrderSubmitEvent>));
        }

        public IEnumerable<IConsumer<T>> GetSubscriptions<T>()
        {
            var consumers = Container.Resolve<IConsumerArray<T>>();
            return consumers.Consumers;
        }
    }
}

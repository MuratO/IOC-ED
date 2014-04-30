using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasketBase.Interfaces
{
    public interface IConsumer<T>
    {
        void Handle(T eventMessage);
    }
    public class IConsumerArray<T>
    {
        public IConsumer<T>[] Consumers { get; private set; }

        public IConsumerArray(IConsumer<T>[] consumers)
        {
            this.Consumers = consumers;
        }
    }

}

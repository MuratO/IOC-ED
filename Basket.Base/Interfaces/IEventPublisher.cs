using BasketBase.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BasketBase.Interfaces;
using BasketBase.Events;

namespace BasketBase.Interfaces
{
    public interface IEventPublisher
    {
        void Publish<T>(T eventMessage);
    }
}

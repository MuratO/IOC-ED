using BasketBase.Events;
using BasketBase.Interfaces;
using BasketBase.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketBase
{
    public class Basket
    {
        private readonly IRepository<Order> _orderRepository;
        private readonly IEventPublisher _eventPublisher;

        public Basket(IRepository<Order> orderRepository, IEventPublisher eventPublisher)
        {
            this._orderRepository = orderRepository;
            this._eventPublisher = eventPublisher;            
        }

        public void Submit(List<Product> products){

            Order order = new Order();
            order.product = new List<Product>();
            foreach (Product product in products){
                order.product.Add(product);
            }
             
            _orderRepository.Save(order);

            _eventPublisher.Publish(new OrderSubmitEvent(order.orderId));

        }
    }
}

using BasketBase;
using BasketBase.Managers;
using BasketBase.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BasketApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Core.StartApplication();

            OrderRepository repo = new OrderRepository();

            EventSubscriptions subscribeService = new EventSubscriptions();
            EventPublisher events = new EventPublisher(subscribeService);

            Basket basket = new Basket(repo, events);

            List<Product> products = new List<Product>();
            products.Add(new Product() { price = 2, prodId = 1, quantity = 3 });
            products.Add(new Product() { price = 23, prodId = 2, quantity = 1 });
            products.Add(new Product() { price = 4, prodId = 4, quantity = 4 });
            
            basket.Submit(products);

            basket.Submit(products);

            Console.ReadLine();
        }
        
    }
}

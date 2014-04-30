using BasketBase.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketBase.Repositories
{
    public class OrderRepository : IRepository<Order>
    {

        public IQueryable<Order> FindAll()
        {
            return null;
        }

        public IQueryable<Order> FindByText(string q)
        {
            return null;
        }

        public Order Get(int id)
        {
            return null;
        }

        public void Add(Order entity)
        { 
        }

        public void Delete(Order entity)
        { 
        }

        public void Update(Order entity)
        { 
        }

        public void Save(Order entity)
        {
            entity.orderId = new Random().Next(100);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketBase.InterFaces
{
    public interface IRepository<T>
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByText(string q);
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        void Save(T entity);
    }
}

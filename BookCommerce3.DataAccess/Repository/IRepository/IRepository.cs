using BookCommerce3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookCommerce3.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        //thirrja e listes
        IEnumerable<T> GetAll();
        T FirstOrDefault(Expression<Func<T,bool>> filteri);
        void Add(T entiteti);
        void Remove(T entiteti);
        void RemoveRange(IEnumerable<T> entitetet);
    }
}

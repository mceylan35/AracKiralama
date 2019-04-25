using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.Interfaces
{
    public interface IGenericService<T>:IDisposable
    {
        T Add(T entity);
        T Update(T entity);
        T Get(int id);
     
        List<T> GetAll();
        bool Delete(int id);
        bool Delete(T entity);
    }
}

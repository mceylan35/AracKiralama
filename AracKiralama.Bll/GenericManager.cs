using AracKiralama.Dal.Abstract;
using AracKiralama.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.Bll
{
    public abstract class GenericManager<T> : IGenericService<T> where T:class
    {
        private readonly IGenericRepository<T> genericRepository;

        protected GenericManager(IGenericRepository<T> _genericRepository)
        {
            genericRepository = _genericRepository;
        }
        public T Add(T entity)
        {
            return genericRepository.Add(entity);
        }

        public bool Delete(int id)
        {
            return genericRepository.Delete(id);
        }

        public bool Delete(T entity)
        {
            return genericRepository.Delete(entity);
        }


        public void Dispose()
        {
           Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                genericRepository.Dispose();
            }

        }

        public T Get(int id)
        {
            return genericRepository.Get(id);
        }

      

        public List<T> GetAll()
        {
            return genericRepository.GetAll();
        }

        public T Update(T entity)
        {
            return genericRepository.Update(entity);
        }
    }
}

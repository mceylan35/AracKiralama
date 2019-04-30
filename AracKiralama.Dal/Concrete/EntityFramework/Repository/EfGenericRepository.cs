using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AracKiralama.Dal.Abstract;
using AracKiralama.Dal.Concrete.EntityFramework.Context;

namespace AracKiralama.Dal.Concrete.EntityFramework.Repository
{
    public abstract class EfGenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected AracKiralamaContext context;

        public T Add(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges(); 
            return entity;
        }

        public bool Delete(int id)
        {
            return Delete(Get(id));

        }

        public bool Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            return context.SaveChanges()>0;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool dispose)
        {
            if (dispose)
            {
                context.Dispose();
            }
        }

        public T Get(int id)
        {
            var entity = context.Set<T>().Find(id);
           
            context.Entry(entity).State = EntityState.Deleted;

            context.Entry(entity).State = EntityState.Modified;
            return entity;
        }

     

        public List<T> GetAll()
        {
            // return context.Set<T>().AsNoTracking().ToList();
            return context.Set<T>().ToList();
        }

        public T Update(T entity)
        {
            context.Set<T>().AddOrUpdate(entity);//varsa güncelle yoksa ekle
            context.SaveChanges();
            return entity;
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }

        //IQueryable<T> IGenericRepository<T>.GetAll(Expression<Func<T, bool>> predicate)
        //{
        //    throw new NotImplementedException();
        //}
    }


}

using _45_Repository_Desing.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _45_Repository_Desing.DataAccess.Concrete
{
    public class GenericRepository<T, TContext> : IRepository<T> where T : class where TContext : DbContext, new()
    {
        public void Create(T entity)
        {
            using (var context = new TContext())
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();

            }
        }

        public virtual void Delete(T entity)
        {
            using (var context = new TContext())
            {
                context.Set<T>().Remove(entity);
                context.SaveChanges();
                
            }
        }

        public virtual List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using (var context = new TContext())
            {//Select * from Product 
              //Select * from Product where ProductName='Çay'
                return filter==null? context.Set<T>().ToList(): context.Set<T>().ToList();
            }
        }

        public T GetById(int id)
        {
            using (var context = new TContext())
            {
                return context.Set<T>().Find(id);
            }
        }

        public T GetOne(Expression<Func<T, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return context.Set<T>().Where(filter).FirstOrDefault();
            }
        }


        public virtual void Update(T entity)
        {
            using (var context = new TContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}

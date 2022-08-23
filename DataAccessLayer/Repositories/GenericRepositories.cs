using DataAccessLayer.Concerete;
using EntityLayerr.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepositories<T> : IRepository<T> where T : class
    {
        Context c = new Context();
        DbSet<T> _object;

        public GenericRepositories()
        {
            _object = c.Set<T>();
        }
        public void Delete(T entity)
        {
            var delete = c.Entry(entity);
            delete.State=EntityState.Deleted;
            c.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
           return _object.SingleOrDefault(filter);
        }

        public void Insert(T entity)
        {
          var insert = c.Entry(entity);
            insert.State = EntityState.Added;
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T entity)
        {
            var update = c.Entry(entity);
            update.State = EntityState.Modified;
            c.SaveChanges();
        }
    }
}

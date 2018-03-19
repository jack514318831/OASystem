using OA.IDAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.EFDAL
{
    public class BaseDAL<T> : IBaseDAL<T> where T : class, new()
    {
        DbContext dbContext = DBContextFactory.GetDbContext();
        public T Add(T item)
        {
            dbContext.Set<T>().Add(item);
            return item;
        }

        public bool Delete(T item)
        {
            dbContext.Entry(item).State = EntityState.Deleted;
            return true;
        }

        public bool Edit(T item)
        {
            dbContext.Entry(item).State = EntityState.Modified;
            return true;
        }

        public IEnumerable<T> Requery(Expression<Func<T, bool>> where)
        {
            return dbContext.Set<T>().Where(where);
        }

    }
}

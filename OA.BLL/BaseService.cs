using OA.DALFactory;
using OA.IBLL;
using OA.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.BLL
{
    public abstract class BaseService<T> where T: class, new()
    {
        public ISession dbsession = new DBSession();
        public IBaseDAL<T> DAL { get; set; }
        public BaseService()
        {
            SetDAL();
        }

        public abstract void SetDAL();

        public T Add(T item)
        {
            DAL.Add(item);
            dbsession.SaveChanges();
            return (item);
        }

        public bool Delete(T item)
        {
            DAL.Delete(item);
            dbsession.SaveChanges();
            return true;
        }

        public bool Edit(T item)
        {
            DAL.Edit(item);
            dbsession.SaveChanges();
            return true;
        }

        public IEnumerable<T> ShowAll()
        {
            return DAL.Requery(u => true);
        }
    }
}

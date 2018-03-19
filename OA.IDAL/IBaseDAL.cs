using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OA.IDAL
{
    public interface IBaseDAL<T>
    {
        T Add(T item);
        bool Delete(T item);
        bool Edit(T item);
        IEnumerable<T> Requery(Expression<Func<T, bool>> where);
    }
}

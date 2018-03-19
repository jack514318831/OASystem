using OA.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OA.EFDAL
{
    public static class DBContextFactory
    {
        private static DbContext _current;
        public static DbContext GetDbContext()
        {
            _current = CallContext.GetData("currentDB") as DbContext;
            if (_current == null)
            {
                _current = new OASystemEntities();
                CallContext.SetData("currentDB",_current);
            }
            return _current;
        }

    }
}

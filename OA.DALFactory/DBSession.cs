using OA.EFDAL;
using OA.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.DALFactory
{
    public class DBSession : ISession
    {
        public IUserInfoDAL userinfoDal
        {
            get
            {
                return DALFactory.GetUserInfoDAL();
            }
        }
        public IOrderInfoDAL orderinfoDal
        {
            get
            {
                return DALFactory.GetOrderInfoDAL();
            }
        }

        public void SaveChanges()
        {
            DBContextFactory.GetDbContext().SaveChanges();
        }
    }
}

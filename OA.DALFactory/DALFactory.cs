using OA.EFDAL;
using OA.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.DALFactory
{
    public class DALFactory
    {
        public static IUserInfoDAL GetUserInfoDAL()
        {
            return new UserInfoDAL();
        }

        public static IOrderInfoDAL GetOrderInfoDAL()
        {
            return new OrderInfoDAL();
        }

    }
}

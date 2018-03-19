using OA.IBLL;
using OA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.BLL
{
    public class OrderInfoService : BaseService<OrderInfo>, IOrderInfoService
    {
        public OrderInfo GetItemById(int id)
        {
            return DAL.Requery(u => u.OrderId == id).First();
        }

        public override void SetDAL()
        {
            this.DAL = dbsession.orderinfoDal;
        }
    }
}

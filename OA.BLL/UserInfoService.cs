using OA.IBLL;
using OA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.BLL
{
    public class UserInfoService : BaseService<UserInfo>, IUserInfoService
    {
        public UserInfo GetItemById(int id)
        {
            return DAL.Requery(u => u.UserId == id).First();
        }

        public override void SetDAL()
        {
            this.DAL = dbsession.userinfoDal;
        }
    }
}

using OA.BLL;
using OA.IBLL;
using OA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OA.UI.Portal.Controllers
{
    public class UserInfoController : Controller
    {
        // GET: UserInfo
        public IUserInfoService service = new UserInfoService();
        public ActionResult Index()
        {
            ViewData.Model = service.ShowAll();
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(UserInfo user)
        {
            service.Add(user);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            ViewData.Model = service.GetItemById(id);
            return View();
        }

        [HttpPost]
        public ActionResult Delete(UserInfo user)
        {
            UserInfo userInfo = new UserInfo() { UserId = user.UserId };
            service.Delete(userInfo);
            return RedirectToAction("Index");
        }

    }
}
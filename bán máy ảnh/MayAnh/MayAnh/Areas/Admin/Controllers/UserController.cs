using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;
using Model.EF;
using Model;

namespace MayAnh.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        // GET: Admin/User
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(user user)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                long id = dao.Insert(user);
                var db = new Model1();
                if (db.user.Any(x => x.UserName == user.UserName))
                {
                    ModelState.AddModelError("", "Tài Khoản này đã tồn tại");
                }
                
                    if (id >0)
                {
                    return RedirectToAction("listuser","List");
                }
                else
                {
                    ModelState.AddModelError("","Thêm User Không Thành Công");
                }
                
            }
            return RedirectToAction("Listuser");
        }
    }
}
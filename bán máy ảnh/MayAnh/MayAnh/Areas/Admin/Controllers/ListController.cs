using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;
namespace MayAnh.Areas.Admin.Controllers
{
    public class ListController : Controller
    {
        
        // GET: Admin/List
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Listuser(int page=1,int pagesize=10)
        {
            var dao = new UserDao();
            var model = dao.Listuser(page, pagesize);
            return View(model);
        }
        public ActionResult Delete(int id)
        {
            var xoa = new UserDao().Deleted(id);
            return RedirectToAction("Listuser");
        }
    }
}
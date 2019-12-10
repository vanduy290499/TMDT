using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;
using MayAnh.Areas.Admin.Models;
using System.Web.Security;
using MayAnh.Common;

namespace MayAnh.Areas.Admin.Controllers
{

    public class LoginController : Controller
    {


        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        public  ActionResult Home()
        {
            return View();
        }
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var res = dao.Login(model.UserName, model.PassWord);
                if (res==1)
                {
                    var user = dao.GetByid(model.UserName);
                    var userSession = new UserLogin();
                    userSession.UserName = user.UserName;
                    userSession.UserID = user.id;
                    Session.Add(CommonConstants.USER_SESSION, userSession);
                    return RedirectToAction("index");
                }
                else if(res == 0)
                {

                    ModelState.AddModelError("", "Tài khoản không tồn tại.");
                    //var user = dao.GetByid(model.UserName);
                    //var userSession = new UserLogin();
                    //userSession.UserName = user.UserName;
                    //userSession.UserID = user.id;
                    //userSession.UserIDQ = user.idquyen;
                    //Session.Add(CommonConstants.USER_SESSION, userSession);
                    //return RedirectToAction("View");

                }
                else if (res == 2)
                {
                    ModelState.AddModelError("", "Mật khẩu hoặc Tên đăng nhập không đúng.");
                }
                else
                {
                    ModelState.AddModelError("", "Đăng nhập không đúng.");
                }
            }
            return View("");

        }
        public ActionResult Loguot()
        {
            Session[CommonConstants.USER_SESSION] = null;
            return RedirectToAction("index");
        }
        //public ActionResult LoginAM(LoginAM model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            var dao = new UserDao();
        //            var res = dao.LoginAM(model.username, model.password);
        //            if (res)
        //            {
        //                var user = dao.Getbyid(model.username);
        //                var userSession = new UserAM();
        //                userSession.Username = user.username;
        //                userSession.userID = user.id;

        //                Session.Add(CommonConstants.USER_SESSION, userSession);
        //                return RedirectToAction("Index", "Home");
        //            }
        //            else { ModelState.AddModelError("", "Đăng nhập không đúng."); }

        //        }

        //    }
        //    return View("Index");
        //}

    }
}
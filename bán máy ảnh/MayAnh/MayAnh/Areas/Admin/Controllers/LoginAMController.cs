//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using Model.Dao;
//using PagedList.Mvc;
//using PagedList;
//using MayAnh.Areas.Admin.Models;
//using MayAnh.Common;

//namespace MayAnh.Areas.Admin.Controllers
//{
//    public class LoginAMController : Controller
//    {
//        // GET: Admin/LoginAM
//        public ActionResult Index()
//        {
//            return View();
//        }
//        public ActionResult LoginAM(LoginAM model)
//        {
//            if (ModelState.IsValid)
//            {
//                if (ModelState.IsValid)
//                {
//                    var dao = new UserDao();
//                    var res = dao.LoginAM(model.username, model.password);
//                    if (res)
//                    {
//                        var user = dao.Getbyid(model.username);
//                        var userSession = new UserAM();
//                        userSession.Username = user.username;
//                        userSession.userID = user.id;

//                        Session.Add(CommonConstants.USER_SESSION, userSession);
//                        return RedirectToAction("Index", "Home");
//                    }
//                    else { ModelState.AddModelError("", "Đăng nhập không đúng."); }

//                }
                
//            }
//            return View("");
//        }

//    }
//    [Authorize(Roles ="Admin")]
//    public class ManageUserController : Controller
//    {
        
//    }

//}
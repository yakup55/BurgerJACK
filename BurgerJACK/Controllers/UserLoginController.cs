using BusinessLayer.Concerete;
using DataAccessLayer.EnitityFramework;
using EntityLayerr.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BurgerJACK.Controllers
{
    public class UserLoginController : Controller
    {
        // GET: UserLogin
        UserManager um = new UserManager(new IFUserLoginDal());
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Register p)
        {
            var userinfo = um.GetRegister(p.Mail, p.Password);
            if (userinfo != null)
            {
                FormsAuthentication.SetAuthCookie(userinfo.Mail, false);
                Session["Mail"]=userinfo.Mail;
                return RedirectToAction("Burger", "Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }
        [HttpGet]
        public ActionResult UserRegister()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserRegister(Register r)
        {
            um.RegisterAdd(r);
            return RedirectToAction("Index");
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index");
        }
    }
}
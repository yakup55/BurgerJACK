using BusinessLayer.Concerete;
using DataAccessLayer.EnitityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BurgerJACK.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        AboutManager am = new AboutManager(new IFAboutDal());
        public ActionResult Index()
        {
            var about = am.GetList();
            return View(about);
        }
    }
}
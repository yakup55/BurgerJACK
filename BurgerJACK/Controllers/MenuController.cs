using BusinessLayer.Concerete;
using DataAccessLayer.EnitityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BurgerJACK.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        BurgerManager bm = new BurgerManager(new IFBurgerDal());
        public ActionResult Index()
        {
            var menu = bm.GetList();
            return View(menu);
        }
    }
}
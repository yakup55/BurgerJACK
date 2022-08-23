using BusinessLayer.Concerete;
using DataAccessLayer.EnitityFramework;
using EntityLayerr.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BurgerJACK.Controllers
{
    public class ChefsController : Controller
    {
        // GET: Chefs
        ChefsManager cm = new ChefsManager(new IFChefsDal());
        MediaManager mm = new MediaManager(new IFMediaDal());
        public ActionResult Index()
        {
            var media = mm.GetList();
            return View(media);
        }
        [HttpGet]
        public ActionResult ChefsAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ChefsAdd(OurChefs chefs)
        {
            cm.ChefsAdd(chefs);
            return View("Index");
        }
    }
}
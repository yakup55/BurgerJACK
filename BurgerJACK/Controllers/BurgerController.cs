using BusinessLayer.Concerete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EnitityFramework;
using EntityLayerr.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BurgerJACK.Controllers
{
    public class BurgerController : Controller
    {
        // GET: Burger
        BurgerManager bm = new BurgerManager(new IFBurgerDal());
        CommentManager cm = new CommentManager(new IFCommnetDal());
        Comments  cms=new Comments();
        public ActionResult Index()
        {
            var burger = bm.GetList();
            return View(burger);
        }
        [HttpGet]
        public ActionResult BurgerAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BurgerAdd(Burger burger)
        {
            BurgerValidatior bv = new BurgerValidatior();
            FluentValidation.Results.ValidationResult result = bv.Validate(burger);
            if (result.IsValid)
            {
                bm.BurgerAdd(burger);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var x in result.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                }
            }
            return View();
        }
        public ActionResult Burgerİnformation(int id)
        {
            cms.Deger2 = bm.GetList().Where(x => x.BurgerİD == id).ToList();
            cms.Deger1 = cm.GetList().Where(x => x.Burgerid == id).ToList();
            return View(cms);
        }
        [HttpGet]
        public PartialViewResult BurgerComment(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult BurgerComment(Comment comment)
        {
            CommentValidatior cv = new CommentValidatior();
            FluentValidation.Results.ValidationResult results = cv.Validate(comment);
            if (results.IsValid)
            {
                cm.CommentAdd(comment);
                return PartialView();
            }
            else
            {
                foreach (var x in results.Errors)
                {
                    ModelState.AddModelError(x.ErrorMessage, x.PropertyName);
                }
            }
            return PartialView();

        }
    }
}
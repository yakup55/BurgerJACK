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
    public class AdminCategoryController : Controller
    {
        // GET: AdminCategory
        CategoryManager cm = new CategoryManager(new IFCategoryDal());
        CategoryValidatior cv = new CategoryValidatior();
        public ActionResult Index()
        {
            var category = cm.GetList();
            return View(category);
        }
        [HttpGet]
        public ActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CategoryAdd(Category p)
        {
            FluentValidation.Results.ValidationResult result = cv.Validate(p);
            if (result.IsValid)
            {
                cm.CategoryAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var x in result.Errors)
                {
                    ModelState.AddModelError(x.ErrorMessage, x.PropertyName);
                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult CategoryUpdate(int id)
        {
            var update=cm.GetById(id);
            return View(update);
        }
        [HttpPost]
        public ActionResult CategoryUpdate(Category p)
        {
            cm.CategoryUpdate(p);
            return RedirectToAction("Index");
        }

    }
}
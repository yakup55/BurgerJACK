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
    public class ContactController : Controller
    {
        // GET: Contact
        ContactManager cm = new ContactManager(new IFContactDal());
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult ContactAdd()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult ContactAdd(Contact c)
        {
            ContactValidatior cv = new ContactValidatior();
            FluentValidation.Results.ValidationResult result = cv.Validate(c);
            if (result.IsValid)
            {
                cm.ContactAdd(c);
               return PartialView("Index");
            }
            else
            {
                foreach (var x in result.Errors)
                {
                    ModelState.AddModelError(x.ErrorCode, x.PropertyName);
                }
            }
            return PartialView();
        }
    }
}
using LearnAutofac.Data;
using LearnAutofac.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearnAutofac.Web.Controllers
{
    public class PropertyInjectionController : Controller
    {
        public ActionResult Index()
        {
            var person = DependencyResolver.Current.GetService<IPersonRepository>().GetPerson();
            var model = new PersonViewModel(person);
            return View(model);
        }
    }
}
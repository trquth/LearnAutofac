using LearnAutofac.Data;
using LearnAutofac.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearnAutofac.Web.Controllers
{
    public class DemoNoAutofacController : Controller
    {      
        public ActionResult Index()
        {
            var data = new PersonRepository();
            var person = data.GetPerson();
            var personModel = new PersonViewModel(person);
            return View(personModel);
        }
    }
}
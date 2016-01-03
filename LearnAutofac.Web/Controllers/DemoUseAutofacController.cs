using LearnAutofac.Data;
using LearnAutofac.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearnAutofac.Web.Controllers
{
    public class DemoUseAutofacController : Controller
    {
        private readonly IPersonRepository personRepository;
        public DemoUseAutofacController(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }
        public ActionResult Index()
        {
            var person = personRepository.GetPerson();
            var personModel = new PersonViewModel(person);
            return View(personModel);
        }
    }
}
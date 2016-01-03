using LearnAutofac.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearnAutofac.Web.Models
{
    public class PersonViewModel :Person
    {
        public PersonViewModel(Person person)
        {
            Name = person.Name;
            Age = person.Age;
            SocialSecurityNumber = person.SocialSecurityNumber;
        }
    }
}
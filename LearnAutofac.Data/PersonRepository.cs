using LearnAutofac.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAutofac.Data
{
    public class PersonRepository:IPersonRepository
    {
        public Person GetPerson()
        {
            var person = new Person { Name = "Tran Quan Thien", Age = 23, SocialSecurityNumber = "123456789" };
            return person;
        }
    }
}

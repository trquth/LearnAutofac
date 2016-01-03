using LearnAutofac.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAutofac.Data
{
    public interface IPersonRepository
    {
        Person GetPerson();
    }
}

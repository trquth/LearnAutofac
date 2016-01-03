using Autofac;
using Autofac.Core;
using Autofac.Integration.Mvc;
using LearnAutofac.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace LearnAutofac.Web.App_Start
{
    public class Bootstrapper
    {
        public static void Run()
        {
            SetAutofacContainer();
        }
        public static void SetAutofacContainer()
        {
            //Create the builder
            var builder = new ContainerBuilder();
            //Register controllers so dependencies are contructor injected
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            //Register dependencies
            //builder.RegisterType(typeof(PersonRepository)).As(typeof(IPersonRepository)).InstancePerDependency();
            builder.RegisterAssemblyTypes(typeof(PersonRepository).Assembly).Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerDependency();
            //Build container 
            IContainer container = builder.Build();
            //Replace the MVC dependcy resolver with Autofac
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
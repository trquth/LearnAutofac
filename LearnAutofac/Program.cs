using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAutofac
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee
            {
                Id = 1,
                FirstName = "Thien",
                LastName = "Tran",
                Job = "DEV"
            };
            //registering interface with class that implemented
            //var builder = new ContainerBuilder();
            //builder.RegisterType<AutoFacBasic>().As<IAutoFacBasic>();
            //resolving interface with autofac
            //var container = builder.Build();
            //var printService = container.Resolve<IAutoFacBasic>();
            //printService.PrintSomething("IoC Autofac framework");    
     

            //CONTRUCTOR INJECTION
            var container = BuildContainer();
            var employeeService = container.Resolve<EmployeeService>();
            employeeService.Print(employee);
        }
        static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<EmployeeRepository>().As<IEmployeeRepository>();
            builder.RegisterType<EmployeeService>();
            return builder.Build();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAutofac
{
    class EmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository _employeeRepository)
        {
            this._employeeRepository = _employeeRepository;
        }
        public void Print(Employee employee)
        {
            _employeeRepository.Print(employee);
        }
    }
}

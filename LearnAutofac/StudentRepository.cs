using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAutofac
{
    class StudentRepository: IStudentRepository
    {
        public void PrintStudent(Student student)
        {
            Console.WriteLine("Printing Student");
            Console.WriteLine(string.Format("Student Id : {0}", student.Id));
            Console.WriteLine(string.Format("First name: {0} ", student.FirstName));
            Console.WriteLine(string.Format("Last Name : {0} ", student.LastName));
            Console.WriteLine(string.Format("Department : {0} ", student.Department));
        }
    }
}

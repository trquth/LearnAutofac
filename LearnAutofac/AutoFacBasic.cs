using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAutofac
{
    interface IAutoFacBasic
    {
        void PrintSomething(string text);
    }
    class AutoFacBasic:IAutoFacBasic
    {
        public void PrintSomething(string text)
        {
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}

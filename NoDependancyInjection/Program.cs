using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examples.NoDependancyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            FormHandler formHandler = new FormHandler();
            formHandler.Handle("test@test.com");

            Console.ReadLine();
        }
    }
}

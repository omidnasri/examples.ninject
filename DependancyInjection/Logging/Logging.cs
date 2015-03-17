using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examples.DependancyInjection
{
    public class Logging : ILogging 
    {
        public void Debug(string message)
        {
            Console.WriteLine("Debug: [{0}]", message);
        }
    }
}

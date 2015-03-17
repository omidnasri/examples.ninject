using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examples.DependancyInjection
{
    public class MockLogging : ILogging
    {
        public void Debug(string message)
        {
            Console.WriteLine("Mock Debug: [{0}]", message);
        }
    }
}

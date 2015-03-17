using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using System.Reflection;

namespace Examples.DependancyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a Ninject kernel to resolve dependancies in our code automatically
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            var mailSender = kernel.Get<IMailSender>();

            // the formhandler requires an implementation of IMailSender, so we'll pass this in manually
            var formHandler = new FormHandler(mailSender);
            formHandler.Handle("test@test.com");

            // for the sake of the example, we're still new-ing FormHandler here manually.
            // The true power of Ninject becomes apparent when you also instantiate IFormHandler through Ninject
            // just comment out the code below to see that Ninject constructs a FormHandler, and automatically *also*
            // creates the correct instance of IMailSender
            //
            // var secondFormHandler = kernel.Get<IFormHandler>();
            // secondFormHandler.Handle("test@test.com");

            Console.ReadLine();
        }
    }
}

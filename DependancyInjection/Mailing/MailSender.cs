using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examples.DependancyInjection
{
    public class MailSender : IMailSender
    {
        private readonly ILogging logging;
        
        public MailSender(ILogging logging)
        {
            // when instantiating this class, Ninject will automatically resolve which implementation of ILogging to use and pass it in
            this.logging = logging;
        }

        public void Send(string toAddress, string subject)
        {
            logging.Debug("Sending mail");
            Console.WriteLine("Sending mail to [{0}] with subject [{1}]", toAddress, subject);
        }
    }
}

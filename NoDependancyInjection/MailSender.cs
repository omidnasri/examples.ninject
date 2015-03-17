using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examples.NoDependancyInjection
{
    public class MailSender
    {
        public void Send(string toAddress, string subject)
        {
            Console.WriteLine("Sending mail to [{0}] with subject [{1}]", toAddress, subject);
        }
    }
}

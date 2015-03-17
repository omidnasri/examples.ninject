using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examples.NoDependancyInjection
{
    public class FormHandler
    {
        public void Handle(string toAddress)
        {
            // we create an instance of MailSender here (this is a dependancy on MailSender)
            MailSender mailSender = new MailSender();
            mailSender.Send(toAddress, "Sending an e-mail");
        }
    }
}

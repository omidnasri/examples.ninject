using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examples.DependancyInjection
{
    public class FormHandler : Examples.DependancyInjection.IFormHandler
    {
        private readonly IMailSender mailSender;

        public FormHandler(IMailSender mailSender)
        {
            // this class requires a concrete implementation of IMailSender, so we need to pass it in through the constructor (called Constructor Injection)
            this.mailSender = mailSender;
        }

        public void Handle(string toAddress)
        {
            mailSender.Send(toAddress, "Sending a mail");
        }
    }
}

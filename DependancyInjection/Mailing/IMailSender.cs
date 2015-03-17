using System;

namespace Examples.DependancyInjection
{
    public interface IMailSender
    {
        void Send(string toAddress, string subject);
    }
}

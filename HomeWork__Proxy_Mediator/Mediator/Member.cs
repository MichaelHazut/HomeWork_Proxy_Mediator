using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork__Proxy_Mediator.Mediator
{
    public class Member : IMember
    {
        private readonly IFacebookGroup mediator;
        public string Username { get; set; }
        public Member(IFacebookGroup mediator,string username)
        {
            Username = username;
            this.mediator = mediator;
        }
        public void Receive(string message)
        {
            Console.WriteLine($"{Username} is Receiving: {message} ");
        }

        public void Publish(string message)
        {
            Console.WriteLine($"\n{Username} sending: {message}\n");
            mediator.SendMessage(message, this);
        }
    }
}

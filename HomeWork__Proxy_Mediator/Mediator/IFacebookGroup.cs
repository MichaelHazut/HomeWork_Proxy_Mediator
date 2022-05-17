using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork__Proxy_Mediator.Mediator
{
    public interface IFacebookGroup
    {
        void SendMessage(string message, IMember member);
        void RegisterToGroup(IMember user);
    }
}

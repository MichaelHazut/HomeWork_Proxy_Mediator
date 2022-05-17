using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork__Proxy_Mediator.Mediator
{
    public interface IMember
    {
        void Publish(string message);
        void Receive(string message);
    }
}

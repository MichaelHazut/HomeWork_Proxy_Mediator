using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork__Proxy_Mediator.Mediator
{
    public class FacebookGroup : IFacebookGroup
    {
        private List<IMember> Members { get; set; } = new List<IMember>();

        public void RegisterToGroup(IMember member)
        {
            Members.Add(member);
        }

        public void SendMessage(string message, IMember member)
        {
            foreach(IMember user in Members)
            {
                if(user != member)
                {
                    user.Receive(message);
                }
            }
        }

   
    }
}

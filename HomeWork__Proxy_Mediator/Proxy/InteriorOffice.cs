using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork__Proxy_Mediator.Proxy
{
    public class InteriorOffice : IGoverment
    {
        public IGoverment Person { get; set; }
        public InteriorOffice(IGoverment person)
        {
            this.Person = person;    
        }
        public void CollectTax()
        {
            this.Person.CollectTax();
        }

        public void SendToJail()
        {
            this.Person.SendToJail();
        }
    }
}

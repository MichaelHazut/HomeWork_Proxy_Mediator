using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork__Proxy_Mediator.Proxy
{
    public class ServiceMachine : IPerson
    {
        public IPerson Person { get; set; }
        public ServiceMachine(IPerson person)
        {
            this.Person = person;
        }
        public string ChangeAdress(string adress)
        {
            return this.Person.ChangeAdress(adress);
        }

        public DateTime RenewPassport()
        {
            return this.Person.RenewPassport();
        }

        public void ShowInfo()
        {
            this.Person.ShowInfo();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork__Proxy_Mediator.Proxy
{
    public interface IPerson
    {
        void ShowInfo();
        DateTime RenewPassport();
        string ChangeAdress(string adress);
    }
}

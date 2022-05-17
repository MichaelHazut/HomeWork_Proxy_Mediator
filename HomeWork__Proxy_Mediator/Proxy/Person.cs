using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork__Proxy_Mediator.Proxy
{
    public class Person : IPerson, IGoverment
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime Passport { get; set; } 
        public Person(string adress ,string name)
        {
            Passport = new DateTime(new Random().Next(2022, 2030), 9, 7);
            Address = adress;
            Name = name;
        }
        public string ChangeAdress(string address)
        {
            Console.WriteLine("New Address: " + (Address = address)+"\n");
            return Address;
        }
        public DateTime RenewPassport()
        {
            Console.WriteLine("new Passport date: " + (Passport = DateTime.Now.AddYears(10)).ToString() +"\n");
            return Passport;

        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}\nAddress: {Address}\nPassport Valid till: {Passport}\n");
        }




        public void CollectTax()
        {
            Console.WriteLine("17% Tax Collected successfully\n");
        }


        public void SendToJail()
        {
            int diceRoll = new Random().Next(5, 25);
            Console.WriteLine($"Sent to Jail for {diceRoll} Years\n");
        }

    }
}

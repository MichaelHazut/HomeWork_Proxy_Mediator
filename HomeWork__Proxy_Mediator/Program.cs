using HomeWork__Proxy_Mediator.Proxy;
using HomeWork__Proxy_Mediator.Mediator;


#region Proxy
Person person = new Person("Olive 14/7", "Michael Hazut");

ServiceMachine machine = new ServiceMachine(person);
InteriorOffice goverment = new InteriorOffice(person);

machine.ShowInfo();
machine.ChangeAdress("Peperoni 78");
machine.RenewPassport();
machine.ShowInfo();

goverment.CollectTax();
goverment.SendToJail();
#endregion

#region Mediator
FacebookGroup fbGroup = new FacebookGroup();
var user1 = new Member(fbGroup, "Michael");
var user2 = new Member(fbGroup, "Paul");
var user3 = new Member(fbGroup, "Gidion");

fbGroup.RegisterToGroup(user1);
fbGroup.RegisterToGroup(user2);
fbGroup.RegisterToGroup(user3);

user1.Publish("Hello everyone!");
user3.Publish("Hey how are you doing?");



#endregion



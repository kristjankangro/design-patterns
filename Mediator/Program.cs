using Mediator;
using Mediator.Models;

Console.Title = "Mediator";

TeamChatRoom chat = new();

var lawyer = new Lawyer("Tarmo Pilv");
var lawyer2 = new Lawyer("Heli Pilv");
var am1 = new AccountManager("Teet Aak");
var am2 = new AccountManager("Tarmo Seen");
var am3 = new AccountManager("Villu Tee");

chat.Register(lawyer);
chat.Register(lawyer2);
chat.Register(am1);
chat.Register(am2);
chat.Register(am3);




am1.SendTo<AccountManager>("See videokas oli hea, palun kõigil vaadata accoutmanageridel");


lawyer.Send("Tere hommikust! Tehke palun reliis!");
am2.Send("Reliis tehtud!");
am1.Send("Tarmo Seen", "Saad videosse tulla");
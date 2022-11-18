using Decorator.ConcreteComponents;
using Decorator.ConcreteDecorators;

var cms = new CloudMailService();
cms.SendMail("tere1");

var os = new OnPremiseMailService();
os.SendMail("tere 2");

var sd = new StatsDecorator(cms);
sd.SendMail("tere 3 via stats");

var dd = new MessageDatabaseDecorator(os);
dd.SendMail("tere 4");
dd.SendMail("tere 5");

foreach (var msg in dd.SenMessages)
{
    Console.WriteLine($"sent: {msg}");
}



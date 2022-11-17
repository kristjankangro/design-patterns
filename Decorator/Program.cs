using Decorator;

Console.Title = "Decorator";

var cms = new CloudMailService();
cms.SendMail("testi mess");

var ops = new OnPremiseMailService();
ops.SendMail("testi mess 2");

var sd = new StatsDecorator(cms);
sd.SendMail("message 3");

var dbd = new DataBaseDecorator(ops);
dbd.SendMail("Message 4");


 
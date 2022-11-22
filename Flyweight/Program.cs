using Flyweight;

Console.Title = "Flyweight";

var chars = "abba";

var charFactory = new CharFactory();

var charObj = charFactory.GetChar(chars[0]);
charObj?.Draw("Arial", 12);

charObj = charFactory.GetChar(chars[1]);
charObj?.Draw("Verdana", 13);

charObj = charFactory.GetChar(chars[2]);
charObj?.Draw("SAns", 12);

charObj = charFactory.GetChar(chars[3]);
charObj?.Draw("Impact", 16);

var paragraph = charFactory.CreateParagraph(new List<IChar>{ charObj}, 1);

paragraph.Draw("lucinda", 17);
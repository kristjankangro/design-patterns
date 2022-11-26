using System.ComponentModel.DataAnnotations;
using ChainOfResponsibility.Handlers;
using ChainOfResponsibility.Models;

Console.Title = "Chain of Responsibility";

var validDoc = new Document("How to not java", DateTimeOffset.UtcNow, true, true);
var invalidDoc = new Document("How to not php", DateTimeOffset.UtcNow, false, true);

var handlerChain = new DocumentTitleHandler();
handlerChain.SetSuccessor(new DocumentModifiedHandler())
    .SetSuccessor(new DocumentApprovedByLitigationHandler())
    .SetSuccessor(new DocumentApprovedByManagementHandler());

try
{
    handlerChain.Handle(validDoc);
    Console.WriteLine("Valid doc is valid");
    handlerChain.Handle(invalidDoc);
    Console.WriteLine("invalid doc is valid");
}
catch (ValidationException ex)
{
    Console.WriteLine(ex.Message);
}


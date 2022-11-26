using Mediator.Models;

namespace Mediator;

public interface IChatRoom
{
    void Register(TeamMember member);
    void Send(string from, string message);
    void Send(string from, string to, string message);
    void SendTo<T>(string from, string message) where T : TeamMember;
    
    
}
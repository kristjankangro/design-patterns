﻿namespace Mediator.Models;

public abstract class TeamMember
{
    private IChatRoom? _chatRoom;
    public string Name { get; set; }

    protected TeamMember(string name)
    {
        Name = name;
    }

    internal void SetChatRoom(IChatRoom chatRoom)
    {
        _chatRoom = chatRoom;
    }

    public void Send(string message)
    {
        _chatRoom?.Send(Name, message);
    }

    public void Send(string to, string message)
    {
        _chatRoom?.Send(Name, to, message);
    }
 
    public void SendTo<T>(string message) where T: TeamMember
    {
        _chatRoom?.SendTo<T>(Name, message);
    }

    public virtual void Receive(string from, string message)
    {
        Console.WriteLine($"Message from {from} to {Name}: {message}");
    }
}
﻿using Mediator.Models;

namespace Mediator;

public class TeamChatRoom : IChatRoom
{
    private readonly Dictionary<string, TeamMember> _teamMembers = new();

    public void Register(TeamMember teamMember)
    {
        teamMember.SetChatRoom(this);
        if (_teamMembers.ContainsKey(teamMember.Name)) return;
        _teamMembers.Add(teamMember.Name, teamMember);
    }

    public void Send(string from, string message)
    {
        foreach (var teamMember in _teamMembers.Values.Where(m => m.Name != from))
        {
            teamMember.Receive(from, message);
        }
    }

    public void Send(string from, string to, string message)
    {
        var teamMember = _teamMembers[to];
        teamMember?.Receive(from, message);
    }

    public void SendTo<T>(string from, string message) where T : TeamMember
    {
        foreach (var teamMember in _teamMembers.Values.OfType<T>())
        {
            teamMember.Receive(from, message);
        }
    }
}
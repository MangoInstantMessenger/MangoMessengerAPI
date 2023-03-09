using MangoAPI.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace MangoAPI.Application.Services;

public class AvatarService : IAvatarService
{
    private readonly List<string> avatars = new() { "animetyanpic1.jpg", "animetyanpic2.jpg", "animetyanpic3.jpg", 
        "animetyanpic4.jpg", "animetyanpic5.jpg", "animetyanpic6.jpg", "animetyanpic7.jpg", "animetyanpic8.jpg"}; 
    
    public string GetRandomAvatar()
    {
        var avatarFileName = avatars[new Random().Next(0, avatars.Count - 1)];

        return avatarFileName;
    }
}
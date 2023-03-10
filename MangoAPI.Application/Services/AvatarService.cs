using MangoAPI.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace MangoAPI.Application.Services;

public class AvatarService : IAvatarService
{
    private readonly List<string> avatars = new() { 
        "animetyanpic1.jpg", 
        "animetyanpic2.jpg",
        "animetyanpic3.jpg", 
        "animetyanpic4.jpg",
        "animetyanpic5.jpg", 
        "animetyanpic6.jpg", 
        "animetyanpic7.jpg", 
        "animetyanpic8.jpg",
        "animetyanpic9.jpg", 
        "animetyanpic10.jpg",
        "animetyanpic11.jpg", 
        "animetyanpic12.jpg",
        "animetyanpic13.jpg",
        "animetyanpic14.jpg", 
        "animetyanpic15.jpg",
        "animetyanpic16.jpg", 
        "animetyanpic17.jpg"
    }; 
    
    public string GetRandomAvatar()
    {
        var avatarFileName = avatars[new Random().Next(0, avatars.Count - 1)];

        return avatarFileName;
    }
}
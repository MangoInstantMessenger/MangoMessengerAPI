﻿using System;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Enums;

namespace MangoAPI.BusinessLogic.Responses;

public record TokensResponse : ResponseBase
{
    public Tokens Tokens { get; set; }

    public static TokensResponse FromSuccess(
        string accessToken,
        Guid refreshToken,
        Guid userId,
        long expires,
        string userDisplayName,
        string userProfilePictureUrl,
        DisplayNameColour displayNameColour)
    {
        return new TokensResponse
        {
            Message = ResponseMessageCodes.Success,
            Success = true,
            Tokens = new Tokens
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken,
                Expires = expires,
                UserId = userId,
                UserDisplayName = userDisplayName,
                UserProfilePictureUrl = userProfilePictureUrl,
                DisplayNameColour = displayNameColour
            }
        };
    }
}
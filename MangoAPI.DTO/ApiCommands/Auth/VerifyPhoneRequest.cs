﻿using Newtonsoft.Json;

namespace MangoAPI.DTO.ApiCommands.Auth
{
    public record VerifyPhoneRequest
    {
        [JsonConstructor]
        public VerifyPhoneRequest(int confirmationCode, string userId)
        {
            ConfirmationCode = confirmationCode;
            UserId = userId;
        }

        public int ConfirmationCode { get; }
        public string UserId { get; }
    }

    public static class VerifyPhoneCommandMapper
    {
        public static VerifyPhoneCommand ToCommand(this VerifyPhoneRequest model) =>
            new()
            {
                ConfirmationCode = model.ConfirmationCode,
                UserId = model.UserId
            };
    }
}
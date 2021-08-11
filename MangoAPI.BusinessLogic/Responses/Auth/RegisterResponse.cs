﻿using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;

namespace MangoAPI.BusinessLogic.Responses.Auth
{
    public record RegisterResponse : AuthResponseBase<RegisterResponse>
    {
        public static RegisterResponse FromSuccess(UserEntity userEntity) => new()
        {
            Success = true,
            Message = ResponseMessageCodes.Success
        };
    }
}
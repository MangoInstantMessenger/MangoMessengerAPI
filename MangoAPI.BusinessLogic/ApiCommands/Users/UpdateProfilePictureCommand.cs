﻿using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    public record UpdateProfilePictureCommand : IRequest<Result<ResponseBase>>
    {
        public Guid UserId { get; init; }
        public IFormFile PictureFile { get; set; }
    }
}
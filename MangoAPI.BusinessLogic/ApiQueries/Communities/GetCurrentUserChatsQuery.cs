﻿using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.Communities
{
    public record GetCurrentUserChatsQuery : IRequest<GenericResponse<GetCurrentUserChatsResponse, ErrorResponse>>
    {
        public Guid UserId { get; init; }
    }
}

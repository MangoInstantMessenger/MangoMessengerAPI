using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.BusinessLogic.ApiCommands.Documents;

public record UploadDocumentCommand(IFormFile FormFile, Guid UserId, string ContentType) 
    : IRequest<Result<UploadDocumentResponse>>;
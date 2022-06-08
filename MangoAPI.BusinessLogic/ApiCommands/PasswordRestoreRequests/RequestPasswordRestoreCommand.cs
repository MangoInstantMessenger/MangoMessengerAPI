using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests;

public record RequestPasswordRestoreCommand(string Email) : IRequest<Result<RequestPasswordRestoreResponse>>;
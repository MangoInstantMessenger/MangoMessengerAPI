using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiQueries.AppInfo;

public record GetAppInfoQuery : IRequest<Result<GetAppInfoResponse>>;
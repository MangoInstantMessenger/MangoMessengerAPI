using System.Net;

namespace MangoAPI.BusinessLogic.Responses;

public class ResponseFactory<TResponse> where TResponse : ResponseBase
{
    public Result<TResponse> ConflictResponse(string message, string description)
    {
        return new Result<TResponse>
        {
            Error = new ErrorResponse
            {
                ErrorMessage = message,
                ErrorDetails = description,
                Success = false,
                StatusCode = HttpStatusCode.Conflict,
            },
            Response = null,
            StatusCode = HttpStatusCode.Conflict,
        };
    }

    public Result<TResponse> SuccessResponse(TResponse response)
    {
        return new Result<TResponse>
        {
            Error = null,
            Response = response,
            StatusCode = HttpStatusCode.OK,
        };
    }
}

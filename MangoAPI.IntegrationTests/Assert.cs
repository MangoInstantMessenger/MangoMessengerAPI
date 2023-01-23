using System.Net;
using FluentAssertions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.IntegrationTests;

public class Assert<T> where T : ResponseBase
{
    public void Pass(Result<T> result)
    {
        _ = result.StatusCode.Should().Be(HttpStatusCode.OK);
        _ = result.Response.Success.Should().BeTrue();
        _ = result.Response.Message.Should().Be(ResponseMessageCodes.Success);
        _ = result.Error.Should().BeNull();
    }

    public void Fail(Result<T> result, string expectedMessage, string expectedDetails)
    {
        _ = result.StatusCode.Should().Be(HttpStatusCode.Conflict);
        _ = result.Error.Success.Should().BeFalse();
        _ = result.Error.ErrorMessage.Should().Be(expectedMessage);
        _ = result.Error.ErrorDetails.Should().Be(expectedDetails);
        _ = result.Error.StatusCode.Should().Be(HttpStatusCode.Conflict);
        _ = result.Response.Should().BeNull();
    }
}
using System.Net;
using FluentAssertions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.IntegrationTests;

public class Assert<T> where T : ResponseBase
{
    public void Pass(Result<T> result)
    {
        result.StatusCode.Should().Be(HttpStatusCode.OK);
        result.Response.Success.Should().BeTrue();
        result.Response.Message.Should().Be(ResponseMessageCodes.Success);
        result.Error.Should().BeNull();
    }

    public void Fail(Result<T> result, string expectedMessage, string expectedDetails)
    {
        result.StatusCode.Should().Be(HttpStatusCode.Conflict);
        result.Error.Success.Should().BeFalse();
        result.Error.ErrorMessage.Should().Be(expectedMessage);
        result.Error.ErrorDetails.Should().Be(expectedDetails);
        result.Error.StatusCode.Should().Be(HttpStatusCode.Conflict);
        result.Response.Should().BeNull();
    }
}
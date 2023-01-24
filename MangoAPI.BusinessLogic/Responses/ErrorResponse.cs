using System.ComponentModel;
using System.Net;
using System.Text.Json;

namespace MangoAPI.BusinessLogic.Responses;

public record ErrorResponse
{
    [DefaultValue("ERROR_MESSAGE")]
    public string ErrorMessage { get; init; }

    [DefaultValue("Error description")]
    public string ErrorDetails { get; init; }

    [DefaultValue(409)]
    public HttpStatusCode StatusCode { get; init; }

    [DefaultValue(false)]
    public bool Success { get; init; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(
        this,
        new JsonSerializerOptions(JsonSerializerDefaults.Web));
    }
}

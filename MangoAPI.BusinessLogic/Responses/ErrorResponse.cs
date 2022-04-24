using System.ComponentModel;
using System.Net;
using Newtonsoft.Json;

namespace MangoAPI.BusinessLogic.Responses;

public record ErrorResponse
{
    [DefaultValue("ERROR_MESSAGE")]
    [JsonProperty("errorMessage")]
    public string ErrorMessage { get; init; }
        
    [DefaultValue("Error description")]
    [JsonProperty("errorDetails")]
    public string ErrorDetails { get; init; }
        
    [DefaultValue(409)]
    [JsonProperty("statusCode")]
    public HttpStatusCode StatusCode { get; init; }
        
    [DefaultValue(false)]
    [JsonProperty("success")]
    public bool Success { get; init; }

    public override string ToString() => JsonConvert.SerializeObject(this);
}
using System.ComponentModel;
using System.Text.Json;

namespace MangoAPI.BusinessLogic.Responses
{
    public record ErrorResponse
    {
        [DefaultValue("ERROR_MESSAGE")]
        public string ErrorMessage { get; init; }
        
        [DefaultValue("Exception stack trace")]
        public string ErrorDetails { get; init; }
        
        [DefaultValue(409)]
        public int StatusCode { get; init; }
        
        [DefaultValue(false)]
        public bool Success { get; init; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}

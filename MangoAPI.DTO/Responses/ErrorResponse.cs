using System.Text.Json;

namespace MangoAPI.DTO.Responses
{
    public record ErrorResponse
    {
        public string ErrorMessage { get; set; }
        public string ErrorDetails { get; set; }
        public int StatusCode { get; set; }
        public bool Success { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
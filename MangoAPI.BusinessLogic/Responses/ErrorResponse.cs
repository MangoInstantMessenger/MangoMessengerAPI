using System.Text.Json;

namespace MangoAPI.DTO.Responses
{
    public record ErrorResponse
    {
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string ErrorMessage { get; init; }

        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string ErrorDetails { get; init; }

        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public int StatusCode { get; init; }

        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public bool Success { get; init; }

        public override string ToString() => JsonSerializer.Serialize(this);
    }
}
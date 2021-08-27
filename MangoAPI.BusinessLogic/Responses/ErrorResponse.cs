namespace MangoAPI.BusinessLogic.Responses
{
    using System.Text.Json;

    public record ErrorResponse
    {
        public string ErrorMessage { get; init; }
        
        public string ErrorDetails { get; init; }
        
        public int StatusCode { get; init; }
        
        public bool Success { get; init; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}

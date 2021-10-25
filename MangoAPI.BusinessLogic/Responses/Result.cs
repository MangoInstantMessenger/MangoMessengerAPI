namespace MangoAPI.BusinessLogic.Responses
{
    public record Result<TResponse>
    {
        public TResponse Response { get; init; }

        public ErrorResponse Error { get; init; }

        public int StatusCode { get; init; }
    }
}
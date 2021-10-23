namespace MangoAPI.BusinessLogic.Responses
{
    public record GenericResponse<TResponse>
    {
        public TResponse Response { get; init; }

        public ErrorResponse Error { get; init; }

        public int StatusCode { get; init; }
    }
}
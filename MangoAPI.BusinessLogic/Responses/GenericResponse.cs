namespace MangoAPI.BusinessLogic.Responses
{
    public record GenericResponse<TResponse, TError>
    {
        public TResponse Response { get; init; }

        public TError Error { get; init; }

        public int StatusCode { get; init; }
    }
}
namespace MangoAPI.DTO.Responses
{
    public abstract class ResponseBase
    {
        public string Message { get; set; }
        public bool Success { get; set; }
    }
}
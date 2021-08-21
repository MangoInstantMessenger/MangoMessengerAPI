namespace MangoAPI.BusinessLogic.Responses
{
    using Domain.Constants;

    public abstract record ResponseBase
    {
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string Message { get; init; }
        public bool Success { get; init; }
    }

    public abstract record ResponseBase<T> : ResponseBase
        where T : ResponseBase, new()
    {
        public static T SuccessResponse => new ()
        {
            Success = true,
            Message = ResponseMessageCodes.Success,
        };
    }
}

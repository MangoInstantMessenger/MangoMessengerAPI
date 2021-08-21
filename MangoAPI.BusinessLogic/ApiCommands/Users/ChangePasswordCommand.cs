namespace MangoAPI.BusinessLogic.ApiCommands.Users
{
    using MediatR;

    public record ChangePasswordCommand : IRequest<ChangePasswordResponse>
    {
        public string UserId { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
    }
}

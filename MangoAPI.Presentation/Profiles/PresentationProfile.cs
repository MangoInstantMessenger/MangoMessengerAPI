using AutoMapper;
using MangoAPI.BusinessLogic.ApiCommands.Messages;
using MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.ApiCommands.Users;

namespace MangoAPI.Presentation.Profiles;

public class PresentationProfile : Profile
{
    public PresentationProfile()
    {
        _ = CreateMap<SendMessageRequest, SendMessageCommand>();
        _ = CreateMap<EditMessageRequest, EditMessageCommand>();
        _ = CreateMap<PasswordRestoreRequest, PasswordRestoreCommand>();
        _ = CreateMap<RegisterRequest, RegisterCommand>();
        _ = CreateMap<VerifyEmailRequest, VerifyEmailCommand>();
        _ = CreateMap<ChangePasswordRequest, ChangePasswordCommand>();
        _ = CreateMap<UpdateUserSocialInformationRequest, UpdateUserSocialInformationCommand>();
        _ = CreateMap<UpdateUserAccountInfoRequest, UpdateUserAccountInfoCommand>();
        _ = CreateMap<LoginRequest, LoginCommand>();
        _ = CreateMap<DeleteMessageRequest, DeleteMessageCommand>();
    }
}
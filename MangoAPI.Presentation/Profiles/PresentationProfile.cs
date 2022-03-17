using AutoMapper;
using MangoAPI.BusinessLogic.ApiCommands.KeyExchange;
using MangoAPI.BusinessLogic.ApiCommands.Messages;
using MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.ApiCommands.Users;

namespace MangoAPI.Presentation.Profiles;

public class PresentationProfile : Profile
{
    public PresentationProfile()
    {
        CreateMap<SendMessageRequest, SendMessageCommand>();
        CreateMap<EditMessageRequest, EditMessageCommand>();
        CreateMap<PasswordRestoreRequest, PasswordRestoreCommand>();
        CreateMap<RegisterRequest, RegisterCommand>();
        CreateMap<VerifyEmailRequest, VerifyEmailCommand>();
        CreateMap<ChangePasswordRequest, ChangePasswordCommand>();
        CreateMap<UpdateUserSocialInformationRequest, UpdateUserSocialInformationCommand>();
        CreateMap<UpdateUserAccountInfoRequest, UpdateUserAccountInfoCommand>();
        CreateMap<LoginRequest, LoginCommand>();
        CreateMap<DeleteMessageRequest, DeleteMessageCommand>();
        CreateMap<CreateDiffieHellmanParameterRequest, CreateDiffieHellmanParameterCommand>();
    }
}
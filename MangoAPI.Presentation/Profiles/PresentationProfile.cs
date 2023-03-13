using AutoMapper;
using MangoAPI.BusinessLogic.ApiCommands.Messages;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.ApiCommands.Users;

namespace MangoAPI.Presentation.Profiles;

public class PresentationProfile : Profile
{
    public PresentationProfile()
    {
        CreateMap<SendMessageRequest, SendMessageCommand>();
        CreateMap<EditMessageRequest, EditMessageCommand>();
        CreateMap<RegisterRequest, RegisterCommand>();
        CreateMap<ChangePasswordRequest, ChangePasswordCommand>();
        CreateMap<UpdatePersonalInformationRequest, UpdatePersonalInformationCommand>();
        CreateMap<UpdateUserAccountInfoRequest, UpdateUserAccountInfoCommand>();
        CreateMap<LoginRequest, LoginCommand>();
        CreateMap<DeleteMessageRequest, DeleteMessageCommand>();
    }
}
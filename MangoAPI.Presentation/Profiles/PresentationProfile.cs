using AutoMapper;
using MangoAPI.BusinessLogic.ApiCommands.Communities;
using MangoAPI.BusinessLogic.ApiCommands.Messages;
using MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.Domain.Enums;

namespace MangoAPI.Presentation.Profiles
{
    public class PresentationProfile : Profile
    {
        public PresentationProfile()
        {
            CreateMap<CreateChannelRequest, CreateChannelCommand>()
                .ForMember(x => x.CommunityType,
                    expression => expression.MapFrom(z => (CommunityType)z.ChannelType));

            CreateMap<CreateChatRequest, CreateChatCommand>().ForMember(x => x.CommunityType,
                expression => expression.MapFrom(z => (CommunityType)z.ChatType));

            CreateMap<SendMessageRequest, SendMessageCommand>();
            CreateMap<EditMessageRequest, EditMessageCommand>();
            CreateMap<PasswordRestoreRequest, PasswordRestoreCommand>();

            CreateMap<RegisterRequest, RegisterCommand>();

            CreateMap<VerifyEmailRequest, VerifyEmailCommand>();
            CreateMap<ChangePasswordRequest, ChangePasswordCommand>();
            CreateMap<UpdateUserSocialInformationRequest, UpdateUserSocialInformationCommand>();
            CreateMap<UpdateUserAccountInfoRequest, UpdateUserAccountInfoCommand>();
            CreateMap<LoginRequest, LoginCommand>();
            CreateMap<UpdateChanelPictureRequest, UpdateChanelPictureCommand>();
        }
    }
}
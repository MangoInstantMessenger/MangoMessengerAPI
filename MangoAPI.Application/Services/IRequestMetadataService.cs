using System.Threading.Tasks;
using MangoAPI.Application.Common;
using MangoAPI.Domain.Entities;

namespace MangoAPI.Application.Services
{
    public interface IRequestMetadataService
    {
        RequestMetadata GetRequestMetadata();
        Task<UserEntity> GetUserFromRequestMetadataAsync();
    }
}
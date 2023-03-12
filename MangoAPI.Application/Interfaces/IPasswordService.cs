using MangoAPI.Domain.Entities;

namespace MangoAPI.Application.Interfaces;

public interface IPasswordService
{
    bool ValidateCredentials(UserEntity user, string currentPassword);

    UserEntity ChangePassword(UserEntity user, string newPassword);
}
namespace MangoAPI.Application.Interfaces;

public interface IPasswordValidatorService
{
    bool ValidatePassword(string password);
}
using System.Threading.Tasks;
using MangoAPI.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace MangoAPI.Application.Interfaces;

public interface ISignInManagerService
{
    Task<SignInResult> CheckPasswordSignInAsync(UserEntity user, string password, bool lockoutOnFailure);
}
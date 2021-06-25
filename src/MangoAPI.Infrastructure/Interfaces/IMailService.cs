using System;
using System.Threading.Tasks;

namespace MangoAPI.Infrastructure.Interfaces
{
    public interface IMailService
    {
        Task SendMailMessage(string email, Guid guid);
    }
}
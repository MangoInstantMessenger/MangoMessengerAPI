using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Domain.Entities;
using MangoAPI.DTO.Commands.Auth;
using MangoAPI.DTO.Responses;
using MangoAPI.DTO.Responses.Auth;
using MangoAPI.Infrastructure.Database;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.CommandHandlers
{
    public class ConfirmRegisterCommandHandler : IRequestHandler<ConfirmRegisterCommand, ConfirmRegisterResponse>
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly MangoPostgresDbContext _dbContext;

        public ConfirmRegisterCommandHandler(UserManager<UserEntity> userManager,
            MangoPostgresDbContext dbContext)
        {
            _userManager = userManager;
            _dbContext = dbContext;
        }

        public async Task<ConfirmRegisterResponse> Handle(ConfirmRegisterCommand request,
            CancellationToken cancellationToken)
        {
            var validRequestCode = int.TryParse(request.ValidationCode, out var parsedValidationCode);

            if (!validRequestCode)
            {
                return await Task.FromResult(new ConfirmRegisterResponse
                {
                    Message = "Invalid or expired registration identifier.",
                    Success = false
                });
            }

            var requestEntity = await _dbContext.RegisterRequests
                .FirstOrDefaultAsync(x => x.ConfirmLinkCode == parsedValidationCode, 
                    cancellationToken);

            if (requestEntity == null)
            {
                return await Task.FromResult(new ConfirmRegisterResponse
                {
                    Message = "Invalid or expired registration identifier.",
                    Success = false
                });
            }

            var userEntity = new UserEntity
            {
                DisplayName = requestEntity.Email,
                Email = requestEntity.Email,
                UserName = requestEntity.Email.Split('@')[0],
            };

            var result = await _userManager.CreateAsync(userEntity, requestEntity.Password);

            if (result.Succeeded)
            {
                return await Task.FromResult(new ConfirmRegisterResponse
                {
                    Message = "Your email was verified successfully.",
                    Success = true,
                });
            }
            
            return await Task.FromResult(new ConfirmRegisterResponse
            {
                Message = "Invalid or expired registration identifier.",
                Success = false
            });


        }
    }
}
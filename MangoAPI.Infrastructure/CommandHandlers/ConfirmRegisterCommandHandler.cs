using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Domain.Entities;
using MangoAPI.DTO.Commands.Auth;
using MangoAPI.DTO.Responses;
using MangoAPI.Infrastructure.Database;
using MangoAPI.Infrastructure.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.Infrastructure.CommandHandlers
{
    public class ConfirmRegisterCommandHandler : IRequestHandler<ConfirmRegisterCommand, ConfirmRegisterResponse>
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly IJwtGenerator _jwtGenerator;
        private readonly UserDbContext _dbContext;

        public ConfirmRegisterCommandHandler(UserManager<UserEntity> userManager, IJwtGenerator jwtGenerator,
            UserDbContext dbContext)
        {
            _userManager = userManager;
            _jwtGenerator = jwtGenerator;
            _dbContext = dbContext;
        }

        public async Task<ConfirmRegisterResponse> Handle(ConfirmRegisterCommand request,
            CancellationToken cancellationToken)
        {
            var validRequestCode = Guid.TryParse(request.Guid, out var parsedGuid);

            if (!validRequestCode)
            {
                return await Task.FromResult(new ConfirmRegisterResponse
                {
                    Message = "Invalid or expired registration identifier.",
                    Success = false
                });
            }

            var requestEntity = await _dbContext.RegisterRequests
                .FirstOrDefaultAsync(x => x.ConfirmLinkCode == parsedGuid, cancellationToken);

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
                AccessToken = _jwtGenerator.CreateToken(requestEntity.Email),
                RefreshToken = _jwtGenerator.CreateToken(Guid.NewGuid().ToString()),
                UserName = requestEntity.Email.Split('@')[0],
            };

            var result = await _userManager.CreateAsync(userEntity, requestEntity.Password);

            if (result.Succeeded)
            {
                return await Task.FromResult(new ConfirmRegisterResponse
                {
                    Message = "Your email was verified successfully.",
                    Success = true,
                    AccessToken = userEntity.AccessToken,
                    RefreshToken = userEntity.RefreshToken,
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
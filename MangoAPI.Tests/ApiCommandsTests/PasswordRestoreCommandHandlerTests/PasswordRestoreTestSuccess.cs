using MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.Tests.ApiCommandsTests.PasswordRestoreCommandHandlerTests
{
    public class PasswordRestoreTestSuccess : ITestable<PasswordRestoreCommand, ResponseBase>
    {
        public bool Seed()
        {
            throw new System.NotImplementedException();
        }

        public IRequestHandler<PasswordRestoreCommand, Result<ResponseBase>> CreateHandler()
        {
            throw new System.NotImplementedException();
        }
    }
}
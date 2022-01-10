using System.Threading;
using System.Threading.Tasks;
using FluentAssertions;
using MangoAPI.BusinessLogic.ApiQueries.Contacts;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace MangoAPI.Tests.ApiQueries.SearchContactByDisplayNameQueryHandlerTests
{
    public class SearchContactByDisplayNameTestSuccess : ITestable<SearchContactQuery, SearchContactResponse>
    {
        private readonly MangoDbFixture _mangoDbFixture = new();
        private readonly Assert<SearchContactResponse> _assert = new();

        [Fact]
        public async Task SearchContactByDisplayNameTest_Success()
        {
            Seed();
            var handler = CreateHandler();
            var query = new SearchContactQuery
            {
                UserId = SeedDataConstants.RazumovskyId,
                SearchQuery = "Amelit"
            };

            var result = await handler.Handle(query, CancellationToken.None);

            _assert.Pass(result);
            result.Response.Contacts.Count.Should().Be(1);
            result.Response.Contacts[0].DisplayName.Should().Be(_user2.DisplayName);
        }
        
        public bool Seed()
        {
            _mangoDbFixture.Context.Users.AddRange(_user1, _user2);

            _mangoDbFixture.Context.SaveChanges();

            _mangoDbFixture.Context.Entry(_user1).State = EntityState.Detached;
            _mangoDbFixture.Context.Entry(_user2).State = EntityState.Detached;
            
            return true;
        }

        public IRequestHandler<SearchContactQuery, Result<SearchContactResponse>> CreateHandler()
        {
            var responseFactory = new ResponseFactory<SearchContactResponse>();
            var handler = new SearchContactByDisplayNameQueryHandler(_mangoDbFixture.Context, responseFactory);
            return handler;
        }
        
        private readonly UserEntity _user1 = new()
        {
            DisplayName = "razumovsky r",
            Bio = "11011 y.o Dotnet Developer from $\"{cityName}\"",
            Id = SeedDataConstants.RazumovskyId,
            UserName = "razumovsky_r",
            Email = "kolosovp95@gmail.com",
            NormalizedEmail = "KOLOSOVP94@GMAIL.COM",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            Image = "razumovsky_picture.jpg"
        };

        private readonly UserEntity _user2 = new()
        {
            DisplayName = "Amelit",
            Bio = "Дипломат",
            Id = SeedDataConstants.AmelitId,
            UserName = "TheMoonlightSonata",
            Email = "amelit@gmail.com",
            NormalizedEmail = "AMELIT@GMAIL.COM",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            Image = "amelit_picture.jpg"
        };
    }
}
using FluentAssertions;
using MangoAPI.Application.Services;
using NUnit.Framework;

namespace MangoAPI.Tests.ServiceTests
{
    [TestFixture]
    public class RandomGeneratorTests
    {
        [Test]
        public void RandomGenerator_Test()
        {
            var generator = new RandomGenerator();

            var randomNumber = generator.Next(20, 100);

            randomNumber.Should().BeGreaterOrEqualTo(20);
            randomNumber.Should().BeLessOrEqualTo(100);
        }
    }
}
using System.Threading.Tasks;
using Example.Models;
using FluentAssertions;
using NSubstitute;
using NUnit.Framework;

namespace Example.Tests
{
    public class BuildingMetricsServiceTests
    {
        protected IBuildingMetricsService SystemUnderTest { get; set; }

        private IBuildingMetricsValidator _validator;
        private IBuildingMetricsCalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _validator = Substitute.For<IBuildingMetricsValidator>();
            _calculator = Substitute.For<IBuildingMetricsCalculator>();
            SystemUnderTest = new BuildingMetricsService(_validator, _calculator);
        }

        [Test]
        public async Task ItShouldExecute()
        {
            var request = new JsonOptions();
            var expectedResponse = new SiteResponse();

            _validator.Validate(request).Returns(true);
            _calculator.Calculate(Arg.Any<SiteRequest>()).Returns(expectedResponse);

            var result = await SystemUnderTest.Execute(request);
            result.Should().Be(expectedResponse);
        }
    }
}

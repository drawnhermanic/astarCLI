using System.Collections.Generic;
using System.Threading.Tasks;
using Example.Models;
using FluentAssertions;
using Newtonsoft.Json;
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
            var exampleRequest = new List<SiteRequest>
            {
                new SiteRequest
                {
                    Length = 1,
                    Width = 1,
                    SiteConfiguration = new ApartmentConfiguration
                    {
                        AverageApartmentArea = 1,
                        NumberOfStoreys = 1,
                        SiteCoverage = 1
                    }
                }
            };

            var request = new JsonOptions
            {
                Input = JsonConvert.SerializeObject(exampleRequest)
            };
            var expectedResponse = new SiteResponse();

            _validator.Validate(request).Returns(true);
            _calculator.Calculate(Arg.Any<SiteRequest>()).Returns(expectedResponse);

            var result = await SystemUnderTest.Execute(request);
            result.Should().BeEquivalentTo(expectedResponse);
        }
    }
}

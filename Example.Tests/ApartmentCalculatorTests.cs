using System.Threading.Tasks;
using Example.Calculators;
using Example.Models;
using FluentAssertions;
using NUnit.Framework;

namespace Example.Tests
{
    public class ApartmentCalculatorTests
    {
        protected ApartmentCalculator SystemUnderTest { get; set; }

        [SetUp]
        public void Setup()
        {
            SystemUnderTest = new ApartmentCalculator();
        }

        [Test]
        public async Task ItShouldPerformExpectedCalculation()
        {
            var request = new SiteRequest
            {
                Length = 100,
                Width = 500,
                SiteConfiguration = new ApartmentConfiguration
                {
                    NumberOfStoreys = 3,
                    SiteCoverage = 70,
                    AverageApartmentArea = 74
                }
            };

            var result = await SystemUnderTest.Calculate(request);
            result.Should().NotBeNull();
            result.SiteArea.Should().Be(50000);
            result.SitePerimeter.Should().Be(1200);
            result.SiteConfigurationResponse.Should().BeOfType<ApartmentResponse>();
            if (result.SiteConfigurationResponse is ApartmentResponse siteConfigResponse)
            {
                siteConfigResponse.BuildingGFA.Should().Be(10500000);
                siteConfigResponse.BuildingFootprint.Should().Be(3500000);
                siteConfigResponse.NumberOfApartments.Should().Be(141891);
            }
        }
    }
}
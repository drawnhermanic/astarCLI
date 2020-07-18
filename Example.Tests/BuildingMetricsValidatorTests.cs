using FluentAssertions;
using NUnit.Framework;

namespace Example.Tests
{
    public class BuildingMetricsValidatorTests
    {
        protected IBuildingMetricsValidator SystemUnderTest { get; set; }

        [SetUp]
        public void Setup()
        {
            SystemUnderTest = new BuildingMetricsValidator();
        }

        [Test]
        public void ItShouldValidateRequest()
        {
            var request = new JsonOptions();
            var result = SystemUnderTest.Validate(request);
            result.Should().BeTrue();
        }
    }
}

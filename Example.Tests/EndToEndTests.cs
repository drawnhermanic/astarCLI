using System.Collections.Generic;
using System.Threading.Tasks;
using Example.Models;
using ExampleCLI;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace Example.Tests
{
    public class EndToEndTests
    {
        [Test]
        public async Task ItShouldReturnTheExpectedOutput()
        {
            var input = "[{\"width\":100,\"length\":500,\"site_config\":{\"num_storeys\":0,\"site_coverage\":90,\"development_type\":\"subdivision\",\"avg_lot_size\":300}},{\"width\":50,\"length\":100,\"site_config\":{\"num_storeys\":3,\"site_coverage\":70,\"development_type\":\"apartment\",\"avg_apt_area\":74}},{\"width\":250,\"length\":700,\"site_config\":{\"num_storeys\":5,\"site_coverage\":70,\"development_type\":\"mixed_use\",\"avg_apt_area\":74,\"commerical_mix\":20,\"retail_mix\":70,\"residential_mix\":10}},{\"width\":250,\"length\":700,\"site_config\":{\"num_storeys\":20,\"site_coverage\":70,\"development_type\":\"commercial\",\"commerical_mix\":20,\"retail_mix\":70}},{\"width\":50,\"length\":100,\"site_config\":{\"num_storeys\":3,\"site_coverage\":70,\"development_type\":\"apartment\"}},{\"width\":20,\"length\":30,\"site_config\":{\"num_storeys\":2,\"site_coverage\":70,\"development_type\":\"apartment\",\"avg_apt_area\":90}},{\"width\":10,\"length\":50,\"site_config\":{\"num_storeys\":0,\"site_coverage\":90,\"development_type\":\"subdivision\",\"avg_lot_size\":450}},{\"width\":10,\"length\":50,\"site_config\":{\"num_storeys\":0,\"site_coverage\":90,\"development_type\":\"subdivision\",\"avg_lot_size\":500}}]";
            var expectedResult = new List<SiteResponse>();

            var serviceProvider = ServiceRegistration.Register();

            var service = serviceProvider.GetService<IBuildingMetricsService>();
            var response = await service.Execute(new JsonOptions
            {
                Input = input
            });

            response.Should().NotBeNull();
            response.Count.Should().Be(8);
            //response.Should().BeEquivalentTo(expectedResult);
        }

    }
}
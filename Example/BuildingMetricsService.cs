using System;
using System.Threading.Tasks;
using Example.Models;

namespace Example
{
    public interface IBuildingMetricsService
    {
        Task<SiteResponse> Execute(JsonOptions options);
    }

    public class BuildingMetricsService : IBuildingMetricsService
    {
        private readonly IBuildingMetricsValidator _validator;
        private readonly IBuildingMetricsCalculator _calculator;

        public BuildingMetricsService(IBuildingMetricsValidator validator,
            IBuildingMetricsCalculator calculator)
        {
            _validator = validator;
            _calculator = calculator;
        }

        public async Task<SiteResponse> Execute(JsonOptions options)
        {
            if (!_validator.Validate(options)) 
                throw new ArgumentException("Request is not valid");
            var request = CreateRequest(options);
            return  await _calculator.Calculate(request);
        }

        private SiteRequest CreateRequest(JsonOptions options)
        {
            return new SiteRequest();
        }
    }
}
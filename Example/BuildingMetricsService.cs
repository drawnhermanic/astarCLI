using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Example.Models;
using Newtonsoft.Json;

namespace Example
{
    public interface IBuildingMetricsService
    {
        Task<IList<SiteResponse>> Execute(JsonOptions options);
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

        public async Task<IList<SiteResponse>> Execute(JsonOptions options)
        {
            if (!_validator.Validate(options)) 
                throw new ArgumentException("Request is not valid");
            var requests = CreateRequests(options);
            var response = new List<SiteResponse>();
            foreach (var request in requests)
            {
                var siteResponse = await _calculator.Calculate(request);
                response.Add(siteResponse);
            }
            return response;
        }

        private IList<SiteRequest> CreateRequests(JsonOptions options)
        {
            return JsonConvert.DeserializeObject<IList<SiteRequest>>(options.Input);
        }
    }
}
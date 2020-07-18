using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Example.Calculators;
using Example.Models;

namespace Example
{
    public interface IBuildingMetricsCalculator
    {
        Task<SiteResponse> Calculate(SiteRequest request);
    }
    public class BuildingMetricsCalculator : IBuildingMetricsCalculator
    {
        private readonly IEnumerable<IBuildingCalculator> _buildingCalculators;

        public BuildingMetricsCalculator(IEnumerable<IBuildingCalculator> buildingCalculators)
        {
            _buildingCalculators = buildingCalculators;
        }
        public async Task<SiteResponse> Calculate(SiteRequest request)
        {
            var calculator = _buildingCalculators.FirstOrDefault(x => x.CanCalculate(request.SiteConfiguration));
            if (calculator == null)
                throw new ArgumentException("No calculator available for this type of request");
            return await calculator.Calculate(request);
        }
    }
}

using System.Threading.Tasks;
using Example.Models;

namespace Example.Calculators
{
    public class ApartmentCalculator : IBuildingCalculator
    {
        public bool CanCalculate(ISiteConfiguration siteConfiguration)
        {
            return siteConfiguration is IApartmentConfiguration;
        }

        public async Task<SiteResponse> Calculate(SiteRequest request)
        {
            var response = new SiteResponse();

            return await Task.FromResult(response);
        }
    }
}
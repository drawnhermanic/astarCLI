using System.Threading.Tasks;
using Example.Models;

namespace Example.Calculators
{
    public interface IBuildingCalculator
    {
        bool CanCalculate(ISiteConfiguration siteConfiguration);
        Task<SiteResponse> Calculate(SiteRequest request);
    }
}
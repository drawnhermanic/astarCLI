using Example.Models;

namespace Example
{
    public interface IBuildingMetricsValidator
    {
        bool Validate(JsonOptions request);
    }
    public class BuildingMetricsValidator : IBuildingMetricsValidator
    {
        public bool Validate(JsonOptions request)
        {
            return true;
        }
    }
}
using System;

namespace Example.Calculators
{
    public static class SimpleCalculator
    {
        public static decimal Area(decimal width, decimal length)
        {
            return width * length;
        }

        public static decimal Perimeter(decimal width, decimal length)
        {
            return (width * 2) + (length * 2);
        }

        public static decimal BuildingFootprint(decimal siteArea, decimal siteCoverage)
        {
            return siteArea * siteCoverage;
        }

        public static decimal BuildingGFA(decimal buildingFootprint, decimal numOfStoreys)
        {
            return buildingFootprint * numOfStoreys;
        }

        public static decimal ResidentialGFA(decimal buildingFootprint, decimal residentialMix)
        {
            return buildingFootprint * residentialMix;
        }

        public static decimal CommercialGFA(decimal buildingFootprint, decimal commercialMix)
        {
            return buildingFootprint * commercialMix;
        }

        public static decimal RetailGFA(decimal buildingFootprint, decimal retailMix)
        {
            return buildingFootprint * retailMix;
        }

        public static int? NumberOfApartments(decimal buildingGFA, decimal avgApartmentArea)
        {
            if (avgApartmentArea > 0)
            {
                return Convert.ToInt32(Math.Floor(buildingGFA / avgApartmentArea));
            }
            return null;
        }

        public static int? NumberOfLots(decimal siteArea, decimal siteCoverage, decimal avgLotSize)
        {
            if (avgLotSize > 0)
            {
                return Convert.ToInt32(Math.Floor((siteArea * siteCoverage) / avgLotSize));
            }
            return null;
        }   

    }
}
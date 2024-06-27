namespace labs;

public class ProductionDemandCalculator
{
    public List<ProductionDemandYearData> Calculate(int initialProduction, int initialDemand, double productionIncreasePercent, double demandDecreasePercent)
    {
        List<ProductionDemandYearData> traceData = new List<ProductionDemandYearData>();

        int year = 1;
        int production = initialProduction;
        int demand = initialDemand;
        int i = 0;
        // Пока производство не превысит спрос
        while (production <= demand)
        {
            traceData.Add(new ProductionDemandYearData(i++, year, null, null));
            production = (int)(production * (1 + productionIncreasePercent / 100));
            traceData.Add(new ProductionDemandYearData(i++, null, production, null));
            demand = (int)(demand * (1 - demandDecreasePercent / 100));
            traceData.Add(new ProductionDemandYearData(i++, null, null, demand));
            year++;
            
        }

        return traceData;
    }
}
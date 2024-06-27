namespace labs;

public class ProductionDemandYearData
{
    public int Id { get; set; }
    public int? Year { get; set; }
    public int? Production { get; set; }
    public int? Demand { get; set; }

    public ProductionDemandYearData(int id, int? year, int? production, int? demand)
    {
        Id = id;
        Year = year;
        Production = production;
        Demand = demand;
    }
}
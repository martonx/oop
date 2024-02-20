namespace OOP;

public interface ICar
{
    int DoorsCount { get; set; }
    decimal MaximumDistance { get; }
    int MaximumValami { get; set; }
    int PassangersCount { get; set; }

    decimal ConsumptionByDistance(int kilometers);
}
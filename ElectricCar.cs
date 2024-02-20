namespace OOP;

public class ElectricCar : Vehicle, ICar
{
    public int Kw { get; set; }
    public int DoorsCount { get; set; }
    public int PassangersCount { get; set; }
    public decimal ConsumptionKw { get; set; }
    public int BatteryCapacity { get; set; }
    public decimal MaximumDistance
    {
        get
        {
            //gyakran használt osztályon belüli számított adat
            return BatteryCapacity / ConsumptionKw;
        }
    }
    private int _maximumValami;
    public int MaximumValami
    {
        get
        {
            return _maximumValami;
        }
        set
        {
            //Nem gyakran használt,
            //inkább csak a teljesség kedvéért írtam ide ezt a lehetőséget
            _maximumValami = value * 100;
        }
    }

    //Osztály saját metódusa
    public decimal ConsumptionByDistance(int kilometers)
    {
        return ConsumptionKw * kilometers;
    }
}

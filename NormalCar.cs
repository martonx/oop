namespace OOP;

public class NormalCar : Vehicle, ICar
{
    public int Ccm { get; set; }
    public int DoorsCount { get; set; }
    public int PassangersCount { get; set; }
    public decimal ConsumptionLiter { get; set; }
    public int FuelTankCapacity { get; set; }
    public decimal MaximumDistance
    {
        get
        {
            //gyakran használt osztályon belüli számított adat
            return FuelTankCapacity / ConsumptionLiter;
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
        return ConsumptionLiter * kilometers;
    }
}

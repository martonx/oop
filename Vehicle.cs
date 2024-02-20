namespace OOP;

public abstract class Vehicle
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Color Color { get; set; }
    public int Speed { get; set; }

    public int ElapsedDistance (int hour)
    {
        return Speed * hour;
    }
}

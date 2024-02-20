// See https://aka.ms/new-console-template for more information
using OOP;

Console.WriteLine("Hello, World!");

var newCar = new Car
{
    Id = 1,
    Ccm = 2000,
    Color = Color.White,
    DoorsCount = 4,
    Name = "BMW X5",
    PassangersCount = 4,
    Speed = 100,
    Consumption = 5,
    FuelTankCapacity = 50,
    MaximumValami = 10,
};

var hour = 4;
//Ez a metódus a szülőről öröklődött Vehicle.ElapsedDistance
var elapasedDistance = newCar.ElapsedDistance(hour);
Console.WriteLine($"Autó által {hour} óra alatt megtett út {elapasedDistance}");

var kilometers = 200;
//Ez a metódus saját Car.ConsumptionByDistance
var consumptionByKm = newCar.ConsumptionByDistance(kilometers);
Console.WriteLine($"Autó által {kilometers} km alatt fogyasztott üzemanyag {consumptionByKm}");

Console.WriteLine($"Autó által megtehető maximális táv: {newCar.MaximumDistance}");
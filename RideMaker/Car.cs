public class Car : Vehicle, INeedFuel
{
    public string FuelType {get;set;}
    public int FuelTotal {get;set;}
    public Car(string n, int passengers, string color, string fueltype) : base(n, passengers, color, true)
    {
        FuelType = fueltype;
        FuelTotal = 10;
    }

    public void GiveFuel(int Amount)
    {
        Console.WriteLine($"Fueled the {Name} with {FuelType} to {FuelTotal}.");
        FuelTotal += Amount;
    }

}
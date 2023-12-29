public class Horse : Vehicle, INeedFuel
{
    public string FuelType {get;set;}
    public int FuelTotal {get;set;}
    public Horse(string name, string color, string fueltype) : base(name, 2, color, false)
    {
        FuelTotal = 10;
        FuelType = fueltype;
    }
    public void GiveFuel(int Amount)
    {
        Console.WriteLine($"The horse ate {Amount} barrels of {FuelType}.");
        FuelTotal += Amount;
    }
}
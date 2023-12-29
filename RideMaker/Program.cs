//! Unable to use Vehicle because it is abstract
// Vehicle v = Vehicle("Hyundai", 5, "silver", true);
// Vehicle v2 = Vehicle("Corvette", 2, "grey green", true);
// Vehicle v3 = Vehicle("Toyota", "blue");
// Vehicle v4 = Vehicle("Hyundai", "white");
Car car = new("Hyundai", 4, "Silver", "Gas");
Horse horse = new("Horsey", "Brown", "Hay");
Bike bike = new();

// Add all of the vehicles to the list
List<Vehicle> lot = new() {car, horse, bike};

// Create a list for interfaces
List<INeedFuel> fuel = new();

// Loop through the list of vehicle
foreach(Vehicle transport in lot){

    if ( transport is INeedFuel){
        fuel.Add((INeedFuel) transport);
    }
}

foreach (INeedFuel item in fuel)
{
    item.GiveFuel(10);
}


foreach (INeedFuel item in fuel)
{
    Console.WriteLine(item);
    Console.WriteLine(item.FuelTotal);
}



// v.Travel(100);
// v.ShowInfo();


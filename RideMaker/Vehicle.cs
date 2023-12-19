public class Vehicle{
    public string Name;
    public int NumOfPassengers;
    public string CarColor;
    public bool HasEngine;
    private double Miles = 0;

    public Vehicle(string n, int passengers, string c, bool engine){
        Name = n;
        NumOfPassengers = passengers;
        CarColor = c;
        HasEngine = engine;
    }

    public Vehicle(string n, string color){
        Name = n;
        CarColor = color;
        NumOfPassengers = 4;
        HasEngine = true;
    }

    public void ShowInfo(){
        Console.WriteLine($"Name of the vehicle: {Name}");
        Console.WriteLine($"Number of Passengers: {NumOfPassengers}");
        Console.WriteLine($"Car color: {CarColor}");
        Console.WriteLine($"Does it have an engine: {HasEngine}");
        Console.WriteLine($"Number of miles driven: {Miles}\n");
    }

    public string Travel(int distance){
        Miles += distance;

        return $"Your vehicle had gone {Miles} miles.";
    }
}
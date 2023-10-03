public class Drink{
    public string Name;
    public string Color;
    public double Temperature;
    public bool IsCarbonated;
    public int Calories;

    public Drink(string name, string color, double temp, bool isCarb, int calories){
        Name = name;
        Color = color;
        Temperature = temp;
        IsCarbonated = isCarb;
        Calories = calories;
    }

    public virtual void ShowDrink(){
        Console.WriteLine($"Name of the drink: {Name}");
        Console.WriteLine($"Color of the drink: {Color}");
        Console.WriteLine($"Temperature: {Temperature}");
        Console.WriteLine($"Is carbonated: {IsCarbonated}");
        Console.WriteLine($"Calories: {Calories}");
    }

}
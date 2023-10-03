public class Coffee : Drink{
    public string Roast;
    public string Beans;
    public Coffee(string roast , string beans ) : base("Mocha", "Brown", 86.5, false, 540){
        Roast = roast;
        Beans = beans;
    }

    public override void ShowDrink()
    {
        base.ShowDrink();
        Console.WriteLine($"Roast: {Roast}");
        Console.WriteLine($"Beans: {Beans}\n");
    }

}
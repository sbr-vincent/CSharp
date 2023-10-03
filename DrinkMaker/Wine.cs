public class Wine : Drink{
    public string Region;
    public int YearBottled;
    public Wine(string region, int yearBottled) : base("Merlot", "Red", 40.6, false, 60){
        Region = region;
        YearBottled = yearBottled;
    }

    public override void ShowDrink()
    {
        base.ShowDrink();
        Console.WriteLine($"Region: {Region}");
        Console.WriteLine($"Year: {YearBottled}\n");
    }


}
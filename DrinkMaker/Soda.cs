public class Soda : Drink{
    public bool IsDiet;
    public Soda(bool isDiet) : base("Sprite", "Clear", 65.9, true, 190){
        IsDiet = isDiet;
    }

    public override void ShowDrink()
    {
        base.ShowDrink();
        Console.WriteLine($"Diet: {IsDiet}\n");
    }
}
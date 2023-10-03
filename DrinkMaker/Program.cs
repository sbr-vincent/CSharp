using System.Reflection.Metadata;

Soda soda = new Soda(false);
Coffee coffee = new Coffee("Blonde", "Uganda");
Wine wine = new Wine("France", 1969);

List<Drink> AllBeverages = new List<Drink>();
AllBeverages.Add(soda);
AllBeverages.Add(coffee);
AllBeverages.Add(wine);

foreach(Drink drink in AllBeverages){
    drink.ShowDrink();
}

// Coffee MyDrink = new Soda(true); 
// We run into a conversion error trying to make a Coffee instance using the Soda Class
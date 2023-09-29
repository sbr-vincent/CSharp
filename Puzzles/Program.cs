// Coin Flip
static string CoinFlip(){
    Random rand = new Random();

    if(rand.Next(2) == 1){
        return "heads";
    }else{
        return "tails";
    }

}

Console.WriteLine(CoinFlip());

// Dice Roll
static int DiceRoll(int number){
    Random rand = new Random();
    int die = rand.Next(1, number+1);

    return die;
}

Console.WriteLine(DiceRoll(8));

// Stat Roll
static List<int> StatRoll(){
    List<int> stats = new List<int>();

    for(int i = 0; i < 4; i++){
        stats.Add(DiceRoll(6));
    }

    int largest = stats[0];
    foreach(int die in stats){
        if(die > largest){
            largest = die;
        }
        Console.WriteLine(die);
    }

    Console.WriteLine($"The largest value is {largest}");
    
    return stats;
}

Console.WriteLine(StatRoll());

// Roll Until
static string KeepRolling(int number){
    if(number > 6){
        return $"Your number {number} is bigger than the six-sided die.";
    }

    int count = 0;
    int numOfRolls = 0;

    while(number != numOfRolls){
        count++;
        numOfRolls = DiceRoll(6);
    }

    return $"Rolled a {number} after {count} tries";
}

Console.WriteLine(KeepRolling(8));




class Enemy
{
    public string Name;
    public int MaxHealth = 100;
    private int Health;
    public int _Health
    {
        get { return Health; }
        set { Health = value; }
    }
    public List<Attack> AttackList = new List<Attack>(){new Attack("Slice", 30), new Attack("Gouge", 50), new Attack("Poke", 15)};

    public Enemy(string n)
    {
        Name = n;
        Health = 100;
        AttackList = new List<Attack>();

    }

    public string RandomAttack()
    {
        if (AttackList.Count < 1)
        {
            return "You don't know any attacks you newb!";
        }
        else
        {
            Random rand = new Random();
            return $"You attacked with {AttackList[rand.Next(0, AttackList.Count)].Name}";
        }
    }

    public virtual void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        if(Target._Health < 0){
            Console.WriteLine($"You cannot attack someone who is dead.");
        }else{
            Target._Health -= ChosenAttack.DamageAmount;
            Console.WriteLine($"{Name} attacks {Target.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
        }
    }



}
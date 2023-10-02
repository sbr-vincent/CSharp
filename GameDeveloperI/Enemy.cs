class Enemy
{
    public string Name;
    private int Health;
    public int _Health
    {
        get { return Health; }
        set { Health = value; }
    }
    public List<Attack> AttackList = new List<Attack>();

    public Enemy(string n)
    {
        Name = n;
        Health = 100;
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



}
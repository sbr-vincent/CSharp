class Melee : Enemy
{
    Attack meleeSkill = new Attack("Punch", 20);
    Attack meleeSkill2 = new Attack("Kick", 15);
    Attack meleeSkill3 = new Attack("Tackle", 25);
    public Melee() : base("Barb") {
        _Health = 200;
        AttackList = new List<Attack>(){
            meleeSkill, meleeSkill2, meleeSkill3
        };
        MaxHealth = 200;
    }

    public string Rage(Enemy Target)
    {
        Random rand = new Random();
        Attack chosenAttack = AttackList[rand.Next(0, AttackList.Count)];

        if(Target._Health < 0){
            return $"You cannot attack someone who has died.";
        }

        Target._Health -= chosenAttack.DamageAmount;
        return $"You randomly attacked {Target.Name} with {chosenAttack.Name}, dealing {chosenAttack.DamageAmount}. Their health is now {Target._Health}";
    }


}
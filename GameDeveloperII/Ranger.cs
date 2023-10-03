class Ranger : Enemy {
    public double Distance = 5.0;
    private Attack rangerSkill = new Attack("Shoot an Arrow", 20);
    private Attack rangerSkill2 = new Attack("Throw a knife", 15);
    public Ranger() : base("Legolas"){
        AttackList = new List<Attack>(){
            rangerSkill, rangerSkill2
        };
    }

    public void Dash(){
        Distance = 20;
    }

    public override void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        if(Distance > 19){
            if(Target._Health < 0){
                Console.WriteLine($"You cannot attack someone who is dead.");
            }else{
                Target._Health -= ChosenAttack.DamageAmount;
                Console.WriteLine($"{Name} attacks {Target.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target._Health}!!");        
            }
        }else{
            Console.WriteLine($"Unable to perform the attack because you are too close");
        }
    }




}
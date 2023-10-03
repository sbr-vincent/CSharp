using System.Reflection.PortableExecutable;

class Caster : Enemy{
    // public readonly int MaxHealth = 80;
    public Caster() : base("Merlin"){
        _Health = 80;
        AttackList = new List<Attack>(){
            new Attack("Fireball", 25),
            new Attack("Lighting Bolt", 20),
            new Attack("Staff Strike", 10)
        };
        MaxHealth = 80;
    }

    public void Heal(Enemy Target){
        if(Target._Health + 40 > Target.MaxHealth){
            int RecoveredHealth = Target.MaxHealth - Target._Health;
            Target._Health = Target.MaxHealth;
            Console.WriteLine($"{Name} healed {Target.Name} for {RecoveredHealth} health points. Their health is now {Target._Health}");
        }else{
            Target._Health += 40;
            Console.WriteLine($"{Name} healed {Target.Name} for 40 health points. Their health is now {Target._Health}");

        }
    }


}
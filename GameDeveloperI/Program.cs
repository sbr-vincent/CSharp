Enemy villain = new ("Orin");
Attack skills = new ("Slice", 30);
Attack skills2 = new ("Gouge", 50);
Attack skills3 = new ("Poke", 15);

villain.AttackList.Add(skills);
villain.AttackList.Add(skills2);
villain.AttackList.Add(skills3);

Console.WriteLine(villain.RandomAttack());

Console.WriteLine(villain._Health);

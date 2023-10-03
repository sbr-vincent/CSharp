Melee barb = new Melee();
Ranger ranger = new Ranger();
Caster caster = new Caster();
barb.PerformAttack(ranger, barb.AttackList[1]);
Console.WriteLine(barb.Rage(caster));

ranger.PerformAttack(barb, ranger.AttackList[0]);
ranger.Dash();
ranger.PerformAttack(barb, ranger.AttackList[0]);

caster.PerformAttack(barb, caster.AttackList[0]);
caster.Heal(ranger);
caster.Heal(caster);



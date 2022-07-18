using WarriorStrategy;

Gun gun = new ();
Warrior warrior1 = new Warrior("Voin", 100, gun);
warrior1.GetWarriorInfo();

Console.WriteLine();

Sword sword = new();
Warrior warrior2 = new Warrior("Voin", 100, sword);
warrior2.GetWarriorInfo();
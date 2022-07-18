using AbstractFactory;

Hero elf = new (new ElfFactory(),100);
Hero voin = new(new VoinFactory(),100);


voin.ReciveDamage(elf.Hit());
Console.WriteLine("здоровье солдата: "+voin.Helth);


elf.ReciveDamage(voin.Hit());
Console.WriteLine("здоровье эльфа: " + elf.Helth);

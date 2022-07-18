var inst = Singleton.Singleton.GetInstance(10);
// пробуем присвоить новое значение
var inst2 = Singleton.Singleton.GetInstance(10000);

for (int i = inst2.Counter; i > 0; i--)
{
    Console.WriteLine(inst2.Counter);
    inst2.Decrement();
}

for(int i = inst2.Counter; i <= 10; i++)
{
    Console.WriteLine(inst2.Counter);
    inst2.Increment();
}
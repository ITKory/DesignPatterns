using FactoryMethod;
using System.Xml.Linq;

 void Print(IHouse house) {
    Console.WriteLine();
    Console.WriteLine("Затраты:" + house.Outlay);
    Console.WriteLine("Колличество комнат:" + house.ApartmentsCount);
    Console.WriteLine("Колличество этажей:" + house.FloorCount);
    Console.WriteLine("Рейтинг застройщика:" + house.Raiting);
    Console.WriteLine("Застройщик:" + house.DevName);

    if (house is PanelHouse)
        Console.WriteLine("Панели:" + (house as PanelHouse).PanelType);
    else
        Console.WriteLine("Дерево:"+(house as WoodHouse).WoodType);
    Console.WriteLine();


}


Developer dev = new PanelDeveloper("ООО КирпичСтрой","10");
IHouse house2 = dev.Create("100","10","500Mln" );

Print(house2);


dev = new WoodDeveloper("Частный застройщик","12");
IHouse house = dev.Create("500","30","950Mln");
 
Print(house);   
 

 

 
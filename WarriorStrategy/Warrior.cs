using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorStrategy
{
    public class Warrior
    {

        public int Helth { get;  protected set ; }
        public string Name { get; protected set ; }
        public IWeapon Weapon { private get;  set ; }

        public Warrior( string name, int helth, IWeapon weapon )
        {
            Weapon = weapon;
            Name = name;
            Helth = helth;  

        }

        public void GetWarriorInfo()
        {
            Console.WriteLine($"Name: {Name}\nHelth: {Helth}\nWeapon name: {Weapon.Name}\nWeapon damage:{Weapon.Damage}");
        }


    }
}

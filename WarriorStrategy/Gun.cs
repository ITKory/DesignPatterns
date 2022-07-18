using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorStrategy
{
    public class Gun : IWeapon
    {
        public int Damage { get; set; } = 100;
        public string Name { get; set; } = "Anigeliatornay pyshka";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorStrategy
{
    public class Sword : IWeapon
    {
        public int Damage { get; set; } = 10000;
        public string Name { get; set; } = "Typo Sword";
    }
}

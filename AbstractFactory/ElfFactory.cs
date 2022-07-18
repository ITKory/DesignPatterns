using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ElfFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new Fly();
        }

        public override Weapoon CreateWeapoon()
        {
            return new Arbalet();
        }
    }
}

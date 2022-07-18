using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class VoinFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new Run();
        }

        public override Weapoon CreateWeapoon()
        {
            return new Sword();
        }
    }
}

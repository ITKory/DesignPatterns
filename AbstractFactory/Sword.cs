using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Sword : Weapoon
    {
        public override int Hit()
        {
            Console.WriteLine("Удар мечем");
            return 30;
        }
    }
}

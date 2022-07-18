using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Arbalet : Weapoon
    {
        public override int Hit()
        {
            Console.WriteLine("Стрельба из арбaлета");
            return 10;
        }
    }
}

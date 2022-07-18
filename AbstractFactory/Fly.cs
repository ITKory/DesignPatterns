using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Fly : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Лечу");
        }
    }
}

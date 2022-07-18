using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Developer
    {
        public string Name { get; set; }
        public string Raiting { get; set; }

        public Developer(string n,string r)
        {
            Name = n;
            Raiting = r;
        }
        abstract public IHouse Create(string apartmentsCount, string floorCount, string outlay);
    }
}

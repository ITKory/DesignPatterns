using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class WoodDeveloper : Developer
    {
        public WoodDeveloper(string n,string r) : base(n,r)
        { }


        public override IHouse Create(string apartmentsCount, string floorCount, string outlay)
        {
            return new WoodHouse
            {
                ApartmentsCount = apartmentsCount,
                FloorCount = floorCount,
                Outlay = outlay,
                WoodType = "Сосна",
                Raiting = Raiting,
                DevName = Name

            };
        }
    }
}

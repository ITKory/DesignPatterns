using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class PanelDeveloper:Developer
    {
        public PanelDeveloper(string n,string r) : base(n,r)
        { }


        public override IHouse Create(string apartmentsCount, string floorCount,string outlay)
        {
            return new PanelHouse
            {
                ApartmentsCount =  apartmentsCount,
                FloorCount = floorCount,
                Outlay = outlay,
                PanelType = "Железобетонные",
                Raiting = Raiting,
                DevName = Name

            };
        }
    }
}

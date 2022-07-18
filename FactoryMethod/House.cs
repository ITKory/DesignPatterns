using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public interface IHouse
    {
        public string FloorCount { get; set; }
        public string ApartmentsCount { get; set; }
        public string Outlay { get; set; }
        public string DevName { get; set; }
        public string Raiting { get; set; }
    }
}

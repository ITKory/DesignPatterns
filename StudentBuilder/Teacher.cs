using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBuilder
{
    internal class Teacher : IPerson
    {
        public int Age { get ; set  ; }
        public string Name { get ; set  ; }
        public List<string> Groups{ get ; set  ; }
        public string CoreSubject { get ; set ; }
    }
}

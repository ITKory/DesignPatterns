using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBuilder
{
    public class Student : IPerson
    {
        public int Age { get ; set  ; }
        public string Name { get ; set  ; }
        public string Faculty { get ; set ; }
        public string Group { get ; set ; }
        public int Course { get ; set ; }
    }
}

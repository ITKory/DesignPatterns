using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBuilder
{
    public interface IBuilder
    {
        void BuildPerson(string name, int age);

        IPerson GetPerson();
    }
}

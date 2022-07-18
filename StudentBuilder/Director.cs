using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBuilder
{
    public class Director
    {

        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }
        public void CreatePerson(string name, int age) => _builder.BuildPerson(name, age);

        public IPerson? FillInfo()
        {
            IPerson person;
            if (_builder is StudentBuild )
            {
                (_builder as StudentBuild)?.FillStudentInfo("ПВ012", "РПО", 3);
                person = _builder.GetPerson();
            }
            else if (_builder is TeacherBuild)
            {
                (_builder as TeacherBuild)?.FillTeacherInfo(new List<string> { "РПО", "ПВО" }, "C#");
                person = _builder.GetPerson();
            }
            else
                return null;

            return person;
        }
    }
}

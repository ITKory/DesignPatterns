using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBuilder
{
    public class TeacherBuild : IBuilder
    {
        Teacher _teacher;
        public TeacherBuild()
        {
            _teacher = new();
        }

        public void BuildPerson(string name, int age)
        {
            _teacher.Name = name;
            _teacher.Age = age;
        }

        public void FillTeacherInfo(List<string> groups, string coreSubject )
        {
            _teacher.CoreSubject = coreSubject;
            _teacher.Groups = groups;
        }
        public IPerson GetPerson()
        {
            Teacher teacher = _teacher;
            _teacher = new();
            return teacher;
        }
    }
}

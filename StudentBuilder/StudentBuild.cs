using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBuilder
{
    public class StudentBuild : IBuilder
    {
        Student _student;
        public StudentBuild()
        {
            _student = new Student();
        }

        public void BuildPerson(string name, int age)
        {
            _student.Name = name;
            _student.Age = age;
        }

       public void FillStudentInfo(string group,string facult, int course )
        {
            _student.Course = course;
            _student.Faculty = facult;
            _student.Group = group;
        }

        public IPerson GetPerson()
        {
            Student student = _student;
            _student = new();
            return student;
        }
    }
}

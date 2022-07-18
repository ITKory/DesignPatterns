using StudentBuilder;
var director = new Director();

director.Builder = new StudentBuild();
director.CreatePerson("Alex", 18);
Student? alex  = director.FillInfo() as Student;
if (alex is not null)
    Console.WriteLine($"Name: {alex.Name}\nAge: {alex.Age}\nGroup: {alex.Group}\nFaculty: {alex.Faculty}\nCourse: {alex.Course}");

Console.WriteLine();

director.Builder = new TeacherBuild();
director.CreatePerson("Andrey", 30);
Teacher? Andrey = director.FillInfo() as Teacher;
if (Andrey is not null)
    Console.WriteLine($"Name: {Andrey.Name}\nAge: {Andrey.Age}\nGroup: {Andrey.Groups}\nCoreSubject: {Andrey.CoreSubject}");

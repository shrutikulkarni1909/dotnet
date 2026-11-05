using StudentLibrary;

StudentService service=new StudentService();

service.AddStudent(new Student(1, "Alex", "IT"));
service.AddStudent(new Student(2, "Ben", "CS"));
service.AddStudent(new Student(3, "Priya", "Electronics"));

List<Student> students=service.GetStudents();
Console.Write("Student records: ");

foreach (Student student in students)
{
    Console.WriteLine($"ID: {student.StudentId}");
    Console.WriteLine($"Name: {student.Name}");
    Console.WriteLine($"Course: {student.Course}");
}
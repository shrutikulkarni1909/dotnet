using StudentCourseManagement.Models;
using StudentCourseManagement.Services;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("==================================");
        Console.WriteLine("     TRANSFLOWER STUDENT SYSTEM");
        Console.WriteLine("==================================");
        Console.WriteLine();

        // Create two Course objects
        Course course1 = new Course(101, "C# Programming", "6 weeks");
        Course course2 = new Course(102, "ASP.NET Core", "8 weeks");

        // Create three Student objects
        Student student1 = new Student(1, "Amit", 85);
        Student student2 = new Student(2, "Sneha", 90);
        Student student3 = new Student(3, "Rahul", 78);

        // Create EnrollmentService object
        EnrollmentService enrollmentService = new EnrollmentService();

        // Enroll students into courses
        enrollmentService.Enroll(student1, course1);
        enrollmentService.Enroll(student2, course2);
        enrollmentService.Enroll(student3, course1);

        Console.WriteLine("----------------------------------");
        Console.WriteLine($"Total Students Created: {Student.TotalStudents}");
        Console.WriteLine("----------------------------------");
    }
}
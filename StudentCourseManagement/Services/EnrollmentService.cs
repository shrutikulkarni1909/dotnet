using StudentCourseManagement.Models;
namespace StudentCourseManagement.Services;

public class EnrollmentService{
    public void Enroll(Student student, Course course){
        if(student == null){
            Console.WriteLine("Invalid student.");
            return;
        }
        if(course == null){
            Console.WriteLine("Invalid course.");
            return;
        }
        Console.WriteLine($"Student: {student.StudentName}");
        Console.WriteLine($"Course : {course.Title}");
        Console.WriteLine();

    }
}
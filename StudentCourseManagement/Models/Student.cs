namespace StudentCourseManagement.Models;

public class Student{
    public int StudentId{get; private set;}
    public string StudentName{get; private set;}
    public int Marks{get; private set;}

    public static int TotalStudents{get; private set;}

    public Student(int studentId, string studentName, int marks){
        StudentId=studentId;
        StudentName=studentName;
        
        UpdateMarks(marks);
        TotalStudents++;
    }

    public void UpdateMarks(int marks){
        if(marks<0 || marks>100){
            throw new ArgumentException("Marks must be between 0 and 100.");
        }
        Marks=marks;
    }

    public void Display(){
        Console.WriteLine($"Student ID: {StudentId}");
        Console.WriteLine($"Student Name: {StudentName}");
        Console.WriteLine($"Marks: {Marks}");
    }

}
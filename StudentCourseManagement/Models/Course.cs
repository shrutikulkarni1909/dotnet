namespace StudentCourseManagement.Models;

public class Course{
    public int CourseId {get;private set;}
    public string Title { get; private set; }
    public string Duration { get; private set; }

     public Course(int courseId, string title, string duration)
    {
        CourseId = courseId;
        Title = title;
        Duration = duration;
    }

    public void Display()
    {
        Console.WriteLine($"Course ID: {CourseId}");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Duration: {Duration}");
    }
}

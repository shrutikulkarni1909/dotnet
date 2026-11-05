namespace StudentLibrary;

public class StudentService
{
    private List<Student> students =new List<Student>();

    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public List<Student> GetStudents()
    {
        return students;
    }

    public int GetStudentCount()
    {
        return students.Count;
    }
}

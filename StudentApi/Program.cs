using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

string filePath = Path.Combine(app.Environment.ContentRootPath,"students.json");
var options = new JsonSerializerOptions{
    PropertyNameCaseInsensitive= true
};

//Reads student data from JSON file and stores into dictionary
async Task<List<Student>> ReadStudents()
{
    if(!File.Exists(filePath))
    {
        return new List<Student>();
    }

    string json=await File.ReadAllTextAsync(filePath);
    Console.WriteLine(json);
    return JsonSerializer.Deserialize<List<Student>>(json, options) ?? new List<Student>();
}

//Save students data into JSON file
async Task SaveStudents(List<Student> students)
{
    string json=JsonSerializer.Serialize(students, options);
    await File.WriteAllTextAsync(filePath, json);
}

app.MapGet("/api/students", async () =>
{
    var students = await ReadStudents();
    return Results.Ok(students);
});

app.MapGet("/api/students/{id:int}", async (int id) =>{
    var students = await ReadStudents();
    var student=students.FirstOrDefault(s => s.Id ==id);

    if(student == null)
       return Results.NotFound();

    return Results.Ok(student);

});

app.MapPost("api/students", async (Student student) =>{
    var students = await ReadStudents();

    if(string.IsNullOrWhiteSpace(student.Name))
       return Results.BadRequest("Student name is required.");

    student.Id = students.Count ==0
        ? 1
        : students.Max(s => s.Id) +1;
    students.Add(student);

    await SaveStudents(students);

    return Results.Created(
        $"/api/students/{student.Id}", student
    );
});

app.MapPut("/api/students/{id:int}", async(
    int id, Student updatedStudent) =>{
        var students = await ReadStudents();
        var student = students.FirstOrDefault( s => s.Id == id);

        if(student==null)
            return Results.NotFound();
        
        if(string.IsNullOrWhiteSpace(updatedStudent.Name))
            return Results.BadRequest("Student name is required");
        
        student.Name = updatedStudent.Name;
        student.Age = updatedStudent.Age;
        student.Course= updatedStudent.Course;
        student.CGPA= updatedStudent.CGPA;

        await SaveStudents(students);
        return Results.Ok(student);
    }
);

app.MapDelete("api/students/{id:int}", async (int id)=>
{
    var students = await ReadStudents();
    var student = students.FirstOrDefault(s => s.Id == id);

    if(student == null)
        return Results.NotFound();

    students.Remove(student);
    await SaveStudents(students);

    return Results.Ok("Student deleted successfully.");
});

app.Run();

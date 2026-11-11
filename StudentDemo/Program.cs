using System;

public class Student{
    public int StudentId{get; private set;}
    public string Name{get; private set;}
    public int Marks{get; private set;}
    public Date DateOfBirth{get; private set;}

    public Student(int studentId, string name, int marks, Date dateOfBirth){
        StudentId=studentId;
        Name=name;
        Marks=marks;
        DateOfBirth=dateOfBirth;

    }

    public void display(){
        Console.WriteLine($"Student ID: {StudentId} \nName: {Name} \nMarks: {Marks} \nDate of Birth: {DateOfBirth}");
    }

    public void CalculateResult(){
        if(Marks>=35){
            Console.WriteLine("Result: Pass");
        }
        else{
            Console.WriteLine("Result: Fail");
        }
    }    
}

public class Date{
    public int Day{get; private set;}
    public int Month{get; private set;}
    public int Year{get; private set;}

    public Date(int day, int month, int year){
        Day=day;
        Month=month;
        Year=year;
    }

    public override string ToString(){
        return $"{Day}/{Month}/{Year}";
    }
}

public class Program{
    public static void Main(string[] args){
        Date dob=new Date(7,5,2003);
        Student student=new Student(101, "Amit", 78,dob);
        student.display();
        student.CalculateResult();

    }
}
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine() ?? "";

        int[] marks = new int[5];
        int total=0;

        for(int i=0;i<marks.Length; i++){
            Console.Write($"Enter Subject {i+1} Marks: ");
            if(!int.TryParse(Console.ReadLine(), out marks[i]) || marks[i] < 0 || marks[i] > 100)
            {
                Console.WriteLine("Invalid Marks");
                return;
            }
            total+=marks[i];
        
        }
            double percentage = total / 5.0;
        

        Console.WriteLine("\n--- Student Result ---");

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Total: {total}");
        Console.WriteLine($"Percentage: {percentage}%");

        if (Array.Exists(marks, mark => mark < 35))
        {
            Console.WriteLine("Result: Fail");
        }
        else
        {
            Console.WriteLine("Result: Pass");
        }
    }
}


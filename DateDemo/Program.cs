using System;

public class Date{
    public int Day{get; private set;}
    public int Month{get; private set;}
    public int Year{get; private set;}

    public Date(int day, int month, int year)
    {
        Day=day;
        Month=month;
        Year=year;
    }

    public void Show(){
        Console.WriteLine($"{Day}/{Month}/{Year}");
    }

    public bool IsLeapYear(){
        return Year % 400 == 0 || (Year % 4 == 0 && Year % 100 !=0);
    }

    public override string ToString(){
        return $"{Day}/{Month}/{Year}";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Date today = new Date (12, 10, 2025);
        Date birthday = new Date(5, 7, 2003);

        today.Show();
        birthday.Show();

        Console.WriteLine(today);
        Console.WriteLine($"Is LeapYear: {today.IsLeapYear()}");
    }
}
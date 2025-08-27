using System;


public class Employee
{
    public string FirstName;
    public string LastName;
    string Email;

    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }

}

public class FulltimeEmployee : Employee
{
    float AnnualSalary;
}

public class ParttimeEmployee : Employee
{
    float HourlyRate;
}


public class Program
{
    public static void Main()
    {
        FulltimeEmployee FTE = new FulltimeEmployee();
        FTE.FirstName = "Lakshmi";
        FTE.LastName = "Vishnu";
        FTE.PrintFullName();
    }
}
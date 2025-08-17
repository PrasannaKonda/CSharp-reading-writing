using System;

class Program
{
    static void Main()
    {
        // Calling Static method
        Program.EvenNumbers(30);
        //Calling Instance method
        Program p = new Program();
        int Sum = p.Add(5, 10);
        Console.WriteLine(Sum);
    }

    // Instance method to add two numbers
    public int Add(int fn, int sn)
    {
        return fn + sn;
    }

    // Static method to print even numbers up to a target number
    public static void EvenNumbers(int Target)
    {
        int Start = 0;
        while (Start <= Target)
        { 
            Console.WriteLine(Start);
            Start += 2;
        }
    }
}
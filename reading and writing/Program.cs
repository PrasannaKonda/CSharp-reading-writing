using System;

class Program
{
    static void Main()
    {
        Program.EvenNumbers();
    }

    public static void EvenNumbers()
    {
        int Start = 0;
        while (Start <= 20)
        { 
            Console.WriteLine(Start);
            Start += 2;
        }
    }
}
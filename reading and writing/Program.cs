using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter your target?");
        int UserTarget = int.Parse(Console.ReadLine());

        int Start = 0;

        while(Start <= UserTarget)
        {
            //Console.WriteLine(Start);   //it prints values in a new line
            Console.Write(Start+" ");   //it's print the values in same line with a space
            Start += 2;
        }
    }
}
using System;

class Program
{
    static void Main()
    {
        int i = 0;
        SimpleMethod(i);
        Console.WriteLine(i); // Output: 0
    }

    //Value Parameter Example
    public static void SimpleMethod(int j)
    {
        j = 101;
    }
}
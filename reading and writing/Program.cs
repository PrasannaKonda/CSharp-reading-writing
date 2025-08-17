using System;

class Program
{
    static void Main()
    {
        int i = 0;
        SimpleMethod(ref i);
        Console.WriteLine(i); // Output: 101
    }

    //Reference Parameter Example
    public static void SimpleMethod(ref int j)
    {
        j = 101;
    }
}
using System;

class Program
{
    static void Main()
    {
        int Total = 0;
        int Product = 0;
        Calculate(10,20, out Total, out Product);
        Console.WriteLine("Sum = {0}, Product = {1}", Total, Product);
    }

    //Out parameters are used to return multiple values from a method.
    public static void Calculate(int FN, int SN, out int Sum, out int Product)
    {
        Sum = FN + SN;
        Product = FN * SN;
    }
}
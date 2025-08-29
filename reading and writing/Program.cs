using System;

public delegate void HelloFunctionDelegate(string Message);
public class Program
{
    public static void Main()
    {
        //Delegate is a type safe function pointer
        HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
        del("Hello from delegates");
    }

    public static void Hello(string strMessage)
    {
        Console.WriteLine(strMessage);
    }
}
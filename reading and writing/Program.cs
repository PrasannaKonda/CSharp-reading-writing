using System;

class Program
{
    static void Main() {
        string strNumber = "100";
        int number = int.Parse(strNumber);  // Parse the string to an integer
        Console.WriteLine($"The number is: {number}");
        Console.WriteLine(strNumber);
    }

    //Example for TryParse
    static void ExampleTryParse() {
        string strNumber = "1234";
        int Result = 0;
        bool IsConvertionSuccessful = int.TryParse(strNumber, out Result);
        if (IsConvertionSuccessful)
        {
            Console.WriteLine(Result);
        }
        else {
            Console.WriteLine("Please Enter Valid Number");
        }
        
    }
}
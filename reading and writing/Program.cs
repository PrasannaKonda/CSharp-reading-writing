using System;

class Program {
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        int UserNumber = int.Parse(Console.ReadLine());
        //Joining multiple cases in a switch statement
        switch (UserNumber)
        {
            case 10:
            case 20:
            case 30:
                Console.WriteLine("Your Number is {0}", UserNumber);
                break;
            default:
                Console.WriteLine("your number is not 10, 20 or 30");
                break;
        }

    }
}


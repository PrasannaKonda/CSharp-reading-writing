using System;

class Program
{
    static void Main()
    {
        string UserChoice = string.Empty;
        do
        {
            Console.WriteLine("Please enter your target?");
            int UserTarget = int.Parse(Console.ReadLine());

            int Start = 0;

            while (Start <= UserTarget)
            {
                //Console.WriteLine(Start);   //it prints values in a new line
                Console.Write(Start + " ");   //it's print the values in same line with a space
                Start += 2;
            }


            do
            {
                Console.WriteLine("Do you want to continue - Yes or No?");
                UserChoice = Console.ReadLine().ToUpper();
                if (UserChoice != "YES" && UserChoice != "NO")
                {
                    Console.WriteLine("Invalid Choice. Please say Yes or No.");
                }
            } while (UserChoice != "YES" && UserChoice != "NO");
        } while (UserChoice == "YES");
    }
}
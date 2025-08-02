using System;

class Program
{
    static void Main()
    {
        // here trying to explain the scenario of nullable value type i.e, user has a chance to not to specify he is major or not
        bool? AreYouMajor = null;  //here bool is a value type

        if (AreYouMajor == true)
        {
            Console.WriteLine("User is major.");
        }
        else if (AreYouMajor == false)
        {
            Console.WriteLine("User is not major.");
        }
        else
        {
            Console.WriteLine("User not Answer the Question.");
        }
    }
}
using System;

class Program
{
    static void Main() {
        int i = 100;
        float f = i; // Implicit conversion from int to float
        //Console.WriteLine(f);

        float f2 = 100.25F;
        int i2 = (int)f2; // Explicit conversion from float to int
        //Console.WriteLine(i2);

        //Or use convert class
        int i3 = Convert.ToInt32(f2); // Using Convert class for conversion
        Console.WriteLine(i3);
    }
}
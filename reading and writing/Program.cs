using System;

public class ParentClass
{
    public ParentClass()
    {
        Console.WriteLine("ParentClass Constructor Called");
    }
}

public class ChildClass : ParentClass
{
    public ChildClass()
    { 
        Console.WriteLine("ChildClass Constructor Called");
    }

}

public class Program 
{
    public static void Main()
    { 
        ChildClass child = new ChildClass();
    }
}
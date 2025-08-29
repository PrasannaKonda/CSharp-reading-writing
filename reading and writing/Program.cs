interface I1
{
    void InterfaceMethod();
}

interface I2
{
    void InterfaceMethod();
}

public class  Program : I1, I2
{
    public void InterfaceMethod()
    {
        Console.WriteLine("I1 Interface Method");
    }
    void I2.InterfaceMethod()
    {
        Console.WriteLine("I2 Interface Method");
    }
    public static void Main()
    {
        //Explicit interface implementation
        //Program p = new Program();
        //((I1)p).InterfaceMethod();
        //((I2)p).InterfaceMethod();

        //I1 i1 = new Program();
        //I2 i2 = new Program();
        //i1.InterfaceMethod();
        //i2.InterfaceMethod();

        //Default and Explicit interface implementation
        Program p = new Program();
        p.InterfaceMethod();
        I2 i2 = new Program();
        i2.InterfaceMethod();
    }
}
using System;

public struct Customer
{
    private int _id;
    private string _name;

    public int Id
    {
        get { return this._id; }
        set { this._id = value; }
    }

    public string Name
    {
        get { return this._name; }
        set { this._name = value; } 
    }

    public Customer()
    { 
    
    }

    public Customer(int Id, string Name)
    {
        this._id = Id;
        this._name = Name;
    }

    public void PrintDetails()
    {
        Console.WriteLine("ID = {0} && Name = {1}", this._id, this._name);
    }

}

public class  Program
{
    public static void Main()
    {
        Customer c1 = new Customer(101, "Lakshmi");
        c1.PrintDetails();

        Customer c2 = new Customer();
        c2.Id = 102;
        c2.Name = "Vishnu";
        c2.PrintDetails();

        Customer c3 = new Customer
        {
            Id = 103,
            Name = "Jaswik"
        };
        c3.PrintDetails();
    }
}
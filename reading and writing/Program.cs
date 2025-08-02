//Null Coalescing Assignment Operator
using System;

class Program
{
    static void Main()
    {
      int? TicketsOnSale = null;
        int AvailableTickets;
        if (TicketsOnSale == null)
        {
            AvailableTickets = 0; // Default value if TicketsOnSale is null
        }
        else
        {
            AvailableTickets = TicketsOnSale.Value;
            //AvailableTickets = (int)TicketsOnSale; 
        }
        Console.WriteLine('Available Tickets = {0}',AvailableTickets);
    }
}

//Implementing Null Coalescing Assignment Operator

using System;

class Program
{
    static void Main1()
    {
        int? TicketsOnSale = 100;
        int AvailableTickets = TicketsOnSale ?? 0; // Using null coalescing operator
        Console.WriteLine("Available Tickets = {0}", AvailableTickets);
    }
}

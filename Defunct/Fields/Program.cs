// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;

namespace Fields
{

    class Program
    { 
        
        static void Main(string[] args)
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Customer.Order());
            customer.Orders.Add(new Customer.Order());

            Console.WriteLine(customer.Orders.Count);
        }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address("123 Elm St", "Orlando", "FL", "USA");
        Customer customer1 = new Customer("Matt Nunes", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Phone", "T001", 5.50, 3));
        order1.AddProduct(new Product("Charger", "T002", 2.25, 4));

        Console.WriteLine(order1.CreatePacking());
        Console.WriteLine(order1.CreateShipping());
        Console.WriteLine($"Total: ${order1.CalculateTotal()}\n");
        Console.WriteLine("--------------------");


        Address address2 = new Address("444 Pan Rd", "Miami", "FL", "USA");
        Customer customer2 = new Customer("Laura Nunes", address1);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Book", "L001", 15.20, 2));
        order2.AddProduct(new Product("Pen", "L002", 1.05, 8));

        Console.WriteLine(order2.CreatePacking());
        Console.WriteLine(order2.CreateShipping());
        Console.WriteLine($"Total: ${order2.CalculateTotal()}\n");
        Console.WriteLine("--------------------");
    }
}
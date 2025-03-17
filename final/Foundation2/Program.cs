using System;

class Program
{
    static void Main()
    {
        Address address1 = new Address("0984 Main St", "Los Angeles", "CA", "USA");
        Address address2 = new Address("3111 Maple Ave", "Toronto", "ON", "Canada");
        
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);
        
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);
        
        order1.AddProduct(new Product("Laptop", "P1001", 1200, 1));//the products in question
        order1.AddProduct(new Product("Mouse", "P1002", 25, 2));
        order2.AddProduct(new Product("Keyboard", "P2001", 45, 1));
        order2.AddProduct(new Product("Monitor", "P2002", 200, 1));
        order2.AddProduct(new Product("USB Drive", "P2003", 15, 3));
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("\nTotal Price: " + order1.GetTotalPrice());
        Console.WriteLine("\n--------------------------------\n");//big spacer 
        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("\nTotal Price: " + order2.GetTotalPrice());
    }
}
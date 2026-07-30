using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.\n");

        Address address1 = new Address("123 Main St", "Los Angeles", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1); 
        
        Product p1 = new Product("Laptop", 101, 899.99, 1);
        Product p2 = new Product("Wireless Mouse", 102, 25.50, 2);
        
        order1.AddProduct(p1);
        order1.AddProduct(p2);
        
        Console.WriteLine("--- ORDER 1 ---");
        Console.WriteLine("SHIPPING LABEL:\n" + order1.GetDisplayShipping());
        Console.WriteLine("\nPACKING LABEL:\n" + order1.GetPacking());
        Console.WriteLine($"TOTAL PRICE: ${order1.DisplayTotal()}");
        Console.WriteLine("==========================================\n");

        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);
        
        Product p3 = new Product("Monitor", 201, 199.99, 1);
        Product p4 = new Product("Keyboard", 202, 45.00, 1);
        Product p5 = new Product("USB Cable", 203, 10.00, 3);
        
        order2.AddProduct(p3);
        order2.AddProduct(p4);
        order2.AddProduct(p5);
        
        Console.WriteLine("--- ORDER 2 ---");
        Console.WriteLine("SHIPPING LABEL:\n" + order2.GetDisplayShipping());
        Console.WriteLine("\nPACKING LABEL:\n" + order2.GetPacking());
        Console.WriteLine($"TOTAL PRICE: ${order2.DisplayTotal()}");
        Console.WriteLine("==========================================");
    }
}
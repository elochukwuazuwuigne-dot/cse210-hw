using System;

class Program
{
    static void Main(string[] args)
    {
        // First Order
        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        Product product1 = new Product("Laptop", "P100", 800, 1);
        Product product2 = new Product("Mouse", "P101", 25, 2);

        Order order1 = new Order(customer1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Second Order
        Address address2 = new Address(
            "45 King Road",
            "Toronto",
            "Ontario",
            "Canada"
        );

        Customer customer2 = new Customer("Sarah Johnson", address2);

        Product product3 = new Product("Phone", "P200", 600, 1);
        Product product4 = new Product("Headphones", "P201", 50, 3);

        Order order2 = new Order(customer2);

        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Display First Order
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

        Console.WriteLine("\n------------------------\n");

        // Display Second Order
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}
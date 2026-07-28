using System;

class Program
{
    static void Main(string[] args)
    {

        // First Order in USA
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Francisco De Leon", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product("Laptop", "P001", 858.00, 1);
        Product product2 = new Product("Mouse", "P002", 27.00, 2);

        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}\n");

        Console.WriteLine("====================================\n");

        // Second Order outside USA
        Address address2 = new Address("456 Real St", "Guatemala City", "Guatemala", "Guatemala");
        Customer customer2 = new Customer("Milly Roman", address2);
        Order order2 = new Order(customer2);

        Product product3 = new Product("Keyboard", "P003", 50.00, 1);
        Product product4 = new Product("Monitor", "P004", 200.00, 2);
        Product product5 = new Product("HDMI Cable", "P005", 10.00, 3);

        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}\n");
    }
}
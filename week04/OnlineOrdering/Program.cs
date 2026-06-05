using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        // ADDRESSES
        Address address1 = new Address(
            "123 Main Street",
            "Dallas",
            "Texas",
            "USA"
        );

        Address address2 = new Address(
            "15 Allen Avenue",
            "Ikeja",
            "Lagos",
            "Nigeria"
        );

        // CUSTOMERS
        Customer customer1 = new Customer(
            "John Smith",
            address1
        );

        Customer customer2 = new Customer(
            "Alex Ghost",
            address2
        );

        // PRODUCTS
        Product hplaptop = new Product(
            01,
            150000,
            "Laptop",
            "30"
        );

        Product mouse = new Product(
            02,
            2000,
            "Mouse",
            "200");

        Product keyboard = new Product(
            03,
            10000,
            "Keyboard",
            "40"
        );

        Product macbook = new Product(
            04,
            450000,
            "Macbook",
            "3"
        );
       

        Product headphones = new Product(
            05,
            50,
            "Headphones",
            "40"
        );

        // The Order 1
        Order order1 = new Order(1001, customer1);

        order1.AddProduct(hplaptop);
        order1.AddProduct(mouse);
        order1.AddProduct(keyboard);

        // The Order 2
        Order order2 = new Order(1002, customer2);

        order2.AddProduct(macbook);
        order2.AddProduct(headphones);

        // Display order 1
        Console.WriteLine("====================================");
        Console.WriteLine("ORDER 1");
        Console.WriteLine("====================================");

        Console.WriteLine("\nPACKING LABEL");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("\nSHIPPING LABEL");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"\nTOTAL PRICE: ${order1.GetTotalPrice()}");

        // Display order 2
        Console.WriteLine("\n====================================");
        Console.WriteLine("ORDER 2");
        Console.WriteLine("====================================");

        Console.WriteLine("\nPACKING LABEL");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("\nSHIPPING LABEL");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"\nTOTAL PRICE: ${order2.GetTotalPrice()}");

    }
    
}
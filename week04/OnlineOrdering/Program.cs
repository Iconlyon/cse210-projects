using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("28, Gana Street, Maitama", "Maitama", "Abuja", "Nigeria");
        Customer customer1 = new Customer("Daniel Abughdyer ", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop Stand", "LS100", 25.99, 2));
        order1.AddProduct(new Product("Wireless Mouse", "WM200", 15.50, 1));
        order1.AddProduct(new Product("USB-C Cable", "UC300", 8.75, 3));

        Address address2 = new Address("45 Unity Road", "Lagos", "Lagos State", "Nigeria");
        Customer customer2 = new Customer("Mary Johnson", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Notebook", "NB400", 6.99, 4));
        order2.AddProduct(new Product("Backpack", "BP500", 32.50, 1));
        order2.AddProduct(new Product("Water Bottle", "WB600", 12.25, 2));

        Console.WriteLine("ORDER 1");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order1.GetTotalCost():0.00}");
        Console.WriteLine("----------------------------------------");

        Console.WriteLine("ORDER 2");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order2.GetTotalCost():0.00}");
    }
}
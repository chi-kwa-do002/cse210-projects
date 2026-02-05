using System;

class Program
{
    static void Main(string[] args)
    {
    
        Address address1 = new Address("123 Main St", "Idaho", "ID", "USA");
        Customer customer1 = new Customer("John wiz", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Notebook", "A100", 3.50, 4));
        order1.AddProduct(new Product("Pen", "B200", 1.25, 10));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost()}\n");

        Address address2 = new Address("456 Queen St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Backpack", "C300", 45.00, 1));
        order2.AddProduct(new Product("Water Bottle", "D400", 12.00, 2));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost()}");
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("555 First Ave", "Malta", "ID", "USA");
        Customer cust1 = new Customer("George Washington", addr1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Toothbrush", "TB001", 2.99, 3));
        order1.AddProduct(new Product("Toothpaste", "TP002", 1.99, 2));

        Address addr2 = new Address("45 Lincoln St", "Burley", "ID", "USA");
        Customer cust2 = new Customer("Thomas Jefferson", addr2);
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Notebook", "NB123", 5.99, 4));
        order2.AddProduct(new Product("Pen Set", "PS456", 3.49, 1));
        order2.AddProduct(new Product("Backpack", "BP789", 24.99, 1));

        DisplayOrderDetails(order1);
        Console.WriteLine();
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalCost():0.00}");
    }
}

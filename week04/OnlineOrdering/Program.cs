using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Etsa St", "Accra", "ACC", "GHA");
        Address address2 = new Address("233 Demo St", "Kumasi", "KMS", "GHA");

        Customer customer1 = new Customer("William Boateng", address1);
        Customer customer2 = new Customer("Seth Adjei", address2);

        Product product1 = new Product("Shoe", "S001", 10.0, 2);
        Product product2 = new Product("Jacket", "J002", 15.0, 1);
        Product product3 = new Product("Sneaker", "S003", 7.5, 3);

        Product product4 = new Product("Backpack", "B004", 12.0, 4);
        Product product5 = new Product("Hoodie", "H005", 5.0, 5);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        List<Order> orders = new List<Order> { order1, order2 };
        int orderNumber = 1;

        foreach (Order order in orders)
        {
            Console.WriteLine($"Order #{orderNumber}");
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order.CalculateTotalPrice():0.00}");
            Console.WriteLine("-----------------------------\n");
            orderNumber++;
        }
    }
}
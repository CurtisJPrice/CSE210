using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating address objects
        Address usaAddress1 = new Address("123 Main St", "Apt, 112", "Rexburg", "ID", "USA");
        Address usaAddress2 = new Address("456 Neptune St", "Dallas", "MN", "USA");
        Address nonUsaAddress = new Address ("789 Elmo St", "Joliette", "QC", "Canada");

        // Creating cust objects with addresses
        Customer usaCustomer1 = new Customer("Emma Jones", usaAddress1);
        Customer usaCustomer2 = new Customer("Hyrum Smith", usaAddress2);
        Customer nonUsaCustomer = new Customer("Robyn Matthews", nonUsaAddress);

        // Create product objects
        Product product1 = new Product("Sparkling Cider", "P001", 3.68, 1);
        Product product2 = new Product("Barbie Doll", "P002", 10.99, 2);
        Product product3 = new Product("Ceramic Ornaments", "P003", 16.75, 5);
        Product product4 = new Product("Necklace", "P004", 14.99, 3);
        Product product5 = new Product("Socks", "P005", 9.00, 10);

        // Create orders and add products
        Order order1 = new Order(usaCustomer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(usaCustomer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Order order3 = new Order(nonUsaCustomer);
        order3.AddProduct(product5);
        order3.AddProduct(product2);
        order3.AddProduct(product3);

        // Display order info
        DisplayOrderInfo(order1);
        DisplayOrderInfo(order2);
        DisplayOrderInfo(order3);
    }
    
    static void DisplayOrderInfo(Order order)
    {
        Console.WriteLine("--------- Order ---------");
        Console.WriteLine("     Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine("     Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"\n     Total Price: ${order.GetTotalPrice():F2}");
        Console.WriteLine();
    }
}
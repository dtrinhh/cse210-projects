using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the ordering system, here are the current orders we need to fufil: ");
        Console.WriteLine();

        string product1 = "Small Shirt";
        string product2 = "Medium Shirt";
        string product3 = "Large Shirt";
        string product4 = "XL Shirt";
        
        double productPrice = 29.99;

        int orderQuantity = 4;

        // Order1 related actions
        Order order1 = new Order();

        Product order1ProductSet1 = new Product(product4, productPrice, orderQuantity);
        order1.AddOrder(order1ProductSet1);

        orderQuantity = 3;
        Product order1ProductSet2 = new Product(product1, productPrice, orderQuantity);
        order1.AddOrder(order1ProductSet2);

        // Display Packing Label of Order1
        Console.WriteLine("Order 1");
        Console.WriteLine("Packing List:");
        order1.PackingLabel();
        Console.WriteLine();

        // Adding address to order1
        string street = "123 Rainbow rd";
        string city = "Portland";
        string stateProvince = "Oregon";
        string country = "USA";

        // Part of alt method to do create address for customer. 
        // Address address1 = new Address(street1, city1, stateProvince1, country1);
        // Customer customer1 = new Customer(customerName, address1);

        // Adding customer Name
        string customerName = "Dustin";

        // Displaying Shipping label
        Console.WriteLine("Shipping Label: ");
        Customer customer = new Customer(customerName, street, city, stateProvince, country);
        Console.WriteLine();

        // Adding customer name is order1
        order1.SetCustomer(customer);

        // Math for subtotal and shipping cost
        order1.OrderTotal();
        Console.WriteLine();



        // Order2 related actions
        Order order2 = new Order();

        orderQuantity = 1;
        Product order2ProductSet1 = new Product(product2, productPrice, orderQuantity);
        order2.AddOrder(order2ProductSet1);

        orderQuantity = 2;
        Product order2ProductSet2 = new Product(product3, productPrice, orderQuantity);
        order2.AddOrder(order2ProductSet2);

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing List:");
        order2.PackingLabel();
        Console.WriteLine();

        street = "789 Made Up st";
        city = "Toronto";
        stateProvince = "Ontario";
        country = "Canada";

        customerName = "Emily";

        Console.WriteLine("Shipping Label: ");
        customer = new Customer(customerName, street, city, stateProvince, country);
        Console.WriteLine();

        order2.SetCustomer(customer);

        order2.OrderTotal();
        Console.WriteLine();
    }
}
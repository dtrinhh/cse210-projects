using System;
using System.Runtime.CompilerServices;

public class Order
{
    private List<Product> _purchaseOrder = new List<Product>();
    // Am I interpreting this wrong? Is it suppose to be a list? Prob not.
    // private List<Customer> _customer = new List<Customer>();
    private Customer _customer;

    private double _orderTotal;

    private int _domesticShipping = 5;

    private int _internationalShipping = 35;

    private int _chosenShipping;

    private double _subtotal;


    public void AddOrder(Product product)
    {
        _purchaseOrder.Add(product);
    }
    
    public void PackingLabel()
    {
        foreach (Product p in _purchaseOrder)
        {
            Console.WriteLine($"Qty       Product                   Price         Total ");
            Console.WriteLine($"{p.GetProductQuantity()}         {p.GetProductName()} ({p.GetProductId()})         {p.GetProductPrice()}         {p.ProductTotal()}");
        }
    }

    public void ShippingLabel()
    {
        if (_customer.USACustomer() == true)
        {
            Console.WriteLine($"Shipping Cost: ${_domesticShipping}");
        }
        else
        {
            Console.WriteLine($"Shipping Cost: ${_internationalShipping}");
        }
    }

    public void OrderTotal()
    {
        foreach (Product p in _purchaseOrder)
        {
            _subtotal += p.ProductTotal();
            _orderTotal = _subtotal;
        }

        if (_customer.USACustomer() == true)
        {
            _orderTotal += _domesticShipping;
            _chosenShipping = _domesticShipping;
        }
        else
        {
            _orderTotal += _internationalShipping;
            _chosenShipping = _internationalShipping;
        }
        
        Console.WriteLine($"Subtotal: ${_subtotal}\nShipping: ${_chosenShipping}\nTotal: ${_orderTotal}");
    }

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }
}
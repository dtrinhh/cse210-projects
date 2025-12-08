using System;

public class Product
{
    private string _productName;

    private string _productId;

    private double _productPrice;

    private int _productQuantity;

    public int GetProductQuantity()
    {
        return _productQuantity;
    }
    public string GetProductId()
    {
        return _productId;
    }
    public double GetProductPrice()
    {
        return _productPrice;
    }
    public string GetProductName()
    {
        return _productName;
    }
    public double ProductTotal()
    {
        return _productPrice * _productQuantity;
    }

    // Good idea to make a constructor to auto assign the productId based off the product name or something similar.
    public Product(string productName, double productPrice, int productQuantity)
    {
        _productName = productName;
        // This can use an if statement to assign productId
        if (_productName.ToLower() == "small shirt") 
        {
            _productId = "Id.111";
        }
        else if (_productName.ToLower() == "medium shirt") 
        {
            _productId = "Id.112";
        }
        else if (_productName.ToLower() == "large shirt") 
        {
            _productId = "Id.113";
        }
        else if (_productName.ToLower() == "xl shirt") 
        {
            _productId = "Id.114";
        }
        _productPrice = productPrice;
        _productQuantity = productQuantity;
        
    }
    public Product(string productName, string productId, int productPrice, int productQuantity)
    {
        _productName = productName;
        _productId = productId;
        _productPrice = productPrice;
        _productQuantity = productQuantity;

    }
}
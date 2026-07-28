using System;

public class Product
{
    //Atributes
    private string _productName;
    private string _productId;
    private double _productPrice;
    private int _quantity;

    public Product(string productName, string productId, double productPrice, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _productPrice = productPrice;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _productPrice * _quantity;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public string GetProductID()
    {
        return _productId;
    }


}
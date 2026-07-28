using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetShippingCost()
    {
        if (_customer.LiveInUsa())
        {
            return 5.0;
        }
        else
        {
            return 35.0;
        }
    }

    public double CalculateTotalCost()
    {
        double totalProductsCost = 0.0;

        foreach (Product product in _products)
        {
            totalProductsCost += product.GetTotalCost();
        }

        return totalProductsCost + GetShippingCost();
    }

    public string GetPackingLabel()
    {
        string label = "--- PACKING LABEL ---\n";
        foreach (Product product in _products)
        {
            label += $"Product: {product.GetProductName()} | ID: {product.GetProductID()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = "--- SHIPPING LABEL ---\n";
        label += $"Customer: {_customer.GetName()}\n";
        label += $"Address:\n{_customer.GetCustomerAddress()}\n";
        return label;
    }
}
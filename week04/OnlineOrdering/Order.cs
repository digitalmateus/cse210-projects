using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotal()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalCost();
        }
        total += _customer.LivesInUSA() ? 5 : 35;
        return total;
    }

    public string CreatePacking()
    {
        string result = "Packing Label:\n";
        foreach (var product in _products)
        {
            result += $"{product.GetProductId()} - {product.GetName()}\n";
        }
        return result;
    }

    public string CreateShipping()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}
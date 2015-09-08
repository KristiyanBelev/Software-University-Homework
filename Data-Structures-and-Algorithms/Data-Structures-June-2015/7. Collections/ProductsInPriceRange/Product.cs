using System;

class Product : IComparable<Product>
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        this.Name = name;
        this.Price = price;
    }

    public int CompareTo(Product other)
    {
        return this.Price.CompareTo(other.Price);
    }
}
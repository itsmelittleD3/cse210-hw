class Order
{
    private Customer customer;
    private List<Product> products;
    
    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }
    
    public void AddProduct(Product product)
    {
        products.Add(product);
    }
    
    public double GetTotalPrice()
    {
        double total = 0;
        foreach (var product in products)
        {
            total += product.GetTotalCost();
        }
        
        double shippingCost;//changes based on if theyre in the us or not
        if (customer.IsInUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        
        return total + shippingCost;
    }
    
    public string GetPackingLabel()
    {
        List<string> labels = new List<string>();
        foreach (var product in products)
        {
            labels.Add(product.GetPackingLabel());
        }
        return string.Join("\n", labels);
    }
    
    public string GetShippingLabel()
    {
        return $"{customer.GetName()}\n{customer.GetAddress()}";
    }
}
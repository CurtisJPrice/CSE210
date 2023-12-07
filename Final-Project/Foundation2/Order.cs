public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order (Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach (var product in products)
        {
            totalPrice += product.Price * product.Quantity;
        }

        // Add shipping cost based on cust location
        if (customer.IsInUSA())
        {
            totalPrice += 5;
        }
        else
        {
            totalPrice += 35;
        }

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (var product in products)
        {
            label += $"Name: {product.Name}, ID: {product.ProductId}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Customer: {customer.Name}\nAddress: {customer.Address.GetFullAddress()}";
    }
}
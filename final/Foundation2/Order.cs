using static System.Console;

public class Order{
    private List<Product> _products = new List<Product>();
    private Customer _customer {get; set;}

    public Order (Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }   

    public double CalculateSubtotal() 
    {
        double subtotal = 0;
        foreach (Product product in _products)
        {
            double productPrice = product.CalculatePrice();
            subtotal += productPrice;
        }
        subtotal = Math.Round(subtotal, 2);

        return subtotal;
    }

    public double CalculateTotal()
    {
        double total = Math.Round((CalculateSubtotal() + _customer.GetShippingCost()),2);
        return total;
    }

        public void DisplayCosts(double subtotal, double shippingCost, double totalCost)
    {   
        WriteLine($"Subtotal: ${subtotal.ToString("F2")}");
        WriteLine($"Shipping: ${shippingCost.ToString("F2")}");
        WriteLine($"Total: ${totalCost.ToString("F2")}");
    }

     public void DisplayPackingLabel()
    {   
        WriteLine("Packing Label");
        foreach (Product product in _products)
        {
            product.DisplayProductInfo();
        }
        
    }
    public void DisplayShippingLabel()
    {   
        WriteLine("Shipping Label");
        WriteLine("SHIP TO: ");
        _customer.DisplayCustomer();
    }


}
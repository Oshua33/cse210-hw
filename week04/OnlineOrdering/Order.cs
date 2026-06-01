public class Order
{
    private int _orderId;
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    //constructor
    public Order(int orderId, Customer customer)
    {
        _orderId = orderId;
        _customer = customer;
    }

    //methood to add a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    //method for packing label
    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetProductName()} - {product.GetProductId()}\n";
        }
        return packingLabel;
    }


    //method for shipping label
    public string GetShippingLabel()
    {
        return _customer.GetCustomerInfo();
    }

    //method to calculate the total price of the order
    public int GetTotalPrice()
    {
        int _totalPrice = 0;
        foreach (Product product in _products)
        {
            _totalPrice += product.GetTotalPrice();
        }

        if (_customer.CustomerIsUSA())
        {
             // the shipping cost for USA
            _totalPrice += 5;
        }
        else
        {
            // shipping cost for international
            _totalPrice += 35; 
        }
        return _totalPrice;
    }
   
}
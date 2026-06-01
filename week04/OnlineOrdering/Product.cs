public class Product
{
    private int _productId;
    private int _price;
    private string _productname;
    private string _quantity;

    //constructor
    public Product(int productId, int price, string productname, string quantity)
    {
        _productId = productId;
        _price = price;
        _productname = productname;
        _quantity = quantity;
    }   

    //method to calculate the total price of the product
    public int GetTotalPrice()
    {
        int totalPrice = _price * int.Parse(_quantity);
        return totalPrice; 
    }

    //method to display the product information
    public string GetProductInfo()
    {
        return ($"\nProduct ID: {_productId} \nProduct Name: {_productname} \nPrice: {_price} \nQuantity: {_quantity}");
    }


    //method to display name of product 
    public string GetProductName()
    {
        return _productname;
    }
    //method to display id of product
     public int GetProductId()
    {
        return _productId;
    }

}
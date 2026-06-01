public class Customer
{
    private string _name;
    private Address _address;

    //constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    //method to display the customer information
    public string GetCustomerInfo()
    {
        return ($"\nName: {_name} \nAddress: {_address.GetFullAddress()}");
    }

    //method to check if the customer is in the USA
    public bool CustomerIsUSA()
    {
        return _address.IsUSA();
    }
}
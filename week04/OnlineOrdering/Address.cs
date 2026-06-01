public class Address
{
   private string _street;
   private string _city;
   private string _state;
   private string _country;

    //constructor
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _country = country;
        _state = state;
    }

    //method to check if the address is in the USA
    public bool IsUSA()
    {
        string country = "usa";
        if (_country.ToLower() == country)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //method to display the address
    public string GetFullAddress()
    {
        return ($"\n{_street} \n{_city} {_state}  \n{_country}");
    }

}
using static System.Console;

public class Address{
    private string _streetAddress {get; set;}
    private string _city {get; set;}
    private string _state {get; set;}
    private string _country {get; set;}

    public Address (string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetAddress() 
    {
        if(string.IsNullOrWhiteSpace(_state)){
            return $"{_streetAddress} {_city}, {_country}";
        }
        else{
            return $"{_streetAddress} {_city}, {_state}, {_country}";
        }
    }

}


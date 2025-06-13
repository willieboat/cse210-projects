using System;

class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public string GetCountry()
    {
        return _country;
    }

    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateOrProvince}\n{_country}";
    }
}


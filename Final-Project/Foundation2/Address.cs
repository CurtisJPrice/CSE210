public class Address
{
    private string StreetAddress1 { get; set; }
    private string StreetAddress2 { get; set; }
    private string City { get; set; }
    private string State { get; set; }
    private string Country { get; set; }

    public Address(string streetAddress1, string streetAddress2, string city, string state, string country)
    {
        StreetAddress1 = streetAddress1;
        StreetAddress2 = $"\n{streetAddress2}";
        City = city;
        State = state;
        Country = country;
    }
    public Address(string streetAddress1, string city, string state, string country)
    {
        StreetAddress1 = streetAddress1;
        StreetAddress2 = "";
        City = city;
        State = state;
        Country = country;
    }
    public bool IsInUSA()
    {
        return Country.ToUpper() == "USA";
    }
    public string GetFullAddress()
    {
        return $"{StreetAddress1}{StreetAddress2}\n{City}, {State} {Country}";
    }
}
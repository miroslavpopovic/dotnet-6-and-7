namespace CSharp.Version10;

public class Address
{
    public string Name { get; set; } = string.Empty;
    public string Address1 { get; set; } = string.Empty;
    public string Address2 { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Region { get; set; } = string.Empty;
    public string PostalCode { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
}

public class Person
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public Address Address { get; set; } = new Address();
}

public static class PropertyPatternsSample
{
    public static void Run()
    {
        var person1 = new Person
        {
            FirstName = "Miroslav",
            LastName = "Popovic",
            Address = new Address
            {
                Name = "Home",
                Address1 = "Prvomajska 3",
                City = "Banja Luka",
                PostalCode = "78000",
                Country = "Bosnia and Herzegovina"
            }
        };
        var person2 = new Person
        {
            FirstName = "Milica",
            LastName = "Slijepcevic",
            Address = new Address
            {
                Name = "Home",
                Address1 = "Rudarska 45",
                City = "Banja Luka",
                PostalCode = "78000",
                Country = "Bosnia and Herzegovina"
            }
        };

        if (person1 is { Address.Name: "Home" })
        {
            Console.WriteLine(
                "    We can use { ParentProperty.ChildProperty: pattern }, instead of ParentProperty: { ChildProperty: pattern }");
        }
    }
}

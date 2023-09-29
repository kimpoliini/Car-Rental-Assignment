using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes;

public class Customer : IPerson
{
    public int Ssn { get; init; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName => FirstName + " " + LastName;

    public Customer(int ssn, string firstName, string lastName) =>
        (Ssn, FirstName, LastName) = (ssn, firstName, lastName);
}

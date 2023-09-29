namespace Car_Rental.Common.Interfaces;

public interface IPerson
{
    public int Ssn { get; init; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get; }
}

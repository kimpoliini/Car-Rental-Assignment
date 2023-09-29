using Car_Rental.Common.Classes;
using Car_Rental.Common.Enums;

namespace Car_Rental.Common.Interfaces;

public interface IBooking
{
    public IVehicle Vehicle { get; set; }
    public IPerson Customer { get; init; }
    public int KmRented { get; init; }
    public int KmReturned { get; set; }
    public DateTime DateRented { get; init; }
    public DateTime DateReturned { get; set;}
    public double GetCost();
    public BookingStatus Status { get; set; }

}

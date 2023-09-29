using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes;

public class Booking : IBooking
{
    public IVehicle Vehicle { get; set; }
    public IPerson Customer { get; init; }
    public int KmRented { get; init; }
    public int KmReturned { get; set; }
    public DateTime DateRented { get; init; }
    public DateTime DateReturned { get; set; }
    public double GetCost()
    {
        double cost = 0;
        try
        {
            cost = KmReturned * Vehicle.CostKm + ((DateReturned - DateRented).Days + 1)  * Vehicle.CostDay;
        }
        catch
        {
            Console.WriteLine("Error: Vehicle is not returned.");
        }

        return cost;
    }
    public BookingStatus Status { get; set; }

    public Booking(IVehicle vehicle, IPerson customer, int kmRented)
    {
        Vehicle = vehicle;
        Customer = customer;
        KmRented = kmRented;

        DateRented = DateTime.Now;
        Status = BookingStatus.Open;
    }

    public Booking(IVehicle vehicle,
        IPerson customer,
        int kmRented,
        int kmReturned,
        DateTime dateRented,
        DateTime dateReturned)
        : this(vehicle, customer, kmRented)
    {
        DateRented = dateRented;
        DateReturned = dateReturned;
        KmReturned = kmReturned;
        Status = BookingStatus.Closed;
    }

    public void ReturnVehicle(int kmReturned)
    {
        DateReturned = DateTime.Now;
        KmReturned = kmReturned;
        Status = BookingStatus.Closed;
    }
}

using Car_Rental.Common.Interfaces;

namespace Car_Rental.Data.Interfaces;

public interface IData
{
    IEnumerable<IVehicle> GetVehicles();
    IEnumerable<IBooking> GetBookings();
    IEnumerable<IPerson> GetCustomers();
    void SetVehicles(IEnumerable<IVehicle> vehicles);
    void SetBookings(IEnumerable<IBooking> bookings);
    void SetCustomers(IEnumerable<IPerson> customers);
}

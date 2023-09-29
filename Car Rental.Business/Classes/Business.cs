using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;
using Car_Rental.Data.Interfaces;

namespace Car_Rental.Business.Classes;

public class Business
{
    private readonly IData _data;

    public Business(IData data) => _data = data;

    public IEnumerable<IVehicle> GetVehicles() => _data.GetVehicles();
    public void SetVehicles(IEnumerable<IVehicle> vehicles) => _data.SetVehicles(vehicles);

    public IEnumerable<IBooking> GetBookings() => _data.GetBookings();
    public void SetBookings(IEnumerable<IBooking> bookings) => _data.SetBookings(bookings);

    public IEnumerable<IPerson> GetCustomers() => _data.GetCustomers();
    public void SetCustomers(IEnumerable<IPerson> customers) => _data.SetCustomers(customers);
}
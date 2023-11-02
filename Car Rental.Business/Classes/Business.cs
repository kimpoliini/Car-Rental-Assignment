using Car_Rental.Common.Interfaces;
using Car_Rental.Data.Interfaces;

namespace Car_Rental.Business.Classes;

public class Business
{
    private readonly IData _data;
    public Business(IData data) => _data = data;
    public IEnumerable<IVehicle> GetVehicles() => _data.GetVehicles();
    public IEnumerable<IBooking> GetBookings() => _data.GetBookings();
    public IEnumerable<IPerson> GetCustomers() => _data.GetCustomers();
}
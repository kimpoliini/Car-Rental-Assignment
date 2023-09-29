using Car_Rental.Common.Classes;
using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;
using Car_Rental.Data.Interfaces;

namespace Car_Rental.Data.Classes;

public class TestCarsData : IData
{
    List<IVehicle> _vehicles = new();
    List<IBooking> _bookings = new();
    List<IPerson> _persons = new();
    
    public IEnumerable<IVehicle> GetVehicles() => _vehicles;
    public void SetVehicles(IEnumerable<IVehicle> vehicles){
    
        _vehicles.AddRange(vehicles);

        //Populate bookings and persons with fake data when vehicles has been added
        List<Customer> customers = new()
        {
            new Customer(1, "Kim", "Hellman"),
            new Customer(12, "Jim", "Kellman"),
            new Customer(8901, "Lim", "Snellman"),
        };
        SetCustomers(customers);

        List<Booking> bookings = new()
        {
            new Booking(GetVehicles().ElementAt(0), GetCustomers().ElementAt(0), 200),
            new Booking(GetVehicles().ElementAt(3), GetCustomers().ElementAt(2), 400),
            new Booking(GetVehicles().ElementAt(4), GetCustomers().ElementAt(1), 600, 600,
            DateTime.Parse("2023-09-22"), DateTime.Parse("2023-09-27"))
        };
        SetBookings(bookings);
    }

    public IEnumerable<IBooking> GetBookings() => _bookings;
    public void SetBookings(IEnumerable<IBooking> bookings)
    {
        _bookings.AddRange(bookings);

        //Loops through the bookings every time it's updated, then gets a reference of the vehicles,
        //modifying their Status property if they are currently booked
        foreach (var b in _bookings)
        {
            if (b.Status == BookingStatus.Open) GetVehicles().Single(v => v.RegNr == b.Vehicle.RegNr).Status = VehicleStatus.Booked;
        }
    }

    public IEnumerable<IPerson> GetCustomers() => _persons;
    public void SetCustomers(IEnumerable<IPerson> customers) => _persons.AddRange(customers);

}

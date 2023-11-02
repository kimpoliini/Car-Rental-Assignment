using Car_Rental.Common.Classes;
using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;
using Car_Rental.Data.Interfaces;
using System.ComponentModel;
using System.Data;
using System.Net.Http.Json;

namespace Car_Rental.Data.Classes;

public class TestCarsData : IData
{
    List<IVehicle> _vehicles = new();
    List<IBooking> _bookings = new();
    List<IPerson> _persons = new();

    public TestCarsData() => SeedData();

    //Creates vehicles, customers and bookings on initialization
    void SeedData()
    {
        SetVehicles(new List<IVehicle>()
        {
            new Car("MOR334",VehicleMake.Volvo,VehicleType.StationWagon,340000,1.2,100),
            new Car("PMG44A",VehicleMake.Volkswagen,VehicleType.Hatchback,23000,1.2,100),
            new Car("NYO00M",VehicleMake.Koenigsegg,VehicleType.Sport,1200,5,1200),
            new Motorcycle("ARG214",VehicleMake.Dukati,VehicleType.Motorcycle,10000,2.2,400),
            new Car("SHR445",VehicleMake.Ford,VehicleType.Hatchback,25000,1,80),
            new Car("PJL392",VehicleMake.Polestar,VehicleType.Sedan,8000,0.8,100),
        });

        SetCustomers(new List<Customer>
        {
            new Customer(1, "Kim", "Hellman"),
            new Customer(12, "Jim", "Kellman"),
            new Customer(8901, "Lim", "Snellman"),
        });

        SetBookings(new List<Booking>
        {
            new Booking(GetVehicles().ElementAt(0), GetCustomers().ElementAt(0), 200),
            new Booking(GetVehicles().ElementAt(3), GetCustomers().ElementAt(2), 400),
            new Booking(GetVehicles().ElementAt(4), GetCustomers().ElementAt(1), 600, 600,
            DateTime.Parse("2023-09-22"), DateTime.Parse("2023-09-27"))
        });
    }

    public IEnumerable<IVehicle> GetVehicles() => _vehicles;

    public void SetVehicles(IEnumerable<IVehicle> vehicles) => _vehicles.AddRange(vehicles);


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

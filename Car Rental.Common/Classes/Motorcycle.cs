using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes;

public class Motorcycle : IVehicle
{
    public string RegNr { get; init; }
    public int Make { get; init; }
    public VehicleType Type { get; init; } = VehicleType.Motorcycle;
    public int Odometer { get; set; }
    public double CostKm { get; init; }
    public int CostDay { get; init; }

    public VehicleStatus Status { get; set; } = VehicleStatus.Available;
    public Motorcycle(string regNr, int make, VehicleType type, int odometer, double costKm, int costDay) =>
        (RegNr, Make, Type, Odometer, CostKm, CostDay) =
        (regNr, make, type, odometer, costKm, costDay);

    public Motorcycle(Car car) =>
        (RegNr, Make, Odometer, CostKm, CostDay) =
        (car.RegNr, car.Make, car.Odometer, car.CostKm, car.CostDay);
}

using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes;

public class Car : IVehicle
{
    public string RegNr { get; init; }
    public VehicleMake Make { get; init; }
    public VehicleType Type { get; init; }
    public int Odometer { get; set; }
    public double CostKm { get; init; }
    public int CostDay { get; init; }

    public VehicleStatus Status { get; set; } = VehicleStatus.Available;
    public Car(string regNr, VehicleMake make, VehicleType type, int odometer, double costKm, int costDay) =>
        (RegNr, Make, Type, Odometer, CostKm, CostDay) =
        (regNr, make, type, odometer, costKm, costDay);
}

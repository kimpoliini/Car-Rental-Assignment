using Car_Rental.Common.Enums;

namespace Car_Rental.Common.Interfaces;

public interface IVehicle
{
    public string RegNr { get; init; }
    public VehicleMake Make { get; init; }
    public VehicleType Type { get; init; }
    public int Odometer { get; set; }
    public double CostKm { get; init; }
    public int CostDay { get; init; }
    VehicleStatus Status { get; set; } 
}

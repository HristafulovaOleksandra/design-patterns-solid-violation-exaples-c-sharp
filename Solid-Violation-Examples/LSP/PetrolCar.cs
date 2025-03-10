namespace Solid_Violation_Examples.LSP
{
    public class PetrolCar : Vehicle
    {
        private const int FUEL_TANK_FULL = 100;
        public int FuelTankLevel { get; private set; } = 0;
        public override void FillUpWithFuel() => FuelTankLevel = FUEL_TANK_FULL;
        public override void ChargeBattery() 
            => throw new NotImplementedException("A petrol car cannot be recharged");

    }
}

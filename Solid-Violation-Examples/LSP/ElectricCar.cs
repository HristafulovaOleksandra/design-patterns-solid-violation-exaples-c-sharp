namespace Solid_Violation_Examples.LSP
{
    public class ElectricCar : Vehicle
    {
        private const int BATTERY_FULL = 100;
        public int BatteryLevel { get; private set; }
        public override void FillUpWithFuel()
            => throw new NotImplementedException("It's an electric car");
        public override void ChargeBattery()
            => BatteryLevel = BATTERY_FULL;
    }
}

namespace Solid_Violation_Examples.LSP
{
    public abstract class Vehicle
    {
        private bool _engineStarted = false;
        public void StartEngine() => _engineStarted = true;
        public void StopEngine() => _engineStarted = false;
        public bool IsEngineStarted() => _engineStarted;
        public abstract void FillUpWithFuel();
        public abstract void ChargeBattery();
        
    }
}

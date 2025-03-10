namespace Solid_Violation_Examples.ISP
{
    public class Bird : IAnimal
    {
        public void Bark() { }
        public void Run() => Console.WriteLine("Bird is running");
        public void Fly() => Console.WriteLine("Bird is flying");
    }
}

namespace DesignPatterns.SimpleFactory
{
    public class RollsRoyceCar:Car
    {
        public override void Run()=>System.Console.WriteLine($"{nameof(RollsRoyceCar)} is Running");
    }
}
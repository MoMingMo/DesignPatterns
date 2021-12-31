namespace DesignPatterns.SimpleFactory
{
    public class BenzCar:Car
    {
        public override void Run()=>System.Console.WriteLine($"{nameof(BenzCar)} is Running");
    }
}
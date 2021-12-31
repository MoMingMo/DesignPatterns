namespace DesignPatterns.SimpleFactory
{
    public class BMWCar:Car
    {
        public override void Run()=>System.Console.WriteLine($"{nameof(BMWCar)}  is Running");
    }
}
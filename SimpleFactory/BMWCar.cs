namespace DesignPatterns.SimpleFactory
{
    public class BMWCar:ICar
    {
        public void Run()=>System.Console.WriteLine($"{nameof(BMWCar)}  is Running");
    }
}
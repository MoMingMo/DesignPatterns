namespace DesignPatterns.SimpleFactory
{
    public class BenzCar:ICar
    {
        public void Run()=>System.Console.WriteLine($"{nameof(BenzCar)} is Running");
    }
}
namespace DesignPatterns.SimpleFactory
{
    public class BenzCar:ICar
    {
        public void CreateCar()=>System.Console.WriteLine($"Create {nameof(BenzCar)}");
    }
}
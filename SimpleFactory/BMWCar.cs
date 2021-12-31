namespace DesignPatterns.SimpleFactory
{
    public class BMWCar:ICar
    {
        public void CreateCar()=>System.Console.WriteLine($"Create {nameof(BMWCar)}");
    }
}
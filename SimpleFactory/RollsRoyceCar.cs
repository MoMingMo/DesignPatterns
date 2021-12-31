namespace DesignPatterns.SimpleFactory
{
    public class RollsRoyceCar:ICar
    {
        public void CreateCar()=>System.Console.WriteLine($"Create {nameof(RollsRoyceCar)}");
    }
}
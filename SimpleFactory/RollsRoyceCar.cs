namespace DesignPatterns.SimpleFactory
{
    public class RollsRoyceCar:ICar
    {
        public void Run()=>System.Console.WriteLine($"{nameof(RollsRoyceCar)} is Running");
    }
}
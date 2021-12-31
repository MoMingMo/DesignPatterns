namespace DesignPatterns.SimpleFactory
{
    public class Main
    {
        public static void Start()
        {
            System.Console.WriteLine("---------简单工厂----------");
            Factory.GetCar(nameof(BMWCar)).Run();
            Factory.GetCar(nameof(BenzCar)).Run();
            Factory.GetCar(nameof(RollsRoyceCar)).Run();
            System.Console.WriteLine("-------------------------");
        }
    }
}
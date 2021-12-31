namespace DesignPatterns.SimpleFactory
{
    public class Main
    {
        public static void Run()
        {
            System.Console.WriteLine("---------简单工厂----------");
            Factory.GetCar(nameof(BMWCar)).CreateCar();
            Factory.GetCar(nameof(BenzCar)).CreateCar();
            Factory.GetCar(nameof(RollsRoyceCar)).CreateCar();
            System.Console.WriteLine("---------简单工厂----------");
        }
    }
}
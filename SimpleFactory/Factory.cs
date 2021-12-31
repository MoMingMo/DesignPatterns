namespace DesignPatterns.SimpleFactory
{
    public class Factory
    {
        public static ICar GetCar(string cartype)
        {
            switch (cartype)
            {
                case nameof(BMWCar):
                    return new BMWCar();
                case nameof(BenzCar):
                    return new BenzCar();
                case nameof(RollsRoyceCar):
                    return new RollsRoyceCar();
                default:
                    return null;

            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DesignPatterns.Factory
{
    public class Main
    {
       public static void Start()
       {
           System.Console.WriteLine("---------工厂模式----------");
            var bmwFactory =new BMWFactory();
            var benzFactory=new BenzFactory();
            var rollsRoyceFactory=new RollsRoyceFactory();
            bmwFactory.CreateCar().Run();
            benzFactory.CreateCar().Run();
            rollsRoyceFactory.CreateCar().Run();
            System.Console.WriteLine("-------------------------");
       }
    }
}
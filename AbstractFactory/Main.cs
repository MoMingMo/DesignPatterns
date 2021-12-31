using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class Main
    {
       public static void Start()
       {
            System.Console.WriteLine("---------抽象工厂----------");
            IFactory europenFactory = new EuropeanFactory();
            IFactory modernizationFactory = new ModernizationFactory();

            europenFactory.CreateDoor().Create();
            europenFactory.CreateFloor().Create();
            europenFactory.CreateRoof().Create();
            europenFactory.CreateWindow().Create();

            modernizationFactory.CreateDoor().Create();
            modernizationFactory.CreateFloor().Create();
            modernizationFactory.CreateRoof().Create();
            modernizationFactory.CreateWindow().Create();
            System.Console.WriteLine("-------------------------");
       }
    }
}
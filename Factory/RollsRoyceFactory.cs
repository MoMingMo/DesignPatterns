using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class RollsRoyceFactory:IFactory
    {
        public Car CreateCar()=> new RollsRoyceCar();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class BMWFactory:IFactory
    {
        public Car CreateCar()=>new BMWCar();
    }
}
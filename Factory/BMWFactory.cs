using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class BMWFactory:IFactory
    {
        public ICar CreateCar()=>new BMWCar();
    }
}
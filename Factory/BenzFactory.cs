using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class BenzFactory:IFactory
    {
        public ICar CreateCar()=>new BenzCar();
    }
}
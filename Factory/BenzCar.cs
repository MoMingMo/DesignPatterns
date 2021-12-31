using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class BenzCar:Car
    {
        public override void Run()=>System.Console.WriteLine($"{nameof(BenzCar)} is Running");
    }
}
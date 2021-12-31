using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class RollsRoyceCar:ICar
    {
        public void Run()=>System.Console.WriteLine($"{nameof(RollsRoyceCar)} is Running");
    }
}
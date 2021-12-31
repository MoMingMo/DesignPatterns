using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class EuropeanDoor: Door
    {
        public override void Create() => System.Console.WriteLine($"{nameof(EuropeanDoor)} is creating");
    }
}
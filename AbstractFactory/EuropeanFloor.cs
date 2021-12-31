using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class EuropeanFloor:Floor
    {
         public override void Create() => System.Console.WriteLine($"{nameof(EuropeanFloor)} is creating");
    }
}
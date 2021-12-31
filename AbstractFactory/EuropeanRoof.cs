using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class EuropeanRoof:Roof
    {
          public override void Create() => System.Console.WriteLine($"{nameof(EuropeanRoof)} is creating");
    }
}
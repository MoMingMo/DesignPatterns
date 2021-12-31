using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class ModernizationRoof:Roof
    {
          public override void Create() => System.Console.WriteLine($"{nameof(ModernizationRoof)} is creating");
    }
}
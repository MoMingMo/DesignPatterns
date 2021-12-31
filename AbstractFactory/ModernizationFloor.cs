using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class ModernizationFloor:Floor
    {
         public override void Create() => System.Console.WriteLine($"{nameof(ModernizationFloor)} is creating");
    }
}
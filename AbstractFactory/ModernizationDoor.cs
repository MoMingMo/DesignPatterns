using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class ModernizationDoor : Door
    {
        public override void Create() => System.Console.WriteLine($"{nameof(ModernizationDoor)} is creating");
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class EuropeanWindow:Window
    {
          public override void Create() => System.Console.WriteLine($"{nameof(EuropeanWindow)} is creating");
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class ModernizationFactory:IFactory
    {
        
        public  Door CreateDoor()=>new ModernizationDoor();
        public  Floor CreateFloor()=>new ModernizationFloor();
        public  Window CreateWindow()=>new ModernizationWindow();
        public  Roof CreateRoof()=>new ModernizationRoof();
    }
}
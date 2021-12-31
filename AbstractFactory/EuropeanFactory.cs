using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class EuropeanFactory:IFactory
    {
        
        public  Door CreateDoor()=>new EuropeanDoor();
        public  Floor CreateFloor()=>new EuropeanFloor();
        public  Window CreateWindow()=>new EuropeanWindow();
        public  Roof CreateRoof()=>new EuropeanRoof();
    }
}
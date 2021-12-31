using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public interface IFactory
    {
         Door CreateDoor();
         Floor CreateFloor();
         Roof CreateRoof();
         Window CreateWindow();
    }
}
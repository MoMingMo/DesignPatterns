using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    //静态
    public sealed class SafeSingletonv3
    {
        private static readonly SafeSingletonv3 instance = null;
        private SafeSingletonv3 ()=>System.Console.WriteLine("ctor 1");
        static SafeSingletonv3()
        {
            System.Console.WriteLine("static stor 2");
            instance = new SafeSingletonv3();
        }
        public static SafeSingletonv3 GetInstance()
        {
            System.Console.WriteLine("GetInstance 3");
            return  instance;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    ///简单线程安全
    public sealed class SafeSingletonv1
    {
        private static SafeSingletonv1 instance = null;
        private static readonly object obj = new Object();
        private SafeSingletonv1() =>System.Console.WriteLine("ctor 1");
        static SafeSingletonv1()=>System.Console.WriteLine("static ctor 2");
        public static SafeSingletonv1 GetInstance()
        {
            System.Console.WriteLine("GetInstance 3");
            lock (obj)
            {
                if (instance == null)
                    instance = new SafeSingletonv1();
                return instance;
            }
        }
    }
}
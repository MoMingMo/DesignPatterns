using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{

    //线程不安全
    public sealed class UnSafeSingleton
    {
        private static UnSafeSingleton instance = null;
        private UnSafeSingleton()=>System.Console.WriteLine("ctor 1");
        static UnSafeSingleton()=>System.Console.WriteLine("static ctor 2");
        public static UnSafeSingleton GetInstance()
        {
            System.Console.WriteLine("GetInstance 3");
            if(instance==null)
                instance=new UnSafeSingleton();
            return instance;
        }
    }
}
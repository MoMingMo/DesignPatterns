using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    ///双重检查线程安全
    public sealed class SafeSingletonv2
    {
        private static readonly Object obj=new Object();
        private static SafeSingletonv2 instance=null;
        private SafeSingletonv2()=>System.Console.WriteLine("ctor 1");
        static SafeSingletonv2()=>System.Console.WriteLine("static ctor 2");
        public static SafeSingletonv2 GetInstance()
        {
            System.Console.WriteLine("GetInstance 3");
            if(instance==null)
            {
                lock (obj)
                {
                    if(instance==null)
                        instance=new SafeSingletonv2();                    
                }
            }
            return instance;
        }

    }
}
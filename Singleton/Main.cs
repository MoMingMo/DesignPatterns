using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class Main
    {
        public static void Start()
        {
            System.Console.WriteLine("线程不安全");
            UnSafeSingleton.GetInstance();
            System.Console.WriteLine("简单线程安全");
            SafeSingletonv1.GetInstance();
            System.Console.WriteLine("双重检查线程安全");
            SafeSingletonv2.GetInstance();
            System.Console.WriteLine("静态构造函数线程安全");
            SafeSingletonv3.GetInstance();
        }
    }
}